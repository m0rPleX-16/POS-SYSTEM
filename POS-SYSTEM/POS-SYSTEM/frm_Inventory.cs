using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using POS_SYSTEM.inventory;

namespace POS_SYSTEM
{
    public partial class frm_Inventory : Form
    {
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;
        private MySqlConnection conn;
        private const int PageSize = 25;
        private int currentPageIndex = 1;
        private int totalPages = 0;
        private int totalRows = 0;

        public frm_Inventory(Employee _currentEmployee)
        {
            InitializeComponent();
            InitializeDatabaseConnection();

            timerClock.Start();
            timerClock.Interval = 100;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();

            LoadInventoryData();
        }

        private void InitializeDatabaseConnection()
        {
            string connString = "server=localhost;userid=root;password=;database=posresto_db";
            conn = new MySqlConnection(connString);
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            int day = now.Day;
            string suffix;
            if (day % 10 == 1 && day != 11) suffix = "st";
            else if (day % 10 == 2 && day != 12) suffix = "nd";
            else if (day % 10 == 3 && day != 13) suffix = "rd";
            else suffix = "th";
            lbl_date.Text = now.ToString($"dddd, d'{suffix}' 'of' MMMM yyyy");
            lbl_time.Text = now.ToString("hh:mm:ss tt");
        }

        private void LoadInventoryData(string searchTerm = "")
        {
            dgv_inventory.Rows.Clear();

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string countQuery = @"
                    SELECT COUNT(*) 
                    FROM ingredients_tb i
                    LEFT JOIN (
                        SELECT ingredient_id, transaction_type, quantity, transaction_date, note
                        FROM inventory_transactions_tb
                        WHERE transaction_date = (
                            SELECT MAX(transaction_date) 
                            FROM inventory_transactions_tb 
                            WHERE ingredient_id = inventory_transactions_tb.ingredient_id
                        )
                    ) it ON i.ingredient_id = it.ingredient_id
                    WHERE i.is_active = 'Unarchived'";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    countQuery += " AND (i.ingredient_name LIKE @search OR i.unit LIKE @search)";
                }

                using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                {
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        countCmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                    }

                    totalRows = Convert.ToInt32(countCmd.ExecuteScalar());
                }

                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);

                lblCurrentPage.Text = currentPageIndex.ToString();
                lblTotalPage.Text = totalPages.ToString();

                string query = @"
                    SELECT 
                        i.ingredient_id,
                        i.ingredient_name,
                        i.unit,
                        i.stock_quantity,
                        i.minimum_quantity,
                        i.expiration_date,
                        it.transaction_type AS last_transaction_type,
                        it.quantity AS last_transaction_quantity,
                        it.transaction_date AS last_transaction_date,
                        it.note AS last_transaction_note
                    FROM ingredients_tb i
                    LEFT JOIN (
                        SELECT ingredient_id, transaction_type, quantity, transaction_date, note
                        FROM inventory_transactions_tb
                        WHERE transaction_date = (
                            SELECT MAX(transaction_date) 
                            FROM inventory_transactions_tb 
                            WHERE ingredient_id = inventory_transactions_tb.ingredient_id
                        )
                    ) it ON i.ingredient_id = it.ingredient_id
                    WHERE i.is_active = 'Unarchived'";

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " AND (i.ingredient_name LIKE @search OR i.unit LIKE @search)";
                }

                query += " ORDER BY i.ingredient_name LIMIT @Limit OFFSET @Offset";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Limit", PageSize);
                    cmd.Parameters.AddWithValue("@Offset", (currentPageIndex - 1) * PageSize);
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                    }

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string transactionType = dr["last_transaction_type"]?.ToString();
                            if (transactionType != "Restock" && transactionType != "Usage")
                            {
                                transactionType = "None";
                            }

                            dgv_inventory.Rows.Add(
                                dr["ingredient_id"],
                                dr["ingredient_name"],
                                dr["unit"],
                                dr["stock_quantity"],
                                dr["minimum_quantity"],
                                dr["expiration_date"] is DBNull ? "N/A" : Convert.ToDateTime(dr["expiration_date"]).ToString("yyyy-MM-dd"),
                                transactionType,
                                dr["last_transaction_quantity"] is DBNull ? 0 : Convert.ToInt32(dr["last_transaction_quantity"]),
                                dr["last_transaction_date"] is DBNull ? "N/A" : Convert.ToDateTime(dr["last_transaction_date"]).ToString("yyyy-MM-dd HH:mm:ss"),
                                dr["last_transaction_note"]?.ToString() ?? "No Notes"
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading inventory data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnl_inventBG.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            pnl_inventBG.Controls.Add(userControl);
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_items(_currentEmployee));
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_category(_currentEmployee));
        }

        private void btn_stockin_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_ingridients(_currentEmployee));
        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_tables(_currentEmployee));
        }

        private void recipe_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_recipe(_currentEmployee));
        }

        private void btn_transactions_Click(object sender, EventArgs e)
        {
            LoadUserControl(new inventory_transactions(_currentEmployee));
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadInventoryData(txt_search.Text);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            LoadInventoryData(txt_search.Text);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                LoadInventoryData(txt_search.Text);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageIndex < totalPages)
            {
                currentPageIndex++;
                LoadInventoryData(txt_search.Text);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPageIndex = totalPages;
            LoadInventoryData(txt_search.Text);
        }
    }
}
