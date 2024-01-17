using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.controls;

namespace ClientManagement
{
    public class ControlForm
    {
        private Control.ControlCollection usingForm = default;

        public ControlForm(Control.ControlCollection form)
        {            
            usingForm = form;
        }

        public void ChangeControl (UserControl control){
            usingForm.Clear();
            usingForm.Add(control);
        }
    }
}
