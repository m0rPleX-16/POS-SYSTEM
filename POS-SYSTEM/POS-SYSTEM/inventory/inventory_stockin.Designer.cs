namespace POS_SYSTEM.inventory
{
    partial class inventory_stockin
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_stockin = new System.Windows.Forms.DataGridView();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.Controls.Add(this.dgv_stockin);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(505, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(796, 665);
            this.panel13.TabIndex = 33;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel12.Controls.Add(this.label1);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(505, 665);
            this.panel12.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stock In";
            // 
            // dgv_stockin
            // 
            this.dgv_stockin.AllowUserToAddRows = false;
            this.dgv_stockin.AllowUserToDeleteRows = false;
            this.dgv_stockin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stockin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_stockin.Location = new System.Drawing.Point(0, 0);
            this.dgv_stockin.Name = "dgv_stockin";
            this.dgv_stockin.ReadOnly = true;
            this.dgv_stockin.RowHeadersWidth = 51;
            this.dgv_stockin.RowTemplate.Height = 24;
            this.dgv_stockin.Size = new System.Drawing.Size(796, 665);
            this.dgv_stockin.TabIndex = 1;
            // 
            // inventory_stockin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Name = "inventory_stockin";
            this.Size = new System.Drawing.Size(1301, 665);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_stockin;
    }
}
