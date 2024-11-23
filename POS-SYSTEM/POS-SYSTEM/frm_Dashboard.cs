using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace POS_SYSTEM
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
            LoadDashboardContent(); 
        }

        private void LoadDashboardContent()
        {
            OpenNewForm(new frm_DashboardContents());
        }
        private void OpenNewForm(Form newForm)
        {
            pnl_display.Controls.Clear();

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;

            pnl_display.Controls.Add(newForm);
            newForm.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_DashboardContents());
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_Inventory());
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            using (frm_POS pos = new frm_POS())
            {
                pos.ShowDialog();
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_History());
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            using (frm_Reports reports = new frm_Reports())
            {
                reports.ShowDialog();
            }
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
