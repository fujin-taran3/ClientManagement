using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakurakuSQLQuery
{
    /// <summary>
    /// アップデートする列とアップデート後の値
    /// </summary>
    public struct UpdateSetInfo
    {
        public string TargetColum { get; }
        public string UpdateValue { get; }
        public string ParameterString { get { return "@" + TargetColum; } }
        public UpdateSetInfo(string targetColum,string setValue)
        {
            TargetColum = targetColum;

            UpdateValue = setValue;
        }
    }

    /// <summary>
    /// 不等号を使用する文をパラメータ込みで作る
    /// </summary>
    public struct WhereInfo
    {

    }
    
    public class UpdateTableQuery
    {
        public string TableName { get ;}
        public UpdateTableQuery(string tablename)
        {
            TableName = tablename;
        }
        

        public string UpdateTableString(UpdateSetInfo setInfo, string where = "")
        {

        }

        public string UpdateTableString(UpdateSetInfo[] setInfos,string where = "")
        {

        }
        
        public string UpdateTableString(UpdateSetInfo[] setInfos,WhereInfo whereInfo)
        {

        }
    }
}
