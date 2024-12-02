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
            LoadInventoryReport(DateTime.MinValue, DateTime.MaxValue);
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

        private void LoadInventoryReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                dgv_inventory.Rows.Clear();
                if (!EnsureConnectionOpen()) return;

                string query = @"
            SELECT i.ingredient_id, i.ingredient_name, i.unit, i.stock_quantity, 
                   i.minimum_quantity, i.is_active
            FROM `ingredients_tb` i
            JOIN `inventory_transactions_tb` it ON i.ingredient_id = it.ingredient_id
            WHERE it.transaction_date BETWEEN @startDate AND @endDate
                  AND i.is_active = 'Yes'
            ORDER BY it.transaction_date DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgv_inventory.Rows.Add(
                        dr["ingredient_id"],
                        dr["ingredient_name"],
                        dr["unit"],
                        dr["stock_quantity"],
                        dr["minimum_quantity"],
                        dr["is_active"]
                    );
                }

                dr.Dispose();
            }
            catch (MySqlException ex)
            {
                HandleError(ex, "Error loading inventory report");
            }
            catch (Exception ex)
            {
                HandleError(ex, "An unexpected error occurred while loading inventory report");
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadFilteredData(string query, DateTime startDate, DateTime endDate, DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();
                if (!EnsureConnectionOpen()) return;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgv.Rows.Add(
                        dr["order_id"], 
                        dr["order_date"],
                        dr["total_sale"], 
                        dr["payment_method"],
                        dr["payment_date"]
                    );
                }

                dr.Dispose();
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

        private void HandleError(Exception ex, string message)
        {
            MessageBox.Show(message + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_Filter_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = start_dtp.Value.Date;
            DateTime endDate = end_dtp.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be later than the end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "";
            if (reports_control.SelectedTab.Name == "sales_tab")
            {
                query = @"
            SELECT o.order_id, o.order_date,
                   SUM(od.quantity * od.price_at_time) AS total_sale, 
                   p.payment_method, p.payment_date
            FROM `orders_tb` o
            JOIN `order_details_tb` od ON o.order_id = od.order_id
            JOIN `payments_tb` p ON o.order_id = p.order_id
            WHERE DATE(o.order_date) BETWEEN @startDate AND @endDate
            GROUP BY o.order_id, p.payment_method, p.payment_date
            ORDER BY o.order_date DESC";
                LoadFilteredData(query, startDate, endDate, dgv_sales);
            }
            else if (reports_control.SelectedTab.Name == "inv_tab")
            {
                LoadInventoryReport(startDate, endDate);
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
                    worksheet.Cell(1, 1).Value = "Ingredient ID";
                    worksheet.Cell(1, 2).Value = "Ingredient Name";
                    worksheet.Cell(1, 3).Value = "Unit";
                    worksheet.Cell(1, 4).Value = "Stock Quantity";
                    worksheet.Cell(1, 5).Value = "Minimum Quantity";
                    worksheet.Cell(1, 6).Value = "Is Active";

                    for (int i = 0; i < dgv_inventory.Rows.Count; i++)
                    {
                        worksheet.Cell(i + 2, 1).Value = (ClosedXML.Excel.XLCellValue)dgv_inventory.Rows[i].Cells[0].Value;
                        worksheet.Cell(i + 2, 2).Value = (ClosedXML.Excel.XLCellValue)dgv_inventory.Rows[i].Cells[1].Value;
                        worksheet.Cell(i + 2, 3).Value = (ClosedXML.Excel.XLCellValue)dgv_inventory.Rows[i].Cells[2].Value;
                        worksheet.Cell(i + 2, 4).Value = (ClosedXML.Excel.XLCellValue)dgv_inventory.Rows[i].Cells[3].Value;
                        worksheet.Cell(i + 2, 5).Value = (ClosedXML.Excel.XLCellValue)dgv_inventory.Rows[i].Cells[4].Value;
                        worksheet.Cell(i + 2, 6).Value = (ClosedXML.Excel.XLCellValue)dgv_inventory.Rows[i].Cells[5].Value;
                    }

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

                    table.AddCell("Order ID");
                    table.AddCell("Order Date");
                    table.AddCell("Total Sale");
                    table.AddCell("Payment Method");
                    table.AddCell("Payment Date");

                    foreach (DataGridViewRow row in dgv_sales.Rows)
                    {
                        table.AddCell(row.Cells[0].Value?.ToString() ?? string.Empty);
                        table.AddCell(row.Cells[1].Value?.ToString() ?? string.Empty);
                        table.AddCell(row.Cells[2].Value?.ToString() ?? string.Empty);
                        table.AddCell(row.Cells[3].Value?.ToString() ?? string.Empty);
                        table.AddCell(row.Cells[4].Value?.ToString() ?? string.Empty);
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();

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
                    var pdfDoc = new iText.Layout.Document(pdf);

                    float[] columnWidths = { 2f, 4f, 3f, 3f, 3f };
                    var table = new iText.Layout.Element.Table(columnWidths);

                    table.AddCell("Ingredient ID");
                    table.AddCell("Ingredient Name");
                    table.AddCell("Unit");
                    table.AddCell("Stock Quantity");
                    table.AddCell("Minimum Quantity");
                    table.AddCell("Is Active");

                    foreach (DataGridViewRow row in dgv_inventory.Rows)
                    {
                        table.AddCell(row.Cells[0].Value.ToString());
                        table.AddCell(row.Cells[1].Value.ToString());
                        table.AddCell(row.Cells[2].Value.ToString());
                        table.AddCell(row.Cells[3].Value.ToString());
                        table.AddCell(row.Cells[4].Value.ToString());
                        table.AddCell(row.Cells[5].Value.ToString());
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
