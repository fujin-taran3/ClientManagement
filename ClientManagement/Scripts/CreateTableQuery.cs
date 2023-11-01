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
            public enum sqlType
            {
                Integer,
                Text,
                Real,
                Blob,
            }

            public string Name { get; set; }
            public sqlType Type { get; set; }

            public ColumSchema(string name, sqlType type)
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
