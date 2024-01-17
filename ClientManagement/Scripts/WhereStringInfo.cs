namespace SQLQueryUser
{
    /// <summary>
    /// 不等号を使用する文をパラメータ込みで作る
    /// </summary>
    public struct WhereStringInfo
    {
        public string ColumName { get; }

        public string ParameterValue { get; }

        public string UsingOperater { get; }

        public enum ComparisonOperator
        {
            Equal,// =
            NotEqual,// !=
            LessThan,// <
            LessThanOrEqual,// <=
            GreaterThan,// >
            GreaterThanOrEqual// >=
        }

        public WhereStringInfo(string columName, ComparisonOperator comparison)
        {
            ColumName = columName;
            ParameterValue = "@" + columName;
            UsingOperater = GetOperaterString(comparison);

            string GetOperaterString(ComparisonOperator changeComparison)
            {
                switch (changeComparison)
                {
                    case ComparisonOperator.Equal:
                        return "=";
                    case ComparisonOperator.NotEqual:
                        return "!=";
                    case ComparisonOperator.LessThan:
                        return "<";
                    case ComparisonOperator.LessThanOrEqual:
                        return "<=";
                    case ComparisonOperator.GreaterThan:
                        return ">";
                    case ComparisonOperator.GreaterThanOrEqual:
                        return ">=";
                    default:
                        return default;
                }
            }
        }

        public string GetWhereString()
        {
            return $"where {ColumName} {UsingOperater} {ParameterValue}";
        }

    }
}
