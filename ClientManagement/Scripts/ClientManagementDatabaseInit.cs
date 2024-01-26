using SQLQueryUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Scripts
{
    public class ClientManagementDatabaseInit:IInitilizeDatabase
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
            
            _workerInsert = $@"insert into workers values(1000001, ""worker"", ""2000/11/11"", 101, ""example@hcs.ac.jp"", null,@password,@salt);";
        }

        public void InitializeDatabase()
        {
            IInitilizeDatabase init = new InitializationDatabase(_database,_init);
            init.InitializeDatabase();
            _database.ExecuteCommand(command =>
            {
                command.CommandText = _workerInsert;
                command.Parameters.AddWithValue("password", _passwordHash);
                command.Parameters.AddWithValue("salt", _salt);
                command.ExecuteNonQuery();
            });
        }
    }
}
