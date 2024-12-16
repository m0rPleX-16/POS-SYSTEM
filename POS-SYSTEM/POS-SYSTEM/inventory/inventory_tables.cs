using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class inventory_tables : UserControl
    {
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;

        public inventory_tables(Employee currentEmployee)
        {
            InitializeComponent();
            dgv_tables.CellClick += DgvInventoryTable_CellClick;
            LoadDataGridView();
            _currentEmployee = currentEmployee;
            txt_tableno.Text = GenerateTableNo();
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

        private string GenerateTableNo()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                    SELECT MAX(CAST(SUBSTRING(table_number, 9) AS UNSIGNED)) 
                    FROM tables_tb";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    object result = cmd.ExecuteScalar();

                    int nextNumber = (result != DBNull.Value && result != null) ? Convert.ToInt32(result) + 1 : 1;

                    string datePrefix = DateTime.Now.ToString("yyyyMMdd");

                    return datePrefix + nextNumber.ToString("D3");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error generating table number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void LoadDataGridView()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT table_id, table_number, is_active, is_archived FROM tables_tb", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dgv_tables.Rows.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No data found in the Tables table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    while (reader.Read())
                    {
                        dgv_tables.Rows.Add(reader["table_id"], reader["table_number"], reader["is_active"], reader.GetBoolean("is_archived") ? "Archived" : "Unarchived");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvInventoryTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tables.CurrentRow != null)
            {
                txt_tableid.Text = dgv_tables.CurrentRow.Cells[0].Value.ToString();
                txt_tableno.Text = dgv_tables.CurrentRow.Cells[1].Value.ToString();

                cb_is_active.SelectedItem = dgv_tables.CurrentRow.Cells[2].Value.ToString();

                btn_save.Enabled = false;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_tableno.Text))
            {
                MessageBox.Show("Table number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_tableno.Text.Length > 100)
            {
                MessageBox.Show("Table number cannot be longer than 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cb_is_active.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an 'Is Active' status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            string generatedTableNo = GenerateTableNo();
            if (generatedTableNo == null) return;

            txt_tableno.Text = generatedTableNo;

            if (!ValidateInput()) return;

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO tables_tb (table_number, is_active) VALUES (@table_number, @is_active)", conn);
                    cmd.Parameters.AddWithValue("@table_number", generatedTableNo);
                    cmd.Parameters.AddWithValue("@is_active", cb_is_active.SelectedItem.ToString());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Table saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogAction("Inventory Table", "Saved new table", null, null, null, "Table Number: " + generatedTableNo);
                    }
                    else
                    {
                        MessageBox.Show("Error saving table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error saving table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadDataGridView();
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_tableid.Clear();
            txt_tableno.Clear();
            cb_is_active.SelectedIndex = -1;
            dgv_tables.Refresh();
            btn_save.Enabled = true;
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE tables_tb SET table_number = @table_number, is_active = @is_active WHERE table_id = @table_id", conn);
                    cmd.Parameters.AddWithValue("@table_id", txt_tableid.Text);
                    cmd.Parameters.AddWithValue("@table_number", txt_tableno.Text);
                    cmd.Parameters.AddWithValue("@is_active", cb_is_active.SelectedItem.ToString());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Table updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogAction("Inventory Table", "Updated table",null, null, null, "Updated Table Number: " + txt_tableno.Text);
                    }
                    else
                    {
                        MessageBox.Show("Error updating table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadDataGridView();
            }
        }

        private void btn_archive_Click_1(object sender, EventArgs e)
        {
            if (dgv_tables.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to archive this table?", "Archive Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("UPDATE tables_tb SET is_archived = 1 WHERE table_id = @table_id", conn);
                            cmd.Parameters.AddWithValue("@table_id", dgv_tables.CurrentRow.Cells[0].Value);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Table archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LogAction("Inventory Table", "Archived table", Convert.ToInt32(dgv_tables.CurrentRow.Cells[0].Value), null, null, "Archived Table ID: " + dgv_tables.CurrentRow.Cells[0].Value);
                            }
                            else
                            {
                                MessageBox.Show("Error archiving table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error archiving table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        LoadDataGridView();
                    }
                }
            }
        }

        private void btn_unarchive_Click_1(object sender, EventArgs e)
        {
            if (dgv_tables.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to unarchive this table?", "Unarchive Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("UPDATE tables_tb SET is_archived = 0 WHERE table_id = @table_id", conn);
                            cmd.Parameters.AddWithValue("@table_id", dgv_tables.CurrentRow.Cells[0].Value);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Table unarchived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LogAction("Inventory Table", "Unarchived table", Convert.ToInt32(dgv_tables.CurrentRow.Cells[0].Value), null, null, "Unarchived Table ID: " + dgv_tables.CurrentRow.Cells[0].Value);
                            }
                            else
                            {
                                MessageBox.Show("Error unarchiving table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error unarchiving table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        LoadDataGridView();
                    }
                }
            }
        }
    }
}
