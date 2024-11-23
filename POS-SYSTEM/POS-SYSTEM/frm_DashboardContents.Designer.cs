namespace POS_SYSTEM
{
    partial class frm_DashboardContents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DashboardContents));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pnl_bgStats = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_clock = new System.Windows.Forms.Panel();
            this.pnl_calendar = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.chart_sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnl_bgStats.SuspendLayout();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_products)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.chart_products);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(837, 361);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1105, 672);
            this.panel13.TabIndex = 35;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Controls.Add(this.chart_sales);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 361);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(837, 672);
            this.panel12.TabIndex = 34;
            // 
            // pnl_bgStats
            // 
            this.pnl_bgStats.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_bgStats.Controls.Add(this.panel11);
            this.pnl_bgStats.Controls.Add(this.panel8);
            this.pnl_bgStats.Controls.Add(this.panel10);
            this.pnl_bgStats.Controls.Add(this.panel9);
            this.pnl_bgStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bgStats.Location = new System.Drawing.Point(0, 153);
            this.pnl_bgStats.Name = "pnl_bgStats";
            this.pnl_bgStats.Size = new System.Drawing.Size(1942, 208);
            this.pnl_bgStats.TabIndex = 33;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkOrange;
            this.panel11.Location = new System.Drawing.Point(1212, 32);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(284, 142);
            this.panel11.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkOrange;
            this.panel8.Location = new System.Drawing.Point(141, 32);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 142);
            this.panel8.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkOrange;
            this.panel10.Location = new System.Drawing.Point(857, 32);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(284, 142);
            this.panel10.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkOrange;
            this.panel9.Location = new System.Drawing.Point(499, 32);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(284, 142);
            this.panel9.TabIndex = 19;
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
            this.pnl_top.TabIndex = 32;
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
            this.label1.Size = new System.Drawing.Size(405, 67);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sales Dashboard";
            // 
            // chart_sales
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_sales.ChartAreas.Add(chartArea2);
            this.chart_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_sales.Legends.Add(legend2);
            this.chart_sales.Location = new System.Drawing.Point(0, 0);
            this.chart_sales.Name = "chart_sales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_sales.Series.Add(series2);
            this.chart_sales.Size = new System.Drawing.Size(837, 672);
            this.chart_sales.TabIndex = 0;
            this.chart_sales.Text = "chart1";
            // 
            // chart_products
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_products.ChartAreas.Add(chartArea1);
            this.chart_products.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_products.Legends.Add(legend1);
            this.chart_products.Location = new System.Drawing.Point(0, 0);
            this.chart_products.Name = "chart_products";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_products.Series.Add(series1);
            this.chart_products.Size = new System.Drawing.Size(1105, 672);
            this.chart_products.TabIndex = 1;
            this.chart_products.Text = "chart1";
            // 
            // frm_DashboardContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1033);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.pnl_bgStats);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DashboardContents";
            this.Text = "frm_DashboardContents";
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.pnl_bgStats.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel pnl_bgStats;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_clock;
        private System.Windows.Forms.Panel pnl_calendar;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_products;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sales;
    }
}