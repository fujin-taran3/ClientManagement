using System;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace RakurakuSQLQuery
{
    public class ClassGenerater
    {       
        /// <summary>
        /// データベース内を参照して入力補助用のクラスを作成する
        /// </summary>
        /// <param name="database"></param>
        public void InfomationWrite(DatabaseManager database) 
        {

            const string ROW_NAME = "name";

            string databaseName = database.DatabaseName.Split('.')[0];

            DataTable tables = database.GetTables();

            List<string> tableNames = new List<string>();

            List<string>[] columsNames = new List<string>[tables.Rows.Count];
            
            // 初期化
            for (int i = 0; i < columsNames.Length; i++)
            {
                columsNames[i] = new List<string>();
            }

            // テーブルごとにコラムとテーブルを取得
            for (int i = 0;i < tables.Rows.Count;i++)
            {
                DataRow row = tables.Rows[i];

                string tableName = row[ROW_NAME].ToString();

                tableNames.Add(tableName);

                DataTable columsTable = database.GetColums(tableName);

                foreach(DataColumn colum in columsTable.Columns)
                {
                    string columName = colum.ColumnName;

                    columsNames[i].Add(columName);
                    
                }
               
            }

            string[] write = CreateWriteStringArray(databaseName,
                   tableNames.ToArray(), ListsChangeToArrays<string>(columsNames));

            ArrayStringWriter($"Info{databaseName}.cs", write);

        }

        /// <summary>
        /// リスト配列をジャグ配列に変換
        /// List<T>[0]はT[0][]に格納される
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lists"></param>
        /// <returns></returns>
        private T[][] ListsChangeToArrays<T>(List<T>[] lists)
        {
            T[][] arrays = new T[lists.Length][];

            for (int i = 0; i < lists.Length; i++)
            {
                arrays[i] = lists[i].ToArray();
            }

            return arrays;
        }
        private string[] CreateWriteStringArray(string databaseName,string[] tableNames, string[][] columsNames, bool deleteDBNameExtension = true)
        {

            if(tableNames.Length != columsNames.Length)
            {
                Console.WriteLine("ERROR:テーブルの数とコラムのテーブル配列の数が合いません");
                return default;
            }

            if (deleteDBNameExtension)
            {
                databaseName = databaseName.Split('.')[0];
            }

            List<string> writeStrings = new List<string>();
            
            writeStrings.Add($"namespace RakurakuSQLQuery.Info.{databaseName}");
            writeStrings.Add("{");
            for (int i = 0; i < tableNames.Length;i++)
            {
                writeStrings.Add($"\tpublic static class Info{tableNames[i]}");
                writeStrings.Add("\t{");
                writeStrings.Add($"\t\tpublic enum ColumNames");
                writeStrings.Add("\t\t{");
                for(int k = 0; k < columsNames[i].Length;k++)
                {
                    writeStrings.Add($"\t\t\t{columsNames[i][k]},");
                }
                writeStrings.Add("\t\t}");
                writeStrings.Add("\t}");
            }
            writeStrings.Add("}");

            return writeStrings.ToArray();
        }

        private void ArrayStringWriter(string filePath,string[] writeStrings)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // 配列の各要素をファイルに書き込み
                foreach (string line in writeStrings)
                {
                    writer.WriteLine(line);
                }
            }

        }

        public void Test()
        {
            string[] tables = new string[] { "a","b","c"};
            string[][] colums = new string[tables.Length][];
            colums[0] = new string[] { "a"};
            colums[1] = new string[] { "a", "b" };
            colums[2] = new string[] { "a", "b", "c" };
            string[] write = CreateWriteStringArray("Test.db", tables, colums);
            string pathDefault = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(pathDefault, "aaa.cs");
            ArrayStringWriter(path, write);
            Console.WriteLine("suc:" + Directory.GetCurrentDirectory() + "\\aaa" );
            
        }
    }
}
