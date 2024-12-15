using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
        private decimal t_price;
        private int t_qty;
        private decimal vatAmount;
        private const decimal vatRate = 0.12m;
        private decimal grandTotal;
        private decimal netTotal;

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
                PrintBills();
            }
            catch (Exception ex)
            {
                ShowError("An error occurred: " + ex.Message);
            }
        }

        private void LoadTransactionData(string transNumber)
        {
            string query = "SELECT transno, transdate, ProdCode, ProdName, qty, price, vat, totalprice, paymentMethod FROM tbl_pos WHERE transno = @transno";
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
                                    ProdName = reader["ProdName"].ToString(),
                                    Quantity = Convert.ToInt32(reader["qty"]),
                                    TotalPrice = Convert.ToDecimal(reader["totalprice"])
                                });
                            }

                            paymentMethod = reader["paymentMethod"].ToString();
                            transDate = Convert.ToDateTime(reader["transdate"]);

                            SumPrice();
                        }
                        else
                        {
                            MessageBox.Show("No transaction data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    ShowError("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    ShowError("Unexpected error: " + ex.Message);
                }
            }
        }

        private void PrintBills()
        {
            try
            {
                ChangeLongPaper();

                PageSettings pageSettings = new PageSettings
                {
                    PaperSize = new PaperSize("Custom", 250, longPaper)
                };
                PD.DefaultPageSettings = pageSettings;

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

        private void ChangeLongPaper()
        {
            longPaper = (products.Count * 25) + 500;
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
            Font headerFont = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            Font regularFont = new Font("Segoe UI Semibold", 8, FontStyle.Regular);

            int centerX = PD.DefaultPageSettings.PaperSize.Width / 2;
            int headerHeight = 10;

            g.DrawString("RK WORKS", headerFont, Brushes.Black, new PointF(centerX, headerHeight), new StringFormat { Alignment = StringAlignment.Center });
            headerHeight += 20;
            g.DrawString("RICHKIDS13 RACING PARTS AND TUNING", regularFont, Brushes.Black, new PointF(centerX, headerHeight), new StringFormat { Alignment = StringAlignment.Center });
            headerHeight += 20;
            g.DrawString("Sandawa, Davao City", regularFont, Brushes.Black, new PointF(centerX, headerHeight), new StringFormat { Alignment = StringAlignment.Center });
            headerHeight += 15;
            g.DrawString("Tel: +1111-2222-333", regularFont, Brushes.Black, new PointF(centerX, headerHeight), new StringFormat { Alignment = StringAlignment.Center });
        }

        private void DrawTransactionDetails(Graphics g)
        {
            Font regularFont = new Font("Segoe UI Semibold", 8, FontStyle.Regular);

            int transactionHeight = 80;
            g.DrawString("Invoice #:", regularFont, Brushes.Black, 10, transactionHeight);
            g.DrawString(transNo, regularFont, Brushes.Black, 70, transactionHeight);

            transactionHeight += 15;
            g.DrawString("Date: " + transDate.ToString("MM/dd/yyyy"), regularFont, Brushes.Black, 10, transactionHeight);
        }

        private void DrawProductDetails(Graphics g)
        {
            Font productFont = new Font("Segoe UI Semibold", 10, FontStyle.Regular);
            Font headerFont = new Font("Segoe UI Semibold", 10, FontStyle.Bold);

            int height = 140;

            g.DrawString("Product Name", headerFont, Brushes.Black, 20, 120);
            g.DrawString("Qty", headerFont, Brushes.Black, 145, 120);
            g.DrawString("Price", headerFont, Brushes.Black, 180, 120);

            foreach (Product product in products)
            {
                g.DrawString(product.ProdName, productFont, Brushes.Black, 20, height);
                g.DrawString(product.Quantity.ToString(), productFont, Brushes.Black, 145, height);
                g.DrawString(product.TotalPrice.ToString("C2"), productFont, Brushes.Black, 180, height);

                height += 20;
            }
        }

        private void DrawFooter(Graphics g)
        {
            Font regularFont = new Font("Segoe UI Semibold", 10, FontStyle.Regular);
            int height = 200 + (products.Count * 20);

            g.DrawString("Net Total:", regularFont, Brushes.Black, 10, height);
            g.DrawString(netTotal.ToString("C2"), regularFont, Brushes.Black, 180, height);
            height += 20;

            g.DrawString("VAT (12%):", regularFont, Brushes.Black, 10, height);
            g.DrawString(vatAmount.ToString("C2"), regularFont, Brushes.Black, 180, height);
            height += 20;

            g.DrawString("Grand Total:", regularFont, Brushes.Black, 10, height);
            g.DrawString(grandTotal.ToString("C2"), regularFont, Brushes.Black, 180, height);
        }

        private void SumPrice()
        {
            t_qty = 0;
            t_price = 0;

            foreach (Product product in products)
            {
                t_qty += product.Quantity;
                t_price += product.TotalPrice;
            }

            vatAmount = t_price * vatRate;
            grandTotal = t_price + vatAmount;
            netTotal = grandTotal - vatAmount;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}

