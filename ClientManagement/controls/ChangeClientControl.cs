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
    public partial class ChangeClientControl : UserControl
    {
        DatabaseManager database = DatabaseAcessSingle.Instance;
        UserControlControler controlControler = default;    
        string _id = default;
        byte[] _salt = default; 
        public ChangeClientControl(UserControlControler userControl, string id)
        {
            _id = id;
            controlControler = userControl;
            string query = "select client_birthday,client_gender,client_salt from clients where client_id = @id";
            InitializeComponent();

            database.ExecuteReader(reader =>
            {
                if (reader.Read())
                {
                    this.TextBoxMail.Text = id;
                    _salt = (byte[])reader["client_salt"];
                    string birthday = reader["client_birthday"].ToString();
                    if (DateTime.TryParse(birthday, out DateTime date))
                    {
                        this.DateTimePicker.Value = date;
                    }
                    string gender = reader["client_gender"].ToString();

                    switch (gender)
                    {
                        case "男":
                            this.RadioButtonMan.Checked = true;
                            break;
                        case "女":
                            this.RadioButtonWoman.Checked = true;
                            break;
                        case "その他":
                            this.RadioButtonOther.Checked = true;
                            break;
                        default:
                            this.RadioButtonOther.Checked = true;
                            break;
                    }


                }
            }, query
            , new SQLiteParameter("id", id));
        }

        private void ButtonChangeClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に変更しますか", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            string query = "update clients set client_id = @id,client_pass = @pass,client_birthday = @day,client_gender = @gender" +
                " where client_id = @nowid";
            PasswordAuthentication authentication = new PasswordAuthentication();
            SQLiteParameter[] parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("id",this.TextBoxMail.Text),
                new SQLiteParameter("pass",authentication.HashPassword(this.TextBoxPass.Text,_salt)),
                new SQLiteParameter("day",this.DateTimePicker.Value.ToString("yyyy-MM-dd")),
                new SQLiteParameter("gender",GetSelectedRadioButtonText(this.GroupBox)),
                new SQLiteParameter("nowid",_id)
            };

            database.ExecuteCommand(command =>
            {
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            });

            MessageBox.Show("更新しました");
            controlControler.ChangeControl(new ClientsControl(controlControler));
            
        }

        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            // グループボックス内のラジオボタンを走査
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    // Checked プロパティが true のラジオボタンの Text を返す
                    return radioButton.Text;
                }
            }

            // Checked プロパティが true のラジオボタンが見つからない場合は null を返す
            return null;
        }
    }
}
