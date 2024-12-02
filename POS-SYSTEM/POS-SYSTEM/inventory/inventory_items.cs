using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class inventory_items : UserControl
    {
        private readonly MySqlConnection conn = new MySqlConnection("server=localhost;userid=root;password=;database=posresto_db");
        private readonly string connectionString = "server=localhost;userid=root;password=;database=posresto_db";
        private Employee _currentEmployee;
        public inventory_items(Employee currentEmployee)
        {
            InitializeComponent();
            dgv_items.CellClick += DgvInventoryItems_CellClick;
            LoadDataGridView();
            _currentEmployee = currentEmployee;
        }
        private void LogAction(string actionModule, string action, int? itemId = null, int? quantity = null, decimal? amount = null, string details = null)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO system_logs 
                    (action_module, action, item_id, quantity, amount, timestamp, details, employee_id) 
                VALUES 
                    (@actionModule, @action, @itemId, @quantity, @amount, @timestamp, @details, @employee_id)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@actionModule", actionModule);
                cmd.Parameters.AddWithValue("@action", action);
                cmd.Parameters.AddWithValue("@itemId", itemId.HasValue ? (object)itemId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@quantity", quantity.HasValue ? (object)quantity.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@amount", amount.HasValue ? (object)amount.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                cmd.Parameters.AddWithValue("@details", details ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@employee_id", _currentEmployee?.Userid ?? (object)DBNull.Value);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error logging action: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadDataGridView()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM ingredients_tb", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found in the ingredients table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgv_items.Rows.Clear();
                while (reader.Read())
                {
                    dgv_items.Rows.Add(
                        reader["ingredient_id"],
                        reader["ingredient_name"],
                        reader["unit"],
                        reader["stock_quantity"],
                        reader["minimum_quantity"],
                        reader["is_active"]);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DgvInventoryItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_items.CurrentRow != null)
            {

                btn_save.Enabled = false;
            }
        }

        private void pic_ProdImg_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_archive_Click(object sender, EventArgs e)
        {

        }

        private void btn_unarchive_Click(object sender, EventArgs e)
        {

        }
    }
}
