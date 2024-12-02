﻿namespace POS_SYSTEM
{
    partial class frm_Inventory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Inventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnl_bgStats = new System.Windows.Forms.Panel();
            this.recipe = new System.Windows.Forms.Button();
            this.btn_tables = new System.Windows.Forms.Button();
            this.btn_stockin = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_clock = new System.Windows.Forms.Panel();
            this.pnl_calendar = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_inventBG = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.inventory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorder_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_bgStats.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_inventBG.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bgStats
            // 
            this.pnl_bgStats.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_bgStats.Controls.Add(this.recipe);
            this.pnl_bgStats.Controls.Add(this.btn_tables);
            this.pnl_bgStats.Controls.Add(this.btn_stockin);
            this.pnl_bgStats.Controls.Add(this.btn_category);
            this.pnl_bgStats.Controls.Add(this.btn_product);
            this.pnl_bgStats.Controls.Add(this.button1);
            this.pnl_bgStats.Controls.Add(this.panel1);
            this.pnl_bgStats.Controls.Add(this.txt_search);
            this.pnl_bgStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bgStats.Location = new System.Drawing.Point(0, 153);
            this.pnl_bgStats.Name = "pnl_bgStats";
            this.pnl_bgStats.Size = new System.Drawing.Size(1461, 119);
            this.pnl_bgStats.TabIndex = 29;
            // 
            // recipe
            // 
            this.recipe.BackColor = System.Drawing.Color.Wheat;
            this.recipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recipe.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.recipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipe.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.recipe.ForeColor = System.Drawing.Color.DarkRed;
            this.recipe.Location = new System.Drawing.Point(853, 11);
            this.recipe.Name = "recipe";
            this.recipe.Size = new System.Drawing.Size(191, 98);
            this.recipe.TabIndex = 41;
            this.recipe.Text = "Recipe";
            this.recipe.UseVisualStyleBackColor = false;
            this.recipe.Click += new System.EventHandler(this.recipe_Click);
            // 
            // btn_tables
            // 
            this.btn_tables.BackColor = System.Drawing.Color.Wheat;
            this.btn_tables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tables.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_tables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tables.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_tables.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_tables.Location = new System.Drawing.Point(647, 11);
            this.btn_tables.Name = "btn_tables";
            this.btn_tables.Size = new System.Drawing.Size(191, 98);
            this.btn_tables.TabIndex = 40;
            this.btn_tables.Text = "Tables";
            this.btn_tables.UseVisualStyleBackColor = false;
            this.btn_tables.Click += new System.EventHandler(this.btn_tables_Click);
            // 
            // btn_stockin
            // 
            this.btn_stockin.BackColor = System.Drawing.Color.Wheat;
            this.btn_stockin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stockin.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_stockin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stockin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_stockin.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_stockin.Location = new System.Drawing.Point(441, 11);
            this.btn_stockin.Name = "btn_stockin";
            this.btn_stockin.Size = new System.Drawing.Size(191, 98);
            this.btn_stockin.TabIndex = 39;
            this.btn_stockin.Text = "Ingridients";
            this.btn_stockin.UseVisualStyleBackColor = false;
            this.btn_stockin.Click += new System.EventHandler(this.btn_stockin_Click);
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.Wheat;
            this.btn_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_category.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_category.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_category.Location = new System.Drawing.Point(234, 11);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(191, 98);
            this.btn_category.TabIndex = 38;
            this.btn_category.Text = "Categories";
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.Wheat;
            this.btn_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_product.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_product.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_product.Location = new System.Drawing.Point(23, 11);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(191, 98);
            this.btn_product.TabIndex = 37;
            this.btn_product.Text = "Items";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1348, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 46);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(969, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 1);
            this.panel1.TabIndex = 24;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txt_search.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_search.Location = new System.Drawing.Point(969, 52);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(382, 36);
            this.txt_search.TabIndex = 23;
            this.txt_search.Text = "Search";
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_top.Controls.Add(this.pnl_clock);
            this.pnl_top.Controls.Add(this.pnl_calendar);
            this.pnl_top.Controls.Add(this.lbl_time);
            this.pnl_top.Controls.Add(this.lbl_date);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1461, 153);
            this.pnl_top.TabIndex = 33;
            // 
            // pnl_clock
            // 
            this.pnl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_clock.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_clock.BackgroundImage")));
            this.pnl_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_clock.Location = new System.Drawing.Point(830, 85);
            this.pnl_clock.Name = "pnl_clock";
            this.pnl_clock.Size = new System.Drawing.Size(55, 43);
            this.pnl_clock.TabIndex = 16;
            // 
            // pnl_calendar
            // 
            this.pnl_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_calendar.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_calendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_calendar.BackgroundImage")));
            this.pnl_calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_calendar.Location = new System.Drawing.Point(830, 28);
            this.pnl_calendar.Name = "pnl_calendar";
            this.pnl_calendar.Size = new System.Drawing.Size(55, 43);
            this.pnl_calendar.TabIndex = 15;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_time.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_time.Location = new System.Drawing.Point(888, 82);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(96, 46);
            this.lbl_time.TabIndex = 14;
            this.lbl_time.Text = "Time";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_date.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_date.Location = new System.Drawing.Point(888, 25);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(92, 46);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inventory Management";
            // 
            // pnl_inventBG
            // 
            this.pnl_inventBG.Controls.Add(this.panel13);
            this.pnl_inventBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_inventBG.Location = new System.Drawing.Point(0, 272);
            this.pnl_inventBG.Name = "pnl_inventBG";
            this.pnl_inventBG.Size = new System.Drawing.Size(1461, 710);
            this.pnl_inventBG.TabIndex = 34;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.dgv_inventory);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1461, 710);
            this.panel13.TabIndex = 33;
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.AllowUserToAddRows = false;
            this.dgv_inventory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.dgv_inventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_inventory.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_inventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventory_id,
            this.product_name,
            this.current_stocks,
            this.reorder_level});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inventory.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_inventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_inventory.Location = new System.Drawing.Point(0, 0);
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_inventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_inventory.RowHeadersVisible = false;
            this.dgv_inventory.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_inventory.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_inventory.RowTemplate.Height = 24;
            this.dgv_inventory.Size = new System.Drawing.Size(1461, 710);
            this.dgv_inventory.TabIndex = 1;
            // 
            // inventory_id
            // 
            this.inventory_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.inventory_id.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventory_id.HeaderText = "INVENTORY NO.";
            this.inventory_id.MinimumWidth = 6;
            this.inventory_id.Name = "inventory_id";
            this.inventory_id.ReadOnly = true;
            this.inventory_id.Visible = false;
            this.inventory_id.Width = 125;
            // 
            // product_name
            // 
            this.product_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.product_name.DefaultCellStyle = dataGridViewCellStyle4;
            this.product_name.HeaderText = "PRODUCT NAME";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            // 
            // current_stocks
            // 
            this.current_stocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.current_stocks.DefaultCellStyle = dataGridViewCellStyle5;
            this.current_stocks.HeaderText = "CURRENT STOCKS";
            this.current_stocks.MinimumWidth = 6;
            this.current_stocks.Name = "current_stocks";
            this.current_stocks.ReadOnly = true;
            // 
            // reorder_level
            // 
            this.reorder_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.reorder_level.DefaultCellStyle = dataGridViewCellStyle6;
            this.reorder_level.HeaderText = "CURRENT REORDER LEVEL";
            this.reorder_level.MinimumWidth = 6;
            this.reorder_level.Name = "reorder_level";
            this.reorder_level.ReadOnly = true;
            // 
            // frm_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 982);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_inventBG);
            this.Controls.Add(this.pnl_bgStats);
            this.Controls.Add(this.pnl_top);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_bgStats.ResumeLayout(false);
            this.pnl_bgStats.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_inventBG.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel pnl_bgStats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_clock;
        private System.Windows.Forms.Panel pnl_calendar;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_stockin;
        private System.Windows.Forms.Panel pnl_inventBG;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_stocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorder_level;
        private System.Windows.Forms.Button btn_tables;
        private System.Windows.Forms.Button recipe;
    }
}