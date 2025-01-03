﻿namespace POS_SYSTEM
{
    partial class inventory_items
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory_items));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.image_base64 = new System.Windows.Forms.DataGridViewImageColumn();
            this.item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_archived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_unarchive = new System.Windows.Forms.Button();
            this.btn_archive = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.chk_available = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_ProdImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProdImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.dgv_items);
            this.panel13.Controls.Add(this.panel2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(470, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1014, 874);
            this.panel13.TabIndex = 33;
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToAddRows = false;
            this.dgv_items.AllowUserToDeleteRows = false;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dgv_items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_items.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.dgv_items.ColumnHeadersHeight = 29;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image_base64,
            this.item_id,
            this.item_name,
            this.category_name,
            this.price,
            this.date_added,
            this.is_available,
            this.is_archived});
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_items.DefaultCellStyle = dataGridViewCellStyle58;
            this.dgv_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_items.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_items.Location = new System.Drawing.Point(0, 0);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.ReadOnly = true;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_items.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dgv_items.RowHeadersVisible = false;
            this.dgv_items.RowHeadersWidth = 51;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_items.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.dgv_items.RowTemplate.Height = 24;
            this.dgv_items.Size = new System.Drawing.Size(1014, 797);
            this.dgv_items.TabIndex = 2;
            // 
            // image_base64
            // 
            this.image_base64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle51.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle51.NullValue")));
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.White;
            this.image_base64.DefaultCellStyle = dataGridViewCellStyle51;
            this.image_base64.HeaderText = "IMAGE";
            this.image_base64.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.image_base64.MinimumWidth = 6;
            this.image_base64.Name = "image_base64";
            this.image_base64.ReadOnly = true;
            this.image_base64.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image_base64.Width = 6;
            // 
            // item_id
            // 
            this.item_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.item_id.DefaultCellStyle = dataGridViewCellStyle52;
            this.item_id.HeaderText = "ITEM ID";
            this.item_id.MinimumWidth = 6;
            this.item_id.Name = "item_id";
            this.item_id.ReadOnly = true;
            this.item_id.Visible = false;
            // 
            // item_name
            // 
            this.item_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.item_name.DefaultCellStyle = dataGridViewCellStyle53;
            this.item_name.HeaderText = "ITEM NAME";
            this.item_name.MinimumWidth = 6;
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // category_name
            // 
            this.category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.category_name.DefaultCellStyle = dataGridViewCellStyle54;
            this.category_name.HeaderText = "CATEGORY";
            this.category_name.MinimumWidth = 6;
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.price.DefaultCellStyle = dataGridViewCellStyle55;
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // date_added
            // 
            this.date_added.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.date_added.DefaultCellStyle = dataGridViewCellStyle56;
            this.date_added.HeaderText = "ADDED AT";
            this.date_added.MinimumWidth = 6;
            this.date_added.Name = "date_added";
            this.date_added.ReadOnly = true;
            // 
            // is_available
            // 
            this.is_available.HeaderText = "AVAILABILITY";
            this.is_available.MinimumWidth = 6;
            this.is_available.Name = "is_available";
            this.is_available.ReadOnly = true;
            this.is_available.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_available.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.is_available.Width = 144;
            // 
            // is_archived
            // 
            this.is_archived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.is_archived.DefaultCellStyle = dataGridViewCellStyle57;
            this.is_archived.HeaderText = "DISABLE";
            this.is_archived.MinimumWidth = 6;
            this.is_archived.Name = "is_archived";
            this.is_archived.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.lblTotalPage);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblCurrentPage);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnFirst);
            this.panel2.Controls.Add(this.btnLast);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 797);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 77);
            this.panel2.TabIndex = 40;
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.lblTotalPage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalPage.Location = new System.Drawing.Point(166, 10);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(29, 35);
            this.lblTotalPage.TabIndex = 16;
            this.lblTotalPage.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(117, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 35);
            this.label9.TabIndex = 15;
            this.label9.Text = "Of";
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.lblCurrentPage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCurrentPage.Location = new System.Drawing.Point(82, 10);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(29, 35);
            this.lblCurrentPage.TabIndex = 14;
            this.lblCurrentPage.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 35);
            this.label11.TabIndex = 13;
            this.label11.Text = "Page";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnFirst.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFirst.Location = new System.Drawing.Point(445, 23);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(90, 36);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "FIRST";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLast.Location = new System.Drawing.Point(785, 23);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(90, 36);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "LAST";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNext.Location = new System.Drawing.Point(671, 23);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 36);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnPrev.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPrev.Location = new System.Drawing.Point(557, 23);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(90, 36);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "PREV";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.chk_available);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.cb_category);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.txt_price);
            this.panel12.Controls.Add(this.txt_itemname);
            this.panel12.Controls.Add(this.txt_itemID);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Controls.Add(this.pic_ProdImg);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(470, 874);
            this.panel12.TabIndex = 32;
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
            this.btn_unarchive.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.btn_unarchive.Click += new System.EventHandler(this.btn_unarchive_Click);
            // 
            // btn_archive
            // 
            this.btn_archive.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.btn_archive.Click += new System.EventHandler(this.btn_archive_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chk_available
            // 
            this.chk_available.AutoSize = true;
            this.chk_available.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.chk_available.ForeColor = System.Drawing.Color.FloralWhite;
            this.chk_available.Location = new System.Drawing.Point(156, 513);
            this.chk_available.Name = "chk_available";
            this.chk_available.Size = new System.Drawing.Size(131, 32);
            this.chk_available.TabIndex = 38;
            this.chk_available.Text = "Availability";
            this.chk_available.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(37, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Category";
            // 
            // cb_category
            // 
            this.cb_category.BackColor = System.Drawing.Color.FloralWhite;
            this.cb_category.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(196, 370);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(240, 36);
            this.cb_category.TabIndex = 25;
            this.cb_category.Text = "Select Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(35, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(35, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Item Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(33, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Item ID";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_price.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_price.Location = new System.Drawing.Point(196, 435);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(240, 34);
            this.txt_price.TabIndex = 20;
            // 
            // txt_itemname
            // 
            this.txt_itemname.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_itemname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_itemname.Location = new System.Drawing.Point(196, 302);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(240, 34);
            this.txt_itemname.TabIndex = 18;
            // 
            // txt_itemID
            // 
            this.txt_itemID.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_itemID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_itemID.Location = new System.Drawing.Point(194, 237);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.ReadOnly = true;
            this.txt_itemID.Size = new System.Drawing.Size(242, 34);
            this.txt_itemID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(204, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "*Please insert an image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(203, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Item Image";
            // 
            // pic_ProdImg
            // 
            this.pic_ProdImg.BackColor = System.Drawing.Color.NavajoWhite;
            this.pic_ProdImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ProdImg.Location = new System.Drawing.Point(32, 66);
            this.pic_ProdImg.Name = "pic_ProdImg";
            this.pic_ProdImg.Size = new System.Drawing.Size(142, 116);
            this.pic_ProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ProdImg.TabIndex = 14;
            this.pic_ProdImg.TabStop = false;
            this.pic_ProdImg.Click += new System.EventHandler(this.pic_ProdImg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Items";
            // 
            // inventory_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Name = "inventory_items";
            this.Size = new System.Drawing.Size(1484, 874);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ProdImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.PictureBox pic_ProdImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.CheckBox chk_available;
        private System.Windows.Forms.DataGridViewImageColumn image_base64;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_added;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_archived;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_unarchive;
        private System.Windows.Forms.Button btn_archive;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
    }
}
