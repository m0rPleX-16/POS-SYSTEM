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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.linepanel_transact = new System.Windows.Forms.Panel();
            this.txt_transactNo = new System.Windows.Forms.TextBox();
            this.pnl_clock = new System.Windows.Forms.Panel();
            this.pnl_calendar = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.line_username = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.pnl_details = new System.Windows.Forms.Panel();
            this.cb_availtb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.line_cash = new System.Windows.Forms.Panel();
            this.txt_change = new System.Windows.Forms.Label();
            this.txt_cash = new System.Windows.Forms.TextBox();
            this.flp_billDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_paymentMethod = new System.Windows.Forms.ComboBox();
            this.pnl_bgCash = new System.Windows.Forms.Panel();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl__discount = new System.Windows.Forms.Label();
            this.pnl_totalBG = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.pnl_flp = new System.Windows.Forms.Panel();
            this.flp_categories = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_sales = new System.Windows.Forms.FlowLayoutPanel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_bg.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.pnl_details.SuspendLayout();
            this.pnl_bgCash.SuspendLayout();
            this.pnl_totalBG.SuspendLayout();
            this.pnl_flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_bg
            // 
            this.pnl_bg.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_bg.Controls.Add(this.panel1);
            this.pnl_bg.Controls.Add(this.panel2);
            this.pnl_bg.Controls.Add(this.pnl_top);
            this.pnl_bg.Controls.Add(this.pnl_flp);
            this.pnl_bg.Controls.Add(this.pnl_bottom);
            this.pnl_bg.Controls.Add(this.pnl_details);
            this.pnl_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bg.Location = new System.Drawing.Point(0, 0);
            this.pnl_bg.Name = "pnl_bg";
            this.pnl_bg.Size = new System.Drawing.Size(1942, 1102);
            this.pnl_bg.TabIndex = 3;
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.linepanel_transact);
            this.pnl_top.Controls.Add(this.txt_transactNo);
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(723, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order No.";
            // 
            // linepanel_transact
            // 
            this.linepanel_transact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linepanel_transact.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.linepanel_transact.Location = new System.Drawing.Point(922, 58);
            this.linepanel_transact.Name = "linepanel_transact";
            this.linepanel_transact.Size = new System.Drawing.Size(390, 1);
            this.linepanel_transact.TabIndex = 22;
            // 
            // txt_transactNo
            // 
            this.txt_transactNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_transactNo.BackColor = System.Drawing.Color.MistyRose;
            this.txt_transactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_transactNo.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.txt_transactNo.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_transactNo.Location = new System.Drawing.Point(922, 22);
            this.txt_transactNo.Name = "txt_transactNo";
            this.txt_transactNo.Size = new System.Drawing.Size(382, 34);
            this.txt_transactNo.TabIndex = 27;
            // 
            // pnl_clock
            // 
            this.pnl_clock.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_clock.BackgroundImage")));
            this.pnl_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_clock.Location = new System.Drawing.Point(27, 71);
            this.pnl_clock.Name = "pnl_clock";
            this.pnl_clock.Size = new System.Drawing.Size(52, 32);
            this.pnl_clock.TabIndex = 26;
            // 
            // pnl_calendar
            // 
            this.pnl_calendar.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_calendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_calendar.BackgroundImage")));
            this.pnl_calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_calendar.Location = new System.Drawing.Point(27, 14);
            this.pnl_calendar.Name = "pnl_calendar";
            this.pnl_calendar.Size = new System.Drawing.Size(52, 32);
            this.pnl_calendar.TabIndex = 25;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.lbl_time.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_time.Location = new System.Drawing.Point(82, 71);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(71, 35);
            this.lbl_time.TabIndex = 24;
            this.lbl_time.Text = "Time";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.lbl_date.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_date.Location = new System.Drawing.Point(82, 14);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(68, 35);
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
            this.btn_search.Location = new System.Drawing.Point(853, 63);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(51, 46);
            this.btn_search.TabIndex = 22;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // line_username
            // 
            this.line_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.line_username.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.line_username.Location = new System.Drawing.Point(922, 113);
            this.line_username.Name = "line_username";
            this.line_username.Size = new System.Drawing.Size(390, 1);
            this.line_username.TabIndex = 21;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BackColor = System.Drawing.Color.MistyRose;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.txt_search.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_search.Location = new System.Drawing.Point(922, 73);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(382, 34);
            this.txt_search.TabIndex = 20;
            this.txt_search.Text = "Search";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Controls.Add(this.btn_history);
            this.pnl_bottom.Controls.Add(this.btn_exit);
            this.pnl_bottom.Controls.Add(this.btn_cancel);
            this.pnl_bottom.Controls.Add(this.btn_confirm);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 976);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1378, 126);
            this.pnl_bottom.TabIndex = 23;
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_history.FlatAppearance.BorderSize = 0;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_history.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_history.Location = new System.Drawing.Point(364, 38);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(230, 59);
            this.btn_history.TabIndex = 23;
            this.btn_history.Text = "Order History";
            this.btn_history.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(88, 38);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(189, 59);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Location = new System.Drawing.Point(696, 38);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(222, 59);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "New Order";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Green;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_confirm.Location = new System.Drawing.Point(1015, 38);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(261, 59);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "Confirm Order";
            this.btn_confirm.UseVisualStyleBackColor = false;
            // 
            // pnl_details
            // 
            this.pnl_details.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_details.Controls.Add(this.cb_availtb);
            this.pnl_details.Controls.Add(this.label5);
            this.pnl_details.Controls.Add(this.label4);
            this.pnl_details.Controls.Add(this.label3);
            this.pnl_details.Controls.Add(this.label7);
            this.pnl_details.Controls.Add(this.line_cash);
            this.pnl_details.Controls.Add(this.txt_change);
            this.pnl_details.Controls.Add(this.txt_cash);
            this.pnl_details.Controls.Add(this.flp_billDetails);
            this.pnl_details.Controls.Add(this.label1);
            this.pnl_details.Controls.Add(this.cmb_paymentMethod);
            this.pnl_details.Controls.Add(this.pnl_bgCash);
            this.pnl_details.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_details.Location = new System.Drawing.Point(1378, 0);
            this.pnl_details.Name = "pnl_details";
            this.pnl_details.Size = new System.Drawing.Size(564, 1102);
            this.pnl_details.TabIndex = 19;
            // 
            // cb_availtb
            // 
            this.cb_availtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_availtb.BackColor = System.Drawing.Color.Ivory;
            this.cb_availtb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_availtb.FormattingEnabled = true;
            this.cb_availtb.Items.AddRange(new object[] {
            "Cash",
            "GCash",
            "Maya"});
            this.cb_availtb.Location = new System.Drawing.Point(359, 957);
            this.cb_availtb.Name = "cb_availtb";
            this.cb_availtb.Size = new System.Drawing.Size(161, 36);
            this.cb_availtb.TabIndex = 24;
            this.cb_availtb.Text = "Select Table";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(47, 960);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Table No.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(47, 906);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Change";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(47, 856);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cash ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(168, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Order Details";
            // 
            // line_cash
            // 
            this.line_cash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.line_cash.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.line_cash.Location = new System.Drawing.Point(359, 883);
            this.line_cash.Name = "line_cash";
            this.line_cash.Size = new System.Drawing.Size(142, 1);
            this.line_cash.TabIndex = 22;
            // 
            // txt_change
            // 
            this.txt_change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_change.AutoSize = true;
            this.txt_change.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_change.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_change.Location = new System.Drawing.Point(416, 906);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(49, 28);
            this.txt_change.TabIndex = 10;
            this.txt_change.Text = "0.00";
            // 
            // txt_cash
            // 
            this.txt_cash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cash.BackColor = System.Drawing.Color.MistyRose;
            this.txt_cash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_cash.Location = new System.Drawing.Point(359, 854);
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(143, 27);
            this.txt_cash.TabIndex = 9;
            this.txt_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flp_billDetails
            // 
            this.flp_billDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_billDetails.BackColor = System.Drawing.Color.NavajoWhite;
            this.flp_billDetails.Location = new System.Drawing.Point(-31, 56);
            this.flp_billDetails.Name = "flp_billDetails";
            this.flp_billDetails.Size = new System.Drawing.Size(564, 562);
            this.flp_billDetails.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(47, 1008);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment Method";
            // 
            // cmb_paymentMethod
            // 
            this.cmb_paymentMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_paymentMethod.BackColor = System.Drawing.Color.Ivory;
            this.cmb_paymentMethod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_paymentMethod.FormattingEnabled = true;
            this.cmb_paymentMethod.Items.AddRange(new object[] {
            "Cash",
            "GCash",
            "Maya"});
            this.cmb_paymentMethod.Location = new System.Drawing.Point(359, 1005);
            this.cmb_paymentMethod.Name = "cmb_paymentMethod";
            this.cmb_paymentMethod.Size = new System.Drawing.Size(161, 36);
            this.cmb_paymentMethod.TabIndex = 4;
            this.cmb_paymentMethod.Text = "Select Payment";
            // 
            // pnl_bgCash
            // 
            this.pnl_bgCash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_bgCash.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_bgCash.Controls.Add(this.lbl_subtotal);
            this.pnl_bgCash.Controls.Add(this.lbl__discount);
            this.pnl_bgCash.Controls.Add(this.pnl_totalBG);
            this.pnl_bgCash.Controls.Add(this.Subtotal);
            this.pnl_bgCash.Controls.Add(this.Discount);
            this.pnl_bgCash.Location = new System.Drawing.Point(-31, 624);
            this.pnl_bgCash.Name = "pnl_bgCash";
            this.pnl_bgCash.Size = new System.Drawing.Size(564, 216);
            this.pnl_bgCash.TabIndex = 0;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_subtotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_subtotal.Location = new System.Drawing.Point(430, 79);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(49, 28);
            this.lbl_subtotal.TabIndex = 5;
            this.lbl_subtotal.Text = "0.00";
            // 
            // lbl__discount
            // 
            this.lbl__discount.AutoSize = true;
            this.lbl__discount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl__discount.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl__discount.Location = new System.Drawing.Point(431, 34);
            this.lbl__discount.Name = "lbl__discount";
            this.lbl__discount.Size = new System.Drawing.Size(49, 28);
            this.lbl__discount.TabIndex = 4;
            this.lbl__discount.Text = "0.00";
            // 
            // pnl_totalBG
            // 
            this.pnl_totalBG.BackColor = System.Drawing.Color.Linen;
            this.pnl_totalBG.Controls.Add(this.lbl_total);
            this.pnl_totalBG.Controls.Add(this.Total);
            this.pnl_totalBG.Location = new System.Drawing.Point(55, 131);
            this.pnl_totalBG.Name = "pnl_totalBG";
            this.pnl_totalBG.Size = new System.Drawing.Size(478, 57);
            this.pnl_totalBG.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbl_total.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_total.Location = new System.Drawing.Point(375, 13);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(50, 28);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "0.00";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.Total.ForeColor = System.Drawing.Color.DarkRed;
            this.Total.Location = new System.Drawing.Point(10, 13);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(55, 28);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total";
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Subtotal.ForeColor = System.Drawing.Color.DarkRed;
            this.Subtotal.Location = new System.Drawing.Point(65, 79);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(87, 28);
            this.Subtotal.TabIndex = 1;
            this.Subtotal.Text = "Subtotal";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Discount.ForeColor = System.Drawing.Color.DarkRed;
            this.Discount.Location = new System.Drawing.Point(65, 34);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(130, 28);
            this.Discount.TabIndex = 0;
            this.Discount.Text = "No. of Orders";
            // 
            // pnl_flp
            // 
            this.pnl_flp.Controls.Add(this.flp_sales);
            this.pnl_flp.Controls.Add(this.flp_categories);
            this.pnl_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_flp.Location = new System.Drawing.Point(0, 0);
            this.pnl_flp.Name = "pnl_flp";
            this.pnl_flp.Size = new System.Drawing.Size(1378, 976);
            this.pnl_flp.TabIndex = 24;
            // 
            // flp_categories
            // 
            this.flp_categories.BackColor = System.Drawing.Color.Bisque;
            this.flp_categories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_categories.Location = new System.Drawing.Point(0, 823);
            this.flp_categories.Name = "flp_categories";
            this.flp_categories.Size = new System.Drawing.Size(1378, 153);
            this.flp_categories.TabIndex = 27;
            // 
            // flp_sales
            // 
            this.flp_sales.BackColor = System.Drawing.Color.NavajoWhite;
            this.flp_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_sales.Location = new System.Drawing.Point(0, 0);
            this.flp_sales.Name = "flp_sales";
            this.flp_sales.Size = new System.Drawing.Size(1378, 823);
            this.flp_sales.TabIndex = 26;
            this.flp_sales.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_sales_Paint);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 847);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1353, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 847);
            this.panel2.TabIndex = 26;
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
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_details.ResumeLayout(false);
            this.pnl_details.PerformLayout();
            this.pnl_bgCash.ResumeLayout(false);
            this.pnl_bgCash.PerformLayout();
            this.pnl_totalBG.ResumeLayout(false);
            this.pnl_totalBG.PerformLayout();
            this.pnl_flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_bg;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_details;
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
        private System.Windows.Forms.TextBox txt_transactNo;
        private System.Windows.Forms.Panel linepanel_transact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel line_username;
        private System.Windows.Forms.FlowLayoutPanel flp_billDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cash;
        private System.Windows.Forms.Label txt_change;
        private System.Windows.Forms.Panel line_cash;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_flp;
        private System.Windows.Forms.FlowLayoutPanel flp_categories;
        private System.Windows.Forms.FlowLayoutPanel flp_sales;
        private System.Windows.Forms.ComboBox cb_availtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}