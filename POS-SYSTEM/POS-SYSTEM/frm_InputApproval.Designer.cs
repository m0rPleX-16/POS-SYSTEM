namespace POS_SYSTEM
{
    partial class frm_InputApproval
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_adminPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 64);
            this.panel3.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 27;
            this.label1.Text = "Action Approval";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(321, 256);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(93, 58);
            this.btn_cancel.TabIndex = 39;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_confirm.Location = new System.Drawing.Point(133, 256);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(93, 58);
            this.btn_confirm.TabIndex = 38;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(54, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 35);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter the admin password:";
            // 
            // txt_adminPass
            // 
            this.txt_adminPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_adminPass.BackColor = System.Drawing.Color.FloralWhite;
            this.txt_adminPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_adminPass.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txt_adminPass.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_adminPass.Location = new System.Drawing.Point(60, 177);
            this.txt_adminPass.Name = "txt_adminPass";
            this.txt_adminPass.PasswordChar = '*';
            this.txt_adminPass.Size = new System.Drawing.Size(427, 36);
            this.txt_adminPass.TabIndex = 35;
            this.txt_adminPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Location = new System.Drawing.Point(60, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 1);
            this.panel1.TabIndex = 36;
            // 
            // frm_InputApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(545, 350);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_adminPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_InputApproval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_InputApproval";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_adminPass;
        private System.Windows.Forms.Panel panel1;
    }
}