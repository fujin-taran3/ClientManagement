using SQLQueryUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.controls
{
    public partial class AddClientControl : UserControl
    {
        UserControlControler controlControler = default;
        DatabaseManager database = DatabaseAcessSingle.Instance;
        public AddClientControl(UserControlControler controler)
        {
            InitializeComponent();
            controlControler = controler;
        }

        private void ButtonInsertClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxMail.Text))
            {
                MessageBox.Show("メールアドレスを入力してください");
                return;
            }

            DialogResult result = MessageBox.Show("本当に追加しますか", "確認", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            PasswordAuthentication authentication = new PasswordAuthentication();
            database.ExecuteCommand(command =>
            {
                command.CommandText = @"
                    INSERT INTO CLIENTS 
                    (CLIENT_ID, CLIENT_PASS, CLIENT_SALT, CLIENT_BIRTHDAY, CLIENT_REGISTERED_DATE, CLIENT_GENDER, CLIENT_DELETE_DATE)
                    VALUES 
                    (@ClientId, @ClientPass, @ClientSalt, @ClientBirthday, @ClientRegisteredDate, @ClientGender, @ClientDeleteDate)
                ";

                string gender = GetSelectedRadioButtonText(this.GroupBox);

                byte[] salt = authentication.GenerateSalt();
                command.Parameters.AddWithValue("@ClientId", this.TextBoxMail.Text);
                command.Parameters.AddWithValue("@ClientPass", authentication.HashPassword(this.TextBoxPass.Text, salt));
                command.Parameters.AddWithValue("@ClientSalt", salt);
                command.Parameters.AddWithValue("@ClientBirthday", this.DateTimePicker.Value.ToString("yyyy-MM-dd")); // 仮の誕生日
                command.Parameters.AddWithValue("@ClientRegisteredDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                command.Parameters.AddWithValue("@ClientGender", gender??"その他");
                command.Parameters.AddWithValue("@ClientDeleteDate", null); // 仮の削除日
                command.ExecuteNonQuery();

                MessageBox.Show("追加しました");

                this.TextBoxMail.Text = default;
                this.TextBoxPass.Text = default;
                this.DateTimePicker.Value = DateTime.Now;


            });



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
