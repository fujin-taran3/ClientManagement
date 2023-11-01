using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ClientManagement.Scripts
{
    public class CreateTableQuery
    {
        public struct ColumSchema
        {
            public 

            public string Name { get; set; }
            public TypeAffinity Type { get; set; }

            

            public ColumSchema(string name, System.Data.SqlDbType type)
            {
                Name = name;
                Type = type;
            }

        }

        public CreateTableQuery()
        {

        }
    }
}
