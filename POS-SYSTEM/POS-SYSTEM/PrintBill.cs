using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public class PrintBill
    {
        private readonly string connectionString = "server=localhost;port=3306;username=root;password=;database=posresto_db";
        private MySqlConnection conn;

        public PrintDocument PD = new PrintDocument();

        private int longPaper;
        private decimal grandTotal;
        private string transNo;
        private DateTime transDate;
        private string paymentMethod;

        private class Product
        {
            public string ProdName { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }
        }

        private List<Product> products = new List<Product>();

        public void Main(string latestTransNo)
        {
            transNo = latestTransNo;

            try
            {
                LoadTransactionData(latestTransNo);

                if (products.Count == 0)
                {
                    MessageBox.Show("No products found for this transaction.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                PrintBills();
            }
            catch (Exception ex)
            {
                ShowError("An error occurred: " + ex.Message);
            }
        }

        private void LoadTransactionData(string transNumber)
        {
            string query = @"
                SELECT 
                    o.orderNo, 
                    o.order_date, 
                    od.item_id, 
                    i.item_name, 
                    od.quantity, 
                    od.price_at_time, 
                    od.subtotal, 
                    p.payment_method
                FROM 
                    orders_tb o
                JOIN order_details_tb od ON o.order_id = od.order_id
                JOIN payments_tb p ON o.order_id = p.order_id
                JOIN menu_items_tb i ON od.item_id = i.item_id
                WHERE o.orderNo = @transno";

            using (conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@transno", transNumber);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            products.Clear();
                            while (reader.Read())
                            {
                                products.Add(new Product
                                {
                                    ProdName = reader["item_name"].ToString(),
                                    Quantity = Convert.ToInt32(reader["quantity"]),
                                    TotalPrice = Convert.ToDecimal(reader["subtotal"])
                                });
                            }

                            paymentMethod = reader["payment_method"].ToString();
                            transDate = Convert.ToDateTime(reader["order_date"]);
                            SumPrice();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    ShowError("Database error: " + ex.Message);
                }
            }
        }

        private void PrintBills()
        {
            try
            {
                AdjustPaperLength();

                PD.DefaultPageSettings.PaperSize = new PaperSize("Custom", 250, longPaper);
                PD.PrintPage += PD_PrintPage;

                using (PrintPreviewDialog previewDialog = new PrintPreviewDialog { Document = PD })
                {
                    if (previewDialog.ShowDialog() == DialogResult.OK)
                    {
                        PD.Print();
                    }
                }

                MessageBox.Show("Bill printed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Error initiating print: " + ex.Message);
            }
        }

        private void AdjustPaperLength()
        {
            longPaper = (products.Count * 25) + 300;
        }

        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                DrawHeader(g);
                DrawTransactionDetails(g);
                DrawProductDetails(g);
                DrawFooter(g);
            }
            catch (Exception ex)
            {
                ShowError("Error during print rendering: " + ex.Message);
            }
        }

        private void DrawHeader(Graphics g)
        {
            Font headerFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Font regularFont = new Font("Segoe UI", 8, FontStyle.Regular);

            float centerX = PD.DefaultPageSettings.PaperSize.Width / 2;
            float headerHeight = 10;

            g.DrawString("RESTAURANT NAME", headerFont, Brushes.Black, centerX, headerHeight, new StringFormat { Alignment = StringAlignment.Center });
            headerHeight += 20;
            g.DrawString("123 Main Street, City, State", regularFont, Brushes.Black, centerX, headerHeight, new StringFormat { Alignment = StringAlignment.Center });
            headerHeight += 15;
            g.DrawString("Tel: +1-800-555-1234", regularFont, Brushes.Black, centerX, headerHeight, new StringFormat { Alignment = StringAlignment.Center });
        }

        private void DrawTransactionDetails(Graphics g)
        {
            Font regularFont = new Font("Segoe UI", 8, FontStyle.Regular);
            float height = 80;

            g.DrawString($"Invoice #: {transNo}", regularFont, Brushes.Black, 10, height);
            height += 15;
            g.DrawString($"Date: {transDate:MM/dd/yyyy HH:mm}", regularFont, Brushes.Black, 10, height);
            height += 15;
            g.DrawString($"Payment: {paymentMethod}", regularFont, Brushes.Black, 10, height);
        }

        private void DrawProductDetails(Graphics g)
        {
            Font productFont = new Font("Segoe UI", 8, FontStyle.Regular);
            Font headerFont = new Font("Segoe UI", 8, FontStyle.Bold);
            float height = 120;

            g.DrawString("Product", headerFont, Brushes.Black, 10, height);
            g.DrawString("Qty", headerFont, Brushes.Black, 150, height);
            g.DrawString("Total", headerFont, Brushes.Black, 200, height);

            height += 15;

            foreach (var product in products)
            {
                g.DrawString(product.ProdName, productFont, Brushes.Black, 10, height);
                g.DrawString(product.Quantity.ToString(), productFont, Brushes.Black, 150, height);
                g.DrawString(product.TotalPrice.ToString("C"), productFont, Brushes.Black, 200, height);

                height += 20;
            }
        }

        private void DrawFooter(Graphics g)
        {
            Font footerFont = new Font("Segoe UI", 8, FontStyle.Bold);
            float height = 200 + (products.Count * 20);

            g.DrawString($"Grand Total: {grandTotal:C}", footerFont, Brushes.Black, 10, height);
            height += 20;
            g.DrawString("Thank you for dining with us!", footerFont, Brushes.Black, PD.DefaultPageSettings.PaperSize.Width / 2, height, new StringFormat { Alignment = StringAlignment.Center });
        }

        private void SumPrice()
        {
            grandTotal = 0;
            foreach (var product in products)
            {
                grandTotal += product.TotalPrice;
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
