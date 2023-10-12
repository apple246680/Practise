using System;
using System.Windows.Forms;
namespace Session1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += HandleUnhandledException;
            Application.Run(new Login());
        }
        private static void HandleUnhandledException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"error: {e.Exception.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
