namespace POS_SYSTEM
{
    partial class frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_POS = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lbl_about = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_role = new System.Windows.Forms.Label();
            this.pnl_pfview = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_user = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pnl_display = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.pnl_pfview.SuspendLayout();
            this.pnl_display.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Wheat;
            this.panel_menu.Controls.Add(this.btn_logout);
            this.panel_menu.Controls.Add(this.btn_users);
            this.panel_menu.Controls.Add(this.btn_reports);
            this.panel_menu.Controls.Add(this.btn_history);
            this.panel_menu.Controls.Add(this.btn_POS);
            this.panel_menu.Controls.Add(this.btn_inventory);
            this.panel_menu.Controls.Add(this.btn_dashboard);
            this.panel_menu.Controls.Add(this.panel14);
            this.panel_menu.Controls.Add(this.lbl_about);
            this.panel_menu.Controls.Add(this.panel7);
            this.panel_menu.Controls.Add(this.panel6);
            this.panel_menu.Controls.Add(this.panel5);
            this.panel_menu.Controls.Add(this.panel4);
            this.panel_menu.Controls.Add(this.panel3);
            this.panel_menu.Controls.Add(this.panel2);
            this.panel_menu.Controls.Add(this.lbl_role);
            this.panel_menu.Controls.Add(this.pnl_pfview);
            this.panel_menu.Controls.Add(this.lbl_user);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(309, 982);
            this.panel_menu.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Wheat;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_logout.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_logout.Location = new System.Drawing.Point(99, 934);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(191, 63);
            this.btn_logout.TabIndex = 42;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.Wheat;
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_users.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_users.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_users.Location = new System.Drawing.Point(99, 843);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(191, 63);
            this.btn_users.TabIndex = 41;
            this.btn_users.Text = "Users";
            this.btn_users.UseVisualStyleBackColor = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.Wheat;
            this.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reports.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_reports.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_reports.Location = new System.Drawing.Point(99, 750);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(191, 63);
            this.btn_reports.TabIndex = 40;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.Wheat;
            this.btn_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_history.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_history.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_history.Location = new System.Drawing.Point(99, 651);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(191, 63);
            this.btn_history.TabIndex = 39;
            this.btn_history.Text = "History";
            this.btn_history.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_POS
            // 
            this.btn_POS.BackColor = System.Drawing.Color.Wheat;
            this.btn_POS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_POS.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_POS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_POS.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_POS.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_POS.Location = new System.Drawing.Point(99, 559);
            this.btn_POS.Name = "btn_POS";
            this.btn_POS.Size = new System.Drawing.Size(191, 63);
            this.btn_POS.TabIndex = 38;
            this.btn_POS.Text = "Cashier";
            this.btn_POS.UseVisualStyleBackColor = false;
            this.btn_POS.Click += new System.EventHandler(this.btn_POS_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Wheat;
            this.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventory.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_inventory.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_inventory.Location = new System.Drawing.Point(99, 466);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(191, 63);
            this.btn_inventory.TabIndex = 37;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = false;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Wheat;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_dashboard.Location = new System.Drawing.Point(99, 371);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(191, 63);
            this.btn_dashboard.TabIndex = 36;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.BackColor = System.Drawing.Color.Wheat;
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Location = new System.Drawing.Point(24, 559);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(64, 63);
            this.panel14.TabIndex = 35;
            // 
            // lbl_about
            // 
            this.lbl_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_about.AutoSize = true;
            this.lbl_about.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lbl_about.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_about.Location = new System.Drawing.Point(50, 937);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(202, 23);
            this.lbl_about.TabIndex = 20;
            this.lbl_about.Text = "POS System @ 2024 etc. ";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Wheat;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(24, 934);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(64, 63);
            this.panel7.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Wheat;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(24, 843);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(64, 63);
            this.panel6.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Wheat;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(24, 750);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(64, 63);
            this.panel5.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(24, 651);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 63);
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(24, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 63);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(24, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 63);
            this.panel2.TabIndex = 18;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI Semibold", 25F);
            this.lbl_role.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_role.Location = new System.Drawing.Point(79, 251);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(126, 57);
            this.lbl_role.TabIndex = 20;
            this.lbl_role.Text = "ROLE";
            // 
            // pnl_pfview
            // 
            this.pnl_pfview.BackColor = System.Drawing.Color.Moccasin;
            this.pnl_pfview.Controls.Add(this.label2);
            this.pnl_pfview.Controls.Add(this.panel1);
            this.pnl_pfview.Location = new System.Drawing.Point(0, 1);
            this.pnl_pfview.Name = "pnl_pfview";
            this.pnl_pfview.Size = new System.Drawing.Size(378, 152);
            this.pnl_pfview.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HYHeadLine-Medium", 20F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(96, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 68);
            this.label2.TabIndex = 17;
            this.label2.Text = "EASYROLL \r\nPOS SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 87);
            this.panel1.TabIndex = 21;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_user.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_user.Location = new System.Drawing.Point(30, 205);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(243, 46);
            this.lbl_user.TabIndex = 19;
            this.lbl_user.Text = "Welcome user,";
            // 
            // pnl_display
            // 
            this.pnl_display.Controls.Add(this.panel8);
            this.pnl_display.Controls.Add(this.message);
            this.pnl_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_display.Location = new System.Drawing.Point(309, 0);
            this.pnl_display.Name = "pnl_display";
            this.pnl_display.Size = new System.Drawing.Size(1633, 982);
            this.pnl_display.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FloralWhite;
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(607, 181);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(406, 364);
            this.panel8.TabIndex = 19;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.FloralWhite;
            this.message.Font = new System.Drawing.Font("Segoe UI Semibold", 75F);
            this.message.ForeColor = System.Drawing.Color.DarkRed;
            this.message.Location = new System.Drawing.Point(149, 574);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(1345, 332);
            this.message.TabIndex = 0;
            this.message.Text = "ERROR 404\r\nOops! Page not found.";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1942, 982);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_display);
            this.Controls.Add(this.panel_menu);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.pnl_pfview.ResumeLayout(false);
            this.pnl_pfview.PerformLayout();
            this.pnl_display.ResumeLayout(false);
            this.pnl_display.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel pnl_pfview;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_about;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_POS;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel pnl_display;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Panel panel8;
    }
}