using SQLQueryUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Scripts
{
    public class ClientManagementDatabaseInit : IInitilizeDatabase
    {
        DatabaseManager _database = default;
        IGetLongSQL _init = new InitSQL();
        byte[] _salt = default;
        string _passwordHash = default;
        string _workerInsert = default;

        public ClientManagementDatabaseInit(DatabaseManager database)
        {
            PasswordAuthentication authentication = new PasswordAuthentication();
            _database = database;
            _salt = authentication.GenerateSalt();
            _passwordHash = authentication.HashPassword("password", _salt);

            _workerInsert = $@"insert into workers values(1000001, ""worker"", ""2000/11/11"", 107, ""example@hcs.ac.jp"", null,@password,@salt);";
        }

        public void InitializeDatabase()
        {
            IInitilizeDatabase init = new InitializationDatabase(_database, _init);
            init.InitializeDatabase();
            _database.ExecuteCommand(command =>
            {
                command.CommandText = _workerInsert;
                command.Parameters.AddWithValue("password", _passwordHash);
                command.Parameters.AddWithValue("salt", _salt);
                command.ExecuteNonQuery();
            });
            AddWorker(100);
            AddClient(100);
        }

        private void AddWorker(int value)
        {
            string sql = "insert into workers values (null,@name,@birth,@group,@mail,null,@password,@salt)";
            Random random = new Random();
            PasswordAuthentication authentication = new PasswordAuthentication();
            _database.ExecuteCommand(command =>
            {
                command.CommandText = sql;
                for (int i = 0; i < value; i++)
                {
                    byte[] salt = authentication.GenerateSalt();
                    command.Parameters.AddWithValue("name", GenerateRandomString(random.Next(5, 10)));
                    command.Parameters.AddWithValue("birth", DateTime.Now.AddYears(-25).ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("group", 100 + random.Next(1, 10));
                    command.Parameters.AddWithValue("mail", GenerateRandomString(random.Next(5, 10),Chars.Alpha) + "@hcs.ac.jp");
                    command.Parameters.AddWithValue("password", authentication.HashPassword("password", salt));
                    command.Parameters.AddWithValue("salt", salt);
                    command.ExecuteNonQuery();

                }
            });


        }

        private void AddClient(int value)
        {
            Random random = new Random();
            PasswordAuthentication authentication = new PasswordAuthentication();
            _database.ExecuteCommand(command =>
            {
                command.CommandText = @"
                    INSERT INTO CLIENTS 
                    (CLIENT_ID, CLIENT_PASS, CLIENT_SALT, CLIENT_BIRTHDAY, CLIENT_REGISTERED_DATE, CLIENT_GENDER, CLIENT_DELETE_DATE)
                    VALUES 
                    (@ClientId, @ClientPass, @ClientSalt, @ClientBirthday, @ClientRegisteredDate, @ClientGender, @ClientDeleteDate)
                ";
                for (int i = 0; i < value; i++)
                {
                    byte[] salt = authentication.GenerateSalt();
                    command.Parameters.AddWithValue("@ClientId", GenerateRandomString(random.Next(5, 10), Chars.Alpha) + "@hcs.ac.jp" );
                    command.Parameters.AddWithValue("@ClientPass", authentication.HashPassword("password",salt));
                    command.Parameters.AddWithValue("@ClientSalt", salt);
                    command.Parameters.AddWithValue("@ClientBirthday", DateTime.Now.AddYears(-25).ToString("yyyy-MM-dd")); // 仮の誕生日
                    command.Parameters.AddWithValue("@ClientRegisteredDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@ClientGender", GetRandomGender());
                    command.Parameters.AddWithValue("@ClientDeleteDate", null); // 仮の削除日
                    command.ExecuteNonQuery();

                }

            });
            string GetRandomGender()
            {
                string[] genders = { "男", "女", "その他" };
                
                return genders[random.Next(0, genders.Length)];
            }
        }

        enum Chars
        { 
            Japanese,
            Alpha
        }
        string GenerateRandomString(int length,Chars c = Chars.Japanese)
        {
            string chars = "あいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもわん";
            if(c == Chars.Alpha)
            {
                chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            }
            Random random = new Random();

            // LINQを使用してランダムな文字列を生成
            string randomString = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }
    }
}
