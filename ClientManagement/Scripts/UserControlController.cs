using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.controls;

namespace ClientManagement
{
    public class UserControlController
    {
        readonly Control.ControlCollection usingForm = default;

        public UserControlController(Control.ControlCollection form)
        {            
            usingForm = form;
        }

        public void ChangeControl (UserControl control){
            usingForm.Clear();
            usingForm.Add(control);
        }
        
        public void ReSize(System.Drawing.Size size)
        {
            foreach(Control control in usingForm)
            {
                control.Size = size;
            }
        }
    }
}
