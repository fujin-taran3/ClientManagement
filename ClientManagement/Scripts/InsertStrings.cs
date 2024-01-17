namespace SQLQueryUser
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
        public InsertStrings(string query, string[] parameterStrings)
        {
            this.query = query;
            this.parameterStrings = parameterStrings;
        }
    }
}
