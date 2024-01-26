using System;
using System.Windows.Forms;
using System.Data.SQLite;
using SQLQueryUser;

namespace ClientManagement.controls
{
    /// <summary>
    /// ログイン画面用のコントロール
    /// </summary>
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
            string columPassword = "WORKER_PASS";
            string columSalt = "WORKER_SALT";
            string parameterName = "@ID";

            // インスタンス取得
            DatabaseManager database = DatabaseAcessSingle.Instance;

            string id = this.TextboxID.Text;
            string password = this.TextboxPassword.Text;
            string loginQuery = $"SELECT WORKER_ID,{columPassword},{columSalt} FROM WORKERS WHERE WORKER_ID = {parameterName}";
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

                }
            }, loginQuery
            , new SQLiteParameter(parameterName, id));

            if (successLogin)
            {
                _formController.ChangeControl(new MainMenuControl());

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
                _init.InitializeDatabase();
            }
        }
    }
}