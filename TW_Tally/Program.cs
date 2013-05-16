using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TW_Tally.Forms;

namespace TW_Tally
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form f2 = new FormLogin();
                f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
                Application.Run(new MainForm());
            else return;
            
        }
    }
}
