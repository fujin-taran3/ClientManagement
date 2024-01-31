using System;
using System.Windows.Forms;
using System.Data.SQLite;
using SQLQueryUser;
using ClientManagement.Scripts;

namespace ClientManagement.controls
{
    /// <summary>
    /// ログイン画面用のコントロール
    /// </summary>
    public partial class LoginControl : UserControl
    {
        readonly UserControlControler _formController = default;
        readonly IInitilizeDatabase _init = default;

        public LoginControl(UserControlControler control, IInitilizeDatabase init)
        {
            InitializeComponent();

            _formController = control;
            _init = init;

        }

        /// <summary>
        /// ログインボタンクリックしたときのイベント用メソッド
        /// </summary>
        private void GoLoginButtonClick(object sender, EventArgs e)
        {
            Login();

        }

        /// <summary>
        /// データベース初期化ボタンクリックしたときのイベント用メソッド
        /// </summary>
        private void InitializeButtonClick(object sender, EventArgs e)
        {
            ConfirmInitializeDatabase();

        }

        /// <summary>
        /// ログイン処理
        /// </summary>
        private void Login()
        {
            string columPassword = "WORKER_PASS";
            string columSalt = "WORKER_SALT";
            string columName = "WORKER_NAME";
            string columGroup = "WORKER_GROUP_ID";
            string parameterName = "@ID";

            // インスタンス取得
            DatabaseManager database = DatabaseAcessSingle.Instance;

            string id = this.TextboxID.Text;
            string password = this.TextboxPassword.Text;
            string loginQuery = $"SELECT {columPassword},{columSalt},{columName},{columGroup} FROM WORKERS WHERE WORKER_ID = {parameterName}";
            string name = default;
            int group = default;
            bool successLogin = false;

            // 認証
            database.ExecuteReader(reader =>
            {
                if (reader.Read())
                {
                    PasswordAuthentication authentication = new PasswordAuthentication();

                    string storedPasswordHash = reader[columPassword].ToString();
                    byte[] storedSalt = (byte[])reader[columSalt];

                    // ハッシュ後のパスワード同士を比較
                    string userPasswordHash = authentication.HashPassword(password, storedSalt);
                    successLogin = storedPasswordHash == userPasswordHash;

                    name = reader[columName].ToString();
                    group = reader.GetInt32(reader.GetOrdinal(columGroup));
                }
            }, loginQuery
            , new SQLiteParameter(parameterName, id));

            if (successLogin)
            {
                UserDataManager.Instance.Name = name;
                UserDataManager.Instance.ID = int.Parse(id);
                UserDataManager.Instance.GroupID = group;

                _formController.ChangeControl(new MainMenuControl(_formController));

            }
            else
            {
                string messageText = "ERROR:IDかパスワードを間違えています";
                MessageBox.Show(messageText);

            }
        }

        /// <summary>
        /// データベース初期化するかの確認
        /// </summary>
        private void ConfirmInitializeDatabase()
        {
            string messageText = "処理を実行しますか？";
            string messageCaption = "確認";

            DialogResult result = MessageBox.Show(messageText, messageCaption, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                _init.InitializeDatabase();
                Cursor.Current = Cursors.Default;
            };
        }
        private void ClientManagementClick(object sender, EventArgs e)
        {
            this.TextboxID.Text = "1000001";
            this.TextboxPassword.Text = "password";
        }
    }


}
