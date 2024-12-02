using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class frm_History : Form
    {
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;

        public frm_History(Employee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
            InitializeForm();
        }
        private void InitializeForm()
        {
            LoadHistory();
            ConfigureTimer();
        }

        private void ConfigureTimer()
        {
            timerClock.Interval = 100;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbl_date.Text = now.ToString($"dddd, d'{GetDaySuffix(now.Day)}' 'of' MMMM yyyy");
            lbl_time.Text = now.ToString("hh:mm:ss tt");
        }

        private string GetDaySuffix(int day)
        {
            return (day % 10 == 1 && day != 11) ? "st" :
                   (day % 10 == 2 && day != 12) ? "nd" :
                   (day % 10 == 3 && day != 13) ? "rd" : "th";
        }

        private void LoadHistory(string searchTerm = "", DateTime? startDate = null)
        {
            dgv_history.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM system_logs ORDER BY timestamp DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        dgv_history.Rows.Add(
                            dr["log_id"],
                            dr["action_module"],
                            dr["action"],
                            dr["item_id"],
                            dr["quantity"],
                            dr["amount"],
                            dr["timestamp"],
                            dr["details"],
                            dr["employee_id"]
                        );
                    }

                    dr.Dispose();
                }
            }
            catch (Exception ex)
            {
                ShowError("Error", ex);
            }
        }

        private void ShowError(string title, Exception ex)
        {
            MessageBox.Show($"{title}:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_history.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM system_logs WHERE action_module LIKE @actionModule ORDER BY timestamp DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@actionModule", "%" + txt_search.Text + "%");

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgv_history.Rows.Add(
                                dr["log_id"],
                                dr["action_module"],
                                dr["action"],
                                dr["item_id"],
                                dr["quantity"],
                                dr["amount"],
                                dr["timestamp"],
                                dr["details"],
                                dr["employee_id"]
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void start_dtp_ValueChanged(object sender, EventArgs e)
        {
            dgv_history.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM system_logs WHERE DATE(timestamp) = @logdate ORDER BY timestamp DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@logdate", start_dtp.Value.Date);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgv_history.Rows.Add(
                                dr["log_id"],
                                dr["action_module"],
                                dr["action"],
                                dr["item_id"],
                                dr["quantity"],
                                dr["amount"],
                                dr["timestamp"],
                                dr["details"],
                                dr["employee_id"]
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
