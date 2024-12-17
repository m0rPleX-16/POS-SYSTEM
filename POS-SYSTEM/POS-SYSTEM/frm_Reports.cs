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
        private MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private Employee _currentEmployee;

        public frm_Reports(Employee currentEmployee)
        {
            _currentEmployee = currentEmployee;
            InitializeComponent();
            timerClock.Interval = 100;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            LoadInventoryReport(null, null);
            LoadSalesReport(null, null);
            LoadDailySales();
            LoadMonthlySales();
        }
        private void LoadInventoryReport(DateTime? startDate, DateTime? endDate, string searchQuery = "")
        {
            string query = @"
    SELECT 
        it.transaction_id, 
        i.ingredient_id, 
        i.ingredient_name, 
        it.transaction_type, 
        it.quantity, 
        it.transaction_date, 
        it.note
    FROM `inventory_transactions_tb` it
    JOIN `ingredients_tb` i ON it.ingredient_id = i.ingredient_id";

            List<string> conditions = new List<string>();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                conditions.Add("(i.ingredient_name LIKE @searchQuery OR it.transaction_id LIKE @searchQuery)");
            }

            if (startDate.HasValue && endDate.HasValue)
            {
                if (conditions.Count > 0)
                    conditions.Add("DATE(it.transaction_date) BETWEEN @startDate AND @endDate");
                else
                    conditions.Add("DATE(it.transaction_date) BETWEEN @startDate AND @endDate");
            }

            if (conditions.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", conditions);
            }

            query += " ORDER BY it.transaction_date DESC";

            LoadFilteredData(query, startDate, endDate, dgv_inventory, new string[]
            {
        "transaction_id",
        "ingredient_id",
        "ingredient_name",
        "transaction_type",
        "quantity",
        "transaction_date",
        "note"
            }, searchQuery);
        }
        private void LoadSalesReport(DateTime? startDate, DateTime? endDate, string searchQuery = "")
        {
            string query = @"
    SELECT 
        o.order_id, 
        o.order_date,
        SUM(od.quantity * od.price_at_time) AS total_sale, 
        p.payment_method, 
        p.payment_date
    FROM 
        `orders_tb` o
    JOIN 
        `order_details_tb` od ON o.order_id = od.order_id
    JOIN 
        `payments_tb` p ON o.order_id = p.order_id
    WHERE 
        o.status != 'Canceled'";

            if (!string.IsNullOrEmpty(searchQuery))
            {
                query += " AND (o.order_id LIKE @searchQuery OR p.payment_method LIKE @searchQuery)";
            }

            if (startDate.HasValue && endDate.HasValue)
            {
                query += " AND DATE(o.order_date) BETWEEN @startDate AND @endDate";
            }

            query += " GROUP BY o.order_id, p.payment_method, p.payment_date ORDER BY o.order_date DESC";

            LoadFilteredData(query, startDate, endDate, dgv_sales, new string[]
            {
        "order_id",
        "order_date",
        "total_sale",
        "payment_method",
        "payment_date"
            }, searchQuery);
        }

        private void LoadFilteredData(string query, DateTime? startDate, DateTime? endDate, DataGridView dgv, string[] columnNames, string searchQuery)
        {
            try
            {
                dgv.Rows.Clear();

                if (!EnsureConnectionOpen()) return;

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (startDate.HasValue && endDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.Value.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@endDate", endDate.Value.Date.ToString("yyyy-MM-dd"));
                }

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    cmd.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                }

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        object[] rowData = new object[columnNames.Length];
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            rowData[i] = dr[columnNames[i]] is DBNull ? "No Data" : dr[columnNames[i]];
                        }
                        dgv.Rows.Add(rowData);
                    }
                }
            }
            catch (MySqlException ex)
            {
                HandleError(ex, "Error loading filtered data");
            }
            catch (Exception ex)
            {
                HandleError(ex, "An unexpected error occurred while loading filtered data");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Filter_Click_1(object sender, EventArgs e)
        {
            string searchQuery = txt_search.Text.Trim();
            LoadReportsBasedOnTab(searchQuery);
        }


        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txt_search.Text.Trim();

            LoadReportsBasedOnTab(string.IsNullOrEmpty(searchQuery) ? "" : searchQuery);
        }


        private void LoadReportsBasedOnTab(string searchQuery)
        {
            DateTime? startDate = start_dtp.Value.Date;
            DateTime? endDate = end_dtp.Value.Date;

            if (reports_control.SelectedTab.Name == "sales_tab")
            {
                LoadSalesReport(startDate, endDate, searchQuery);
            }
            else if (reports_control.SelectedTab.Name == "inv_tab")
            {
                LoadInventoryReport(startDate, endDate, searchQuery);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private bool EnsureConnectionOpen()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                HandleError(ex, "Failed to open database connection");
                return false;
            }
        }
        private void HandleError(Exception ex, string message)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void LoadDailySales()
        {
            try
            {
                conn.Open();
                string query = @"
            SELECT 
                SUM(od.quantity * od.price_at_time) AS 'Daily Total'
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
                SUM(od.quantity * od.price_at_time) AS 'Monthly Total'
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
                HandleError(ex, "Error loading monthly sales");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (reports_control.SelectedTab.Name == "sales_tab")
                {
                    ExportSalesReportToExcel(); 
                }
                else if (reports_control.SelectedTab.Name == "inv_tab")
                {
                    ExportInventoryReportToExcel(); 
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error exporting data");
            }
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (reports_control.SelectedTab.Name == "sales_tab")
                {
                    ExportSalesReportToPDF();
                }
                else if (reports_control.SelectedTab.Name == "inv_tab")
                {
                    ExportInventoryReportToPDF();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error generating PDF");
            }
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
                HandleError(ex, "Error exporting sales report to Excel");
            }
        }

        private void ExportInventoryReportToExcel()
        {
            try
            {
                var wb = new XLWorkbook();
                var ws = wb.AddWorksheet("Inventory Report");

                ws.Cell(1, 1).Value = "Transaction ID";
                ws.Cell(1, 2).Value = "Ingredient ID";
                ws.Cell(1, 3).Value = "Ingredient Name";
                ws.Cell(1, 4).Value = "Transaction Type";
                ws.Cell(1, 5).Value = "Quantity";
                ws.Cell(1, 6).Value = "Transaction Date";
                ws.Cell(1, 7).Value = "Remarks";

                int row = 2;
                foreach (DataGridViewRow dgvRow in dgv_inventory.Rows)
                {
                    if (!dgvRow.IsNewRow)
                    {
                        ws.Cell(row, 1).Value = dgvRow.Cells["transaction_id"].Value?.ToString() ?? "No Data";
                        ws.Cell(row, 2).Value = dgvRow.Cells["ingredient_id"].Value?.ToString() ?? "No Data";
                        ws.Cell(row, 3).Value = dgvRow.Cells["ingredient_name"].Value?.ToString() ?? "No Data";
                        ws.Cell(row, 4).Value = dgvRow.Cells["transaction_type"].Value?.ToString() ?? "No Data";
                        ws.Cell(row, 5).Value = decimal.TryParse(dgvRow.Cells["quantity"].Value?.ToString(), out decimal quantity) ? quantity : 0;
                        ws.Cell(row, 6).Value = dgvRow.Cells["transaction_date"].Value?.ToString() ?? "No Data";
                        ws.Cell(row, 7).Value = dgvRow.Cells["notes"].Value?.ToString() ?? "No Data";
                        row++;
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = "Inventory_Report.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Inventory Report has been exported to Excel.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error exporting inventory report to Excel");
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
            catch (PdfException ex)
            {
                Console.WriteLine($"PdfException Details: {ex.Message}");
                HandleError(ex, "PDF Error: Invalid PDF generation");
            }

            catch (Exception ex)
            {
                HandleError(ex, "Error exporting sales report to PDF");
            }
        }
        private void ExportInventoryReportToPDF()
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PdfWriter writer = new PdfWriter(ms);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    document.Add(new Paragraph("Inventory Report").SetFontSize(18));

                    float[] columnWidths = { 1, 2, 2, 2, 2, 2, 3 };
                    Table table = new Table(columnWidths)
                        .AddHeaderCell("Transaction ID")
                        .AddHeaderCell("Ingredient ID")
                        .AddHeaderCell("Ingredient Name")
                        .AddHeaderCell("Transaction Type")
                        .AddHeaderCell("Quantity")
                        .AddHeaderCell("Transaction Date")
                        .AddHeaderCell("Note");

                    foreach (DataGridViewRow row in dgv_inventory.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            table.AddCell(row.Cells["transaction_id"].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells["ingredient_id"].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells["ingredient_name"].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells["transaction_type"].Value?.ToString() ?? "No Data");
                            table.AddCell(decimal.TryParse(row.Cells["quantity"].Value?.ToString(), out decimal quantity) ? quantity.ToString() : "0");
                            table.AddCell(row.Cells["transaction_date"].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells["notes"].Value?.ToString() ?? "No Data");
                        }
                    }

                    document.Add(table);
                    document.Close();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF Files|*.pdf",
                        FileName = "Inventory_Report.pdf"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, ms.ToArray());
                        MessageBox.Show("Inventory Report has been exported to PDF.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (PdfException ex)
            {
                Console.WriteLine($"PdfException Details: {ex.Message}");
                HandleError(ex, "PDF Error: Invalid PDF generation");
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error exporting inventory report to PDF");
            }
        }
    }
}
