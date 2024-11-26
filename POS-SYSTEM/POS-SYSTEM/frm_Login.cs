using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class frm_Login : Form
    {
        private string connectionString = "server=localhost;userid=root;password=;database=pos_system";
        public static Employee CurrentEmployee { get; private set; }
        public string userid = "";
        public string userRole = "";
        public string firstname = "";
        public string lastname = "";

        public string UserRole { get; private set; }

        public frm_Login()
        {
            InitializeComponent();
        }

        private bool ValidateLogin(string username, string password)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT user_id, firstname, lastname, username, role FROM employee_tb WHERE username = @username AND password = @password AND is_archived = 0 AND status = 'Active'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                userid = reader["user_id"].ToString();
                                userRole = reader["role"].ToString();
                                firstname = reader["firstname"].ToString();
                                lastname = reader["lastname"].ToString();
                            }
                            return true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        private void LogAction(string action)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO logs (user, name, logdate, action) VALUES (@user, @name, @logdate, @action)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", userid);
                cmd.Parameters.AddWithValue("@name", $"{lastname}, {firstname}");
                cmd.Parameters.AddWithValue("@logdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@action", action);

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

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

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

                LogAction("Logged in successfully");
                this.Hide();

                if (userRole == "Admin")
                {
                    var dashboard = new frm_Dashboard(CurrentEmployee);
                    dashboard.ShowDialog();
                }
                else if (userRole == "Staff")
                {
                    var pointofsale = new frm_POS();
                    pointofsale.ShowDialog();
                }

                LogAction("Logged out successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password, or the account is inactive and archived.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
