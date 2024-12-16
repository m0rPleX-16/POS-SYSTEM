namespace POS_SYSTEM
{
    partial class inventory_recipe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ingridients = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_items = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_quantityreq = new System.Windows.Forms.TextBox();
            this.txt_recipeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgv_recipe = new System.Windows.Forms.DataGridView();
            this.recipe_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_required = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_archived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_unarchive = new System.Windows.Forms.Button();
            this.btn_archive = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Controls.Add(this.cb_ingridients);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.cb_items);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.txt_quantityreq);
            this.panel12.Controls.Add(this.txt_recipeid);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(470, 798);
            this.panel12.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(35, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 28);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ingredients Name";
            // 
            // cb_ingridients
            // 
            this.cb_ingridients.BackColor = System.Drawing.Color.FloralWhite;
            this.cb_ingridients.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_ingridients.FormattingEnabled = true;
            this.cb_ingridients.Location = new System.Drawing.Point(241, 223);
            this.cb_ingridients.Name = "cb_ingridients";
            this.cb_ingridients.Size = new System.Drawing.Size(203, 36);
            this.cb_ingridients.TabIndex = 41;
            this.cb_ingridients.Text = "Select Ingredient";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(35, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 28);
            this.label8.TabIndex = 40;
            this.label8.Text = "Item Name";
            // 
            // cb_items
            // 
            this.cb_items.BackColor = System.Drawing.Color.FloralWhite;
            this.cb_items.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_items.FormattingEnabled = true;
            this.cb_items.Location = new System.Drawing.Point(241, 156);
            this.cb_items.Name = "cb_items";
            this.cb_items.Size = new System.Drawing.Size(203, 36);
            this.cb_items.TabIndex = 39;
            this.cb_items.Text = "Select Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(35, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Quantity Required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FloralWhite;
            this.label7.Location = new System.Drawing.Point(35, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Recipe ID";
            // 
            // txt_quantityreq
            // 
            this.txt_quantityreq.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_quantityreq.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_quantityreq.Location = new System.Drawing.Point(241, 289);
            this.txt_quantityreq.Name = "txt_quantityreq";
            this.txt_quantityreq.Size = new System.Drawing.Size(203, 34);
            this.txt_quantityreq.TabIndex = 24;
            // 
            // txt_recipeid
            // 
            this.txt_recipeid.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_recipeid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_recipeid.Location = new System.Drawing.Point(241, 93);
            this.txt_recipeid.Name = "txt_recipeid";
            this.txt_recipeid.Size = new System.Drawing.Size(203, 34);
            this.txt_recipeid.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recipe";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.dgv_recipe);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(470, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(819, 798);
            this.panel13.TabIndex = 34;
            // 
            // dgv_recipe
            // 
            this.dgv_recipe.AllowUserToAddRows = false;
            this.dgv_recipe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_recipe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_recipe.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgv_recipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_recipe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_recipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipe_id,
            this.category_name,
            this.ingredient_id,
            this.quantity_required,
            this.is_archived});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_recipe.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_recipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_recipe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgv_recipe.Location = new System.Drawing.Point(0, 0);
            this.dgv_recipe.Name = "dgv_recipe";
            this.dgv_recipe.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_recipe.RowHeadersVisible = false;
            this.dgv_recipe.RowHeadersWidth = 51;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_recipe.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_recipe.RowTemplate.Height = 24;
            this.dgv_recipe.Size = new System.Drawing.Size(819, 798);
            this.dgv_recipe.TabIndex = 2;
            // 
            // recipe_id
            // 
            this.recipe_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.recipe_id.DefaultCellStyle = dataGridViewCellStyle27;
            this.recipe_id.HeaderText = "RECIPE NO.";
            this.recipe_id.MinimumWidth = 6;
            this.recipe_id.Name = "recipe_id";
            this.recipe_id.ReadOnly = true;
            this.recipe_id.Visible = false;
            this.recipe_id.Width = 125;
            // 
            // category_name
            // 
            this.category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.category_name.DefaultCellStyle = dataGridViewCellStyle28;
            this.category_name.HeaderText = "ITEM NAME";
            this.category_name.MinimumWidth = 6;
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            this.category_name.Width = 142;
            // 
            // ingredient_id
            // 
            this.ingredient_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            this.ingredient_id.DefaultCellStyle = dataGridViewCellStyle29;
            this.ingredient_id.HeaderText = "INGREDIENT NAME";
            this.ingredient_id.MinimumWidth = 6;
            this.ingredient_id.Name = "ingredient_id";
            this.ingredient_id.ReadOnly = true;
            // 
            // quantity_required
            // 
            this.quantity_required.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity_required.HeaderText = "QUANTITY REQUIRED";
            this.quantity_required.MinimumWidth = 6;
            this.quantity_required.Name = "quantity_required";
            this.quantity_required.ReadOnly = true;
            this.quantity_required.Width = 224;
            // 
            // is_archived
            // 
            this.is_archived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.is_archived.HeaderText = "DISABLED";
            this.is_archived.MinimumWidth = 6;
            this.is_archived.Name = "is_archived";
            this.is_archived.ReadOnly = true;
            this.is_archived.Width = 136;
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
            // inventory_recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Name = "inventory_recipe";
            this.Size = new System.Drawing.Size(1289, 798);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recipe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_quantityreq;
        private System.Windows.Forms.TextBox txt_recipeid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DataGridView dgv_recipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ingridients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipe_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_required;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_archived;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_unarchive;
        private System.Windows.Forms.Button btn_archive;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
    }
}
