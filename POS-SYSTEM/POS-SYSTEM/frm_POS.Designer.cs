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
            this.pnl_flp = new System.Windows.Forms.Panel();
            this.flp_sales = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_category = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.linepanel_transact = new System.Windows.Forms.Panel();
            this.txt_transactNo = new System.Windows.Forms.TextBox();
            this.pnl_clock = new System.Windows.Forms.Panel();
            this.pnl_calendar = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_details = new System.Windows.Forms.Panel();
            this.cmb_serveMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_availtb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.line_cash = new System.Windows.Forms.Panel();
            this.txt_change = new System.Windows.Forms.Label();
            this.txt_cash = new System.Windows.Forms.TextBox();
            this.flp_billDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_paymentMethod = new System.Windows.Forms.ComboBox();
            this.pnl_bgCash = new System.Windows.Forms.Panel();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_order = new System.Windows.Forms.Label();
            this.pnl_totalBG = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnl_bg.SuspendLayout();
            this.pnl_flp.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.pnl_details.SuspendLayout();
            this.flp_billDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_bgCash.SuspendLayout();
            this.pnl_totalBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_bg
            // 
            this.pnl_bg.BackColor = System.Drawing.Color.MistyRose;
            this.pnl_bg.Controls.Add(this.pnl_flp);
            this.pnl_bg.Controls.Add(this.panel2);
            this.pnl_bg.Controls.Add(this.pnl_top);
            this.pnl_bg.Controls.Add(this.pnl_bottom);
            this.pnl_bg.Controls.Add(this.panel1);
            this.pnl_bg.Controls.Add(this.pnl_details);
            this.pnl_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bg.Location = new System.Drawing.Point(0, 0);
            this.pnl_bg.Name = "pnl_bg";
            this.pnl_bg.Size = new System.Drawing.Size(1942, 1102);
            this.pnl_bg.TabIndex = 3;
            // 
            // pnl_flp
            // 
            this.pnl_flp.Controls.Add(this.flp_sales);
            this.pnl_flp.Controls.Add(this.flp_category);
            this.pnl_flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_flp.Location = new System.Drawing.Point(25, 129);
            this.pnl_flp.Name = "pnl_flp";
            this.pnl_flp.Size = new System.Drawing.Size(1328, 847);
            this.pnl_flp.TabIndex = 24;
            // 
            // flp_sales
            // 
            this.flp_sales.AutoScroll = true;
            this.flp_sales.AutoSize = true;
            this.flp_sales.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.flp_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_sales.Location = new System.Drawing.Point(0, 0);
            this.flp_sales.Name = "flp_sales";
            this.flp_sales.Size = new System.Drawing.Size(1328, 727);
            this.flp_sales.TabIndex = 28;
            // 
            // flp_category
            // 
            this.flp_category.AutoScroll = true;
            this.flp_category.BackColor = System.Drawing.Color.Bisque;
            this.flp_category.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp_category.Location = new System.Drawing.Point(0, 727);
            this.flp_category.Name = "flp_category";
            this.flp_category.Size = new System.Drawing.Size(1328, 120);
            this.flp_category.TabIndex = 29;
            this.flp_category.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1353, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 847);
            this.panel2.TabIndex = 26;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.BurlyWood;
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.linepanel_transact);
            this.pnl_top.Controls.Add(this.txt_transactNo);
            this.pnl_top.Controls.Add(this.pnl_clock);
            this.pnl_top.Controls.Add(this.pnl_calendar);
            this.pnl_top.Controls.Add(this.lbl_time);
            this.pnl_top.Controls.Add(this.lbl_date);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(25, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1353, 129);
            this.pnl_top.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(714, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order No.";
            // 
            // linepanel_transact
            // 
            this.linepanel_transact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linepanel_transact.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.linepanel_transact.Location = new System.Drawing.Point(904, 95);
            this.linepanel_transact.Name = "linepanel_transact";
            this.linepanel_transact.Size = new System.Drawing.Size(390, 1);
            this.linepanel_transact.TabIndex = 22;
            // 
            // txt_transactNo
            // 
            this.txt_transactNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_transactNo.BackColor = System.Drawing.Color.BurlyWood;
            this.txt_transactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_transactNo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.txt_transactNo.ForeColor = System.Drawing.Color.FloralWhite;
            this.txt_transactNo.Location = new System.Drawing.Point(904, 46);
            this.txt_transactNo.Name = "txt_transactNo";
            this.txt_transactNo.ReadOnly = true;
            this.txt_transactNo.Size = new System.Drawing.Size(382, 45);
            this.txt_transactNo.TabIndex = 0;
            // 
            // pnl_clock
            // 
            this.pnl_clock.BackColor = System.Drawing.Color.BurlyWood;
            this.pnl_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_clock.BackgroundImage")));
            this.pnl_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_clock.Location = new System.Drawing.Point(27, 71);
            this.pnl_clock.Name = "pnl_clock";
            this.pnl_clock.Size = new System.Drawing.Size(52, 32);
            this.pnl_clock.TabIndex = 26;
            // 
            // pnl_calendar
            // 
            this.pnl_calendar.BackColor = System.Drawing.Color.BurlyWood;
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
            this.lbl_time.ForeColor = System.Drawing.Color.FloralWhite;
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
            this.lbl_date.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_date.Location = new System.Drawing.Point(82, 14);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(68, 35);
            this.lbl_date.TabIndex = 23;
            this.lbl_date.Text = "Date";
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.BackColor = System.Drawing.Color.BurlyWood;
            this.pnl_bottom.Controls.Add(this.btn_history);
            this.pnl_bottom.Controls.Add(this.btn_exit);
            this.pnl_bottom.Controls.Add(this.btn_newOrder);
            this.pnl_bottom.Controls.Add(this.btn_confirm);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(25, 976);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(1353, 126);
            this.pnl_bottom.TabIndex = 23;
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.Peru;
            this.btn_history.FlatAppearance.BorderSize = 0;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_history.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_history.Location = new System.Drawing.Point(364, 38);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(230, 59);
            this.btn_history.TabIndex = 0;
            this.btn_history.Text = "Order History";
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Peru;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_exit.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_exit.Location = new System.Drawing.Point(88, 38);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(189, 59);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.BackColor = System.Drawing.Color.Peru;
            this.btn_newOrder.FlatAppearance.BorderSize = 0;
            this.btn_newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_newOrder.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_newOrder.Location = new System.Drawing.Point(696, 38);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(222, 59);
            this.btn_newOrder.TabIndex = 0;
            this.btn_newOrder.Text = "New Order";
            this.btn_newOrder.UseVisualStyleBackColor = false;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Peru;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_confirm.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_confirm.Location = new System.Drawing.Point(1015, 38);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(261, 59);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "Confirm Order";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 1102);
            this.panel1.TabIndex = 25;
            // 
            // pnl_details
            // 
            this.pnl_details.BackColor = System.Drawing.Color.BurlyWood;
            this.pnl_details.Controls.Add(this.cmb_serveMode);
            this.pnl_details.Controls.Add(this.label6);
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
            // cmb_serveMode
            // 
            this.cmb_serveMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_serveMode.BackColor = System.Drawing.Color.Ivory;
            this.cmb_serveMode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmb_serveMode.FormattingEnabled = true;
            this.cmb_serveMode.Items.AddRange(new object[] {
            "Dine In",
            "Takeout"});
            this.cmb_serveMode.Location = new System.Drawing.Point(336, 902);
            this.cmb_serveMode.Name = "cmb_serveMode";
            this.cmb_serveMode.Size = new System.Drawing.Size(161, 36);
            this.cmb_serveMode.TabIndex = 0;
            this.cmb_serveMode.Text = "Select Mode";
            this.cmb_serveMode.SelectedIndexChanged += new System.EventHandler(this.cmb_serveMode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(64, 910);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Service Mode";
            // 
            // cb_availtb
            // 
            this.cb_availtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_availtb.BackColor = System.Drawing.Color.Ivory;
            this.cb_availtb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_availtb.FormattingEnabled = true;
            this.cb_availtb.Location = new System.Drawing.Point(336, 959);
            this.cb_availtb.Name = "cb_availtb";
            this.cb_availtb.Size = new System.Drawing.Size(161, 36);
            this.cb_availtb.TabIndex = 0;
            this.cb_availtb.Text = "Select Table";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(64, 967);
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
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(63, 856);
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
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(63, 806);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cash ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(201, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Order Details";
            // 
            // line_cash
            // 
            this.line_cash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.line_cash.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.line_cash.Location = new System.Drawing.Point(335, 833);
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
            this.txt_change.ForeColor = System.Drawing.Color.FloralWhite;
            this.txt_change.Location = new System.Drawing.Point(353, 856);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(49, 28);
            this.txt_change.TabIndex = 10;
            this.txt_change.Text = "0.00";
            // 
            // txt_cash
            // 
            this.txt_cash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cash.BackColor = System.Drawing.Color.BurlyWood;
            this.txt_cash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cash.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_cash.ForeColor = System.Drawing.Color.FloralWhite;
            this.txt_cash.Location = new System.Drawing.Point(335, 804);
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(143, 27);
            this.txt_cash.TabIndex = 0;
            this.txt_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flp_billDetails
            // 
            this.flp_billDetails.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.flp_billDetails.Controls.Add(this.tableLayoutPanel1);
            this.flp_billDetails.Location = new System.Drawing.Point(10, 56);
            this.flp_billDetails.Name = "flp_billDetails";
            this.flp_billDetails.Size = new System.Drawing.Size(515, 452);
            this.flp_billDetails.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FloralWhite;
            this.panel8.Controls.Add(this.label12);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(423, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(84, 44);
            this.panel8.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(3, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Remove";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FloralWhite;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(345, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(72, 44);
            this.panel7.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Price";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FloralWhite;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(249, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(90, 44);
            this.panel6.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(7, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Quantity";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FloralWhite;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(147, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 44);
            this.panel5.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(9, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Category";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FloralWhite;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 44);
            this.panel4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(24, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "Item Info";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(64, 1017);
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
            this.cmb_paymentMethod.Location = new System.Drawing.Point(336, 1009);
            this.cmb_paymentMethod.Name = "cmb_paymentMethod";
            this.cmb_paymentMethod.Size = new System.Drawing.Size(161, 36);
            this.cmb_paymentMethod.TabIndex = 0;
            this.cmb_paymentMethod.Text = "Select Payment";
            this.cmb_paymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmb_paymentMethod_SelectedIndexChanged);
            // 
            // pnl_bgCash
            // 
            this.pnl_bgCash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_bgCash.BackColor = System.Drawing.Color.Bisque;
            this.pnl_bgCash.Controls.Add(this.lbl_tax);
            this.pnl_bgCash.Controls.Add(this.panel9);
            this.pnl_bgCash.Controls.Add(this.txt_discount);
            this.pnl_bgCash.Controls.Add(this.lbl_subtotal);
            this.pnl_bgCash.Controls.Add(this.label15);
            this.pnl_bgCash.Controls.Add(this.label14);
            this.pnl_bgCash.Controls.Add(this.label13);
            this.pnl_bgCash.Controls.Add(this.lbl_order);
            this.pnl_bgCash.Controls.Add(this.pnl_totalBG);
            this.pnl_bgCash.Controls.Add(this.Discount);
            this.pnl_bgCash.Location = new System.Drawing.Point(10, 520);
            this.pnl_bgCash.Name = "pnl_bgCash";
            this.pnl_bgCash.Size = new System.Drawing.Size(515, 265);
            this.pnl_bgCash.TabIndex = 0;
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_tax.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_tax.Location = new System.Drawing.Point(367, 148);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(49, 28);
            this.lbl_tax.TabIndex = 27;
            this.lbl_tax.Text = "0.00";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel9.Location = new System.Drawing.Point(365, 87);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(50, 1);
            this.panel9.TabIndex = 26;
            // 
            // txt_discount
            // 
            this.txt_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_discount.BackColor = System.Drawing.Color.Bisque;
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_discount.ForeColor = System.Drawing.Color.Crimson;
            this.txt_discount.Location = new System.Drawing.Point(368, 61);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(43, 27);
            this.txt_discount.TabIndex = 0;
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_subtotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_subtotal.Location = new System.Drawing.Point(367, 107);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(49, 28);
            this.lbl_subtotal.TabIndex = 24;
            this.lbl_subtotal.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(53, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 28);
            this.label15.TabIndex = 7;
            this.label15.Text = "Tax (12%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(50, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 28);
            this.label14.TabIndex = 6;
            this.label14.Text = "Sub Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(50, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 28);
            this.label13.TabIndex = 5;
            this.label13.Text = "Discount (%)";
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_order.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_order.Location = new System.Drawing.Point(369, 19);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(49, 28);
            this.lbl_order.TabIndex = 4;
            this.lbl_order.Text = "0.00";
            // 
            // pnl_totalBG
            // 
            this.pnl_totalBG.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_totalBG.Controls.Add(this.lbl_total);
            this.pnl_totalBG.Controls.Add(this.Total);
            this.pnl_totalBG.Location = new System.Drawing.Point(27, 198);
            this.pnl_totalBG.Name = "pnl_totalBG";
            this.pnl_totalBG.Size = new System.Drawing.Size(460, 57);
            this.pnl_totalBG.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbl_total.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_total.Location = new System.Drawing.Point(339, 13);
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
            this.Total.Location = new System.Drawing.Point(23, 13);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(55, 28);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Discount.ForeColor = System.Drawing.Color.DarkRed;
            this.Discount.Location = new System.Drawing.Point(50, 19);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(118, 28);
            this.Discount.TabIndex = 0;
            this.Discount.Text = "No. of Items";
            // 
            // frm_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.pnl_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_bg.ResumeLayout(false);
            this.pnl_flp.ResumeLayout(false);
            this.pnl_flp.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_details.ResumeLayout(false);
            this.pnl_details.PerformLayout();
            this.flp_billDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl_bgCash.ResumeLayout(false);
            this.pnl_bgCash.PerformLayout();
            this.pnl_totalBG.ResumeLayout(false);
            this.pnl_totalBG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_bg;
        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Panel pnl_bgCash;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Panel pnl_totalBG;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_newOrder;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_paymentMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flp_billDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cash;
        private System.Windows.Forms.Label txt_change;
        private System.Windows.Forms.Panel line_cash;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_flp;
        private System.Windows.Forms.ComboBox cb_availtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel linepanel_transact;
        private System.Windows.Forms.TextBox txt_transactNo;
        private System.Windows.Forms.Panel pnl_clock;
        private System.Windows.Forms.Panel pnl_calendar;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flp_sales;
        private System.Windows.Forms.FlowLayoutPanel flp_category;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_serveMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}