using ClientManagement.Scripts;
using SQLQueryUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using ClientManagement.controls;

namespace ClientManagement
{
    public partial class ClientsControl : UserControl
    {
        DataTable data = new DataTable();
        GetDataGridInData gridInData = default;
        DatabaseManager database = DatabaseAcessSingle.Instance;
        DataGridPageManager pageManager = new DataGridPageManager(GET_ROW);
        UserControlControler controlController = default;  
        const int GET_ROW = 10;
        string searchValue = "";
        const string allCountQuery =
            "select count(*) from clients where client_delete_date is null";
        const string selectCountQuery =
            "select count(*) from clients where client_delete_date is null and CLIENT_ID like @ID";
        const string allSearchQuery =
            "select CLIENT_ID as ID,CLIENT_BIRTHDAY as BIRTHDAY,CLIENT_REGISTERED_DATE AS REGISTERED,CLIENT_GENDER AS GENDER from clients" +
                " where client_delete_date is null ORDER BY client_id LIMIT 10 OFFSET @offset";
        const string selectSearchQuery =
            "select CLIENT_ID as ID,CLIENT_BIRTHDAY as BIRTHDAY,CLIENT_REGISTERED_DATE AS REGISTERED,CLIENT_GENDER AS GENDER from clients" +
                " where client_id like @id and client_delete_date is null ORDER BY client_id LIMIT 10 OFFSET @offset";
        public ClientsControl(UserControlControler controler)
        {
            InitializeComponent();
            controlController = controler;
            InitView();
        }

        private void InitView()
        {
            pageManager.Page = 0;
            this.DataGridView.DataSource = default;
            this.CheckBox.Visible = true;
            this.ButtonNext.Visible = true;
            this.ButtonMaxPage.Visible = true;
            this.ButtonMinPage.Visible = true;
            this.ButtonBack.Visible = true;
            this.DataGridView.Visible = true;
            int count = 0;
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                count = pageManager.GetAllRowCount(allCountQuery);
            }
            else
            {
                count = pageManager.GetAllRowCount(selectCountQuery, new SQLiteParameter("@ID", $"%{searchValue}%"));
            }

            if(count <= 0)
            {
                this.CheckBox.Visible = false;
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
            if(string.IsNullOrWhiteSpace(searchValue))
            {
                data = pageManager.GetPageData(allSearchQuery, new SQLiteParameter[]
                { new SQLiteParameter("@offset",pageManager.Offset)});
            }
            else
            {
                data = pageManager.GetPageData(selectSearchQuery, new SQLiteParameter[]
                {
                    new SQLiteParameter("@offset",pageManager.Offset),
                    new SQLiteParameter("@id",$"%{searchValue}%")
                });
            }

            this.DataGridView.DataSource = data;

            this.LabelFindCount.Text = $"{pageManager.MaxPage+1}ページ中{pageManager.Page+1}ページ目を表示";

            this.ButtonMaxPage.Text = (pageManager.MaxPage + 1).ToString();

            gridInData = new GetDataGridInData(this.DataGridView);
        }

        #region Events
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            searchValue = TextBoxSearch.Text;
            InitView();
        }

        private void TextBoxSearchTextChanged(object sender, EventArgs e)
        {
            searchValue = TextBoxSearch.Text;
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            pageManager.Page--;
            CreateView();
        }

        private void ButtonMinPageClick(object sender, EventArgs e)
        {
            pageManager.Page = 0;
            CreateView();
        }

        private void ButtonMaxPageClick(object sender, EventArgs e)
        {
            pageManager.Page = pageManager.MaxPage;
            CreateView();
        }

        private void ButtonNextClick(object sender, EventArgs e)
        {
            pageManager.Page++;
            CreateView();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            controlController.ChangeControl(new AddClientControl(controlController));
        }
        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (gridInData is null)
            {
                return;
            }
            string[] ids = gridInData.GetCheckBox(0, "ID");

            if (ids.Length <= 0)
            {
                MessageBox.Show("何も選択されていません");
                return;
            }

            DialogResult check = MessageBox.Show("本当に消しますか？", "確認", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                database.ExecuteCommand(command =>
                {
                    command.CommandText = "update clients set client_delete_date = @date where client_id = @id";
                    foreach (string id in ids)
                    {
                        command.Parameters.AddWithValue("id", id);
                        command.Parameters.AddWithValue("date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.ExecuteNonQuery();
                    }
                }, true);

                InitView();

            }

        }

        private void ButtonChangeClick(object sender, EventArgs e)
        {
            if(gridInData is null)
            {
                return;
            }
            string[] checks = gridInData.GetCheckBox(0,"ID");

            if(checks.Length != 1)
            {
                MessageBox.Show("一つの項目を選択してください");
                return;
            }

            controlController.ChangeControl(new ChangeClientControl(controlController,checks[0]));


        }

        private void ButtonLogClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DataGridView.Columns["ButtonLog"].Index)
            {
                DataGridViewRow selectedRow = this.DataGridView.Rows[e.RowIndex];
                string cellValue = selectedRow.Cells["ID"].Value.ToString();
                controlController.ChangeControl(new ClientLogControl(cellValue));
            }
               
        }

        #endregion

        
    }
}
