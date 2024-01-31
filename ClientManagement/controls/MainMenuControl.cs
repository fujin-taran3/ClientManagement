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
    public partial class MainMenuControl : UserControl
    {
        UserControlControler _controller = default;    
        public MainMenuControl(UserControlControler controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ButtonClientClick(object sender, EventArgs e)
        {
            _controller.ChangeControl(new ClientsControl(_controller));
        }

        private void ButtonWorkerClick(object sender, EventArgs e)
        {
            _controller.ChangeControl(new WorkersControl(_controller));
        }
    }
}
