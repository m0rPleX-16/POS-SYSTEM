using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            frm_Dashboard dashboard = new frm_Dashboard();
            dashboard.ShowDialog();

            this.Hide();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            frm_Inventory inventory = new frm_Inventory();
            inventory.ShowDialog();

        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            frm_History history = new frm_History();
            history.ShowDialog();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            frm_Reports reports = new frm_Reports();
            reports.ShowDialog();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            frm_Users users = new frm_Users();
            users.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_Login login = new frm_Login();
            login.ShowDialog();

        }
    }
}
