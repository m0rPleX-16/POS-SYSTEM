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
    public partial class inventory_recipe : UserControl
    {
        private readonly MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;

        public inventory_recipe(Employee currentEmployee)
        {
            InitializeComponent();
            dgv_recipe.CellClick += DgvInventoryRecipe_CellClick;
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

                MySqlCommand cmdItems = new MySqlCommand("SELECT item_id, item_name FROM menu_items_tb WHERE is_archived = 0", conn);
                MySqlDataReader drItems = cmdItems.ExecuteReader();
                cb_items.Items.Clear();
                while (drItems.Read())
                {
                    cb_items.Items.Add(drItems["item_name"].ToString());
                }
                drItems.Close();

                MySqlCommand cmdIngredients = new MySqlCommand("SELECT ingredient_id, ingredient_name FROM ingredients_tb WHERE is_active = 0", conn);
                MySqlDataReader drIngredients = cmdIngredients.ExecuteReader();
                cb_ingridients.Items.Clear();
                while (drIngredients.Read())
                {
                    cb_ingridients.Items.Add(drIngredients["ingredient_name"].ToString());
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
                        r.recipe_id, i.item_name, ing.ingredient_name, r.quantity_required, r.is_archived
                    FROM recipe_tb r
                    JOIN menu_items_tb i ON r.item_id = i.item_id
                    JOIN ingredients_tb ing ON r.ingredient_id = ing.ingredient_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dgv_recipe.Rows.Clear();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found in the recipe table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                while (reader.Read())
                {
                    dgv_recipe.Rows.Add(
                        reader["recipe_id"],
                        reader["item_name"],
                        reader["ingredient_name"],
                        reader["quantity_required"],
                        reader.GetBoolean("is_archived") ? "Archived" : "Unarchived"
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
        private bool ValidateInputs()
        {
            if (cb_items.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_items.Focus();
                return false;
            }

            if (cb_ingridients.SelectedItem == null)
            {
                MessageBox.Show("Please select an ingredient.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_ingridients.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_quantityreq.Text))
            {
                MessageBox.Show("Quantity Required cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_quantityreq.Focus();
                return false;
            }

            if (!decimal.TryParse(txt_quantityreq.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity Required must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_quantityreq.Focus();
                return false;
            }

            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                conn.Open();

                int itemId = 0;
                string selectedItemName = cb_items.SelectedItem.ToString();
                MySqlCommand cmdItem = new MySqlCommand("SELECT item_id FROM menu_items_tb WHERE item_name = @item_name", conn);
                cmdItem.Parameters.AddWithValue("@item_name", selectedItemName);
                var result = cmdItem.ExecuteScalar();

                if (result != null)
                {
                    itemId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int ingredientId = 0;
                string selectedIngredientName = cb_ingridients.SelectedItem.ToString();
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
            INSERT INTO recipe_tb (item_id, ingredient_id, quantity_required)
            VALUES (@item_id, @ingredient_id, @quantity_required)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_id", itemId);
                cmd.Parameters.AddWithValue("@ingredient_id", ingredientId);
                cmd.Parameters.AddWithValue("@quantity_required", txt_quantityreq.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Recipe saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogAction("Recipe", "Add", null, null, null, "Added new recipe with item: " + selectedItemName + " and ingredient: " + selectedIngredientName);
                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error saving recipe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_recipeid.Clear();
            txt_quantityreq.Clear();
            cb_items.SelectedIndex = -1;
            cb_ingridients.SelectedIndex = -1;
            dgv_recipe.Refresh();
            btn_save.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                conn.Open();

                int itemId = 0;
                string selectedItemName = cb_items.SelectedItem.ToString();
                MySqlCommand cmdItem = new MySqlCommand("SELECT item_id FROM menu_items_tb WHERE item_name = @item_name", conn);
                cmdItem.Parameters.AddWithValue("@item_name", selectedItemName);
                var result = cmdItem.ExecuteScalar();

                if (result != null)
                {
                    itemId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int ingredientId = 0;
                string selectedIngredientName = cb_ingridients.SelectedItem.ToString();
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
            UPDATE recipe_tb 
            SET item_id = @item_id, ingredient_id = @ingredient_id, quantity_required = @quantity_required
            WHERE recipe_id = @recipe_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@recipe_id", txt_recipeid.Text.Trim());
                cmd.Parameters.AddWithValue("@item_id", itemId);
                cmd.Parameters.AddWithValue("@ingredient_id", ingredientId);
                cmd.Parameters.AddWithValue("@quantity_required", txt_quantityreq.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Recipe updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogAction("Recipe", "Edit", int.Parse(txt_recipeid.Text), null, null, "Edited recipe with item: " + selectedItemName + " and ingredient: " + selectedIngredientName);
                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating recipe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {
            if (dgv_recipe.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to archive this recipe?", "Archive Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE recipe_tb SET is_archived = 1 WHERE recipe_id = @recipe_id", conn);
                        cmd.Parameters.AddWithValue("@recipe_id", dgv_recipe.CurrentRow.Cells[0].Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recipe archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogAction("Inventory Recipe", "Archived recipe", null, null, null, "Archived Recipe ID: " + dgv_recipe.CurrentRow.Cells[0].Value);
                        }
                        else
                        {
                            MessageBox.Show("Error archiving recipe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error archiving recipe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                        LoadDataGridView();
                    }
                }
            }
        }
        private void btn_unarchive_Click(object sender, EventArgs e)
        {
            if (dgv_recipe.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to unarchive this recipe", "Unarchive Recipe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE recipe_tb SET is_archived = 0 WHERE recipe_id = @recipe_id", conn);
                        cmd.Parameters.AddWithValue("@recipe_id", dgv_recipe.CurrentRow.Cells[0].Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recipe unarchived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogAction("Inventory Recipe", "Unarchived recipe", null, null, null, "Unarchived Recipe ID: " + dgv_recipe.CurrentRow.Cells[0].Value);
                        }
                        else
                        {
                            MessageBox.Show("Error unarchiving recipe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error unarchiving recipe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                        LoadDataGridView();
                    }
                }
            }
        }
        private void DgvInventoryRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_recipe.CurrentRow != null)
            {
                txt_recipeid.Text = dgv_recipe.CurrentRow.Cells[0].Value.ToString();

                cb_items.SelectedItem = dgv_recipe.CurrentRow.Cells[1].Value.ToString();
                cb_ingridients.SelectedItem = dgv_recipe.CurrentRow.Cells[2].Value.ToString();

                txt_quantityreq.Text = dgv_recipe.CurrentRow.Cells[3].Value.ToString();

                btn_save.Enabled = false;
            }
        }
    }
}
