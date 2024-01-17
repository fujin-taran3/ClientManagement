namespace SQLQueryUser
{
    /// <summary>
    /// アップデートする列とアップデート後の値
    /// </summary>
    public struct UpdateSetInfo
    {
        /// <summary>
        /// 更新する列
        /// </summary>
        public string TargetColum { get; }
        /// <summary>
        /// 更新後の値
        /// </summary>
        public string UpdateValue { get; }
        
        public string ParameterString { get { return "@" + TargetColum; } }
        public UpdateSetInfo(string targetColum, string setValue)
        {
            TargetColum = targetColum;

            UpdateValue = setValue;
        }
    }
}
