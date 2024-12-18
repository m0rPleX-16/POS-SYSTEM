using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class frm_Reports : Form
    {
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private Employee _currentEmployee;

        public frm_Reports(Employee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadSalesReport();
            ConfigureTimer();
            LoadDailySales();
            LoadMonthlySales();
        }

        private void ConfigureTimer()
        {
            timerClock.Interval = 100;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbl_date.Text = now.ToString($"dddd, d'{GetDaySuffix(now.Day)}' 'of' MMMM yyyy");
            lbl_time.Text = now.ToString("hh:mm:ss tt");
        }

        private string GetDaySuffix(int day)
        {
            return (day % 10 == 1 && day != 11) ? "st" :
                   (day % 10 == 2 && day != 12) ? "nd" :
                   (day % 10 == 3 && day != 13) ? "rd" : "th";
        }

        private void LoadDailySales()
        {
            try
            {
                conn.Open();
                string query = @"
            SELECT 
                SUM((od.quantity * od.price_at_time) - od.discount + od.tax) AS 'Daily Total'
            FROM 
                `orders_tb` o
            JOIN 
                `order_details_tb` od ON o.order_id = od.order_id
            WHERE 
                DATE(o.order_date) = CURDATE()
                AND o.status != 'Canceled'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                lbl_daily_sales.Text = $"₱{(result != DBNull.Value ? Convert.ToDecimal(result) : 0):N2}";
            }
            catch (MySqlException ex)
            {
                ShowError("Error loading daily sales", ex);
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
                SUM((od.quantity * od.price_at_time) - od.discount + od.tax) AS 'Monthly Total'
            FROM 
                `orders_tb` o
            JOIN 
                `order_details_tb` od ON o.order_id = od.order_id
            WHERE 
                MONTH(o.order_date) = MONTH(CURDATE()) 
                AND YEAR(o.order_date) = YEAR(CURDATE())
                AND o.status != 'Canceled'";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                lbl_monthly_sales.Text = $"₱{(result != DBNull.Value ? Convert.ToDecimal(result) : 0):N2}";
            }
            catch (MySqlException ex)
            {
                ShowError("Error loading monthly sales", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadSalesReport(string searchQuery = "", DateTime? filterDate = null)
        {
            dgv_sales.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT o.order_id, o.order_date, SUM(od.quantity * od.price_at_time) AS total_sale, 
                       p.payment_method, p.payment_date
                FROM `orders_tb` o
                JOIN `order_details_tb` od ON o.order_id = od.order_id
                JOIN `payments_tb` p ON o.order_id = p.order_id
                WHERE o.status != 'Canceled' ";

                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query += " AND (o.order_id LIKE @searchQuery OR p.payment_method LIKE @searchQuery)";
                    }

                    if (filterDate.HasValue)
                    {
                        query += " AND DATE(o.order_date) = @filterDate";
                    }

                    query += " GROUP BY o.order_id, o.order_date, p.payment_method, p.payment_date";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                    if (filterDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@filterDate", filterDate.Value.Date);
                    }

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        dgv_sales.Rows.Add(
                            dr["order_id"],
                            dr["order_date"],
                            dr["total_sale"],
                            dr["payment_method"],
                            dr["payment_date"]
                        );
                    }

                    dr.Dispose();
                }
            }
            catch (Exception ex)
            {
                ShowError("Error", ex);
            }
        }


        private void ShowError(string title, Exception ex)
        {
            MessageBox.Show($"{title}:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_sales.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT o.order_id, o.order_date, SUM(od.quantity * od.price_at_time) AS total_sale, 
                       p.payment_method, p.payment_date
                FROM `orders_tb` o
                JOIN `order_details_tb` od ON o.order_id = od.order_id
                JOIN `payments_tb` p ON o.order_id = p.order_id
                WHERE o.status != 'Canceled'
                AND (o.order_id LIKE @searchText OR p.payment_method LIKE @searchText)
                GROUP BY o.order_id, o.order_date, p.payment_method, p.payment_date
                ORDER BY o.order_date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@searchText", "%" + txt_search.Text + "%");

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgv_sales.Rows.Add(
                                dr["order_id"],
                                dr["order_date"],
                                dr["total_sale"],
                                dr["payment_method"],
                                dr["payment_date"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Error", ex);
            }
        }


        private void btn_Export_Click(object sender, EventArgs e)
        {
            ExportSalesReportToExcel();
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            ExportSalesReportToPDF();
        }

        private void ExportSalesReportToExcel()
        {
            try
            {
                var wb = new XLWorkbook();
                var ws = wb.AddWorksheet("Sales Report");

                ws.Cell(1, 1).Value = "Order ID";
                ws.Cell(1, 2).Value = "Order Date";
                ws.Cell(1, 3).Value = "Total Sale";
                ws.Cell(1, 4).Value = "Payment Method";
                ws.Cell(1, 5).Value = "Payment Date";

                int row = 2;
                foreach (DataGridViewRow dgvRow in dgv_sales.Rows)
                {
                    if (!dgvRow.IsNewRow)
                    {
                        ws.Cell(row, 1).Value = dgvRow.Cells["order_id"].Value.ToString();
                        ws.Cell(row, 2).Value = dgvRow.Cells["order_date"].Value.ToString();
                        ws.Cell(row, 3).Value = decimal.TryParse(dgvRow.Cells["total_sale"].Value.ToString(), out decimal totalSale) ? totalSale : 0;
                        ws.Cell(row, 4).Value = dgvRow.Cells["payment_method"].Value.ToString();
                        ws.Cell(row, 5).Value = dgvRow.Cells["payment_date"].Value.ToString();
                        row++;
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = "Sales_Report.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Sales Report has been exported to Excel.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowError("Error exporting sales report to Excel", ex);
            }
        }

        private void ExportSalesReportToPDF()
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PdfWriter writer = new PdfWriter(ms);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    document.Add(new Paragraph("Sales Report").SetFontSize(18));

                    float[] columnWidths = { 1, 2, 2, 2, 2 };
                    Table table = new Table(columnWidths)
                        .AddHeaderCell("Order ID")
                        .AddHeaderCell("Order Date")
                        .AddHeaderCell("Total Sale")
                        .AddHeaderCell("Payment Method")
                        .AddHeaderCell("Payment Date");

                    foreach (DataGridViewRow row in dgv_sales.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            table.AddCell(row.Cells["order_id"].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells["order_date"].Value?.ToString() ?? "No Data");
                            table.AddCell(decimal.TryParse(row.Cells["total_sale"].Value?.ToString(), out decimal totalSale) ? totalSale.ToString("0.00") : "0.00");
                            table.AddCell(row.Cells["payment_method"].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells["payment_date"].Value?.ToString() ?? "No Data");
                        }
                    }

                    document.Add(table);
                    document.Close();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF Files|*.pdf",
                        FileName = "Sales_Report.pdf"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, ms.ToArray());
                        MessageBox.Show("Sales Report has been exported to PDF.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Error exporting sales report to PDF", ex);
            }
        }

        private void filter_dtp_ValueChanged(object sender, EventArgs e)
        {
            dgv_sales.Rows.Clear();
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT o.order_id, o.order_date, 
                       SUM(od.quantity * od.price_at_time) AS total_sale, 
                       p.payment_method, p.payment_date
                FROM `orders_tb` o
                JOIN `order_details_tb` od ON o.order_id = od.order_id
                JOIN `payments_tb` p ON o.order_id = p.order_id
                WHERE o.status != 'Canceled'
                AND DATE(o.order_date) = @orderDate
                GROUP BY o.order_id, o.order_date, p.payment_method, p.payment_date
                ORDER BY o.order_date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderDate", filter_dtp.Value.Date);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dgv_sales.Rows.Add(
                                dr["order_id"],
                                dr["order_date"],
                                dr["total_sale"],
                                dr["payment_method"],
                                dr["payment_date"]
                            );
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
