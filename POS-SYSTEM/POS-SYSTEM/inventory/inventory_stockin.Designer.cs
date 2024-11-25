namespace POS_SYSTEM.inventory
{
    partial class inventory_stockin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_stockin = new System.Windows.Forms.DataGridView();
            this.stock_in_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_per_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.dgv_stockin);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(470, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(946, 706);
            this.panel13.TabIndex = 33;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Controls.Add(this.label1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(470, 706);
            this.panel12.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stock In";
            // 
            // dgv_stockin
            // 
            this.dgv_stockin.AllowUserToAddRows = false;
            this.dgv_stockin.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dgv_stockin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_stockin.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_stockin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stockin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_stockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stockin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock_in_id,
            this.product_id,
            this.qty,
            this.cost_per_unit,
            this.total_cost,
            this.received_by,
            this.date_received,
            this.remarks});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stockin.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_stockin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_stockin.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_stockin.Location = new System.Drawing.Point(0, 0);
            this.dgv_stockin.Name = "dgv_stockin";
            this.dgv_stockin.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stockin.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_stockin.RowHeadersVisible = false;
            this.dgv_stockin.RowHeadersWidth = 51;
            this.dgv_stockin.RowTemplate.Height = 24;
            this.dgv_stockin.Size = new System.Drawing.Size(946, 706);
            this.dgv_stockin.TabIndex = 2;
            // 
            // stock_in_id
            // 
            this.stock_in_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.stock_in_id.DefaultCellStyle = dataGridViewCellStyle14;
            this.stock_in_id.HeaderText = "STOCK IN NO.";
            this.stock_in_id.MinimumWidth = 6;
            this.stock_in_id.Name = "stock_in_id";
            this.stock_in_id.ReadOnly = true;
            this.stock_in_id.Visible = false;
            this.stock_in_id.Width = 124;
            // 
            // product_id
            // 
            this.product_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.product_id.DefaultCellStyle = dataGridViewCellStyle15;
            this.product_id.HeaderText = "PRODUCT NAME";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.qty.DefaultCellStyle = dataGridViewCellStyle16;
            this.qty.HeaderText = "QUANTITY";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 121;
            // 
            // cost_per_unit
            // 
            this.cost_per_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.cost_per_unit.DefaultCellStyle = dataGridViewCellStyle17;
            this.cost_per_unit.HeaderText = "COST PER UNITS";
            this.cost_per_unit.MinimumWidth = 6;
            this.cost_per_unit.Name = "cost_per_unit";
            this.cost_per_unit.ReadOnly = true;
            this.cost_per_unit.Width = 155;
            // 
            // total_cost
            // 
            this.total_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.total_cost.DefaultCellStyle = dataGridViewCellStyle18;
            this.total_cost.HeaderText = "TOTAL COST";
            this.total_cost.MinimumWidth = 6;
            this.total_cost.Name = "total_cost";
            this.total_cost.ReadOnly = true;
            this.total_cost.Width = 122;
            // 
            // received_by
            // 
            this.received_by.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.received_by.DefaultCellStyle = dataGridViewCellStyle19;
            this.received_by.HeaderText = "RECIEVED BY";
            this.received_by.MinimumWidth = 6;
            this.received_by.Name = "received_by";
            this.received_by.ReadOnly = true;
            // 
            // date_received
            // 
            this.date_received.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.date_received.HeaderText = "DATE RECIEVED";
            this.date_received.MinimumWidth = 6;
            this.date_received.Name = "date_received";
            this.date_received.ReadOnly = true;
            this.date_received.Width = 147;
            // 
            // remarks
            // 
            this.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.remarks.DefaultCellStyle = dataGridViewCellStyle20;
            this.remarks.HeaderText = "REMARKS";
            this.remarks.MinimumWidth = 6;
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            // 
            // inventory_stockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Name = "inventory_stockin";
            this.Size = new System.Drawing.Size(1416, 706);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DataGridView dgv_stockin;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_in_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_per_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn received_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
    }
}
