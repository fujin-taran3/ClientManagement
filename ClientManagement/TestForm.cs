using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RakurakuSQLQuery;

namespace ClientManagement
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestStart_Click(object sender, EventArgs e)
        {
            InsertTableQuery insertTableQuery = new InsertTableQuery("test");
            string[] columNames = new string[] { "id", "name", "num", "aaa" };
            InsertStrings insertStrings = insertTableQuery.InsertTableStrings(columNames);
            Console.WriteLine("query:" + insertStrings.query);
            Console.WriteLine(string.Join("," ,insertStrings.parameterStrings));
        }
    }
}
