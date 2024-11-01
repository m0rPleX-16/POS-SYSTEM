namespace POS_SYSTEM
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_login = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedTextBox2 = new POS_SYSTEM.RoundedTextBox();
            this.roundedTextBox1 = new POS_SYSTEM.RoundedTextBox();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.White;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(503, 673);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel_login.Controls.Add(this.roundedTextBox2);
            this.panel_login.Controls.Add(this.roundedTextBox1);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.label1);
            this.panel_login.Controls.Add(this.panel2);
            this.panel_login.Controls.Add(this.panel1);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Location = new System.Drawing.Point(503, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(564, 673);
            this.panel_login.TabIndex = 1;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_login_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(155, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(155, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(87, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 41);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(87, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 41);
            this.panel1.TabIndex = 3;
            // 
            // roundedTextBox2
            // 
            this.roundedTextBox2.BackColor = System.Drawing.Color.White;
            this.roundedTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedTextBox2.BorderRadius = 25;
            this.roundedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roundedTextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.roundedTextBox2.Location = new System.Drawing.Point(160, 426);
            this.roundedTextBox2.Name = "roundedTextBox2";
            this.roundedTextBox2.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextBox2.Size = new System.Drawing.Size(345, 41);
            this.roundedTextBox2.TabIndex = 2;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.White;
            this.roundedTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.roundedTextBox1.BorderRadius = 25;
            this.roundedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roundedTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.roundedTextBox1.Location = new System.Drawing.Point(158, 315);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(10);
            this.roundedTextBox1.Size = new System.Drawing.Size(345, 41);
            this.roundedTextBox1.TabIndex = 2;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.ClientSize = new System.Drawing.Size(1067, 673);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_logo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Module";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private RoundedTextBox roundedTextBox2;
        private RoundedTextBox roundedTextBox1;
    }
}

