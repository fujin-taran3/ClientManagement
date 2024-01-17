namespace SQLQueryUser
{
    public struct UseWhereInfo
    {
        public WhereStringInfo WhereString { get; set; }
        public string ParamValue { get; set; }
        public UseWhereInfo(WhereStringInfo whereString,string paramValue)
        {
            WhereString = whereString;
            ParamValue = paramValue;
        }
    }
}
