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
    public partial class inventory_transactions : UserControl
    {
        private readonly MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;
        public inventory_transactions(Employee currentEmployee)
        {
            InitializeComponent();
            dgv_transact.CellClick += DgvInventoryTransact_CellClick;
            _currentEmployee = currentEmployee;
            LoadDataGridView();
            LoadComboBoxes();
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

        private void LoadComboBoxes()
        {

            try
            {
                conn.Open();
                MySqlCommand cmdIngredients = new MySqlCommand("SELECT ingredient_id, ingredient_name FROM ingredients_tb WHERE is_active = 0", conn);
                MySqlDataReader drIngredients = cmdIngredients.ExecuteReader();
                cb_ingredients.Items.Clear();
                while (drIngredients.Read())
                {
                    cb_ingredients.Items.Add(drIngredients["ingredient_name"].ToString());
                }
                drIngredients.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading combo boxes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadDataGridView()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                string query = @"
            SELECT 
                t.transaction_id,
                ing.ingredient_name,
                t.transaction_type,
                t.quantity,
                t.transaction_date,
                t.note
            FROM inventory_transactions_tb t
            JOIN ingredients_tb ing ON t.ingredient_id = ing.ingredient_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dgv_transact.Rows.Clear();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found in the transactions table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                while (reader.Read())
                {
                    dgv_transact.Rows.Add(
                        reader["transaction_id"],
                        reader["ingredient_name"],
                        reader["transaction_type"],
                        reader["quantity"],
                        Convert.ToDateTime(reader["transaction_date"]).ToString("yyyy-MM-dd HH:mm:ss"),
                        reader["note"]?.ToString() ?? "No notes"
                    );
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
        private void DgvInventoryTransact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_transact.CurrentRow != null)
            {
                txt_transid.Text = dgv_transact.CurrentRow.Cells[0].Value.ToString();
                cb_ingredients.SelectedItem = dgv_transact.CurrentRow.Cells[1].Value.ToString();
                cb_trans.SelectedItem = dgv_transact.CurrentRow.Cells[2].Value.ToString();
                txt_quantity.Text = dgv_transact.CurrentRow.Cells[3].Value.ToString();
                dtp_trans.Value = dgv_transact.CurrentRow.Cells[4].Value == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dgv_transact.CurrentRow.Cells[4].Value);
                txt_notes.Text = dgv_transact.CurrentRow.Cells[5].Value.ToString(); 

                btn_save.Enabled = false;
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();


                    int ingredientId = 0;
                    string selectedIngredientName = cb_ingredients.SelectedItem.ToString();
                    MySqlCommand cmdIngredient = new MySqlCommand("SELECT ingredient_id FROM ingredients_tb WHERE ingredient_name = @ingredient_name", conn);
                    cmdIngredient.Parameters.AddWithValue("@ingredient_name", selectedIngredientName);
                    var ingredientResult = cmdIngredient.ExecuteScalar();

                    if (ingredientResult != null)
                    {
                        ingredientId = Convert.ToInt32(ingredientResult);
                    }
                    else
                    {
                        MessageBox.Show("Ingredient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = @"
                INSERT INTO inventory_transactions_tb 
                    (ingredient_id, transaction_type, quantity, transaction_date, note) 
                VALUES 
                    (@ingredient_id, @transaction_type, @quantity, @transaction_date, @note)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ingredient_id", ingredientId);
                    cmd.Parameters.AddWithValue("@transaction_type", cb_trans.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToDecimal(txt_quantity.Text.Trim()));
                    cmd.Parameters.AddWithValue("@transaction_date", dtp_trans.Value);
                    cmd.Parameters.AddWithValue("@note", string.IsNullOrWhiteSpace(txt_notes.Text) ? (object)DBNull.Value : txt_notes.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LogAction("Inventory Transactions", "Add Transaction", null, Convert.ToInt32(txt_quantity.Text), null, "Added transaction for ingredient: " + selectedIngredientName);
                    LoadDataGridView();
                    ClearFields();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error saving transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

         private void ClearFields()
        {
            txt_transid.Clear();
            cb_ingredients.SelectedIndex = -1;
            cb_trans.SelectedIndex = -1;
            txt_quantity.Clear();
            dtp_trans.Value = DateTime.Now;
            txt_notes.Clear();
            btn_save.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_transid.Text))
            {
                MessageBox.Show("Please select a transaction to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    int ingredientId = 0;
                    string selectedIngredientName = cb_ingredients.SelectedItem.ToString();
                    MySqlCommand cmdIngredient = new MySqlCommand("SELECT ingredient_id FROM ingredients_tb WHERE ingredient_name = @ingredient_name", conn);
                    cmdIngredient.Parameters.AddWithValue("@ingredient_name", selectedIngredientName);
                    var ingredientResult = cmdIngredient.ExecuteScalar();

                    if (ingredientResult != null)
                    {
                        ingredientId = Convert.ToInt32(ingredientResult);
                    }
                    else
                    {
                        MessageBox.Show("Ingredient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = @"
                UPDATE inventory_transactions_tb 
                SET 
                    ingredient_id = @ingredient_id,
                    transaction_type = @transaction_type,
                    quantity = @quantity,
                    transaction_date = @transaction_date,
                    note = @note
                WHERE transaction_id = @transaction_id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@transaction_id", Convert.ToInt32(txt_transid.Text.Trim()));
                    cmd.Parameters.AddWithValue("@ingredient_id", ingredientId);
                    cmd.Parameters.AddWithValue("@transaction_type", cb_trans.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToDecimal(txt_quantity.Text.Trim()));
                    cmd.Parameters.AddWithValue("@transaction_date", dtp_trans.Value);
                    cmd.Parameters.AddWithValue("@note", string.IsNullOrWhiteSpace(txt_notes.Text) ? (object)DBNull.Value : txt_notes.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LogAction("Inventory Transactions", "Edit Transaction", null, Convert.ToInt32(txt_quantity.Text), null, "Edited transaction for ingredient: " + selectedIngredientName);
                    LoadDataGridView();
                    ClearFields();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cb_trans.SelectedItem == null)
            {
                MessageBox.Show("Please select a transaction type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cb_ingredients.SelectedItem == null)
            {
                MessageBox.Show("Please select an ingredient.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_quantity.Text) || !decimal.TryParse(txt_quantity.Text.Trim(), out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtp_trans.Value == DateTime.MinValue)
            {
                MessageBox.Show("Please select a valid transaction date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txt_notes.Text.Length > 255)
            {
                MessageBox.Show("Note cannot exceed 255 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {

        }

        private void btn_unarchive_Click(object sender, EventArgs e)
        {

        }
    }
}
