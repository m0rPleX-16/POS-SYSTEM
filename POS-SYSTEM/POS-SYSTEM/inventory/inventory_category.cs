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
    public partial class inventory_category : UserControl
    {
        private readonly MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;

        public inventory_category(Employee currentEmployee)
        {
            InitializeComponent();
            dgv_category.CellClick += DgvInventoryCategory_CellClick;
            LoadDataGridView();
            _currentEmployee = currentEmployee;
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
                cmd.Parameters.AddWithValue("@employee_id", _currentEmployee?.Userid ?? (object)DBNull.Value);

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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM categories_tb WHERE category_name = @category_name";
                MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conn);
                cmdCheck.Parameters.AddWithValue("@category_name", txt_category_name.Text.Trim());
                int categoryCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (categoryCount > 0)
                {
                    MessageBox.Show("This category already exists. Please enter a different category name.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlCommand cmd = new MySqlCommand("INSERT INTO categories_tb (category_name) VALUES (@category_name)", conn);
                cmd.Parameters.AddWithValue("@category_name", txt_category_name.Text.Trim());

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogAction("Inventory Category", "Saved new category", null, null, null, "Category Name: " + txt_category_name.Text);
                }
                else
                {
                    MessageBox.Show("Error saving category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error saving category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                LoadDataGridView();
                ClearFields();
            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE categories_tb SET category_name = @category_name WHERE category_id = @category_id", conn);
                cmd.Parameters.AddWithValue("@category_id", txt_category_id.Text);
                cmd.Parameters.AddWithValue("@category_name", txt_category_name.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogAction("Inventory Category", "Updated category", null, null, null, "Updated Category Name: " + txt_category_name.Text);
                }
                else
                {
                    MessageBox.Show("Error updating category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                LoadDataGridView();
            }
        }

        private void ClearFields()
        {
            txt_category_id.Clear();
            txt_category_name.Clear();
            dgv_category.Refresh();
            btn_save.Enabled = true;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {
            if (dgv_category.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to archive this category?", "Archive Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE categories_tb SET is_archived = 1 WHERE category_id = @category_id", conn);
                        cmd.Parameters.AddWithValue("@category_id", dgv_category.CurrentRow.Cells[0].Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogAction("Inventory Category", "Archived category", Convert.ToInt32(dgv_category.CurrentRow.Cells[0].Value), null, null, "Archived Category ID: " + dgv_category.CurrentRow.Cells[0].Value);
                        }
                        else
                        {
                            MessageBox.Show("Error archiving category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error archiving category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                        LoadDataGridView();
                        ClearFields();
                    }
                }
            }
        }

        private void btn_unarchive_Click(object sender, EventArgs e)
        {

        }

        private void LoadDataGridView()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM categories_tb", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dgv_category.Rows.Clear();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found in the categories table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                while (reader.Read())
                {
                    dgv_category.Rows.Add(
                        reader["category_id"], 
                        reader["category_name"], 
                        reader.GetBoolean("is_archived") ? "Archived" : "Unarchived");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DgvInventoryCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_category.CurrentRow != null)
            {
                txt_category_id.Text = dgv_category.CurrentRow.Cells[0].Value.ToString();
                txt_category_name.Text = dgv_category.CurrentRow.Cells[1].Value.ToString();

                btn_save.Enabled = false;
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_category_name.Text))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_category_name.Text.Length > 100)
            {
                MessageBox.Show("Category name cannot be longer than 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
