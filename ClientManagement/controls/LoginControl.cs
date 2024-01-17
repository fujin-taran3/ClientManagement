using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagement.controls
{
    public partial class LoginControl : UserControl
    {
        readonly ControlForm formController = default;
        public LoginControl(ControlForm control)
        {
            InitializeComponent();
            formController = control;
        }

        private void BottonGoLogin_Click(object sender, EventArgs e)
        {
            string id = this.TextboxID.Text;
            string pass = this.TextboxPassword.Text;

            formController.ChangeControl(new MainMenuControl());
        }
    }
}
