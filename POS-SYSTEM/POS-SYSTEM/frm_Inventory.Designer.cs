namespace POS_SYSTEM
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
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pnl_bgStats = new System.Windows.Forms.Panel();
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
            this.btn_stockin = new System.Windows.Forms.Button();
            this.pnl_bgStats.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(505, 272);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1437, 830);
            this.panel13.TabIndex = 31;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 272);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(505, 830);
            this.panel12.TabIndex = 30;
            // 
            // pnl_bgStats
            // 
            this.pnl_bgStats.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_bgStats.Controls.Add(this.btn_stockin);
            this.pnl_bgStats.Controls.Add(this.btn_category);
            this.pnl_bgStats.Controls.Add(this.btn_product);
            this.pnl_bgStats.Controls.Add(this.button1);
            this.pnl_bgStats.Controls.Add(this.panel1);
            this.pnl_bgStats.Controls.Add(this.txt_search);
            this.pnl_bgStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bgStats.Location = new System.Drawing.Point(0, 153);
            this.pnl_bgStats.Name = "pnl_bgStats";
            this.pnl_bgStats.Size = new System.Drawing.Size(1942, 119);
            this.pnl_bgStats.TabIndex = 29;
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.Color.Wheat;
            this.btn_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_category.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_category.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_category.Location = new System.Drawing.Point(347, 11);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(191, 98);
            this.btn_category.TabIndex = 38;
            this.btn_category.Text = "Category";
            this.btn_category.UseVisualStyleBackColor = false;
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.Color.Wheat;
            this.btn_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_product.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_product.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_product.Location = new System.Drawing.Point(37, 11);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(191, 98);
            this.btn_product.TabIndex = 37;
            this.btn_product.Text = "Products";
            this.btn_product.UseVisualStyleBackColor = false;
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
            this.button1.Location = new System.Drawing.Point(1829, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 46);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(1450, 88);
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
            this.txt_search.Location = new System.Drawing.Point(1450, 52);
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
            this.pnl_top.Size = new System.Drawing.Size(1942, 153);
            this.pnl_top.TabIndex = 33;
            this.pnl_top.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_top_Paint);
            // 
            // pnl_clock
            // 
            this.pnl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_clock.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_clock.BackgroundImage")));
            this.pnl_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_clock.Location = new System.Drawing.Point(1311, 85);
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
            this.pnl_calendar.Location = new System.Drawing.Point(1311, 28);
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
            this.lbl_time.Location = new System.Drawing.Point(1369, 82);
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
            this.lbl_date.Location = new System.Drawing.Point(1369, 25);
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
            // btn_stockin
            // 
            this.btn_stockin.BackColor = System.Drawing.Color.Wheat;
            this.btn_stockin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stockin.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_stockin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stockin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_stockin.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_stockin.Location = new System.Drawing.Point(668, 11);
            this.btn_stockin.Name = "btn_stockin";
            this.btn_stockin.Size = new System.Drawing.Size(191, 98);
            this.btn_stockin.TabIndex = 39;
            this.btn_stockin.Text = "Stock-in";
            this.btn_stockin.UseVisualStyleBackColor = false;
            // 
            // frm_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.ControlBox = false;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
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
    }
}