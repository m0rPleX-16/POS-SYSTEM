namespace POS_SYSTEM
{
    partial class frm_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Users));
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.line_username = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.pnl_bgStats = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_clock = new System.Windows.Forms.Panel();
            this.pnl_calendar = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.panel13.SuspendLayout();
            this.pnl_bgStats.SuspendLayout();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.dgv_users);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(505, 272);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1419, 756);
            this.panel13.TabIndex = 31;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 272);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(505, 756);
            this.panel12.TabIndex = 30;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txt_search.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_search.Location = new System.Drawing.Point(1432, 52);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(382, 36);
            this.txt_search.TabIndex = 23;
            this.txt_search.Text = "Search";
            // 
            // line_username
            // 
            this.line_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.line_username.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.line_username.Location = new System.Drawing.Point(1432, 88);
            this.line_username.Name = "line_username";
            this.line_username.Size = new System.Drawing.Size(430, 1);
            this.line_username.TabIndex = 24;
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
            this.btn_search.Location = new System.Drawing.Point(1811, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(51, 46);
            this.btn_search.TabIndex = 25;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // pnl_bgStats
            // 
            this.pnl_bgStats.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_bgStats.Controls.Add(this.btn_search);
            this.pnl_bgStats.Controls.Add(this.line_username);
            this.pnl_bgStats.Controls.Add(this.txt_search);
            this.pnl_bgStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bgStats.Location = new System.Drawing.Point(0, 153);
            this.pnl_bgStats.Name = "pnl_bgStats";
            this.pnl_bgStats.Size = new System.Drawing.Size(1924, 119);
            this.pnl_bgStats.TabIndex = 29;
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
            this.pnl_top.Size = new System.Drawing.Size(1924, 153);
            this.pnl_top.TabIndex = 33;
            this.pnl_top.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_top_Paint);
            // 
            // pnl_clock
            // 
            this.pnl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_clock.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_clock.BackgroundImage")));
            this.pnl_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_clock.Location = new System.Drawing.Point(1293, 85);
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
            this.pnl_calendar.Location = new System.Drawing.Point(1293, 28);
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
            this.lbl_time.Location = new System.Drawing.Point(1351, 82);
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
            this.lbl_date.Location = new System.Drawing.Point(1351, 25);
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
            this.label1.Size = new System.Drawing.Size(448, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Management";
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_users.Location = new System.Drawing.Point(0, 0);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersWidth = 51;
            this.dgv_users.RowTemplate.Height = 24;
            this.dgv_users.Size = new System.Drawing.Size(1419, 756);
            this.dgv_users.TabIndex = 1;
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1028);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.pnl_bgStats);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel13.ResumeLayout(false);
            this.pnl_bgStats.ResumeLayout(false);
            this.pnl_bgStats.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel line_username;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel pnl_bgStats;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_clock;
        private System.Windows.Forms.Panel pnl_calendar;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_users;
    }
}