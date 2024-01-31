using SQLQueryUser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Scripts
{
    public class DataGridPageManager
    {
        public int Page
        {
            get { return _page; }
            set
            {
                int set = value;
                if (set < 0 || MaxPage < set)
                {
                    set = 0;
                }
                _page = set;
            }
        }
        private int _page = 0;
        private DatabaseManager database = DatabaseAcessSingle.Instance;
        public int MaxViewRow { get; set; }
        public int AllRowCount { get; private set; }
        public int MaxPage { get { return (int)Math.Ceiling((double)(AllRowCount / MaxViewRow)); } }
        public int Offset { get { return _page * (MaxViewRow - 1); } }

        public DataGridPageManager(int maxViewRow)
        {
            MaxViewRow = maxViewRow;
            Page = 0;
        }

        public int GetAllRowCount(string query)
        {
            database.ExecuteCommand(command =>
            {
                command.CommandText = query;
                AllRowCount = Convert.ToInt32(command.ExecuteScalar());
            });
            return AllRowCount;
        }
        public int GetAllRowCount(string query,params SQLiteParameter[] parameters)
        {
            database.ExecuteCommand(command =>
            {
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                AllRowCount = Convert.ToInt32(command.ExecuteScalar());
            });
            return AllRowCount;
        }

        public DataTable GetPageData(string query)
        {
            DataTable data = database.GetDataTable(query);
            return data;
        }
        public DataTable GetPageData(string query,params SQLiteParameter[] parameters)
        {
            DataTable data = database.GetDataTable(query, parameters);
            return data;
        }

    }
}
