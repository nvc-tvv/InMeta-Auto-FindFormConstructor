using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutoFormFind
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MFormHostAddr formObject = new MFormHostAddr();
            if (formObject.ShowDialog() == DialogResult.OK)
            {
                MFormProjectName f_project = new MFormProjectName(formObject.hostAddr);
                if (f_project.ShowDialog() == DialogResult.OK)
                    Application.Run(new MFormMain(f_project.dSess));
                else Application.ExitThread();
            }
        }
    }
}
