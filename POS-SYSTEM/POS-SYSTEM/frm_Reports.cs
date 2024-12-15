using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf.Canvas;
using iText.Layout.Properties;
using MySqlX.XDevAPI.Relational;
using System.Xml.Linq;
using Table = iText.Layout.Element.Table;

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
            LoadDailySales();
            LoadMonthlySales();
            LoadSalesReport();
            LoadInventoryReport();
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
                DATE(o.order_date) = CURDATE()";

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
                MONTH(o.order_date) = MONTH(CURDATE()) AND YEAR(o.order_date) = YEAR(CURDATE())";

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

        private void LoadInventoryReport()
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
    JOIN `ingredients_tb` i ON it.ingredient_id = i.ingredient_id
    ORDER BY it.transaction_date DESC";

            LoadFilteredData(query, null, null, dgv_inventory, new string[]
            {
        "transaction_id",
        "ingredient_id",
        "ingredient_name",
        "transaction_type",
        "quantity",
        "transaction_date",
        "note"
            });
        }

        private void LoadSalesReport()
        {
            string query = @"
    SELECT o.order_id, o.order_date,
           SUM(od.quantity * od.price_at_time) AS total_sale, 
           p.payment_method, p.payment_date
    FROM `orders_tb` o
    JOIN `order_details_tb` od ON o.order_id = od.order_id
    JOIN `payments_tb` p ON o.order_id = p.order_id
    GROUP BY o.order_id, p.payment_method, p.payment_date
    ORDER BY o.order_date DESC";

            LoadFilteredData(query, null, null, dgv_sales, new string[]
            {
        "order_id",
        "order_date",
        "total_sale",
        "payment_method",
        "payment_date"
            });
        }
        private void LoadFilteredData(string query, DateTime? startDate, DateTime? endDate, DataGridView dgv, string[] columnNames)
        {
            try
            {
                dgv.Rows.Clear();
                if (!EnsureConnectionOpen()) return;

                if (startDate.HasValue && endDate.HasValue)
                {
                    query += " WHERE DATE(o.order_date) BETWEEN @startDate AND @endDate";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (startDate.HasValue && endDate.HasValue)
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", endDate.Value.Date);
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
            DateTime startDate = start_dtp.Value.Date;
            DateTime endDate = end_dtp.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be later than the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (reports_control.SelectedTab.Name == "sales_tab")
            {
                LoadSalesReport();
            }
            else if (reports_control.SelectedTab.Name == "inv_tab")
            {
                LoadInventoryReport();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.AddWorksheet("Sales Report");
                    worksheet.Cell(1, 1).Value = "Order ID";
                    worksheet.Cell(1, 2).Value = "Order Date";
                    worksheet.Cell(1, 3).Value = "Total Sale";
                    worksheet.Cell(1, 4).Value = "Payment Method";
                    worksheet.Cell(1, 5).Value = "Payment Date";

                    for (int i = 0; i < dgv_sales.Rows.Count; i++)
                    {
                        worksheet.Cell(i + 2, 1).Value = (ClosedXML.Excel.XLCellValue)dgv_sales.Rows[i].Cells[0].Value;
                        worksheet.Cell(i + 2, 2).Value = (ClosedXML.Excel.XLCellValue)dgv_sales.Rows[i].Cells[1].Value;
                        worksheet.Cell(i + 2, 3).Value = (ClosedXML.Excel.XLCellValue)dgv_sales.Rows[i].Cells[2].Value;
                        worksheet.Cell(i + 2, 4).Value = (ClosedXML.Excel.XLCellValue)dgv_sales.Rows[i].Cells[3].Value;
                        worksheet.Cell(i + 2, 5).Value = (ClosedXML.Excel.XLCellValue)dgv_sales.Rows[i].Cells[4].Value;
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        FileName = "Sales_Report.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Sales report has been successfully exported to Excel.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.AddWorksheet("Inventory Report");

                    string[] headers = {
                "Transaction ID",
                "Ingredient ID",
                "Ingredient Name",
                "Transaction Type",
                "Quantity",
                "Transaction Date",
                "Note"
            };
                    for (int col = 0; col < headers.Length; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = headers[col];
                    }
                    for (int i = 0; i < dgv_inventory.Rows.Count; i++)
                    {
                        for (int j = 0; j < headers.Length; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dgv_inventory.Rows[i].Cells[j].Value?.ToString() ?? "No Data";
                        }
                    }

                    var headerRow = worksheet.Range(1, 1, 1, headers.Length);
                    headerRow.Style.Font.Bold = true;
                    headerRow.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGray;
                    headerRow.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;

                    worksheet.Columns().AdjustToContents();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        FileName = "Inventory_Report.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Inventory report has been successfully exported to Excel.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                    var pdfDoc = new iText.Layout.Document(pdf);

                    float[] columnWidths = { 2f, 4f, 3f, 3f, 3f };
                    var table = new iText.Layout.Element.Table(columnWidths);

                    // Add header row
                    table.AddCell("Order ID");
                    table.AddCell("Order Date");
                    table.AddCell("Total Sale");
                    table.AddCell("Payment Method");
                    table.AddCell("Payment Date");

                    // Add data rows
                    foreach (DataGridViewRow row in dgv_sales.Rows)
                    {
                        try
                        {
                            table.AddCell(row.Cells[0].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells[1].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells[2].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells[3].Value?.ToString() ?? "No Data");
                            table.AddCell(row.Cells[4].Value?.ToString() ?? "No Data");
                        }
                        catch (Exception rowEx)
                        {
                            // Log row-specific errors for debugging
                            MessageBox.Show($"Error processing row: {rowEx.Message}", "Row Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();

                    // Save the PDF to file
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF Files (*.pdf)|*.pdf",
                        FileName = "Sales_Report.pdf"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, ms.ToArray());
                        MessageBox.Show("Sales report has been successfully exported to PDF.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (iText.Kernel.Exceptions.PdfException pdfEx)
            {
                // Log the full exception message and stack trace for further debugging
                MessageBox.Show($"Error generating PDF: {pdfEx.Message}\n{pdfEx.StackTrace}", "PDF Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Log a more generic error for debugging
                MessageBox.Show($"Error exporting sales report to PDF: {ex.Message}\n{ex.StackTrace}", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var pdfDoc = new iText.Layout.Document(pdf);

                    float[] columnWidths = { 3f, 3f, 5f, 3f, 3f, 3f, 4f };
                    var table = new iText.Layout.Element.Table(columnWidths);

                    table.AddCell("Transaction ID");
                    table.AddCell("Ingredient ID");
                    table.AddCell("Ingredient Name");
                    table.AddCell("Transaction Type");
                    table.AddCell("Quantity");
                    table.AddCell("Transaction Date");
                    table.AddCell("Note");

                    foreach (DataGridViewRow row in dgv_inventory.Rows)
                    {
                        table.AddCell(row.Cells["transaction_id"].Value?.ToString() ?? "No Data");
                        table.AddCell(row.Cells["ingredient_id"].Value?.ToString() ?? "No Data");
                        table.AddCell(row.Cells["ingredient_name"].Value?.ToString() ?? "No Data");
                        table.AddCell(row.Cells["transaction_type"].Value?.ToString() ?? "No Data");
                        table.AddCell(row.Cells["quantity"].Value?.ToString() ?? "No Data");
                        table.AddCell(Convert.ToDateTime(row.Cells["transaction_date"].Value).ToString("yyyy-MM-dd HH:mm:ss"));
                        table.AddCell(row.Cells["note"].Value?.ToString() ?? "No notes");
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();

                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF Files (*.pdf)|*.pdf",
                        FileName = "Inventory_Report.pdf"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, ms.ToArray());
                        MessageBox.Show("Inventory report has been successfully exported to PDF.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error exporting inventory report to PDF");
            }
        }

    }
}
