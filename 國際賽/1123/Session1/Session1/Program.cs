using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Thread;
            Application.Run(new Main());
        }
        public static void Thread(object sender,ThreadExceptionEventArgs ex)
        {
            MessageBox.Show(ex.Exception.Message);
        }
    }
}
