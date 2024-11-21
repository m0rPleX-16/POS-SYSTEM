using System;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void OpenNewForm(Form newForm)
        {
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_Dashboard());
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_Inventory());
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_POS());
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_History());
        }   

        private void btn_reports_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_Reports());
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_Users());
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frm_Login login = new frm_Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

    }
}
