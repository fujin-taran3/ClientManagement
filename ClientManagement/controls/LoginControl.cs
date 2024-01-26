using System;
using System.Windows.Forms;
using System.Data.SQLite;
using SQLQueryUser;

namespace ClientManagement.controls
{
    public partial class LoginControl : UserControl
    {
        readonly UserControlController _formController = default;
        readonly IInitilizeDatabase _init = default;

        public LoginControl(UserControlController control, IInitilizeDatabase init)
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
            const string ROW_PASSWORD = "WORKER_PASS";
            const string ROW_SALT = "WORKER_SALT";
            const string PARAMETER_NAME = "@ID";

            DatabaseManager database = DatabaseAcessSingle.Instance;

            string id = this.TextboxID.Text;
            string password = this.TextboxPassword.Text;
            bool successLogin = false;
            string loginQuery = $"SELECT WORKER_ID,{ROW_PASSWORD},{ROW_SALT} FROM WORKERS WHERE WORKER_ID = {PARAMETER_NAME}";

            // 認証
            database.ExecuteReader(reader =>
            {
                if (reader.Read())
                {
                    PasswordAuthentication authentication = new PasswordAuthentication();

                    string storedPasswordHash = reader[ROW_PASSWORD].ToString();
                    byte[] storedSalt = (byte[])reader[ROW_SALT];

                    // ハッシュ後のパスワード同士を比較
                    string userPasswordHash = authentication.HashPassword(password, storedSalt);
                    successLogin = storedPasswordHash == userPasswordHash;

                }
            }, loginQuery
            , new SQLiteParameter(PARAMETER_NAME, id));

            if (successLogin)
            {
                _formController.ChangeControl(new MainMenuControl());

            }
            else
            {
                const string MESSAGE_TEXT = "ERROR:IDかパスワードを間違えています";
                MessageBox.Show(MESSAGE_TEXT);

            }
        }

        /// <summary>
        /// データベース初期化するかの確認
        /// </summary>
        private void ConfirmInitializeDatabase()
        {
            const string MESSAGE_TEXT = "処理を実行しますか？";
            const string MESSAGE_CAPTION = "確認";

            DialogResult result = MessageBox.Show(MESSAGE_TEXT, MESSAGE_CAPTION, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _init.InitializeDatabase();
            }
        }
    }
}