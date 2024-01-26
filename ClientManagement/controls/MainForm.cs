using System.Windows.Forms;
using System.Drawing;
using SQLQueryUser;
using System;
using System.IO;
using ClientManagement.Scripts;

namespace ClientManagement
{
    public partial class MainForm : Form
    {
        readonly UserControlController controlForm = default;
        readonly IInitilizeDatabase init = default;
        //Size headerSize = default;
        public MainForm()
        {
            const string DATABASE_NAME = "management.db";
            InitializeComponent();
            DatabaseManager database = new DatabaseManager(DATABASE_NAME);
            new DatabaseAcessSingle(database);
            init = new ClientManagementDatabaseInit(database);

            if (!File.Exists(database.DatabaseName))
            {
                init.InitializeDatabase();
            }

            controlForm = new UserControlController(this.PanelControl.Controls);
            controlForm.ChangeControl(new controls.LoginControl(controlForm,init));
            //headerSize = this.Size - this.PanelControl.Size;
        }

       

        public void FormResizeEvent(object sender, System.EventArgs e)
        {
            //if(controlForm != null)
            //{
            //    Size setSize = this.Size - headerSize;
            //    this.PanelControl.Size = setSize;
            //    controlForm.ReSize(this.PanelControl.Size);

            //}
        }

    }
}

