using System;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string validUsername = "admin";
            string validPassword = "password";

            if (txt_username.Text == validUsername && txt_password.Text == validPassword)
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
