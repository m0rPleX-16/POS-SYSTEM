﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class frm_POS : Form
    {
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private readonly Employee _currentEmployee;

        public frm_POS(Employee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
            InitializeTimer();
            AutoGenerateTransactionNumber();
            LoadProducts();
            LoadCategory();
            txt_cash.TextChanged += TxtCash_TextChanged;
        }


        private void InitializeTimer()
        {
            timerClock.Interval = 1000;
            timerClock.Tick += UpdateClock;
            timerClock.Start();
        }


        private void UpdateClock(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbl_date.Text = now.ToString("dddd, d'" + GetDaySuffix(now.Day) + "' 'of' MMMM yyyy");
            lbl_time.Text = now.ToString("hh:mm:ss tt");
        }

        private static string GetDaySuffix(int day)
        {
            return day % 10 == 1 && day != 11 ? "st"
                 : day % 10 == 2 && day != 12 ? "nd"
                 : day % 10 == 3 && day != 13 ? "rd"
                 : "th";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            LogAction("Logout", "POS Session", $"Cashier {_currentEmployee.Username} logged out");
        }

        private void LogAction(string action, string module, string details = null, string itemId = null, int? quantity = null, decimal? amount = null)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO system_logs 
                    (action_module, action, item_id, quantity, amount, timestamp, details, employee_id) 
                    VALUES 
                    (@module, @action, @itemId, @quantity, @amount, @timestamp, @details, @employeeId)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@module", module);
                    cmd.Parameters.AddWithValue("@action", action);
                    cmd.Parameters.AddWithValue("@itemId", itemId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@quantity", quantity ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@amount", amount ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                    cmd.Parameters.AddWithValue("@details", details ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@employeeId", _currentEmployee.Userid);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error logging action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AutoGenerateTransactionNumber()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT orderNo FROM orders_tb ORDER BY order_id DESC LIMIT 1";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            txt_transactNo.Text = (Convert.ToInt32(reader["orderNo"]) + 1).ToString();
                        }
                        else
                        {
                            txt_transactNo.Text = DateTime.Now.ToString("yyyyMM") + "-001";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error generating transaction number: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProducts(string categoryFilter = "ALL CATEGORY")
        {
            flp_sales.Controls.Clear();


            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT  
                    m.item_id, m.item_name, m.price, m.image_base64, 
                    c.category_name, m.is_available 
                FROM 
                    menu_items_tb m
                LEFT JOIN 
                    categories_tb c ON m.category_id = c.category_id
                WHERE 
                    m.is_archived = 0 AND m.is_available = 1";

                    if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter != "ALL CATEGORY")
                    {
                        query += " AND c.category_name = @categoryName";
                    }

                    query += " ORDER BY m.item_name ASC";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter != "ALL CATEGORY")
                        {
                            cmd.Parameters.AddWithValue("@categoryName", categoryFilter);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemId = reader["item_id"].ToString();
                                string itemName = reader["item_name"].ToString().ToUpper();
                                decimal price = Convert.ToDecimal(reader["price"]);
                                string categoryName = reader["category_name"].ToString();
                                bool isAvailable = Convert.ToBoolean(reader["is_available"]);

                                long len = reader.GetBytes(reader.GetOrdinal("image_base64"), 0, null, 0, 0);
                                byte[] imageArray = new byte[len];
                                reader.GetBytes(reader.GetOrdinal("image_base64"), 0, imageArray, 0, (int)len);

                                AddProductToUI(itemId, itemName, categoryName, price, imageArray, isAvailable);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddProductToUI(string itemId, string itemName, string categoryName, decimal price, byte[] imageArray, bool isAvailable)
        {
            if (!isAvailable)
            {
                return;
            }

            RoundedPanel productPanel = CreateProductPanel(itemId, itemName, categoryName, price, imageArray, isAvailable);
            flp_sales.Controls.Add(productPanel);
        }

        private RoundedPanel CreateProductPanel(string itemId, string itemName, string categoryName, decimal price, byte[] imageArray, bool isAvailable)
        {
            RoundedPanel productPanel = new RoundedPanel
            {
                Width = 130,
                Height = 210,
                BackColor = isAvailable ? Color.FloralWhite : Color.LightGray,
                Tag = itemId,
                Margin = new Padding(20, 20, 20, 20),
            };
            PictureBox productImage = new PictureBox
            {
                Width = 100,
                Height = 100,
                BackgroundImageLayout = ImageLayout.Stretch,
                Dock = DockStyle.Top,
                Tag = itemId
            };
            using (MemoryStream ms = new MemoryStream(imageArray))
            {
                productImage.BackgroundImage = Image.FromStream(ms);
            }

            Label lblItemName = new Label
            {
                Text = itemName.ToUpper(),
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,     
                MaximumSize = new Size(150, 0),
                Size = new Size(150, 40), 
            };


            Label lblCategoryName = new Label
            {
                Text = categoryName,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblPrice = new Label
            {
                Text = "₱" + price.ToString("F2"),
                ForeColor = Color.FromArgb(15, 187, 112),
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter
            };

            productPanel.Controls.Add(lblPrice);
            productPanel.Controls.Add(lblCategoryName);
            productPanel.Controls.Add(lblItemName);
            productPanel.Controls.Add(productImage);

            productPanel.Click += (s, e) => DisplayProductInSales(itemId, itemName, categoryName, price, imageArray, isAvailable);
            productImage.Click += (s, e) => DisplayProductInSales(itemId, itemName, categoryName, price, imageArray, isAvailable);
            lblItemName.Click += (s, e) => DisplayProductInSales(itemId, itemName, categoryName, price, imageArray, isAvailable);
            lblCategoryName.Click += (s, e) => DisplayProductInSales(itemId, itemName, categoryName, price, imageArray, isAvailable);
            lblPrice.Click += (s, e) => DisplayProductInSales(itemId, itemName, categoryName, price, imageArray, isAvailable);

            return productPanel;
        }
        private void DisplayProductInSales(string itemId, string itemName, string categoryName, decimal price, byte[] imageArray, bool isAvailable)
        {
            if (!isAvailable)
            {
                ShowUnavailableItemMessage();
                return;
            }

            if (TryUpdateExistingProduct(itemId, price))
                return;

            RoundedPanel saleProductPanel = CreateProductPanel(itemId, itemName, categoryName, price, imageArray);
            flp_billDetails.Controls.Add(saleProductPanel);
            flp_billDetails.AutoScroll = true;

            UpdateOrderNumber();
            UpdateTotal();
        }

        private void ShowUnavailableItemMessage()
        {
            MessageBox.Show("This item is currently unavailable.", "Unavailable Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool TryUpdateExistingProduct(string itemId, decimal price)
        {
            foreach (RoundedPanel panel in flp_billDetails.Controls.OfType<RoundedPanel>())
            {
                PictureBox existingPictureBox = panel.Controls.OfType<PictureBox>()
                    .FirstOrDefault(pb => pb.Tag.ToString() == itemId);

                if (existingPictureBox != null)
                {
                    Label lblQuantity = panel.Controls.OfType<Label>()
                        .FirstOrDefault(lbl => lbl.Tag != null && lbl.Tag.ToString() == "Quantity");

                    if (lblQuantity != null && int.TryParse(lblQuantity.Text, out int existingQuantity))
                    {
                        int newQuantity = existingQuantity + 1;
                        lblQuantity.Text = newQuantity.ToString();
                        UpdateTotal();
                        return true;
                    }
                }
            }
            return false;
        }

        private RoundedPanel CreateProductPanel(string itemId, string itemName, string categoryName, decimal price, byte[] imageArray)
        {
            RoundedPanel saleProductPanel = new RoundedPanel
            {   
                Width = flp_billDetails.Width - 20, 
                Height = 60,
                BackColor = Color.FloralWhite,
                Margin = new Padding(5), 
                BorderStyle = BorderStyle.None 
            };

            PictureBox productImage = CreateProductImage(itemId, imageArray);
            Label lblItemName = CreateLabel(itemName, FontStyle.Bold, 90, ContentAlignment.MiddleCenter);
            Label lblCategory = CreateLabel(categoryName, FontStyle.Regular, 55, ContentAlignment.MiddleCenter, Color.Gray);
            Label lblQuantity = CreateLabel("1", FontStyle.Bold, 65, ContentAlignment.MiddleCenter, tag: "Quantity");
            Label lblPrice = CreateLabel("₱" + price.ToString("F2"), FontStyle.Regular, 85, ContentAlignment.MiddleCenter);
            Button btnRemove = CreateRemoveButton(saleProductPanel);

            saleProductPanel.Controls.AddRange(new Control[] { btnRemove, lblPrice, lblQuantity, lblCategory, lblItemName, productImage });
            return saleProductPanel;
        }

        private PictureBox CreateProductImage(string itemId, byte[] imageArray)
        {
            PictureBox productImage = new PictureBox
            {
                Width = 45,
                Height = 32,
                BackgroundImageLayout = ImageLayout.Stretch,
                Dock = DockStyle.Left,
                Tag = itemId
            };

            using (MemoryStream ms = new MemoryStream(imageArray))
            {
                productImage.BackgroundImage = Image.FromStream(ms);
            }

            return productImage;
        }

        private Label CreateLabel(string text, FontStyle fontStyle, int width, ContentAlignment textAlign, Color? foreColor = null, string tag = null)
        {
            return new Label
            {
                Text = text,
                ForeColor = foreColor ?? Color.Black,
                Font = new Font("Segoe UI", 8, fontStyle),
                Width = width,
                Dock = DockStyle.Left,
                TextAlign = textAlign,
                Tag = tag
            };
        }

        private Button CreateRemoveButton(RoundedPanel panel)
        {
            Button btnRemove = new Button
            {
                Text = "X",
                ForeColor = Color.Red,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                Width = 30,
                Dock = DockStyle.Right,
                FlatStyle = FlatStyle.Flat
            };

            btnRemove.FlatAppearance.BorderSize = 0;

            btnRemove.Click += (s, e) =>
            {
                flp_billDetails.Controls.Remove(panel);
                flp_billDetails.Refresh();
                UpdateTotal();
                UpdateOrderNumber();
            };

            return btnRemove;
        }

        private void UpdateOrderNumber()
        {
            int totalItems = 0;

            foreach (Control control in flp_billDetails.Controls)
            {
                if (control is RoundedPanel panel)
                {
                    Label lblQuantity = panel.Controls.OfType<Label>()
                        .FirstOrDefault(lbl => lbl.Tag != null && lbl.Tag.ToString() == "Quantity");

                    if (lblQuantity != null && int.TryParse(lblQuantity.Text, out int quantity))
                    {
                        totalItems += quantity;
                    }
                }
            }

            lbl_order.Text = totalItems.ToString(); 
        }

        private void UpdateChange()
        {
            decimal totalAmount = 0;
            decimal cashInput = 0;

            if (decimal.TryParse(lbl_total.Text.Replace("₱", ""), out totalAmount) &&
                decimal.TryParse(txt_cash.Text, out cashInput))
            {
                decimal change = cashInput - totalAmount;
                txt_change.Text = change >= 0 ? $"₱{change:F2}" : "Insufficient Cash";
            }
            else
            {
                txt_change.Text = "Invalid Input";
            }
        }
        private void TxtCash_TextChanged(object sender, EventArgs e)
        {
            UpdateChange();
        }


        private void UpdateTotal()
        {
            decimal totalAmount = 0;

            foreach (Control control in flp_billDetails.Controls)
            {
                if (control is RoundedPanel panel)
                {
                    Label lblQuantity = panel.Controls.OfType<Label>()
                        .FirstOrDefault(lbl => lbl.Tag != null && lbl.Tag.ToString() == "Quantity");
                    Label lblPrice = panel.Controls.OfType<Label>()
                        .FirstOrDefault(lbl => lbl.Text.StartsWith("₱"));

                    if (lblQuantity != null && lblPrice != null &&
                        int.TryParse(lblQuantity.Text, out int quantity) &&
                        decimal.TryParse(lblPrice.Text.Replace("₱", ""), out decimal price))
                    {
                        totalAmount += quantity * price;
                    }
                }
            }

            lbl_total.Text = $"₱{totalAmount:F2}";
        }
        private void LoadCategory(string categoryName = null)
        {
            flp_category.Controls.Clear();
            flp_category.VerticalScroll.Visible = false;
            flp_category.VerticalScroll.Enabled = false;
            flp_category.AutoScroll = true;

            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Panel allCategoryPanel = CreateCategoryPanel("ALL CATEGORY", null);
                    flp_category.Controls.Add(allCategoryPanel);

                    string query = "SELECT category_name FROM categories_tb WHERE is_archived = 0";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string categoryNameFromDb = dr["category_name"].ToString();
                            Panel categoryPanel = CreateCategoryPanel(categoryNameFromDb, categoryNameFromDb);

                            flp_category.Controls.Add(categoryPanel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading categories: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private Panel CreateCategoryPanel(string labelText, string categoryName)
        {
            Panel categoryPanel = new Panel
            {
                BackColor = Color.SaddleBrown,
                BorderStyle = BorderStyle.None,
                Size = new Size(150, 40),
                Margin = new Padding(50, 20, 10, 10), 
                Cursor = Cursors.Hand
            };

            Label categoryLabel = new Label
            {
                Text = labelText.ToUpper(),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            categoryPanel.Controls.Add(categoryLabel);

            categoryPanel.Click += (s, e) => HighlightSelectedCategory(categoryPanel, categoryName);
            categoryLabel.Click += (s, e) => HighlightSelectedCategory(categoryPanel, categoryName);

            return categoryPanel;
        }

        private void HighlightSelectedCategory(Panel selectedPanel, string categoryName)
        {
            foreach (Control control in flp_category.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = Color.SaddleBrown;
                }
            }
            selectedPanel.BackColor = Color.SandyBrown;

            LoadProducts(categoryName);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 25;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            using (Pen pen = new Pen(Color.Gray, 1.5f))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
