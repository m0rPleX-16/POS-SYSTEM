using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class frm_Login : Form
    {
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        public static Employee CurrentEmployee { get; private set; }

        public string userid = "";
        public string userRole = "";
        public string firstname = "";
        public string lastname = "";

        public frm_Login()
        {
            InitializeComponent();
        }

        private bool ValidateLogin(string username, string password)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT employee_id, firstname, lastname, username, role, password " +
                               "FROM employee_tb " +
                               "WHERE username = @username AND is_archived = 0 AND status = 'Active'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string storedHashedPassword = reader["password"].ToString();
                                string inputHashedPassword = HashPassword(password);

                                if (storedHashedPassword == inputHashedPassword)
                                {
                                    userid = reader["employee_id"].ToString();
                                    userRole = reader["role"].ToString();
                                    firstname = reader["firstname"].ToString();
                                    lastname = reader["lastname"].ToString();
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during login validation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            return false;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                {
                    result.Append(b.ToString("x2"));
                }
                return result.ToString();
            }
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
                cmd.Parameters.AddWithValue("@employee_id", userid);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error logging action: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidateLogin(username, password))
            {
                CurrentEmployee = new Employee
                {
                    Userid = userid,
                    Username = username,
                    Role = userRole,
                    Firstname = firstname,
                    Lastname = lastname
                };

                LogAction("Login", "Authentication", $"User {username} logged in");

                this.Hide();

                if (userRole == "Admin")
                {
                    using (var dashboard = new frm_Dashboard(CurrentEmployee))
                    {
                        dashboard.ShowDialog();
                    }
                }
                else if (userRole == "Cashier")
                {
                    using (var pointofsale = new frm_POS(CurrentEmployee))
                    {
                        pointofsale.ShowDialog();
                    }
                }

                LogAction("Logout", "Authentication", $"User {username} logged out");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password, or the account is inactive/archived.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
                txt_password.Focus();
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
