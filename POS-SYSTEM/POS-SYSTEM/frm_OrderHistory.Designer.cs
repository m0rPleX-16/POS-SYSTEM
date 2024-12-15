namespace POS_SYSTEM
{
    partial class frm_OrderHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_OrderHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_bgStats = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.line_username = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dgv_orderHist = new System.Windows.Forms.DataGridView();
            this.orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top.SuspendLayout();
            this.pnl_bgStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderHist)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1344, 79);
            this.pnl_top.TabIndex = 23;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Maroon;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1257, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 38);
            this.btn_close.TabIndex = 30;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Order History";
            // 
            // pnl_bgStats
            // 
            this.pnl_bgStats.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_bgStats.Controls.Add(this.btn_search);
            this.pnl_bgStats.Controls.Add(this.line_username);
            this.pnl_bgStats.Controls.Add(this.txt_search);
            this.pnl_bgStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bgStats.Location = new System.Drawing.Point(0, 79);
            this.pnl_bgStats.Name = "pnl_bgStats";
            this.pnl_bgStats.Size = new System.Drawing.Size(1344, 61);
            this.pnl_bgStats.TabIndex = 30;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(253, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(26, 28);
            this.btn_search.TabIndex = 25;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // line_username
            // 
            this.line_username.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.line_username.Location = new System.Drawing.Point(12, 43);
            this.line_username.Name = "line_username";
            this.line_username.Size = new System.Drawing.Size(270, 1);
            this.line_username.TabIndex = 24;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txt_search.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_search.Location = new System.Drawing.Point(12, 21);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(245, 23);
            this.txt_search.TabIndex = 23;
            this.txt_search.Text = "Search";
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dgv_orderHist
            // 
            this.dgv_orderHist.AllowUserToAddRows = false;
            this.dgv_orderHist.AllowUserToDeleteRows = false;
            this.dgv_orderHist.AllowUserToResizeColumns = false;
            this.dgv_orderHist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_orderHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_orderHist.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_orderHist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_orderHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orderHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_orderHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNo,
            this.table_number,
            this.employee_id,
            this.total_price,
            this.status,
            this.date_added});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orderHist.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_orderHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orderHist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_orderHist.Location = new System.Drawing.Point(0, 140);
            this.dgv_orderHist.Name = "dgv_orderHist";
            this.dgv_orderHist.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orderHist.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_orderHist.RowHeadersVisible = false;
            this.dgv_orderHist.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_orderHist.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_orderHist.RowTemplate.Height = 24;
            this.dgv_orderHist.Size = new System.Drawing.Size(1344, 664);
            this.dgv_orderHist.TabIndex = 31;
            // 
            // orderNo
            // 
            this.orderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.orderNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderNo.HeaderText = "ORDER NO.";
            this.orderNo.MinimumWidth = 6;
            this.orderNo.Name = "orderNo";
            this.orderNo.ReadOnly = true;
            // 
            // table_number
            // 
            this.table_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.table_number.HeaderText = "TABLE NUMBER";
            this.table_number.MinimumWidth = 6;
            this.table_number.Name = "table_number";
            this.table_number.ReadOnly = true;
            // 
            // employee_id
            // 
            this.employee_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employee_id.HeaderText = "EMPLOYEE";
            this.employee_id.MinimumWidth = 6;
            this.employee_id.Name = "employee_id";
            this.employee_id.ReadOnly = true;
            this.employee_id.Width = 124;
            // 
            // total_price
            // 
            this.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total_price.HeaderText = "TOTAL PRICE";
            this.total_price.MinimumWidth = 6;
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            this.total_price.Width = 141;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.HeaderText = "STATUS";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 101;
            // 
            // date_added
            // 
            this.date_added.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_added.HeaderText = "ORDER DATE";
            this.date_added.MinimumWidth = 6;
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            // 
            // frm_OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 804);
            this.Controls.Add(this.dgv_orderHist);
            this.Controls.Add(this.pnl_bgStats);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_OrderHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_OrderHistory";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bgStats.ResumeLayout(false);
            this.pnl_bgStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderHist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        internal System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_bgStats;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel line_username;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_orderHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
    }
}