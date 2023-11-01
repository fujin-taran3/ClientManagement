using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ClientManagement.Scripts
{
    public class DatabaseAcess
    {
        const string ADD_STRING = "Data Source=";

        string _databaseName = default;

        public DatabaseAcess(string databaseName)
        {
            _databaseName = databaseName;

           
        }



        void DatabaseConnection(Action<string> query)
        {
            string connectionString = ADD_STRING + _databaseName;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

            }

        }

        public void DatabaseCreateTable(string query)
        {
            
        }

        public void DatabaseInsert(string query)
        {

        }

        public void DatabaseRead(string query)
        {
            
        }
    }
}
