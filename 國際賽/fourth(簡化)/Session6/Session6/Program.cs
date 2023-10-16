using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session6
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += HandleUnhandledException;
            Application.Run(new Main());
        }
        private static void HandleUnhandledException(object sender, System.Threading.ThreadExceptionEventArgs e) => MessageBox.Show($"error: {e.Exception.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
