namespace POS_SYSTEM.inventory
{
    partial class inventory_ingridients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgv_ingridients = new System.Windows.Forms.DataGridView();
            this.ingredient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingridient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_archived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.expire_dtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_minquan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stockquan = new System.Windows.Forms.TextBox();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.txt_ingname = new System.Windows.Forms.TextBox();
            this.txt_ingid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_unarchive = new System.Windows.Forms.Button();
            this.btn_archive = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingridients)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.dgv_ingridients);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(470, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(946, 875);
            this.panel13.TabIndex = 33;
            // 
            // dgv_ingridients
            // 
            this.dgv_ingridients.AllowUserToAddRows = false;
            this.dgv_ingridients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_ingridients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dgv_ingridients.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_ingridients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ingridients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ingridients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgv_ingridients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingridients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredient_id,
            this.ingridient_name,
            this.unit,
            this.stock_quantity,
            this.minimum_quantity,
            this.expiration_date,
            this.date_updated,
            this.is_archived});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ingridients.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgv_ingridients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ingridients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_ingridients.Location = new System.Drawing.Point(0, 0);
            this.dgv_ingridients.Name = "dgv_ingridients";
            this.dgv_ingridients.ReadOnly = true;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ingridients.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dgv_ingridients.RowHeadersVisible = false;
            this.dgv_ingridients.RowHeadersWidth = 51;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_ingridients.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.dgv_ingridients.RowTemplate.Height = 24;
            this.dgv_ingridients.Size = new System.Drawing.Size(946, 875);
            this.dgv_ingridients.TabIndex = 2;
            // 
            // ingredient_id
            // 
            this.ingredient_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            this.ingredient_id.DefaultCellStyle = dataGridViewCellStyle36;
            this.ingredient_id.HeaderText = "INGREDIENT ID";
            this.ingredient_id.MinimumWidth = 6;
            this.ingredient_id.Name = "ingredient_id";
            this.ingredient_id.ReadOnly = true;
            this.ingredient_id.Visible = false;
            this.ingredient_id.Width = 125;
            // 
            // ingridient_name
            // 
            this.ingridient_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.ingridient_name.DefaultCellStyle = dataGridViewCellStyle37;
            this.ingridient_name.HeaderText = "INGREDIENT NAME";
            this.ingridient_name.MinimumWidth = 6;
            this.ingridient_name.Name = "ingridient_name";
            this.ingridient_name.ReadOnly = true;
            this.ingridient_name.Width = 177;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.unit.DefaultCellStyle = dataGridViewCellStyle38;
            this.unit.HeaderText = "UNIT";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 79;
            // 
            // stock_quantity
            // 
            this.stock_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.stock_quantity.DefaultCellStyle = dataGridViewCellStyle39;
            this.stock_quantity.HeaderText = "STOCK QUANTITY";
            this.stock_quantity.MinimumWidth = 6;
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.ReadOnly = true;
            this.stock_quantity.Width = 167;
            // 
            // minimum_quantity
            // 
            this.minimum_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.minimum_quantity.DefaultCellStyle = dataGridViewCellStyle40;
            this.minimum_quantity.HeaderText = "MIN. QUANTITY";
            this.minimum_quantity.MinimumWidth = 6;
            this.minimum_quantity.Name = "minimum_quantity";
            this.minimum_quantity.ReadOnly = true;
            this.minimum_quantity.Width = 154;
            // 
            // expiration_date
            // 
            this.expiration_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expiration_date.HeaderText = "EXPIRATION DATE";
            this.expiration_date.MinimumWidth = 6;
            this.expiration_date.Name = "expiration_date";
            this.expiration_date.ReadOnly = true;
            // 
            // date_updated
            // 
            this.date_updated.HeaderText = "DATE MODIFIED";
            this.date_updated.MinimumWidth = 6;
            this.date_updated.Name = "date_updated";
            this.date_updated.ReadOnly = true;
            this.date_updated.Width = 125;
            // 
            // is_archived
            // 
            this.is_archived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.is_archived.DefaultCellStyle = dataGridViewCellStyle41;
            this.is_archived.HeaderText = "DISABLED";
            this.is_archived.MinimumWidth = 6;
            this.is_archived.Name = "is_archived";
            this.is_archived.ReadOnly = true;
            this.is_archived.Width = 121;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.expire_dtp);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Controls.Add(this.txt_minquan);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.txt_stockquan);
            this.panel12.Controls.Add(this.txt_unit);
            this.panel12.Controls.Add(this.txt_ingname);
            this.panel12.Controls.Add(this.txt_ingid);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(470, 875);
            this.panel12.TabIndex = 32;
            // 
            // expire_dtp
            // 
            this.expire_dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.expire_dtp.Location = new System.Drawing.Point(226, 427);
            this.expire_dtp.Name = "expire_dtp";
            this.expire_dtp.Size = new System.Drawing.Size(216, 30);
            this.expire_dtp.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(27, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 51;
            this.label3.Text = "Expiration Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(27, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 50;
            this.label2.Text = "Min. Quantity";
            // 
            // txt_minquan
            // 
            this.txt_minquan.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_minquan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_minquan.Location = new System.Drawing.Point(226, 359);
            this.txt_minquan.Name = "txt_minquan";
            this.txt_minquan.Size = new System.Drawing.Size(216, 34);
            this.txt_minquan.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(29, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "Stock Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(27, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(27, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 28);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ingredient name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(25, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 28);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ingredient ID";
            // 
            // txt_stockquan
            // 
            this.txt_stockquan.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_stockquan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_stockquan.Location = new System.Drawing.Point(228, 290);
            this.txt_stockquan.Name = "txt_stockquan";
            this.txt_stockquan.Size = new System.Drawing.Size(216, 34);
            this.txt_stockquan.TabIndex = 35;
            // 
            // txt_unit
            // 
            this.txt_unit.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_unit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_unit.Location = new System.Drawing.Point(228, 221);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(216, 34);
            this.txt_unit.TabIndex = 34;
            // 
            // txt_ingname
            // 
            this.txt_ingname.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_ingname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ingname.Location = new System.Drawing.Point(228, 153);
            this.txt_ingname.Name = "txt_ingname";
            this.txt_ingname.Size = new System.Drawing.Size(216, 34);
            this.txt_ingname.TabIndex = 33;
            // 
            // txt_ingid
            // 
            this.txt_ingid.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_ingid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ingid.Location = new System.Drawing.Point(226, 88);
            this.txt_ingid.Name = "txt_ingid";
            this.txt_ingid.Size = new System.Drawing.Size(218, 34);
            this.txt_ingid.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingredients";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_unarchive);
            this.panel1.Controls.Add(this.btn_archive);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(1, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 206);
            this.panel1.TabIndex = 55;
            // 
            // btn_unarchive
            // 
            this.btn_unarchive.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_unarchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_unarchive.FlatAppearance.BorderSize = 0;
            this.btn_unarchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unarchive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unarchive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_unarchive.Location = new System.Drawing.Point(254, 115);
            this.btn_unarchive.Name = "btn_unarchive";
            this.btn_unarchive.Size = new System.Drawing.Size(139, 58);
            this.btn_unarchive.TabIndex = 36;
            this.btn_unarchive.Text = "Unarchive";
            this.btn_unarchive.UseVisualStyleBackColor = false;
            // 
            // btn_archive
            // 
            this.btn_archive.BackColor = System.Drawing.Color.Orange;
            this.btn_archive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_archive.FlatAppearance.BorderSize = 0;
            this.btn_archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_archive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_archive.Location = new System.Drawing.Point(82, 115);
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.Size = new System.Drawing.Size(124, 58);
            this.btn_archive.TabIndex = 35;
            this.btn_archive.Text = "Archive";
            this.btn_archive.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.Location = new System.Drawing.Point(334, 31);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(93, 58);
            this.btn_edit.TabIndex = 34;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.SlateGray;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Location = new System.Drawing.Point(193, 31);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 58);
            this.btn_clear.TabIndex = 33;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(53, 31);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 58);
            this.btn_save.TabIndex = 32;
            this.btn_save.Text = "Add";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // inventory_ingridients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Name = "inventory_ingridients";
            this.Size = new System.Drawing.Size(1416, 875);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingridients)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DataGridView dgv_ingridients;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_stockquan;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.TextBox txt_ingname;
        private System.Windows.Forms.TextBox txt_ingid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_minquan;
        private System.Windows.Forms.DateTimePicker expire_dtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingridient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimum_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiration_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_archived;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_unarchive;
        private System.Windows.Forms.Button btn_archive;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
    }
}
