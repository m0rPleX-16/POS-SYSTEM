﻿using MySql.Data.MySqlClient;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace POS_SYSTEM
{
    public partial class frm_DashboardContents : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;
        public frm_DashboardContents(Employee _currentEmployee)
        {
            InitializeComponent();
            timerClock.Start();
            timerClock.Interval = 100;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            LoadOrderHistory();
            LoadDailySales();
            LoadMonthlySales();
            LoadAnnualSales();
            LoadStockLevels();
            CalculateSalesAndProfitForEachDay();
            DGV_load();
            DGV_loadBestCategory();
        }
        private void HandleError(Exception ex, string message)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LoadDailySales()
        {
            try
            {
                conn.Open();
                string query = @"
        SELECT 
            SUM((od.quantity * od.price_at_time) - od.discount + ((od.quantity * od.price_at_time - od.discount) * 0.12)) AS 'Daily Total'
        FROM 
            `orders_tb` o
        JOIN 
            `order_details_tb` od ON o.order_id = od.order_id
        WHERE 
            DATE(o.order_date) = @date
            AND o.status != 'Canceled'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                object result = cmd.ExecuteScalar();
                lbl_daily.Text = $"₱{(result != DBNull.Value ? Convert.ToDecimal(result) : 0):N2}";
            }
            catch (MySqlException ex)
            {
                HandleError(ex, "Error loading daily sales");
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadMonthlySales()
        {
            try
            {
                conn.Open();
                string query = @"
        SELECT 
            SUM((od.quantity * od.price_at_time) - od.discount + ((od.quantity * od.price_at_time - od.discount) * 0.12)) AS 'Monthly Total'
        FROM 
            `orders_tb` o
        JOIN 
            `order_details_tb` od ON o.order_id = od.order_id
        WHERE 
            MONTH(o.order_date) = @month 
            AND YEAR(o.order_date) = @year
            AND o.status != 'Canceled'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@month", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@year", DateTime.Now.Year);

                object result = cmd.ExecuteScalar();
                lbl_monthly.Text = $"₱{(result != DBNull.Value ? Convert.ToDecimal(result) : 0):N2}";
            }
            catch (MySqlException ex)
            {
                HandleError(ex, "Error loading monthly sales");
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadAnnualSales()
        {
            try
            {
                conn.Open();
                string query = @"
        SELECT 
            SUM((od.quantity * od.price_at_time) - od.discount + ((od.quantity * od.price_at_time - od.discount) * 0.12)) AS 'Annual Total'
        FROM 
            `orders_tb` o
        JOIN 
            `order_details_tb` od ON o.order_id = od.order_id
        WHERE 
            YEAR(o.order_date) = @year
            AND o.status != 'Canceled'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@year", DateTime.Now.Year);

                object result = cmd.ExecuteScalar();
                lbl_annual.Text = $"₱{(result != DBNull.Value ? Convert.ToDecimal(result) : 0):N2}";
            }
            catch (MySqlException ex)
            {
                HandleError(ex, "Error loading annual sales");
            }
            finally
            {
                conn.Close();
            }
        }

        private void DGV_loadBestCategory()
        {
            dgv_bestCat.Rows.Clear();
            try
            {
                conn.Open();

                string query = @"
        SELECT 
            c.category_name AS cat_name, 
            SUM(od.quantity) AS qty_sold, 
            SUM(od.price_at_time * od.quantity) AS total_sales
        FROM order_details_tb od
        JOIN orders_tb o ON od.order_id = o.order_id
        JOIN menu_items_tb mi ON od.item_id = mi.item_id
        JOIN categories_tb c ON mi.category_id = c.category_id
        WHERE MONTH(o.order_date) = MONTH(CURRENT_DATE) 
        AND YEAR(o.order_date) = YEAR(CURRENT_DATE)
        AND o.status != 'Canceled'
        GROUP BY c.category_id, c.category_name
        ORDER BY qty_sold DESC
        LIMIT 5";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv_bestCat.Rows.Add(
                        dr["cat_name"],
                        dr["qty_sold"],
                        dr["total_sales"]
                    );
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
        private void DGV_load()
        {
            dgv_bestSellers.Rows.Clear();
            try
            {
                conn.Open();

                string query = @"
            SELECT 
                mi.image_base64, 
                mi.item_name, 
                c.category_name, 
                SUM(od.quantity) AS quantity_sold, 
                od.price_at_time, 
                SUM(od.discount) AS total_discount, 
                SUM(od.tax) AS total_tax
            FROM order_details_tb od
            JOIN orders_tb o ON od.order_id = o.order_id
            JOIN menu_items_tb mi ON od.item_id = mi.item_id
            JOIN categories_tb c ON mi.category_id = c.category_id
            WHERE MONTH(o.order_date) = MONTH(CURRENT_DATE) 
            AND YEAR(o.order_date) = YEAR(CURRENT_DATE)
            AND o.status != 'Canceled' -- Exclude canceled orders
            GROUP BY mi.item_id, mi.item_name, c.category_name, od.price_at_time
            ORDER BY quantity_sold DESC
            LIMIT 5";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    decimal totalPrice = Convert.ToDecimal(dr["price_at_time"]) * Convert.ToInt32(dr["quantity_sold"]);
                    decimal discount = Convert.ToDecimal(dr["total_discount"]);
                    decimal tax = Convert.ToDecimal(dr["total_tax"]);

                    decimal finalPrice = totalPrice - discount + tax;

                    Image itemImage = null;
                    if (dr["image_base64"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])dr["image_base64"];
                        if (imageBytes.Length > 0)
                        {
                            try
                            {
                                using (var ms = new MemoryStream(imageBytes))
                                {
                                    Image originalImage = Image.FromStream(ms);
                                    itemImage = new Bitmap(originalImage, 80, 80);
                                }
                            }
                            catch (Exception imgEx)
                            {
                                MessageBox.Show($"Error converting image: {imgEx.Message}");
                            }
                        }
                    }

                    dgv_bestSellers.Rows.Add(
                        itemImage,
                        dr["item_name"],
                        dr["category_name"],
                        dr["quantity_sold"],
                        finalPrice
                    );
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

        private void LoadStockLevels()
        {
            try
            {
                conn.Open();

                string query = @"
            SELECT 
                SUM(stock_quantity) AS total_stock
            FROM 
                ingredients_tb";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                decimal totalStock = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                lbl_stocks.Text = $"{(totalStock < 0 ? 0 : totalStock)} units";
            }
            catch (MySqlException ex)
            {
                HandleError(ex, "Error loading total stock levels for ingredients");
            }
            finally
            {
                conn.Close();
            }
        }

        private void CalculateSalesAndProfitForEachDay()
        {
            try
            {
                conn.Open();

                string query = @"
            SELECT 
                DATE(o.order_date) AS order_date,
                SUM((od.quantity * mi.price) - od.discount + od.tax) AS daily_sales,
                SUM((od.quantity * mi.price) - od.discount + od.tax) AS daily_profit
            FROM orders_tb o
            JOIN order_details_tb od ON o.order_id = od.order_id
            JOIN menu_items_tb mi ON od.item_id = mi.item_id
            WHERE o.status IN ('Dine In', 'Takeout')
            GROUP BY DATE(o.order_date)
            ORDER BY order_date";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                Dictionary<string, decimal> dailySales = new Dictionary<string, decimal>();
                Dictionary<string, decimal> dailyProfit = new Dictionary<string, decimal>();

                if (!dr.HasRows)
                {
                    MessageBox.Show("No sales data found for visualization.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                while (dr.Read())
                {
                    string orderDate = dr["order_date"].ToString();
                    decimal dailySalesValue = dr["daily_sales"] != DBNull.Value ? Convert.ToDecimal(dr["daily_sales"]) : 0;
                    decimal dailyProfitValue = dr["daily_profit"] != DBNull.Value ? Convert.ToDecimal(dr["daily_profit"]) : 0;

                    dailySales[orderDate] = dailySalesValue;
                    dailyProfit[orderDate] = dailyProfitValue;
                }

                sales_chart.Series.Clear();

                var salesSeries = new Series("Sales")
                {
                    ChartType = SeriesChartType.Area,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    IsValueShownAsLabel = true,
                    Color = System.Drawing.Color.DarkOrange,
                    BorderColor = System.Drawing.Color.FromArgb(178, 88, 0),
                    BorderWidth = 2
                };

                var profitSeries = new Series("Profit")
                {
                    ChartType = SeriesChartType.Area,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    IsValueShownAsLabel = true,
                    Color = System.Drawing.Color.FromArgb(255, 140, 0),
                    BorderColor = System.Drawing.Color.FromArgb(139, 69, 0),
                    BorderWidth = 2
                };

                foreach (var entry in dailySales)
                {
                    salesSeries.Points.AddXY(entry.Key, entry.Value);
                    Console.WriteLine($"Adding Sales Data: {entry.Key} - {entry.Value}");
                }

                foreach (var entry in dailyProfit)
                {
                    profitSeries.Points.AddXY(entry.Key, entry.Value);
                    Console.WriteLine($"Adding Profit Data: {entry.Key} - {entry.Value}");
                }

                sales_chart.Series.Add(salesSeries);
                sales_chart.Series.Add(profitSeries);

                sales_chart.Titles.Clear();
                sales_chart.Titles.Add("Daily Sales and Profit");
                sales_chart.ChartAreas[0].AxisX.Title = "Date";
                sales_chart.ChartAreas[0].AxisY.Title = "Amount";
                sales_chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                sales_chart.ChartAreas[0].BackColor = System.Drawing.Color.WhiteSmoke;

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

        private DataTable orderHistoryTable = new DataTable();

        private void LoadOrderHistory()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string query = @"
        SELECT 
            o.orderNo AS 'Order No',
            IFNULL(t.table_number, 'Takeout') AS 'Table Number',
            e.username AS 'Employee',
            o.total_price AS 'Total Price',
            o.status AS 'Status',
            DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i:%s') AS 'Order Date'
        FROM 
            orders_tb o
        LEFT JOIN  
            tables_tb t ON o.table_id = t.table_id
        INNER JOIN 
            employee_tb e ON o.employee_id = e.employee_id
        ORDER BY 
            o.order_date DESC;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                orderHistoryTable.Clear();
                adapter.Fill(orderHistoryTable);

                UpdateOrderHistoryGrid(10);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading order history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void UpdateOrderHistoryGrid(int rowCount)
        {
            dgv_orderHist.Rows.Clear();

            for (int i = 0; i < Math.Min(rowCount, orderHistoryTable.Rows.Count); i++)
            {
                DataRow row = orderHistoryTable.Rows[i];
                dgv_orderHist.Rows.Add(
                    row["Order No"],
                    row["Table Number"],
                    row["Employee"],
                    row["Total Price"],
                    row["Status"],
                    row["Order Date"]
                );
            }

            dgv_orderHist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_orderHist.ReadOnly = true;
            dgv_orderHist.AllowUserToAddRows = false;
            dgv_orderHist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmb_rowView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmb_rowView.SelectedItem.ToString(), out int selectedRowCount))
            {
                UpdateOrderHistoryGrid(selectedRowCount);
            }
            else
            {
                MessageBox.Show("Invalid row count selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
