using ClientManagement.Scripts;
using SQLQueryUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.controls
{
    public partial class WorkersControl : UserControl
    {
        private const string BaseName = "@GROUP";
        UserControlControler controlControler = default;
        DatabaseManager database = DatabaseAcessSingle.Instance;
        DataGridPageManager pageManager = new DataGridPageManager(10);
        string _groupParams = default;
        string _allSearchQuery = "SELECT W.WORKER_ID as ID, W.WORKER_NAME as NAME, W.WORKER_BIRTHDAY as BIRTHDAY, G.GROUP_NAME AS GROUP_NAME, W.WORKER_MAIL AS MAIL" +
        " FROM WORKERS AS W JOIN GROUPS AS G ON W.WORKER_GROUP_ID = G.GROUP_ID" +
            $" WHERE W.WORKER_DELETE_DATE IS NULL AND W.WORKER_GROUP_ID IN (@GROUP)" +
            " ORDER BY w.worker_id LIMIT 10 OFFSET @offset";

        string _selectSearchQuery = "SELECT W.WORKER_ID as ID, W.WORKER_NAME as NAME, W.WORKER_BIRTHDAY as BIRTHDAY, G.GROUP_NAME AS GROUP_NAME, W.WORKER_MAIL AS MAIL" +
        " FROM WORKERS AS W JOIN GROUPS AS G ON W.WORKER_GROUP_ID = G.GROUP_ID" +
            " WHERE W.WORKER_DELETE_DATE IS NULL AND W.WORKER_GROUP_ID IN (@GROUP)" +
            " AND W.WORKER_ID LIKE @SEARCH" +
            " ORDER BY w.worker_id LIMIT 10 OFFSET @offset";

        string _allCountQuery = "SELECT COUNT(*)" +
            " FROM WORKERS AS W " +
            " WHERE W.WORKER_DELETE_DATE IS NULL AND W.WORKER_GROUP_ID IN (@GROUP)";

        string _selectCountQuery = "SELECT COUNT(*)" +
            " FROM WORKERS AS W " +
            " WHERE W.WORKER_DELETE_DATE IS NULL AND W.WORKER_GROUP_ID IN (@GROUP)" +
            "AND W.WORKER_ID LIKE @SEARCH";

        int[] _grants = default;
        string searchValue = "";

        public WorkersControl(UserControlControler controler)
        {
            InitializeComponent();
            controlControler = controler;
            _grants = GetGrant(UserDataManager.Instance.GroupID);
            _groupParams = CreateParam(_grants.Length, BaseName);
            _allSearchQuery = "SELECT W.WORKER_ID as ID, W.WORKER_NAME as NAME, W.WORKER_BIRTHDAY as BIRTHDAY, G.GROUP_NAME AS GROUP_NAME, W.WORKER_MAIL AS MAIL" +
       " FROM WORKERS AS W JOIN GROUPS AS G ON W.WORKER_GROUP_ID = G.GROUP_ID" +
           $" WHERE W.WORKER_DELETE_DATE IS NULL AND W.WORKER_GROUP_ID IN ({_groupParams})" +
           " ORDER BY w.worker_id LIMIT 10 OFFSET @offset";

            _selectSearchQuery = "SELECT W.WORKER_ID as ID, W.WORKER_NAME as NAME, W.WORKER_BIRTHDAY as BIRTHDAY, G.GROUP_NAME AS GROUP_NAME, W.WORKER_MAIL AS MAIL" +
           " FROM WORKERS AS W JOIN GROUPS AS G ON W.WORKER_GROUP_ID = G.GROUP_ID" +
               $" WHERE W.WORKER_DELETE_DATE IS NULL AND W.WORKER_GROUP_ID IN ({_groupParams})" +
               " AND (W.WORKER_ID LIKE @SEARCH OR w.worker_name like @SEARCH)" +
               " ORDER BY w.worker_id LIMIT 10 OFFSET @offset";

            _allCountQuery = "SELECT COUNT(*)" +
               " FROM WORKERS AS W " +
               $" WHERE W.WORKER_DELETE_DATE IS NULL AND W.WORKER_GROUP_ID IN ({_groupParams})";

            _selectCountQuery = "SELECT COUNT(*)" +
               " FROM WORKERS AS W " +
               $" WHERE W.WORKER_DELETE_DATE IS NULL AND W.WORKER_GROUP_ID IN ({_groupParams})" +
               "AND (W.WORKER_ID LIKE @SEARCH OR w.worker_name like @SEARCH)";
            InitView();
        }

        private int[] GetGrant(int myGrant)
        {
            List<int> grants = new List<int>();
            database.ExecuteCommand(command =>
            {
                // SQLiteパラメータの作成
                command.Parameters.AddWithValue("@startGroupId", myGrant);

                // CTEを含む再帰的なクエリを実行
                command.CommandText = @"
                    WITH RECURSIVE GroupHierarchy AS (
                        SELECT GROUP_ID, GROUP_PARENT_ID
                        FROM PARENT_GROUPS
                        WHERE GROUP_ID = @startGroupId

                        UNION ALL

                        SELECT P.GROUP_ID, P.GROUP_PARENT_ID
                        FROM PARENT_GROUPS P
                        JOIN GroupHierarchy G ON P.GROUP_PARENT_ID = G.GROUP_ID
                    )
                    SELECT * FROM GroupHierarchy;";

                using (System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int groupId = Convert.ToInt32(reader["GROUP_ID"]);

                        grants.Add(groupId);
                    }
                }

            });
            return grants.ToArray();
        }
        private void InitView()
        {
            pageManager.Page = 0;
            this.DataGridView.DataSource = default;
            this.ButtonNext.Visible = true;
            this.ButtonMaxPage.Visible = true;
            this.ButtonMinPage.Visible = true;
            this.ButtonBack.Visible = true;
            this.DataGridView.Visible = true;
            int count = 0;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                parameters.AddRange(GenerateParameter(BaseName, _grants));
                count = pageManager.GetAllRowCount(_allCountQuery, parameters.ToArray());

            }
            else
            {
                parameters.AddRange(GenerateParameter(BaseName, _grants));
                parameters.Add(new SQLiteParameter("SEARCH", $"%{searchValue}%"));
                count = pageManager.GetAllRowCount(_selectCountQuery, parameters.ToArray());
            }

            if (count <= 0)
            {
                this.ButtonNext.Visible = false;
                this.ButtonMaxPage.Visible = false;
                this.ButtonMinPage.Visible = false;
                this.ButtonBack.Visible = false;
                this.DataGridView.Visible = false;
                this.LabelFindCount.Text = "データが見つかりませんでした";
                return;
            }

            CreateView();
        }

        private void CreateView()
        {
            DataTable data = default;
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                parameters.Add(new SQLiteParameter("@offset", pageManager.Offset));
                parameters.AddRange(GenerateParameter(BaseName, _grants));
                data = pageManager.GetPageData(_allSearchQuery, parameters.ToArray());
               
            }
            else
            {
                parameters.Add(new SQLiteParameter("@offset", pageManager.Offset));
                parameters.Add(new SQLiteParameter("@SEARCH", $"%{searchValue}%"));
                parameters.AddRange(GenerateParameter(BaseName, _grants));
                data = pageManager.GetPageData(_selectSearchQuery, parameters.ToArray());
                
            }

            this.DataGridView.DataSource = data;

            this.LabelFindCount.Text = $"{pageManager.MaxPage + 1}ページ中{pageManager.Page + 1}ページ目を表示";

            this.ButtonMaxPage.Text = (pageManager.MaxPage + 1).ToString();

        }

        private SQLiteParameter[] GenerateParameter(string baseName,int[] values)
        {
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();
            for(int i = 0; i < values.Length; i++)
            {

                parameters.Add(new SQLiteParameter(baseName + i, values[i]));
            }
            return parameters.ToArray();
        }
        private string CreateParam(int count, string baseName)
        {
            string param = default;
            for (int i = 0; i < count; i++)
            {
                param += baseName + i;
                if (i < count - 1)
                {
                    param += ",";
                }
            }
            return param;
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            pageManager.Page--;
            CreateView();
        }

        private void ButtonMinPage_Click(object sender, EventArgs e)
        {
            pageManager.Page = 0;
            CreateView();
        }

        private void ButtonMaxPage_Click(object sender, EventArgs e)
        {
            pageManager.Page = pageManager.MaxPage;
            CreateView();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            pageManager.Page++;
            CreateView();

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            searchValue = this.TextBoxSearch.Text;
            InitView();
        }
    }
}
