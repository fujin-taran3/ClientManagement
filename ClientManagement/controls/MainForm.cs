using System.Windows.Forms;
using SQLQueryUser;


namespace ClientManagement
{
    public partial class MainForm : Form
    {
        readonly ControlForm controlForm = default;
        public MainForm()
        {
            InitializeComponent();
            const string DATABASE_NAME = "management";
            new DatabaseAcessSingle(new DatabaseManager(DATABASE_NAME));
            controlForm = new ControlForm(this.Controls);
            controlForm.ChangeControl(new controls.LoginControl(controlForm));

        }


    }
}

