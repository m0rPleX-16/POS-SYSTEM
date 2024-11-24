namespace POS_SYSTEM
{
    partial class frm_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_POS));
            this.pnl_bg = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_categories = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flp_sales = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_clock = new System.Windows.Forms.Panel();
            this.pnl_calendar = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.line_username = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_bill = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.pnl_bgCash = new System.Windows.Forms.Panel();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl__discount = new System.Windows.Forms.Label();
            this.pnl_totalBG = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.cmb_paymentMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_bg.SuspendLayout();
            this.pnl_categories.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_bill.SuspendLayout();
            this.pnl_bgCash.SuspendLayout();
            this.pnl_totalBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_bg
            // 
            this.pnl_bg.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_bg.Controls.Add(this.btn_cancel);
            this.pnl_bg.Controls.Add(this.btn_exit);
            this.pnl_bg.Controls.Add(this.pnl_categories);
            this.pnl_bg.Controls.Add(this.flp_sales);
            this.pnl_bg.Controls.Add(this.pnl_top);
            this.pnl_bg.Controls.Add(this.pnl_bill);
            this.pnl_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bg.Location = new System.Drawing.Point(0, 0);
            this.pnl_bg.Name = "pnl_bg";
            this.pnl_bg.Size = new System.Drawing.Size(1942, 1102);
            this.pnl_bg.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Location = new System.Drawing.Point(888, 976);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(317, 59);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "Cancel Order";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(357, 976);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(317, 59);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_categories
            // 
            this.pnl_categories.BackColor = System.Drawing.Color.Bisque;
            this.pnl_categories.Controls.Add(this.panel7);
            this.pnl_categories.Controls.Add(this.panel6);
            this.pnl_categories.Controls.Add(this.panel5);
            this.pnl_categories.Controls.Add(this.panel4);
            this.pnl_categories.Location = new System.Drawing.Point(37, 780);
            this.pnl_categories.Name = "pnl_categories";
            this.pnl_categories.Size = new System.Drawing.Size(1400, 153);
            this.pnl_categories.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Ivory;
            this.panel7.Location = new System.Drawing.Point(1089, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(178, 112);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Ivory;
            this.panel6.Location = new System.Drawing.Point(744, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(178, 112);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.Location = new System.Drawing.Point(421, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 112);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.Location = new System.Drawing.Point(123, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 112);
            this.panel4.TabIndex = 0;
            // 
            // flp_sales
            // 
            this.flp_sales.BackColor = System.Drawing.Color.Peru;
            this.flp_sales.Location = new System.Drawing.Point(37, 129);
            this.flp_sales.Name = "flp_sales";
            this.flp_sales.Size = new System.Drawing.Size(1400, 651);
            this.flp_sales.TabIndex = 17;
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.pnl_clock);
            this.pnl_top.Controls.Add(this.pnl_calendar);
            this.pnl_top.Controls.Add(this.lbl_time);
            this.pnl_top.Controls.Add(this.lbl_date);
            this.pnl_top.Controls.Add(this.btn_search);
            this.pnl_top.Controls.Add(this.line_username);
            this.pnl_top.Controls.Add(this.txt_search);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1378, 129);
            this.pnl_top.TabIndex = 20;
            // 
            // pnl_clock
            // 
            this.pnl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_clock.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_clock.BackgroundImage")));
            this.pnl_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_clock.Location = new System.Drawing.Point(27, 71);
            this.pnl_clock.Name = "pnl_clock";
            this.pnl_clock.Size = new System.Drawing.Size(55, 43);
            this.pnl_clock.TabIndex = 26;
            // 
            // pnl_calendar
            // 
            this.pnl_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_calendar.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_calendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_calendar.BackgroundImage")));
            this.pnl_calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_calendar.Location = new System.Drawing.Point(27, 14);
            this.pnl_calendar.Name = "pnl_calendar";
            this.pnl_calendar.Size = new System.Drawing.Size(55, 43);
            this.pnl_calendar.TabIndex = 25;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_time.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_time.Location = new System.Drawing.Point(85, 68);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(96, 46);
            this.lbl_time.TabIndex = 24;
            this.lbl_time.Text = "Time";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_date.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_date.Location = new System.Drawing.Point(85, 11);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(92, 46);
            this.lbl_date.TabIndex = 23;
            this.lbl_date.Text = "Date";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(1238, 38);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(51, 46);
            this.btn_search.TabIndex = 22;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // line_username
            // 
            this.line_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.line_username.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.line_username.Location = new System.Drawing.Point(859, 86);
            this.line_username.Name = "line_username";
            this.line_username.Size = new System.Drawing.Size(430, 1);
            this.line_username.TabIndex = 21;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BackColor = System.Drawing.Color.MistyRose;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txt_search.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_search.Location = new System.Drawing.Point(859, 50);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(382, 36);
            this.txt_search.TabIndex = 20;
            this.txt_search.Text = "Search";
            // 
            // pnl_bill
            // 
            this.pnl_bill.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_bill.Controls.Add(this.label1);
            this.pnl_bill.Controls.Add(this.cmb_paymentMethod);
            this.pnl_bill.Controls.Add(this.label7);
            this.pnl_bill.Controls.Add(this.btn_confirm);
            this.pnl_bill.Controls.Add(this.pnl_bgCash);
            this.pnl_bill.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_bill.Location = new System.Drawing.Point(1378, 0);
            this.pnl_bill.Name = "pnl_bill";
            this.pnl_bill.Size = new System.Drawing.Size(564, 1102);
            this.pnl_bill.TabIndex = 19;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Green;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_confirm.Location = new System.Drawing.Point(116, 976);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(317, 59);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "Confirm Order";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // pnl_bgCash
            // 
            this.pnl_bgCash.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_bgCash.Controls.Add(this.lbl_subtotal);
            this.pnl_bgCash.Controls.Add(this.lbl__discount);
            this.pnl_bgCash.Controls.Add(this.pnl_totalBG);
            this.pnl_bgCash.Controls.Add(this.Subtotal);
            this.pnl_bgCash.Controls.Add(this.Discount);
            this.pnl_bgCash.Location = new System.Drawing.Point(-26, 540);
            this.pnl_bgCash.Name = "pnl_bgCash";
            this.pnl_bgCash.Size = new System.Drawing.Size(564, 313);
            this.pnl_bgCash.TabIndex = 0;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl_subtotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_subtotal.Location = new System.Drawing.Point(430, 113);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(81, 46);
            this.lbl_subtotal.TabIndex = 5;
            this.lbl_subtotal.Text = "0.00";
            // 
            // lbl__discount
            // 
            this.lbl__discount.AutoSize = true;
            this.lbl__discount.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl__discount.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl__discount.Location = new System.Drawing.Point(430, 43);
            this.lbl__discount.Name = "lbl__discount";
            this.lbl__discount.Size = new System.Drawing.Size(81, 46);
            this.lbl__discount.TabIndex = 4;
            this.lbl__discount.Text = "0.00";
            // 
            // pnl_totalBG
            // 
            this.pnl_totalBG.BackColor = System.Drawing.Color.Linen;
            this.pnl_totalBG.Controls.Add(this.lbl_total);
            this.pnl_totalBG.Controls.Add(this.Total);
            this.pnl_totalBG.Location = new System.Drawing.Point(55, 223);
            this.pnl_totalBG.Name = "pnl_totalBG";
            this.pnl_totalBG.Size = new System.Drawing.Size(478, 71);
            this.pnl_totalBG.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbl_total.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_total.Location = new System.Drawing.Point(375, 13);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(81, 46);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "0.00";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.Total.ForeColor = System.Drawing.Color.DarkRed;
            this.Total.Location = new System.Drawing.Point(10, 13);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(95, 46);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.Subtotal.ForeColor = System.Drawing.Color.DarkRed;
            this.Subtotal.Location = new System.Drawing.Point(65, 113);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(146, 46);
            this.Subtotal.TabIndex = 1;
            this.Subtotal.Text = "Subtotal";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.Discount.ForeColor = System.Drawing.Color.DarkRed;
            this.Discount.Location = new System.Drawing.Point(65, 43);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(209, 46);
            this.Discount.TabIndex = 0;
            this.Discount.Text = "Discount (%)";
            // 
            // cmb_paymentMethod
            // 
            this.cmb_paymentMethod.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.cmb_paymentMethod.FormattingEnabled = true;
            this.cmb_paymentMethod.Location = new System.Drawing.Point(347, 884);
            this.cmb_paymentMethod.Name = "cmb_paymentMethod";
            this.cmb_paymentMethod.Size = new System.Drawing.Size(160, 53);
            this.cmb_paymentMethod.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(39, 887);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment Method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(183, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 46);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bill Details";
            // 
            // frm_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.pnl_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_bg.ResumeLayout(false);
            this.pnl_categories.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bill.ResumeLayout(false);
            this.pnl_bill.PerformLayout();
            this.pnl_bgCash.ResumeLayout(false);
            this.pnl_bgCash.PerformLayout();
            this.pnl_totalBG.ResumeLayout(false);
            this.pnl_totalBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_bg;
        private System.Windows.Forms.FlowLayoutPanel flp_sales;
        private System.Windows.Forms.Panel pnl_categories;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bill;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Panel pnl_bgCash;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl__discount;
        private System.Windows.Forms.Panel pnl_totalBG;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel line_username;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel pnl_clock;
        private System.Windows.Forms.Panel pnl_calendar;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_paymentMethod;
        private System.Windows.Forms.Label label7;
    }
}