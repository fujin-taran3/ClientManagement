using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueryUser
{

    public class UpdateTableQuery
    {
        public string TableName { get; }

        readonly private string startString = default;
        public UpdateTableQuery(string tablename)
        {
            TableName = tablename;
            startString = $"update {tablename} set";
        }


        public string UpdateTableString(UpdateSetInfo setInfo, string where = "")
        {
            return default;
        }

        public string UpdateTableString(UpdateSetInfo setInfo,WhereStringInfo whereInfo)
        {
            return default;
        }

        public string UpdateTableString(UpdateSetInfo[] setInfos, string where = "")
        {
            return default;
        }

        public string UpdateTableString(UpdateSetInfo[] setInfos, WhereStringInfo whereInfo)
        {
            return default;
        }

        private string setInfoConnect(UpdateSetInfo[] infos)
        {
            string connectedString = default;

            for (int i = 0; i < infos.Length; i++)
            {
                UpdateSetInfo info = infos[i];
                connectedString += $"{info.TargetColum} = {info.ParameterString} ,";
                
            }

            if (connectedString.EndsWith(","))
            {
                connectedString.Substring(0, connectedString.Length - 1);
            }

            return connectedString;
        }
    }
}
