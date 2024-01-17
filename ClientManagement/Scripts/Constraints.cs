namespace SQLQueryUser
{

    /// <summary>
    /// 制約文を作成するためのクラス
    /// </summary>
    public static class Constraints
    {
        public const string NotNull = "Not Null";
        public const string Unique = "Unique";
        public const string PrimaryKey = "Primary Key";
        public enum ForeignKeyOn
        {
            DELETE,
            UPDATE,
        }
        public enum ForeignKeyAction
        {
            No_Action,
            Cascade,
            Set_Null,
            Set_Default,
            Restrict
        }
        public static string Check(string check) { return $"Check({check})"; }

        public static string Default(string num) { return "Default " + num; }

        public static string ForeignKey(string table)
        {
            return  $"References {table}";
        }

        public static string ForeignKey(string table, ForeignKeyOn on, ForeignKeyAction action)
        {
            return $"References {table} ON {on} {action.ToString().Replace("_"," ")}";
        }


    }
}