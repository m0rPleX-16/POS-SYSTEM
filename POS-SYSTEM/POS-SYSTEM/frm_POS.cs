using DocumentFormat.OpenXml.Spreadsheet;
using MySql.Data.MySqlClient;
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
    public partial class frm_POS : Form

    {
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private readonly Employee _currentEmployee;

        public frm_POS(Employee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
            timerClock.Interval = 1000; 
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            LogAction("Logout", "POS Session", $"Cashier {_currentEmployee.Username} logged out");
        }

        private void LogAction(string action, string module, string details = null, string itemId = null, int? quantity = null, decimal? amount = null)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO system_logs (action_module, action, item_id, quantity, amount, timestamp, details, employee_id) " +
                               "VALUES (@action_module, @action, @item_id, @quantity, @amount, @timestamp, @details, @employee_id)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@action_module", module);
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@item_id", itemId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@quantity", quantity.HasValue ? (object)quantity : DBNull.Value);
                cmd.Parameters.AddWithValue("@amount", amount.HasValue ? (object)amount : DBNull.Value);
                cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                cmd.Parameters.AddWithValue("@details", details ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@employee_id", _currentEmployee.Userid);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error logging action: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
