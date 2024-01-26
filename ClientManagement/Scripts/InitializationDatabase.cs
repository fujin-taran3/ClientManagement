using ClientManagement.Scripts;
using SQLQueryUser;
using System;

namespace ClientManagement
{
    public interface IInitilizeDatabase
    {
        void InitializeDatabase();
    }

    public class InitializationDatabase:IInitilizeDatabase
    {
        readonly DatabaseManager _database = default;
        readonly IGetLongSQL _sql = default;
        public InitializationDatabase(DatabaseManager database,IGetLongSQL sql)
        {
            _database = database;
            _sql = sql;
        }

        public void InitializeDatabase()
        {
            InitDatabase(_sql);
        }
        public void InitDatabase(IGetLongSQL sqlText)
        {
            _database.ExecuteCommand(command =>
            {                
                // SQLiteCommandのCommandTextにSQL文を設定
                command.CommandText = sqlText.GetSQL;
        
                command.ExecuteNonQuery();
            });
        }
    }
}
