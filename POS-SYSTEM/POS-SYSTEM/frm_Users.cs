using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace POS_SYSTEM
{
    public partial class frm_Users : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=pos_system");
        private string connectionString = "server=localhost;userid=root;password=;database=pos_system";
        private string rolelgn;
        private string usernamelgn;
        private string firstNamelgn;
        private string lastNamelgn;

        public frm_Users()
        {
            InitializeComponent();
            timerClock.Start();
            timerClock.Interval = 100;
            timerClock.Tick += TimerClock_Tick;
            LoadEmployeeDetails();
            LoadUsers();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int day = now.Day;
            string suffix = (day % 10 == 1 && day != 11) ? "st" : (day % 10 == 2 && day != 12) ? "nd" : (day % 10 == 3 && day != 13) ? "rd" : "th";
            lbl_date.Text = now.ToString($"dddd, d'{suffix}' 'of' MMMM yyyy");
            lbl_time.Text = now.ToString("hh:mm:ss tt");
        }

        private void LoadEmployeeDetails()
        {
            if (frm_Login.CurrentEmployee != null)
            {
                usernamelgn = frm_Login.CurrentEmployee.Username;
                rolelgn = frm_Login.CurrentEmployee.Role;
                firstNamelgn = frm_Login.CurrentEmployee.Firstname;
                lastNamelgn = frm_Login.CurrentEmployee.Lastname;
            }
        }

        private void LogAction(string action)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO logs (user, name, logdate, action) VALUES (@user, @name, @logdate, @action)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", usernamelgn);
                cmd.Parameters.AddWithValue("@name", $"{firstNamelgn} {lastNamelgn}");
                cmd.Parameters.AddWithValue("@logdate", DateTime.Now);
                cmd.Parameters.AddWithValue("@action", action);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Log successful
                    }
                    else
                    {
                        // Log failed
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error logging action: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Add or update users (similar to your other methods)
        private void btn_save_Click(object sender, EventArgs e)
        {
            // Assume textboxes for input like txt_username, txt_firstname, txt_lastname
            SaveUser();
        }

        private void SaveUser()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `employee_tb` (`firstname`, `lastname`, `username`, `password`, `role`, `status`) VALUES (@firstname, @lastname, @username, @password, @role, @status)", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", "Temporary1!");
                cmd.Parameters.AddWithValue("@role", cb_role.Text);
                cmd.Parameters.AddWithValue("@status", cb_status.Text);
                    
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("User Saved Successfully!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogAction("Added new user: " + txt_lastname.Text + ", " + txt_firstname.Text);
                }
                else
                {
                    MessageBox.Show("User Save Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Clear fields after saving
            ClearFields();
        }

        private void ClearFields()
        {
            txt_userid.Clear();
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_username.Clear();
            cb_role.SelectedIndex = 0;
            cb_status.SelectedIndex = 0;
        }

        // Load user details into DataGridView (if applicable)
        private void LoadUsers()
        {
            try
            {
                dgv_users.Rows.Clear();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee_tb", conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv_users.Rows.Add(dr["user_id"], dr["firstname"], dr["lastname"], dr["username"], dr["role"], dr["status"], dr["is_archived"]);
                }

                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Handle user actions like edit, delete, archive, etc.
        private void btn_edit_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void UpdateUser()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE `employee_tb` SET `firstname`=@firstname, `lastname`=@lastname, `username`=@username, `role`=@role, `status`=@status WHERE `user_id`=@user_id", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user_id", txt_userid.Text);
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text);
                cmd.Parameters.AddWithValue("@username", txt_username.Text);
                cmd.Parameters.AddWithValue("@role", cb_role.Text);
                cmd.Parameters.AddWithValue("@status", cb_status.Text);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("User Updated Successfully!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogAction("Updated user: " + txt_lastname.Text + ", " + txt_firstname.Text);
                }
                else
                {
                    MessageBox.Show("User Update Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            ClearFields();
            LoadUsers();
        }
    }
}
