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
            this.panel_log = new System.Windows.Forms.Panel();
            this.login_logo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_icon = new System.Windows.Forms.Panel();
            this.user_icon = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_logo.BackgroundImage")));
            this.panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(503, 673);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_log
            // 
            this.panel_log.BackColor = System.Drawing.Color.FloralWhite;
            this.panel_log.Controls.Add(this.txt_password);
            this.panel_log.Controls.Add(this.txt_username);
            this.panel_log.Controls.Add(this.login_logo);
            this.panel_log.Controls.Add(this.label3);
            this.panel_log.Controls.Add(this.btn_login);
            this.panel_log.Controls.Add(this.label2);
            this.panel_log.Controls.Add(this.label1);
            this.panel_log.Controls.Add(this.password_icon);
            this.panel_log.Controls.Add(this.user_icon);
            this.panel_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_log.Location = new System.Drawing.Point(503, 0);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(564, 673);
            this.panel_log.TabIndex = 1;
            // 
            // login_logo
            // 
            this.login_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_logo.BackgroundImage")));
            this.login_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_logo.Location = new System.Drawing.Point(241, 69);
            this.login_logo.Name = "login_logo";
            this.login_logo.Size = new System.Drawing.Size(100, 101);
            this.login_logo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(174, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 67);
            this.label3.TabIndex = 8;
            this.label3.Text = "USER LOGIN";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.btn_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_login.Location = new System.Drawing.Point(212, 520);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(170, 52);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(152, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(152, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // password_icon
            // 
            this.password_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password_icon.BackgroundImage")));
            this.password_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.password_icon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.password_icon.Location = new System.Drawing.Point(87, 426);
            this.password_icon.Name = "password_icon";
            this.password_icon.Size = new System.Drawing.Size(53, 41);
            this.password_icon.TabIndex = 4;
            // 
            // user_icon
            // 
            this.user_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_icon.BackgroundImage")));
            this.user_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.user_icon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.user_icon.Location = new System.Drawing.Point(87, 315);
            this.user_icon.Name = "user_icon";
            this.user_icon.Size = new System.Drawing.Size(53, 41);
            this.user_icon.TabIndex = 3;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.txt_username.Location = new System.Drawing.Point(154, 320);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(328, 34);
            this.txt_username.TabIndex = 12;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.txt_password.Location = new System.Drawing.Point(154, 431);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(328, 34);
            this.txt_password.TabIndex = 13;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1067, 673);
            this.Controls.Add(this.panel_log);
            this.Controls.Add(this.panel_logo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Module";
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel password_icon;
        private System.Windows.Forms.Panel user_icon;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel login_logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
    }
}

