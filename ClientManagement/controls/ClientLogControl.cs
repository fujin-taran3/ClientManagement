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
    public partial class ClientLogControl : UserControl
    {
        string clientId;
        DatabaseManager database = DatabaseAcessSingle.Instance;
        DataGridPageManager pageManager = new DataGridPageManager(10);
        Random random = new Random();
        string _insertQuery = "insert into CLIENT_SERVICE_LOG values(@id,@clientId,@time,@goya)";
        string _searchQuery = "select CLIENT_SERVICE_ID as ID,CLIENT_SERVICE_TIMESTUMP as TIMESTUMP,CLIENT_SERVICE_GOYA AS USED_GOYA from Client_service_log" +
            " where client_service_client_id = @id" +
            " ORDER BY client_service_timestump LIMIT 10 OFFSET @offset";
        string _countQuery = "select count(*) from client_service_log";
        public ClientLogControl(string id)
        {
            InitializeComponent();
            clientId = id;
            for (int i = 0; i < random.Next(3, 6); i++)
            {
                AddLog();

            }
            InitView();
        }

        private void AddLog()
        {
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("id",Guid.NewGuid().ToString()),
                new SQLiteParameter("clientId",clientId),
                new SQLiteParameter("time",DateTime.Now.AddMinutes(-1)),
                new SQLiteParameter("goya",random.Next(1,100))
            };

            database.ExecuteCommand(command =>
            {
                command.CommandText = _insertQuery;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            });
        }

        private void InitView()
        {
            int count = pageManager.GetAllRowCount(_countQuery);
            this.DataGridView.Visible = true;
            this.ButtonBack.Visible = true;
            this.ButtonMaxPage.Visible = true;
            this.ButtonMinPage.Visible = true;
            this.ButtonNext.Visible = true;
            if (count <= 0)
            {
                this.LabelFindCount.Text = "データがありません";
                this.DataGridView.Visible = false;
                this.ButtonBack.Visible = false;
                this.ButtonMaxPage.Visible = false;
                this.ButtonMinPage.Visible = false;
                this.ButtonNext.Visible = false;
                return;
            }
            pageManager.Page = 0;
            this.ButtonMaxPage.Text = (pageManager.MaxPage).ToString();
            CreateView();

        }
        private void CreateView()
        {
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("id",clientId),
                new SQLiteParameter("offset",pageManager.Offset)
            };
            DataTable data = pageManager.GetPageData(_searchQuery, parameters);
            this.DataGridView.DataSource = data;
            this.LabelFindCount.Text = $"{pageManager.MaxPage}ページ中{pageManager.Page + 1}ページ目を表示";
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

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            AddLog();
            InitView();
        }
    }
}
