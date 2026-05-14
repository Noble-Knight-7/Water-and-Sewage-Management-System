namespace WaterSewageManagementSystem
{
    partial class LoginForm
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_sign_in = new System.Windows.Forms.Label();
            this.label_role_select = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel_register = new System.Windows.Forms.LinkLabel();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.comboBox_role_selector = new System.Windows.Forms.ComboBox();
            this.linkLabel_forgot_password = new System.Windows.Forms.LinkLabel();
            this.checkBox_show_password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_title.Location = new System.Drawing.Point(22, 45);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(633, 40);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "WATER AND SEWAGE MANAGEMENT SYSTEM";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_email
            // 
            this.label_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(146, 214);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(136, 25);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "E-Mail Address";
            // 
            // label_password
            // 
            this.label_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(146, 308);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(90, 25);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            // 
            // label_sign_in
            // 
            this.label_sign_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_sign_in.AutoSize = true;
            this.label_sign_in.BackColor = System.Drawing.Color.LightCyan;
            this.label_sign_in.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sign_in.ForeColor = System.Drawing.Color.Teal;
            this.label_sign_in.Location = new System.Drawing.Point(173, 123);
            this.label_sign_in.Name = "label_sign_in";
            this.label_sign_in.Size = new System.Drawing.Size(330, 38);
            this.label_sign_in.TabIndex = 3;
            this.label_sign_in.Text = "Sign-in to Your Account";
            this.label_sign_in.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_role_select
            // 
            this.label_role_select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_role_select.AutoSize = true;
            this.label_role_select.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role_select.Location = new System.Drawing.Point(146, 428);
            this.label_role_select.Name = "label_role_select";
            this.label_role_select.Size = new System.Drawing.Size(146, 25);
            this.label_role_select.TabIndex = 4;
            this.label_role_select.Text = "Select Your Role";
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_login.BackColor = System.Drawing.Color.DarkCyan;
            this.button_login.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(151, 531);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(376, 37);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_clicked);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(172, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Don\'t Have an Account?";
            // 
            // linkLabel_register
            // 
            this.linkLabel_register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_register.AutoSize = true;
            this.linkLabel_register.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_register.Location = new System.Drawing.Point(366, 597);
            this.linkLabel_register.Name = "linkLabel_register";
            this.linkLabel_register.Size = new System.Drawing.Size(107, 23);
            this.linkLabel_register.TabIndex = 7;
            this.linkLabel_register.TabStop = true;
            this.linkLabel_register.Text = "Register Now";
            this.linkLabel_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_register_clicked);
            // 
            // textBox_email
            // 
            this.textBox_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_email.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(151, 251);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(376, 30);
            this.textBox_email.TabIndex = 8;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(151, 348);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(376, 30);
            this.textBox_password.TabIndex = 9;
            // 
            // comboBox_role_selector
            // 
            this.comboBox_role_selector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_role_selector.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox_role_selector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_role_selector.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_role_selector.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_role_selector.FormattingEnabled = true;
            this.comboBox_role_selector.Location = new System.Drawing.Point(151, 465);
            this.comboBox_role_selector.Name = "comboBox_role_selector";
            this.comboBox_role_selector.Size = new System.Drawing.Size(376, 31);
            this.comboBox_role_selector.TabIndex = 10;
            this.comboBox_role_selector.SelectedIndexChanged += new System.EventHandler(this.comboBox_role_selector_SelectedIndexChanged);
            // 
            // linkLabel_forgot_password
            // 
            this.linkLabel_forgot_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_forgot_password.AutoSize = true;
            this.linkLabel_forgot_password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_forgot_password.Location = new System.Drawing.Point(381, 310);
            this.linkLabel_forgot_password.Name = "linkLabel_forgot_password";
            this.linkLabel_forgot_password.Size = new System.Drawing.Size(138, 23);
            this.linkLabel_forgot_password.TabIndex = 11;
            this.linkLabel_forgot_password.TabStop = true;
            this.linkLabel_forgot_password.Text = "Forgot Password?";
            this.linkLabel_forgot_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel_forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forgot_password_clicked);
            // 
            // checkBox_show_password
            // 
            this.checkBox_show_password.AutoSize = true;
            this.checkBox_show_password.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show_password.Location = new System.Drawing.Point(151, 384);
            this.checkBox_show_password.Name = "checkBox_show_password";
            this.checkBox_show_password.Size = new System.Drawing.Size(121, 21);
            this.checkBox_show_password.TabIndex = 12;
            this.checkBox_show_password.Text = "Show Password";
            this.checkBox_show_password.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(667, 687);
            this.Controls.Add(this.checkBox_show_password);
            this.Controls.Add(this.linkLabel_forgot_password);
            this.Controls.Add(this.comboBox_role_selector);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.linkLabel_register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_role_select);
            this.Controls.Add(this.label_sign_in);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_title);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_sign_in;
        private System.Windows.Forms.Label label_role_select;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel_register;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.ComboBox comboBox_role_selector;
        private System.Windows.Forms.LinkLabel linkLabel_forgot_password;
        private System.Windows.Forms.CheckBox checkBox_show_password;
    }
}

