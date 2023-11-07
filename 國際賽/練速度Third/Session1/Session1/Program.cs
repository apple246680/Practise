using System;
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
            Application.ThreadException += HandleUnhandledException;
            Application.Run(new LoginForm());
        }
        private static void HandleUnhandledException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"error: {e.Exception.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
