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
            Application.ThreadException += HandleUnhandledExcepttion;
            Application.Run(new Main());
        }
        private static void HandleUnhandledExcepttion(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"error: {e.Exception.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
