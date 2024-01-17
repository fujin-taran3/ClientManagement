using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLQueryUser
{
    public class GetMatchesString
    {

        public string[] GetParameterToQuery(string query)
        {
            // 正規表現パターンを定義
            string pattern = @"@\w+";

            // 正規表現に一致する文字列を抽出
            MatchCollection matches = Regex.Matches(query, pattern);

            // 抽出されたパラメータを配列に格納
            string[] parameters = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                parameters[i] = matches[i].Value;
            }

            return parameters;
        }

    }
}
