﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS_SYSTEM.inventory
{
    public partial class inventory_ingridients : UserControl
    {
        private readonly MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;
        private const int PageSize = 25;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;

        public inventory_ingridients(Employee currentEmployee)
        {
            InitializeComponent();
            dgv_ingridients.CellClick += DgvInventoryCategory_CellClick;
            LoadDataGridView();
            _currentEmployee = currentEmployee;
        }

        private Timer blinkTimer = new Timer();
        private List<int> blinkingRows = new List<int>();

        private void LoadDataGridView()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string countQuery = "SELECT COUNT(*) FROM ingredients_tb";
                MySqlCommand countCmd = new MySqlCommand(countQuery, conn);
                totalRows = Convert.ToInt32(countCmd.ExecuteScalar());
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);

                lblCurrentPage.Text = currentPageIndex.ToString();
                lblTotalPage.Text = totalPages.ToString();

                string query = @"
            SELECT * FROM ingredients_tb
            LIMIT @offset, @pageSize";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@offset", (currentPageIndex - 1) * PageSize);
                cmd.Parameters.AddWithValue("@pageSize", PageSize);

                MySqlDataReader reader = cmd.ExecuteReader();
                dgv_ingridients.Rows.Clear();
                blinkingRows.Clear();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found in the ingredients table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                while (reader.Read())
                {
                    int rowIndex = dgv_ingridients.Rows.Add(
                        reader["ingredient_id"],
                        reader["ingredient_name"],
                        reader["unit"],
                        reader["stock_quantity"],
                        reader["minimum_quantity"],
                        reader["expiration_date"],
                        reader["date_updated"],
                        reader.GetBoolean("is_active") ? "Archived" : "Unarchived");

                    int stockQuantity = Convert.ToInt32(reader["stock_quantity"]);
                    int minimumQuantity = Convert.ToInt32(reader["minimum_quantity"]);
                    DateTime expirationDate = reader.IsDBNull(reader.GetOrdinal("expiration_date"))
                        ? DateTime.MaxValue
                        : Convert.ToDateTime(reader["expiration_date"]);

                    if (stockQuantity <= minimumQuantity || expirationDate <= DateTime.Now.AddDays(3))
                    {
                        blinkingRows.Add(rowIndex);
                        dgv_ingridients.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                if (blinkingRows.Count > 0)
                {
                    blinkTimer.Interval = 500;
                    blinkTimer.Tick += BlinkTimer_Tick;
                    blinkTimer.Start();
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

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            List<int> rowsToRemove = new List<int>();

            foreach (int rowIndex in blinkingRows)
            {
                DataGridViewRow row = dgv_ingridients.Rows[rowIndex];
                int stockQuantity = Convert.ToInt32(row.Cells["stock_quantity"].Value);
                int minimumQuantity = Convert.ToInt32(row.Cells["minimum_quantity"].Value);
                DateTime expirationDate = Convert.ToDateTime(row.Cells["expiration_date"].Value);

                if (stockQuantity > minimumQuantity && expirationDate > DateTime.Now.AddDays(3))
                {
                    row.DefaultCellStyle.BackColor = Color.FloralWhite; 
                    rowsToRemove.Add(rowIndex); 
                }
                else
                {
                    if (row.DefaultCellStyle.BackColor == Color.Red)
                    {
                        row.DefaultCellStyle.BackColor = Color.FloralWhite; 
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Red; 
                    }
                }
            }


            foreach (int rowIndex in rowsToRemove)
            {
                blinkingRows.Remove(rowIndex);
            }

            if (blinkingRows.Count == 0)
            {
                blinkTimer.Stop();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_ingname.Text))
            {
                MessageBox.Show("Ingredient name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_ingname.Text.Length > 255)
            {
                MessageBox.Show("Ingredient name cannot be longer than 255 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_unit.Text))
            {
                MessageBox.Show("Unit cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txt_unit.Text.Length > 50)
            {
                MessageBox.Show("Unit cannot be longer than 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txt_stockquan.Text, out decimal stockQuantity) || stockQuantity < 0)
            {
                MessageBox.Show("Stock quantity must be a valid non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txt_minquan.Text, out decimal minimumQuantity) || minimumQuantity < 0)
            {
                MessageBox.Show("Minimum quantity must be a valid non-negative number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

        private void DgvInventoryCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ingridients.CurrentRow != null)
            {
                txt_ingid.Text = dgv_ingridients.CurrentRow.Cells[0].Value.ToString();
                txt_ingname.Text = dgv_ingridients.CurrentRow.Cells[1].Value.ToString();
                txt_unit.Text = dgv_ingridients.CurrentRow.Cells[2].Value.ToString();
                txt_stockquan.Text = dgv_ingridients.CurrentRow.Cells[3].Value.ToString();
                txt_minquan.Text = dgv_ingridients.CurrentRow.Cells[4].Value.ToString();
                expire_dtp.Value = dgv_ingridients.CurrentRow.Cells[5].Value == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dgv_ingridients.CurrentRow.Cells[5].Value);

                btn_save.Enabled = false;
                txt_stockquan.ReadOnly = true;
                txt_minquan.ReadOnly = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            int quantityAdded = 0;

            if (!int.TryParse(txt_stockquan.Text, out quantityAdded))
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM ingredients_tb WHERE ingredient_name = @ingredient_name";
                MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conn);
                cmdCheck.Parameters.AddWithValue("@ingredient_name", txt_ingname.Text.Trim());
                int ingredientCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (ingredientCount > 0)
                {
                    MessageBox.Show("This ingredient already exists. Please enter a different name.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
        INSERT INTO ingredients_tb (ingredient_name, unit, stock_quantity, minimum_quantity, expiration_date, is_active)
        VALUES (@ingredient_name, @unit, @stock_quantity, @minimum_quantity, @expiration_date, @is_active)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ingredient_name", txt_ingname.Text.Trim());
                cmd.Parameters.AddWithValue("@unit", txt_unit.Text.Trim());
                cmd.Parameters.AddWithValue("@stock_quantity", txt_stockquan.Text.Trim());
                cmd.Parameters.AddWithValue("@minimum_quantity", txt_minquan.Text.Trim());
                cmd.Parameters.AddWithValue("@expiration_date", expire_dtp.Value.Date == DateTime.MinValue ? (object)DBNull.Value : expire_dtp.Value.Date);
                cmd.Parameters.AddWithValue("@is_active", false);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingredient saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogAction("Inventory", "Save Ingredient", null, quantityAdded, null, $"Saved new ingredient: {txt_ingname.Text}");

                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error saving ingredient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ingid.Clear();
            txt_ingname.Clear();
            txt_unit.Clear();
            txt_stockquan.Clear();
            txt_minquan.Clear();
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            decimal stockQuantityUpdated, minimumQuantityUpdated;

            if (!Decimal.TryParse(txt_stockquan.Text.Trim(), out stockQuantityUpdated) ||
                !Decimal.TryParse(txt_minquan.Text.Trim(), out minimumQuantityUpdated))
            {
                MessageBox.Show("Please enter valid numeric values for stock quantity and minimum quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                string query = @"
            UPDATE ingredients_tb
            SET ingredient_name = @ingredient_name, unit = @unit, stock_quantity = @stock_quantity,
                minimum_quantity = @minimum_quantity, expiration_date = @expiration_date, is_active = @is_active
            WHERE ingredient_id = @ingredient_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ingredient_id", txt_ingid.Text.Trim());
                cmd.Parameters.AddWithValue("@ingredient_name", txt_ingname.Text.Trim());
                cmd.Parameters.AddWithValue("@unit", txt_unit.Text.Trim());
                cmd.Parameters.AddWithValue("@stock_quantity", stockQuantityUpdated);
                cmd.Parameters.AddWithValue("@minimum_quantity", minimumQuantityUpdated);
                cmd.Parameters.AddWithValue("@expiration_date", expire_dtp.Value.Date == DateTime.MinValue ? (object)DBNull.Value : expire_dtp.Value.Date);
                cmd.Parameters.AddWithValue("@is_active", false); 

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingredient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogAction("Inventory", "Edit Ingredient", null, (int)stockQuantityUpdated, null, $"Edited ingredient: {txt_ingname.Text}");

                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating ingredient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btn_archive_Click(object sender, EventArgs e)
        {
            if (dgv_ingridients.CurrentRow == null)
                return;

            try
            {
                conn.Open();

                string query = "UPDATE ingredients_tb SET is_active = 1 WHERE ingredient_id = @ingredient_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ingredient_id", dgv_ingridients.CurrentRow.Cells[0].Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingredient archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogAction("Inventory", "Archive Ingredient",null, null, null, $"Archived ingredient: {dgv_ingridients.CurrentRow.Cells[1].Value}");

                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error archiving ingredient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_unarchive_Click(object sender, EventArgs e)
        {
            if (dgv_ingridients.CurrentRow == null)
                return;

            try
            {
                conn.Open();

                string query = "UPDATE ingredients_tb SET is_active = 0 WHERE ingredient_id = @ingredient_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ingredient_id", dgv_ingridients.CurrentRow.Cells[0].Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingredient unarchived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogAction("Inventory", "Unarchive Ingredient", null, null, null, $"Unarchived ingredient: {dgv_ingridients.CurrentRow.Cells[1].Value}");

                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error unarchiving ingredient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            LoadDataGridView();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                LoadDataGridView();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages)
            {
                currentPageIndex++;
                LoadDataGridView();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages;
            LoadDataGridView();
        }
    }
}
