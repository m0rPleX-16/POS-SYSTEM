using System;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class frm_Dashboard : Form
    {
        private Employee _currentEmployee;

        public frm_Dashboard(Employee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
            LoadDashboardContent();
            UpdateRoleLabel();
        }

        private void LoadDashboardContent()
        {
            OpenNewForm(new frm_DashboardContents(_currentEmployee));
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

        private void UpdateRoleLabel()
        {
            lbl_role.Text = _currentEmployee.Role;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_DashboardContents(_currentEmployee));
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_Inventory(_currentEmployee));
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            using (frm_POS pos = new frm_POS(_currentEmployee))
            {
                pos.ShowDialog();
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_History(_currentEmployee));
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            using (frm_Reports reports = new frm_Reports(_currentEmployee))
            {
                reports.ShowDialog();
            }
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            OpenNewForm(new frm_Users(_currentEmployee));
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