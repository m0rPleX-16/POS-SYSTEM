using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_SYSTEM.inventory;

namespace POS_SYSTEM
{
    public partial class frm_Inventory : Form
    {
        public frm_Inventory()
        {
            InitializeComponent();
            timerClock.Start();
            timerClock.Interval = 100;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            int day = now.Day;
            string suffix;
            if (day % 10 == 1 && day != 11) suffix = "st";
            else if (day % 10 == 2 && day != 12) suffix = "nd";
            else if (day % 10 == 3 && day != 13) suffix = "rd";
            else suffix = "th";
            lbl_date.Text = now.ToString($"dddd, d'{suffix}' 'of' MMMM yyyy");
            lbl_time.Text = now.ToString("hh:mm:ss tt");
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnl_inventBG.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            pnl_inventBG.Controls.Add(userControl);
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_product());
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_category());
        }

        private void btn_stockin_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_stockin());
        }
    }
}
