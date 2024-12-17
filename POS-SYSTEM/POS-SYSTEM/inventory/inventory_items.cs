using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class inventory_items : UserControl
    {
        private readonly MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private readonly string _connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;
        public inventory_items(Employee currentEmployee)
        {
            InitializeComponent();
            dgv_items.CellClick += DgvInventoryItems_CellClick;
            LoadComboBox();
            LoadDataGridView();
            _currentEmployee = currentEmployee;
        }
        private void LogAction(string module, string action, int? itemId = null, int? quantity = null, decimal? amount = null, string details = null)
        {
            const string query = @"
                INSERT INTO system_logs 
                (action_module, action, item_id, quantity, amount, timestamp, details, employee_id) 
                VALUES 
                (@module, @action, @itemId, @quantity, @amount, @timestamp, @details, @employeeId)";

            ExecuteQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@module", module);
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@itemId", itemId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@quantity", quantity ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@amount", amount ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                cmd.Parameters.AddWithValue("@details", details ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@employeeId", _currentEmployee?.Userid ?? (object)DBNull.Value);
            });
        }

        private void ExecuteQuery(string query, Action<MySqlCommand> parameterize, Action<MySqlDataReader> process = null)
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        parameterize?.Invoke(cmd);
                        if (process != null)
                        {
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read()) process(reader);
                            }
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadComboBox()
        {
            try
            {
                conn.Open();

                MySqlCommand cmdItems = new MySqlCommand("SELECT category_id, category_name FROM categories_tb WHERE is_archived = 0", conn);
                MySqlDataReader drCat = cmdItems.ExecuteReader();
                cb_category.Items.Clear();

                while (drCat.Read())
                {
                    cb_category.Items.Add(drCat["category_name"].ToString());
                }
                drCat.Close();
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
            const string query = @"
SELECT 
    m.*, 
    c.category_name, 
    CASE 
        WHEN m.is_archived = 1 THEN 'Archived' 
        ELSE 'Unarchived' 
    END AS archive_status
FROM menu_items_tb m
JOIN categories_tb c ON m.category_id = c.category_id
ORDER BY m.date_added DESC";

            dgv_items.Rows.Clear();

            using (var conn = new MySqlConnection(_connectionString))
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No data found in the items table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        while (reader.Read())
                        {
                            Image productImage = LoadImageFromBase64(reader["image_base64"]);

                            dgv_items.Rows.Add(
                                productImage,
                                reader["item_id"],
                                reader["item_name"],
                                reader["category_name"],
                                reader["price"],
                                reader["date_added"],
                                reader.GetBoolean("is_available") ? "Active" : "Inactive",
                                reader.GetBoolean("is_archived") ? "Archived" : "Unarchived"
                            );
                        }
                    }
                }
            }
        }

        private Image LoadImageFromBase64(object base64Data)
        {
            if (base64Data == DBNull.Value) return null;

            try
            {
                byte[] imageArray = (byte[])base64Data;
                using (var ms = new MemoryStream(imageArray))
                {
                    var originalImage = Image.FromStream(ms);
                    return ResizeImageToFitDGV(originalImage, 80, 80);
                }
            }
            catch
            {
                return null;
            }
        }

        private void DgvInventoryItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_items.Rows.Count)
            {
                DataGridViewRow row = dgv_items.Rows[e.RowIndex];

                txt_itemID.Text = row.Cells["item_id"].Value?.ToString();
                txt_itemname.Text = row.Cells["item_name"].Value?.ToString();
                cb_category.SelectedItem = row.Cells["category_name"].Value?.ToString();
                txt_price.Text = row.Cells["price"].Value?.ToString();
                chk_available.Checked = row.Cells["is_available"].Value?.ToString() == "Active";


                if (row.Cells["image_base64"].Value is Image cellImage)
                {
                    pic_ProdImg.Image = cellImage;
                }
                else
                {
                    pic_ProdImg.Image = null;
                }

                btn_save.Enabled = false;
                btn_edit.Enabled = true;
            }
        }
        private Image ResizeImageToFitDGV(Image img, int width, int height)
        {
            int newWidth, newHeight;

            if (img.Width > img.Height)
            {
                newWidth = width;
                newHeight = (int)(img.Height * ((float)newWidth / img.Width));
                if (newHeight > height)
                {
                    newHeight = height;
                    newWidth = (int)(img.Width * ((float)newHeight / img.Height));
                }
            }
            else
            {
                newHeight = height;
                newWidth = (int)(img.Width * ((float)newHeight / img.Height));
                if (newWidth > width)
                {
                    newWidth = width;
                    newHeight = (int)(img.Height * ((float)newWidth / img.Width));
                }
            }
            Bitmap resizedImage = new Bitmap(img, newWidth, newHeight);
            return resizedImage;
        }

        private byte[] GetImageBytes()
        {
            if (pic_ProdImg.Image == null) return null;

            using (var ms = new MemoryStream())
            {
                pic_ProdImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void pic_ProdImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Image originalImage = Image.FromFile(openFileDialog.FileName))
                        {
                            Image resizedImage = ResizeImageToFitDGV(originalImage, 120, 120);
                            pic_ProdImg.Image = resizedImage;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                conn.Open();

                int catId = 0;
                string selectedCatName = cb_category.SelectedItem.ToString();
                MySqlCommand cmdCat = new MySqlCommand("SELECT category_id FROM categories_tb WHERE category_name = @category_name", conn);
                cmdCat.Parameters.AddWithValue("@category_name", selectedCatName);
                var result = cmdCat.ExecuteScalar();

                if (result != null)
                {
                    catId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal price;
                if (!decimal.TryParse(txt_price.Text.Trim(), out price))
                {
                    MessageBox.Show("Invalid Price. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string checkQuery = "SELECT COUNT(*) FROM menu_items_tb WHERE item_name = @item_name";
                MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conn);
                cmdCheck.Parameters.AddWithValue("@item_name", txt_itemname.Text.Trim());
                int itemCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (itemCount > 0)
                {
                    MessageBox.Show("This item already exists. Please enter a different item name.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"INSERT INTO menu_items_tb (item_name, category_id, price, is_available, image_base64, is_archived)
                  VALUES (@item_name, @category_id, @price, @is_available, @image_base64, @is_archived)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_name", txt_itemname.Text.Trim());
                cmd.Parameters.AddWithValue("@category_id", catId);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@is_available", chk_available.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@image_base64", GetImageBytes());
                cmd.Parameters.AddWithValue("@is_archived", 0);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu item saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogAction("Menu Management", "Add Menu Item", null, null, price, "Added menu item:" + txt_itemname.Text);
                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error saving item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
            txt_itemID.Clear();
            txt_itemname.Clear();
            txt_price.Clear();
            pic_ProdImg.Image = null;
            cb_category.SelectedIndex = -1;
            chk_available.Checked = false;
            btn_save.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                conn.Open();
                int catId = 0;
                string selectedCatName = cb_category.SelectedItem.ToString();
                MySqlCommand cmdCat = new MySqlCommand("SELECT category_id FROM categories_tb WHERE category_name = @category_name", conn);
                cmdCat.Parameters.AddWithValue("@category_name", selectedCatName);
                var result = cmdCat.ExecuteScalar();

                if (result != null)
                {
                    catId = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"UPDATE menu_items_tb 
                         SET item_name = @item_name, category_id = @category_id, price = @price, 
                             is_available = @is_available, image_base64 = @image_base64 
                         WHERE item_id = @item_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_id", txt_itemID.Text.Trim());
                cmd.Parameters.AddWithValue("@item_name", txt_itemname.Text.Trim());
                cmd.Parameters.AddWithValue("@category_id", catId);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txt_price.Text.Trim()));
                cmd.Parameters.AddWithValue("@is_available", chk_available.Checked ? 1 : 0);
                cmd.Parameters.AddWithValue("@image_base64", GetImageBytes());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogAction("Menu Management", "Edit Menu Item", Convert.ToInt32(txt_itemID.Text), null, Convert.ToDecimal(txt_price.Text), $"Edited menu item: {txt_itemname.Text}");
                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error editing item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_itemID.Text))
            {
                MessageBox.Show("Item ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int itemId;
            if (!int.TryParse(txt_itemID.Text.Trim(), out itemId))
            {
                MessageBox.Show("Invalid Item ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();

                string checkQuery = @"SELECT is_archived FROM menu_items_tb WHERE item_id = @item_id";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@item_id", itemId);
                object result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int isArchived = Convert.ToInt32(result);
                if (isArchived == 1)
                {
                    MessageBox.Show("Item is already archived.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = @"UPDATE menu_items_tb SET is_archived = 1 WHERE item_id = @item_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_id", itemId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu item archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogAction("Menu Management", "Archive Menu Item", itemId, null, null, $"Archived menu item: {txt_itemname.Text}");
                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error archiving item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

       private void btn_unarchive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_itemID.Text))
            {
                MessageBox.Show("Item ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int itemId;
            if (!int.TryParse(txt_itemID.Text.Trim(), out itemId))
            {
                MessageBox.Show("Invalid Item ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string checkQuery = @"SELECT is_archived FROM menu_items_tb WHERE item_id = @item_id";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@item_id", itemId);
                object result = checkCmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int isArchived = Convert.ToInt32(result);

                if (isArchived == 0)
                {
                    MessageBox.Show("Item is already active (not archived).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = @"UPDATE menu_items_tb SET is_archived = 0 WHERE item_id = @item_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_id", itemId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu item unarchived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LogAction("Menu Management", "Unarchive Menu Item", itemId, null, null, $"Unarchived menu item: {txt_itemname.Text}");
                LoadDataGridView();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error unarchiving item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_itemname.Text))
            {
                MessageBox.Show("Item Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cb_category.SelectedItem == null)
            {
                MessageBox.Show("Category is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txt_price.Text, out var price) || price <= 0)
            {
                MessageBox.Show("Invalid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (pic_ProdImg.Image == null)
            {
                MessageBox.Show("Product image is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
