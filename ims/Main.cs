using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    internal class Main
    {
        public static void showWindow(Form openWin, Form hideWin, Form MDIWin) 
        {
            hideWin.Close();

            // Set parrent Window
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void showWindow(Form openWin, Form MDIWin)
        {
            // Set parrent Window
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
    }
}
