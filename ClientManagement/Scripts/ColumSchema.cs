namespace SQLQueryUser
{
    public struct ColumSchema
    {

        public string Name { get; set; }
        public ColumType Type { get; set; }

        public string Constraints { get; set; }
        public ColumSchema(string name, ColumType type, string constraints)
        {
            Name = name;
            Type = type;
            Constraints = constraints;
        }
        public ColumSchema(string name, ColumType type)
        {
            Name = name;
            Type = type;
            Constraints = "";
        }

    }
}
