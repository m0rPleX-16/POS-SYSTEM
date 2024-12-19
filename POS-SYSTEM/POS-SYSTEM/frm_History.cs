using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace POS_SYSTEM
{
    public partial class frm_History : Form
    {
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;
        private const int PageSize = 25;
        private int currentPageindex = 1;
        private int totalPages = 0;
        private int totalRows = 0;

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
                    string countQuery = "SELECT COUNT(*) FROM system_logs";
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        countQuery += " WHERE action_module LIKE @actionModule";
                    }
                    if (startDate.HasValue)
                    {
                        countQuery += (string.IsNullOrEmpty(searchTerm) ? " WHERE " : " AND ") + "DATE(timestamp) = @logdate";
                    }

                    using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            countCmd.Parameters.AddWithValue("@actionModule", "%" + searchTerm + "%");
                        }
                        if (startDate.HasValue)
                        {
                            countCmd.Parameters.AddWithValue("@logdate", startDate.Value.Date);
                        }

                        totalRows = Convert.ToInt32(countCmd.ExecuteScalar());
                    }

                    totalPages = (int)Math.Ceiling((double)totalRows / PageSize);

                    lblCurrentPage.Text = currentPageindex.ToString();
                    lblTotalPage.Text = totalPages.ToString();

                    string query = "SELECT * FROM system_logs";
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " WHERE action_module LIKE @actionModule";
                    }
                    if (startDate.HasValue)
                    {
                        query += (string.IsNullOrEmpty(searchTerm) ? " WHERE " : " AND ") + "DATE(timestamp) = @logdate";
                    }
                    query += " ORDER BY timestamp DESC LIMIT " + (currentPageindex - 1) * PageSize + ", " + PageSize;

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@actionModule", "%" + searchTerm + "%");
                        }
                        if (startDate.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@logdate", startDate.Value.Date);
                        }

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

                            dr.Dispose();
                        }
                    }
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
            currentPageindex = 1;
            LoadHistory(txt_search.Text);
        }

        private void start_dtp_ValueChanged(object sender, EventArgs e)
        {
            currentPageindex = 1;
            LoadHistory(null, start_dtp.Value.Date);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPageindex = 1;
            LoadHistory();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageindex > 1)
            {
                currentPageindex--;
                LoadHistory();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageindex < totalPages)
            {
                currentPageindex++;
                LoadHistory();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPageindex = totalPages;
            LoadHistory();
        }
    }
}
