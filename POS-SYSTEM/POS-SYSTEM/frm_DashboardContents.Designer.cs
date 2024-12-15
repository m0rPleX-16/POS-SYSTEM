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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_bgStats = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_clock = new System.Windows.Forms.Panel();
            this.pnl_calendar = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sales_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgv_bestSellers = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgv_orderHist = new System.Windows.Forms.DataGridView();
            this.orderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.image_base64 = new System.Windows.Forms.DataGridViewImageColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_bgStats.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_chart)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bestSellers)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bgStats
            // 
            this.pnl_bgStats.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_bgStats.Controls.Add(this.panel7);
            this.pnl_bgStats.Controls.Add(this.panel5);
            this.pnl_bgStats.Controls.Add(this.panel3);
            this.pnl_bgStats.Controls.Add(this.panel2);
            this.pnl_bgStats.Controls.Add(this.panel1);
            this.pnl_bgStats.Controls.Add(this.panel8);
            this.pnl_bgStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bgStats.Location = new System.Drawing.Point(0, 153);
            this.pnl_bgStats.Name = "pnl_bgStats";
            this.pnl_bgStats.Size = new System.Drawing.Size(1736, 318);
            this.pnl_bgStats.TabIndex = 33;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PeachPuff;
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(3, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 149);
            this.panel8.TabIndex = 18;
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
            this.pnl_top.Size = new System.Drawing.Size(1736, 153);
            this.pnl_top.TabIndex = 32;
            // 
            // pnl_clock
            // 
            this.pnl_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_clock.BackColor = System.Drawing.Color.SeaShell;
            this.pnl_clock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_clock.BackgroundImage")));
            this.pnl_clock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_clock.Location = new System.Drawing.Point(1105, 85);
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
            this.pnl_calendar.Location = new System.Drawing.Point(1105, 28);
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
            this.lbl_time.Location = new System.Drawing.Point(1163, 82);
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
            this.lbl_date.Location = new System.Drawing.Point(1163, 25);
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
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FloralWhite;
            this.panel12.Controls.Add(this.dgv_orderHist);
            this.panel12.Controls.Add(this.panel10);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 820);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1736, 213);
            this.panel12.TabIndex = 34;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.sales_chart);
            this.panel13.Controls.Add(this.panel4);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 471);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1736, 349);
            this.panel13.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(211, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 149);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 149);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(211, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 149);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1736, 43);
            this.panel4.TabIndex = 0;
            // 
            // sales_chart
            // 
            chartArea7.Name = "ChartArea1";
            this.sales_chart.ChartAreas.Add(chartArea7);
            this.sales_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.sales_chart.Legends.Add(legend7);
            this.sales_chart.Location = new System.Drawing.Point(0, 43);
            this.sales_chart.Margin = new System.Windows.Forms.Padding(4);
            this.sales_chart.Name = "sales_chart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.Legend = "Legend1";
            series7.Name = "Series";
            this.sales_chart.Series.Add(series7);
            this.sales_chart.Size = new System.Drawing.Size(1736, 306);
            this.sales_chart.TabIndex = 6;
            this.sales_chart.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel5.Controls.Add(this.dgv_bestSellers);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(430, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(640, 304);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(640, 47);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(1088, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(640, 306);
            this.panel7.TabIndex = 25;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(640, 47);
            this.panel9.TabIndex = 0;
            // 
            // dgv_bestSellers
            // 
            this.dgv_bestSellers.AllowUserToAddRows = false;
            this.dgv_bestSellers.AllowUserToDeleteRows = false;
            this.dgv_bestSellers.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgv_bestSellers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bestSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bestSellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image_base64,
            this.item_name,
            this.category_name,
            this.quantity_sold,
            this.price});
            this.dgv_bestSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bestSellers.Location = new System.Drawing.Point(0, 47);
            this.dgv_bestSellers.Name = "dgv_bestSellers";
            this.dgv_bestSellers.ReadOnly = true;
            this.dgv_bestSellers.RowHeadersVisible = false;
            this.dgv_bestSellers.RowHeadersWidth = 51;
            this.dgv_bestSellers.RowTemplate.Height = 24;
            this.dgv_bestSellers.Size = new System.Drawing.Size(640, 257);
            this.dgv_bestSellers.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1736, 43);
            this.panel10.TabIndex = 1;
            // 
            // dgv_orderHist
            // 
            this.dgv_orderHist.AllowUserToAddRows = false;
            this.dgv_orderHist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_orderHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dgv_orderHist.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgv_orderHist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_orderHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orderHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgv_orderHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNo,
            this.table_number,
            this.employee_id,
            this.total_price,
            this.status,
            this.date_added});
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orderHist.DefaultCellStyle = dataGridViewCellStyle40;
            this.dgv_orderHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orderHist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_orderHist.Location = new System.Drawing.Point(0, 43);
            this.dgv_orderHist.Name = "dgv_orderHist";
            this.dgv_orderHist.ReadOnly = true;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orderHist.RowHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgv_orderHist.RowHeadersVisible = false;
            this.dgv_orderHist.RowHeadersWidth = 51;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_orderHist.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dgv_orderHist.RowTemplate.Height = 24;
            this.dgv_orderHist.Size = new System.Drawing.Size(1736, 170);
            this.dgv_orderHist.TabIndex = 32;
            // 
            // orderNo
            // 
            this.orderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White;
            this.orderNo.DefaultCellStyle = dataGridViewCellStyle39;
            this.orderNo.HeaderText = "ORDER NO.";
            this.orderNo.MinimumWidth = 6;
            this.orderNo.Name = "orderNo";
            this.orderNo.ReadOnly = true;
            // 
            // table_number
            // 
            this.table_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.table_number.HeaderText = "TABLE NUMBER";
            this.table_number.MinimumWidth = 6;
            this.table_number.Name = "table_number";
            this.table_number.ReadOnly = true;
            // 
            // employee_id
            // 
            this.employee_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employee_id.HeaderText = "EMPLOYEE";
            this.employee_id.MinimumWidth = 6;
            this.employee_id.Name = "employee_id";
            this.employee_id.ReadOnly = true;
            this.employee_id.Width = 124;
            // 
            // total_price
            // 
            this.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total_price.HeaderText = "TOTAL PRICE";
            this.total_price.MinimumWidth = 6;
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
            this.total_price.Width = 129;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.HeaderText = "STATUS";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 101;
            // 
            // date_added
            // 
            this.date_added.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_added.HeaderText = "ORDER DATE";
            this.date_added.MinimumWidth = 6;
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(26, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sales Revenue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(26, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 35);
            this.label3.TabIndex = 14;
            this.label3.Text = "Recent Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(8, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Top Items of the Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(15, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Top Categories of the Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(30, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Daily Sales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monthly Sales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(19, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "Annual Sales";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(18, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 35);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Stocks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(28, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 46);
            this.label10.TabIndex = 14;
            this.label10.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(30, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 46);
            this.label11.TabIndex = 15;
            this.label11.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(28, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 46);
            this.label12.TabIndex = 16;
            this.label12.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(30, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 46);
            this.label13.TabIndex = 17;
            this.label13.Text = "0.00";
            // 
            // image_base64
            // 
            this.image_base64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.image_base64.HeaderText = "IMAGE";
            this.image_base64.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.image_base64.MinimumWidth = 6;
            this.image_base64.Name = "image_base64";
            this.image_base64.ReadOnly = true;
            this.image_base64.Width = 6;
            // 
            // item_name
            // 
            this.item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_name.HeaderText = "ITEM NAME";
            this.item_name.MinimumWidth = 6;
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // category_name
            // 
            this.category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.category_name.HeaderText = "CATEGORY";
            this.category_name.MinimumWidth = 6;
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            this.category_name.Width = 111;
            // 
            // quantity_sold
            // 
            this.quantity_sold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantity_sold.HeaderText = "QUANTITY SOLD";
            this.quantity_sold.MinimumWidth = 6;
            this.quantity_sold.Name = "quantity_sold";
            this.quantity_sold.ReadOnly = true;
            this.quantity_sold.Width = 132;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 76;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 259);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "CATEGORY NAME";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTITY SOLD";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 132;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "TOTAL PROFIT";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 121;
            // 
            // frm_DashboardContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 1033);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.pnl_bgStats);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DashboardContents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DashboardContents";
            this.pnl_bgStats.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_chart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bestSellers)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_bgStats;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_clock;
        private System.Windows.Forms.Panel pnl_calendar;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart sales_chart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv_bestSellers;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgv_orderHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewImageColumn image_base64;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_sold;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}