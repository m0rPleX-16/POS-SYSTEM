using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    public partial class frm_OrderHistory : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private DataTable orderHistoryTable;
        private Employee _currentEmployee;
        public frm_OrderHistory(Employee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
            LoadOrderHistory();
            dgv_orderHist.CellClick += dgv_orderHist_CellClick;
        }

        private void frm_OrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

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
            t.table_number AS 'Table Number',
            e.username AS 'Employee',
            o.total_price AS 'Total Price',
            o.status AS 'Status',
            DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i:%s') AS 'Order Date'
        FROM 
            orders_tb o
        INNER JOIN 
            tables_tb t ON o.table_id = t.table_id
        INNER JOIN 
            employee_tb e ON o.employee_id = e.employee_id
        ORDER BY 
            o.order_date DESC;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dgv_orderHist.Rows.Clear();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found in the order history.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                while (reader.Read())
                {
                    dgv_orderHist.Rows.Add(
                        reader["Order No"],
                        reader["Table Number"],
                        reader["Employee"],
                        reader["Total Price"],
                        reader["Status"],
                        reader["Order Date"]
                    );
                }

                if (!dgv_orderHist.Columns.Contains("Cancel"))
                {
                    DataGridViewButtonColumn cancelButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "Cancel",
                        HeaderText = "Action",
                        Text = "Cancel",
                        UseColumnTextForButtonValue = true,
                    };
                    dgv_orderHist.Columns.Add(cancelButtonColumn);
                }

                dgv_orderHist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_orderHist.ReadOnly = false;
                dgv_orderHist.AllowUserToAddRows = false;
                dgv_orderHist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string searchText = txt_search.Text.Trim();
                string query = @"
            SELECT 
                o.orderNo AS 'Order No',
                t.table_number AS 'Table Number',
                e.username AS 'Employee',
                o.total_price AS 'Total Price',
                o.status AS 'Status',
                DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i:%s') AS 'Order Date'
            FROM 
                orders_tb o
            INNER JOIN 
                tables_tb t ON o.table_id = t.table_id
            INNER JOIN 
                employee_tb e ON o.employee_id = e.employee_id
            WHERE 
                o.orderNo LIKE @searchText OR
                t.table_number LIKE @searchText OR
                e.username LIKE @searchText OR
                o.status LIKE @searchText OR
                DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i:%s') LIKE @searchText
            ORDER BY 
                o.order_date DESC;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                MySqlDataReader reader = cmd.ExecuteReader();
                dgv_orderHist.Rows.Clear();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No matching records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                while (reader.Read())
                {
                    dgv_orderHist.Rows.Add(
                        reader["Order No"],
                        reader["Table Number"],
                        reader["Employee"],
                        reader["Total Price"],
                        reader["Status"],
                        reader["Order Date"]
                    );
                }

                dgv_orderHist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_orderHist.ReadOnly = true;
                dgv_orderHist.AllowUserToAddRows = false;
                dgv_orderHist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error performing search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_orderHist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_orderHist.Columns[e.ColumnIndex].Name == "Cancel")
            {
                string orderNo = dgv_orderHist.Rows[e.RowIndex].Cells["orderNo"].Value.ToString();
                string currentStatus = dgv_orderHist.Rows[e.RowIndex].Cells["status"].Value.ToString();

                if (currentStatus == "Canceled")
                {
                    MessageBox.Show("This order is already canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to cancel Order No: {orderNo}?",
                    "Confirm Cancel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.Yes)
                {
                    CancelOrder(orderNo);
                }
            }
        }

        private void CancelOrder(string orderNo)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();

                string query = "UPDATE orders_tb SET status = 'Canceled' WHERE orderNo = @orderNo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderNo", orderNo);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order has been successfully canceled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrderHistory();
                }
                else
                {
                    MessageBox.Show("Failed to cancel the order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error canceling the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

