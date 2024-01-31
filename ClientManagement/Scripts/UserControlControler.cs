using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManagement.controls;

namespace ClientManagement
{
    public class UserControlControler
    {
        readonly Control.ControlCollection usingForm = default;

        private Stack<UserControl> controlLog = new Stack<UserControl>();

        public UserControlControler(Control.ControlCollection form)
        {
            usingForm = form;
        }

        public void ChangeControl(UserControl control)
        {
            usingForm.Clear();
            usingForm.Add(control);
            if (controlLog.Count() == 0 || controlLog.Peek() != control)
            {
                controlLog.Push(control);

            }
        }

        public void BackControl()
        {
            if (controlLog.Count > 1)
            {
                controlLog.Pop();
                ChangeControl(controlLog.Peek());
            }


        }

        public void ReSize(System.Drawing.Size size)
        {
            foreach (Control control in usingForm)
            {
                control.Size = size;
            }
        }
    }
}
