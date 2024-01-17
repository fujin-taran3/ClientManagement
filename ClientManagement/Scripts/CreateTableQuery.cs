using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLQueryUser
{

    public class CreateTableQuery
    {
        
        public string TableName { get; }

        List<ColumSchema> _colums = new List<ColumSchema>();

        public CreateTableQuery(ColumSchema[] schemas,string tableName)
        {
            AddColum(schemas);
            TableName = tableName;
        }

        public CreateTableQuery(ColumSchema schema, string tableName)
        {
            AddColum(schema);
            TableName = tableName;
        }

        public void AddColum(ColumSchema schema)
        {
            _colums.Add(schema);
        }

        public void AddColum(ColumSchema[] schemas)
        {
            _colums.AddRange(schemas);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string CreateTableString()
        {
            string createTable = $"CREATE TABLE IF NOT EXISTS {TableName} ( ";

            const string END_TABLE = ");";

            for (int i = 0; i < _colums.Count; i++)
            {
                ColumSchema colum = _colums[i];
                string columString;

                if (i > 0)
                {
                    columString = $",{colum.Name} {colum.Type} {colum.Constraints}";
                }
                else
                {
                    columString = $"{colum.Name} {colum.Type} {colum.Constraints}";
                }

                createTable += columString;
            }

            createTable += END_TABLE;

            return createTable;

        }

        /// <summary>
        /// 登録した列を全てコンソールに表示
        /// </summary>
        public void CheckColums()
        {
            int num = 0;

            Console.WriteLine($"tableName : [{TableName}] 結果");

            foreach (ColumSchema colum in _colums)
            {
                num += 1;

                Console.WriteLine($"{num}列目　{colum.Name},{colum.Type},{colum.Constraints}");
            }

            Console.WriteLine("END");
        }
    }
}
