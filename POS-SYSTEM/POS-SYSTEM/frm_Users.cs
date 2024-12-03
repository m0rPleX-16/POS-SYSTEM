using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace POS_SYSTEM
{
    public partial class frm_Users : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;
        private string usernamelgn;
        private string rolelgn;
        private string firstNamelgn;

        public string lastNamelgn { get; private set; }

        public frm_Users(Employee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
            InitializeUI();
        }   
        private void InitializeUI()
        {
            timerClock.Start();
            timerClock.Interval = 100;
            timerClock.Tick += TimerClock_Tick;
            dgv_users.CellClick += dgv_users_CellClick;
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

        private void LoadUsers()
        {
            dgv_users.Rows.Clear();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee_tb", conn);
                MySqlDataReader dr = cmd.ExecuteReader();   

                while (dr.Read())
                {
                    dgv_users.Rows.Add(dr["employee_id"], dr["firstname"], dr["lastname"], dr["username"], dr["role"], dr["status"], dr.GetBoolean("is_archived") ? "Archived" : "Unarchived");
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
        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_users.CurrentRow != null)
            {
                txt_userid.Text = dgv_users.CurrentRow.Cells[0].Value.ToString();
                txt_firstname.Text = dgv_users.CurrentRow.Cells[1].Value.ToString();
                txt_lastname.Text = dgv_users.CurrentRow.Cells[2].Value.ToString();
                txt_username.Text = dgv_users.CurrentRow.Cells[3].Value.ToString();

                cb_role.SelectedItem = dgv_users.CurrentRow.Cells[4].Value;
                cb_status.SelectedItem = dgv_users.CurrentRow.Cells[5].Value;


                txt_userid.ReadOnly = true;
                btn_save.Enabled = false;
            }
        }

        private void LoadEmployeeDetails()
        {
            if (_currentEmployee != null)
            {
                usernamelgn = _currentEmployee.Username;
                rolelgn = _currentEmployee.Role;
                firstNamelgn = _currentEmployee.Firstname;
                lastNamelgn = _currentEmployee.Lastname;
            }
        }
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {
            ArchiveOrUnarchiveUser(isArchiving: true);
        }

        private void btn_unarchive_Click(object sender, EventArgs e)
        {
            ArchiveOrUnarchiveUser(isArchiving: false);
        }

        private void LogAction(string actionModule, string action, int? itemId = null, int? quantity = null, decimal? amount = null, string details = null)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO system_logs 
                (action_module, action, item_id, quantity, amount, timestamp, details, employee_id) 
            VALUES 
                (@actionModule, @action, @itemId, @quantity, @amount, @timestamp, @details, @employee_id)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@actionModule", actionModule);
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@itemId", itemId.HasValue ? (object)itemId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@quantity", quantity.HasValue ? (object)quantity.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@amount", amount.HasValue ? (object)amount.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                cmd.Parameters.AddWithValue("@details", details ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@employee_id", frm_Login.CurrentEmployee?.Userid ??(object)DBNull.Value);

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

        private void SaveUser()
        {
            if (!ValidateFields()) return;

            try
            {
                conn.Open();
                string query = @"
                INSERT INTO `employee_tb` 
                (`firstname`, `lastname`, `username`, `password`, `role`, `status`, `is_archived`) 
                VALUES 
                (@firstname, @lastname, @username, @password, @role, @status, 0)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
                cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
                cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                cmd.Parameters.AddWithValue("@password", "Temporary1!");
                cmd.Parameters.AddWithValue("@role", cb_role.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@status", cb_status.SelectedItem.ToString());

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogAction("User Management", "Add", null, null, null, $"Added user: {txt_username.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                ClearFields();
                LoadUsers();
            }
        }

        private void ClearFields()
        {
            txt_userid.Text = string.Empty;
            txt_firstname.Text = string.Empty;
            txt_lastname.Text = string.Empty;
            txt_username.Text = string.Empty;
            cb_role.SelectedIndex = -1;
            cb_status.SelectedIndex = -1;

            txt_userid.ReadOnly = true;
            btn_save.Enabled = true;
            btn_edit.Enabled = false;
        }
        private void UpdateUser()
        {
            if (!ValidateFields()) return;

            try
            {
                conn.Open();
                string query = @"
                UPDATE `employee_tb` 
                SET 
                    `firstname` = @firstname, 
                    `lastname` = @lastname, 
                    `username` = @username, 
                    `role` = @role, 
                    `status` = @status
                WHERE `employee_id` = @employee_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@employee_id", txt_userid.Text.Trim());
                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text.Trim());
                cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text.Trim());
                cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                cmd.Parameters.AddWithValue("@role", cb_role.Text);
                cmd.Parameters.AddWithValue("@status", cb_status.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogAction("User Management", "Edit", null, null, null, "Updated user details: " + txt_username.Text);
                }
                else
                {
                    MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                ClearFields();
                LoadUsers();
            }
            LoadUsers();
        }
        private void ArchiveOrUnarchiveUser(bool isArchiving)
        {
            if (dgv_users.CurrentRow != null && dgv_users.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                try
                {
                    int userId = Convert.ToInt32(dgv_users.CurrentRow.Cells[0].Value);
                    conn.Open();

                    string query = isArchiving
                        ? "UPDATE employee_tb SET is_archived = 1 WHERE employee_id = @employee_id"
                        : "UPDATE employee_tb SET is_archived = 0 WHERE employee_id = @employee_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@employee_id", userId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        string message = isArchiving ? "archived" : "unarchived";
                        MessageBox.Show($"User {message} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogAction("User Management", isArchiving ? "Archive" : "Unarchive", null, null, null, $"User {message}: {userId}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_respassword_Click(object sender, EventArgs e)
        {
            if (dgv_users.CurrentRow != null && dgv_users.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                using (frm_ResetPassword resetPasswordForm = new frm_ResetPassword())
                {
                    if (resetPasswordForm.ShowDialog() == DialogResult.OK)
                    {
                        string newPassword = resetPasswordForm.NewPassword;

                        try
                        {
                            conn.Open();
                            string query = "UPDATE `employee_tb` SET `password` = @newPassword WHERE `employee_id` = @employee_id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@newPassword", newPassword);
                            cmd.Parameters.AddWithValue("@employee_id", dgv_users.CurrentRow.Cells[0].Value);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LogAction("User Management", "Reset Password", null, null, null, $"Password reset for user ID: {dgv_users.CurrentRow.Cells[0].Value}");
                            }
                            else
                            {
                                MessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error resetting password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                            LoadUsers();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to reset the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txt_firstname.Text) ||
                string.IsNullOrWhiteSpace(txt_lastname.Text) ||
                string.IsNullOrWhiteSpace(txt_username.Text) ||
                cb_role.SelectedItem == null ||
                cb_status.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
