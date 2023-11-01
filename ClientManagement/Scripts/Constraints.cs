namespace System.Data.SQLite
{
    public static class Constraints
    {
        public const string NotNull = "Not Null";
        public const string Unique = "Unique";
        public const string PrimaryKey = "Primary Key";

        public static string Check(string check) { return "Check " + check; }

        public static string Default(string num) { return "Check " + num; }

        public static string ForeignKey(string colum,string table)
        {
            return $"Foreign Key {colum} References {table}";
        }

        public static string ForeignKey(string colum, string table, string )
        {
            return $"Foreign Key {colum} References {table}";
        }


    }
}