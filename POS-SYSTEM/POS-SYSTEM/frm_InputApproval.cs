using System;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class frm_InputApproval : Form
    {
        public string InputPassword { get; private set; }

        public frm_InputApproval()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_adminPass.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InputPassword = txt_adminPass.Text;
            DialogResult = DialogResult.OK;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
