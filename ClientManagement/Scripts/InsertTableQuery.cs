using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakurakuSQLQuery
{
    public struct InsertStrings
    {
        /// <summary>
        /// sql文
        /// </summary>
        public string query;
        
        /// <summary>
        /// パラメータの文字列 先頭には@
        /// </summary>
        public string[] parameterStrings;
        public InsertStrings(string query,string[] parameterStrings)
        {
            this.query = query;
            this.parameterStrings = parameterStrings;
        }
    }
    public class InsertTableQuery
    {
        public string TableName { get; }
        public InsertTableQuery(string tableName)
        {
            TableName = tableName;
        }
        
        /// <summary>
        /// インサート文を作成する
        /// </summary>
        /// <param name="colums">テーブルのコラムの名前の配列</param>
        /// <returns></returns>
        public InsertStrings InsertTableStrings(string[] colums)
        {
            string[] columParams = new string[colums.Length];
            colums.CopyTo(columParams,0);  

            for(int i = 0; i < columParams.Length; i++)
            {
                columParams[i] = "@" + columParams[i];
            }

            string insertString = $"insert into {TableName}({string.Join(",",colums)})" +
                $"values({string.Join(",",columParams)});";

            return new InsertStrings(insertString, columParams);
        }

        }
}
