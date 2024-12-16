namespace POS_SYSTEM
{
    partial class inventory_tables
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_is_active = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tableno = new System.Windows.Forms.TextBox();
            this.txt_tableid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_tables = new System.Windows.Forms.DataGridView();
            this.table_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_archived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_unarchive = new System.Windows.Forms.Button();
            this.btn_archive = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tables)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.cb_is_active);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.txt_tableno);
            this.panel12.Controls.Add(this.txt_tableid);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(470, 815);
            this.panel12.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(51, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 28);
            this.label8.TabIndex = 40;
            this.label8.Text = "Status";
            // 
            // cb_is_active
            // 
            this.cb_is_active.BackColor = System.Drawing.Color.FloralWhite;
            this.cb_is_active.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_is_active.FormattingEnabled = true;
            this.cb_is_active.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cb_is_active.Location = new System.Drawing.Point(237, 212);
            this.cb_is_active.Name = "cb_is_active";
            this.cb_is_active.Size = new System.Drawing.Size(201, 36);
            this.cb_is_active.TabIndex = 39;
            this.cb_is_active.Text = "Select Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(51, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Table Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(49, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Table ID";
            // 
            // txt_tableno
            // 
            this.txt_tableno.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_tableno.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_tableno.Location = new System.Drawing.Point(237, 155);
            this.txt_tableno.Name = "txt_tableno";
            this.txt_tableno.Size = new System.Drawing.Size(201, 34);
            this.txt_tableno.TabIndex = 24;
            // 
            // txt_tableid
            // 
            this.txt_tableid.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_tableid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_tableid.Location = new System.Drawing.Point(235, 90);
            this.txt_tableid.Name = "txt_tableid";
            this.txt_tableid.Size = new System.Drawing.Size(203, 34);
            this.txt_tableid.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tables";
            // 
            // dgv_tables
            // 
            this.dgv_tables.AllowUserToAddRows = false;
            this.dgv_tables.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_tables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_tables.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_tables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_tables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.table_id,
            this.table_number,
            this.status,
            this.is_archived});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tables.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_tables.Location = new System.Drawing.Point(470, 0);
            this.dgv_tables.Name = "dgv_tables";
            this.dgv_tables.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tables.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_tables.RowHeadersVisible = false;
            this.dgv_tables.RowHeadersWidth = 51;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_tables.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_tables.RowTemplate.Height = 24;
            this.dgv_tables.Size = new System.Drawing.Size(798, 815);
            this.dgv_tables.TabIndex = 34;
            // 
            // table_id
            // 
            this.table_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.table_id.DefaultCellStyle = dataGridViewCellStyle10;
            this.table_id.HeaderText = "TABLE ID";
            this.table_id.MinimumWidth = 6;
            this.table_id.Name = "table_id";
            this.table_id.ReadOnly = true;
            this.table_id.Visible = false;
            // 
            // table_number
            // 
            this.table_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.table_number.DefaultCellStyle = dataGridViewCellStyle11;
            this.table_number.HeaderText = "TABLE NUMBER";
            this.table_number.MinimumWidth = 6;
            this.table_number.Name = "table_number";
            this.table_number.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "STATUS";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.Width = 125;
            // 
            // is_archived
            // 
            this.is_archived.HeaderText = "DISABLED";
            this.is_archived.MinimumWidth = 6;
            this.is_archived.Name = "is_archived";
            this.is_archived.ReadOnly = true;
            this.is_archived.Width = 125;
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
            // inventory_tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_tables);
            this.Controls.Add(this.panel12);
            this.Name = "inventory_tables";
            this.Size = new System.Drawing.Size(1268, 815);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tables)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tableno;
        private System.Windows.Forms.TextBox txt_tableid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_tables;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_is_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn table_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_archived;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_unarchive;
        private System.Windows.Forms.Button btn_archive;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
    }
}
