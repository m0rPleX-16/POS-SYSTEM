namespace POS_SYSTEM
{
    partial class frm_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reports));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_clock = new System.Windows.Forms.Panel();
            this.pnl_calendar = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panel13 = new System.Windows.Forms.Panel();
            this.pnl_bgStats = new System.Windows.Forms.Panel();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl_lastmonth = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_todaySale = new System.Windows.Forms.Label();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.line_username = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.pnl_bgStats.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.pnl_clock);
            this.pnl_top.Controls.Add(this.pnl_calendar);
            this.pnl_top.Controls.Add(this.lbl_time);
            this.pnl_top.Controls.Add(this.lbl_date);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1942, 153);
            this.pnl_top.TabIndex = 22;
            // 
            // pnl_clock
            // 
            this.pnl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_clock.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_clock.BackgroundImage")));
            this.pnl_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_clock.Location = new System.Drawing.Point(1200, 81);
            this.pnl_clock.Name = "pnl_clock";
            this.pnl_clock.Size = new System.Drawing.Size(55, 43);
            this.pnl_clock.TabIndex = 20;
            // 
            // pnl_calendar
            // 
            this.pnl_calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_calendar.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_calendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_calendar.BackgroundImage")));
            this.pnl_calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_calendar.Location = new System.Drawing.Point(1200, 24);
            this.pnl_calendar.Name = "pnl_calendar";
            this.pnl_calendar.Size = new System.Drawing.Size(55, 43);
            this.pnl_calendar.TabIndex = 19;
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_time.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_time.Location = new System.Drawing.Point(1258, 78);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(96, 46);
            this.lbl_time.TabIndex = 18;
            this.lbl_time.Text = "Time";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lbl_date.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_date.Location = new System.Drawing.Point(1258, 21);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(92, 46);
            this.lbl_date.TabIndex = 17;
            this.lbl_date.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reports";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 272);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1942, 830);
            this.panel13.TabIndex = 31;
            // 
            // pnl_bgStats
            // 
            this.pnl_bgStats.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_bgStats.Controls.Add(this.label5);
            this.pnl_bgStats.Controls.Add(this.label4);
            this.pnl_bgStats.Controls.Add(this.TableLayoutPanel1);
            this.pnl_bgStats.Controls.Add(this.btn_Export);
            this.pnl_bgStats.Controls.Add(this.btn_Filter);
            this.pnl_bgStats.Controls.Add(this.DateTimePicker2);
            this.pnl_bgStats.Controls.Add(this.DateTimePicker1);
            this.pnl_bgStats.Controls.Add(this.btn_search);
            this.pnl_bgStats.Controls.Add(this.line_username);
            this.pnl_bgStats.Controls.Add(this.txt_search);
            this.pnl_bgStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bgStats.Location = new System.Drawing.Point(0, 153);
            this.pnl_bgStats.Name = "pnl_bgStats";
            this.pnl_bgStats.Size = new System.Drawing.Size(1942, 119);
            this.pnl_bgStats.TabIndex = 29;
            this.pnl_bgStats.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_bgStats_Paint);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.SeaShell;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Controls.Add(this.Panel4, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel3, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(1587, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(355, 119);
            this.TableLayoutPanel1.TabIndex = 31;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.lbl_lastmonth);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(180, 3);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(172, 113);
            this.Panel4.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(17, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(146, 28);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Monthly Sales";
            // 
            // lbl_lastmonth
            // 
            this.lbl_lastmonth.AutoSize = true;
            this.lbl_lastmonth.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbl_lastmonth.ForeColor = System.Drawing.Color.White;
            this.lbl_lastmonth.Location = new System.Drawing.Point(64, 73);
            this.lbl_lastmonth.Name = "lbl_lastmonth";
            this.lbl_lastmonth.Size = new System.Drawing.Size(55, 30);
            this.lbl_lastmonth.TabIndex = 2;
            this.lbl_lastmonth.Text = "0.00";
            this.lbl_lastmonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Magenta;
            this.Panel3.Controls.Add(this.label3);
            this.Panel3.Controls.Add(this.lbl_todaySale);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(3, 3);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(171, 113);
            this.Panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Today\'s Sales";
            // 
            // lbl_todaySale
            // 
            this.lbl_todaySale.AutoSize = true;
            this.lbl_todaySale.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbl_todaySale.ForeColor = System.Drawing.Color.White;
            this.lbl_todaySale.Location = new System.Drawing.Point(57, 68);
            this.lbl_todaySale.Name = "lbl_todaySale";
            this.lbl_todaySale.Size = new System.Drawing.Size(55, 30);
            this.lbl_todaySale.TabIndex = 0;
            this.lbl_todaySale.Text = "0.00";
            this.lbl_todaySale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(1377, 26);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(200, 70);
            this.btn_Export.TabIndex = 30;
            this.btn_Export.Text = "Export to Excel";
            this.btn_Export.UseVisualStyleBackColor = false;
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(108)))), ((int)(((byte)(254)))));
            this.btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Filter.FlatAppearance.BorderSize = 0;
            this.btn_Filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btn_Filter.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.Location = new System.Drawing.Point(1200, 26);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(145, 70);
            this.btn_Filter.TabIndex = 29;
            this.btn_Filter.Text = "FILTER";
            this.btn_Filter.UseVisualStyleBackColor = false;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.CalendarForeColor = System.Drawing.Color.White;
            this.DateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateTimePicker2.Location = new System.Drawing.Point(879, 61);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(251, 22);
            this.DateTimePicker2.TabIndex = 28;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateTimePicker1.Location = new System.Drawing.Point(601, 61);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.DateTimePicker1.TabIndex = 27;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(414, 42);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(48, 46);
            this.btn_search.TabIndex = 25;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // line_username
            // 
            this.line_username.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.line_username.Location = new System.Drawing.Point(32, 87);
            this.line_username.Name = "line_username";
            this.line_username.Size = new System.Drawing.Size(430, 1);
            this.line_username.TabIndex = 24;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.txt_search.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_search.Location = new System.Drawing.Point(32, 54);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(373, 29);
            this.txt_search.TabIndex = 23;
            this.txt_search.Text = "Search";
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
            this.btn_close.Location = new System.Drawing.Point(1855, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 38);
            this.btn_close.TabIndex = 30;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(596, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(874, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "End Date:";
            // 
            // frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.pnl_bgStats);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bgStats.ResumeLayout(false);
            this.pnl_bgStats.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel pnl_bgStats;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel line_username;
        private System.Windows.Forms.TextBox txt_search;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbl_lastmonth;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lbl_todaySale;
        internal System.Windows.Forms.Button btn_Export;
        internal System.Windows.Forms.Button btn_Filter;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Panel pnl_clock;
        private System.Windows.Forms.Panel pnl_calendar;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        internal System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
    }
}