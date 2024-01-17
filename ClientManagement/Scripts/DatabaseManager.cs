using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SQLQueryUser
{
    public class DatabaseManager:IDatabaseSingleton
    {
        private const string ADD_STRING = "Data Source=";
        private readonly string _connectionString;

        private GetMatchesString matchesString = new GetMatchesString();

        public string DatabaseName { get; private set; }
        public DatabaseManager(string databaseName)
        {
            _connectionString = ADD_STRING + databaseName;

            DatabaseName = databaseName;
        }
        
        /// <summary>
        /// データベースと接続する処理し、中継する
        /// </summary>
        /// <param name="connectionAction">接続後の処理</param>
        public void ExecuteConnection(Action<SQLiteConnection> connectionAction)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                connectionAction(connection);
            }
        }

        /// <summary>
        /// コマンドで使用される接続を取得または設定し、中継する
        /// </summary>
        /// <param name="commandAction">接続設定後の処理</param>
        public void ExecuteCommand(Action<SQLiteCommand> commandAction,bool useTransaction = false)
        {
            ExecuteConnection(connection =>
            {
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.Connection = connection;
                    if (useTransaction)
                    {
                        // トランザクションを開始
                        using (SQLiteTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // コマンド処理を実行
                                command.Transaction = transaction;
                                commandAction(command);

                                // トランザクションをコミット
                                transaction.Commit();
                            }
                            catch (Exception)
                            {
                                // エラーが発生した場合はロールバック
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                    else
                    {
                        // トランザクションを使用しない場合は単一のコマンドを実行
                        commandAction(command);
                    }
                    
                }
            });
        }

        /// <summary>
        /// 実行されたコマンドの結果を読み取るために必要
        /// </summary>
        /// <param name="readerAction">読み取った後の処理</param>
        /// <param name="query">コマンドのクエリ</param>
        public void ExecuteReader(Action<SQLiteDataReader> readerAction, string query)
        {
            ExecuteCommand(command =>
            {
                command.CommandText = query;
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    readerAction(reader);
                }
            });
        }
        
        /// <summary>
        /// クエリを実行するだけ
        /// </summary>
        /// <param name="query"></param>
        public void CreateTable(string query)
        {

            // Use the Execute method to execute the query
            ExecuteCommand(command =>
            {
                command.CommandText = query;
                command.ExecuteNonQuery();
            });
        }

        /// <summary>
        /// データを追加する
        /// </summary>
        /// <param name="queryStrings">SQL文作成情報</param>
        /// <param name="addParameters">追加する情報の内容</param>
        public void InsertData(InsertStrings queryStrings,string[] addParameters)
        {
            if(queryStrings.parameterStrings.Length != addParameters.Length)
            {
                Console.WriteLine("ERROR:このテーブルのコラムの数と設定するパラメータの数が合ってません");
                return;
            }

            ExecuteCommand(command =>
            {
                command.CommandText = queryStrings.query;
                for(int i = 0; i < addParameters.Length;i++)
                {
                    command.Parameters.AddWithValue(queryStrings.parameterStrings[i], addParameters[i]);
                }

                command.ExecuteNonQuery();
            });
        }

        /// <summary>
        /// データを追加する
        /// </summary>
        /// <param name="query">クエリ</param>
        /// <param name="addParameters">追加する情報の内容</param>
        public void InsertData(string query,string[] addParameters)
        {
            string[] parameterStrings = matchesString.GetParameterToQuery(query);

            InsertStrings insertStrings = new InsertStrings(query, parameterStrings);

            InsertData(insertStrings, addParameters);

        }
        
        /// <summary>
        /// パラメータ付きクエリを実行する
        /// </summary>
        /// <param name="query">パラメータ付きクエリ</param>
        /// <param name="changeParameters">埋め込むパラメータ</param>
        public void UseParameterQuery(string query,string[] changeParameters)
        {
            string[] parameterStrings = matchesString.GetParameterToQuery(query);

            ExecuteCommand(command =>
            {
                command.CommandText = query;
                for (int i = 0; i < changeParameters.Length; i++)
                {
                    command.Parameters.AddWithValue(parameterStrings[i], changeParameters[i]);
                }

                command.ExecuteNonQuery();
            });
        }

            
        /// <summary>
        /// 存在しているテーブルを取得する
        /// </summary>
        /// <returns></returns>
        public DataTable GetTables()
        {
            DataTable tables = new DataTable();

            ExecuteReader(reader =>
            {
                tables.Load(reader);
            }, "SELECT name FROM sqlite_master WHERE type='table';");

            return tables;
        }
        
        /// <summary>
        /// テーブルの表定義を取得する
        /// </summary>
        /// <param name="tableName">取得したいテーブル</param>
        /// <returns></returns>
        public DataTable GetColums(string tableName)
        {
            DataTable columns = new DataTable();

            ExecuteReader(reader =>
            {
                columns.Load(reader);
            }, $"PRAGMA table_info({tableName});");

            return columns;
        }

        /// <summary>
        /// テーブルのコラムを文字列で取得する
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public string[] GetColumsString(string tableName)
        {
            List<string> columsNames = new List<string>();

            DataTable columsTable = GetColums(tableName);

            foreach (DataColumn colum in columsTable.Columns)
            {
                string columName = colum.ColumnName;

                columsNames.Add(columName);

            }
            return columsNames.ToArray();
        }

        }


}
