using System;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with the login form
            using (frm_Login loginForm = new frm_Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Open the dashboard after successful login
                    Application.Run(new frm_Dashboard());
                }
            }
        }
    }
}
