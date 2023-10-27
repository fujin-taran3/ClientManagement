using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ClientManagement.Scripts
{
    class DatabaseCreateTable
    {
        const string ADD_STRING = "Data Source=";
        static bool CreateTable(string createTableName)
        {
            using(var con = new SQLiteConnection(ADD_STRING + createTableName))
            {
                return false;
            }
        }
    }
}
