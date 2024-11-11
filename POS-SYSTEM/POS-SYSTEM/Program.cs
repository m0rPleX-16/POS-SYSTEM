using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
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

            // Start with the login form
            frm_Login loginForm = new frm_Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // After successful login, open the dashboard
                Application.Run(new frm_Dashboard());
            }
            else
            {
                // Exit the application if login was not successful
                Application.Exit();
            }
        }
    }
}
