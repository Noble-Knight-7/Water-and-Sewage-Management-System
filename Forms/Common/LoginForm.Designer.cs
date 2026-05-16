namespace WaterSewageManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle       = new System.Windows.Forms.Label();
            this.lblSubtitle    = new System.Windows.Forms.Label();
            this.lblEmail       = new System.Windows.Forms.Label();
            this.txtEmail       = new System.Windows.Forms.TextBox();
            this.lblPassword    = new System.Windows.Forms.Label();
            this.txtPassword    = new System.Windows.Forms.TextBox();
            this.btnLogin       = new System.Windows.Forms.Button();
            this.lnkRegister    = new System.Windows.Forms.LinkLabel();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.panelMain      = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.ClientSize  = new System.Drawing.Size(900, 550);
            this.Text        = "Water & Sewage Management System - Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor   = System.Drawing.Color.FromArgb(13, 71, 161);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // panelMain (white card)
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelMain.Location = new System.Drawing.Point(250, 80);
            this.panelMain.Size     = new System.Drawing.Size(400, 390);
            this.panelMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblSubtitle,
                this.lblEmail, this.txtEmail,
                this.lblPassword, this.txtPassword,
                this.btnLogin, this.lnkRegister, this.lnkForgotPassword });

            // lblTitle
            this.lblTitle.Text      = "WASA System";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.lblTitle.Location  = new System.Drawing.Point(100, 25);
            this.lblTitle.Size      = new System.Drawing.Size(200, 36);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle
            this.lblSubtitle.Text      = "Sign in to your account";
            this.lblSubtitle.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location  = new System.Drawing.Point(80, 62);
            this.lblSubtitle.Size      = new System.Drawing.Size(240, 20);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblEmail
            this.lblEmail.Text     = "Email Address";
            this.lblEmail.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(40, 105);
            this.lblEmail.Size     = new System.Drawing.Size(120, 20);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(40, 128);
            this.txtEmail.Size     = new System.Drawing.Size(320, 28);
            this.txtEmail.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPassword
            this.lblPassword.Text     = "Password";
            this.lblPassword.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(40, 175);
            this.lblPassword.Size     = new System.Drawing.Size(120, 20);

            // txtPassword
            this.txtPassword.Location     = new System.Drawing.Point(40, 198);
            this.txtPassword.Size         = new System.Drawing.Size(320, 28);
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;

            // btnLogin
            this.btnLogin.Text      = "LOGIN";
            this.btnLogin.Location  = new System.Drawing.Point(40, 255);
            this.btnLogin.Size      = new System.Drawing.Size(320, 42);
            this.btnLogin.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Click    += new System.EventHandler(this.btnLogin_Click);

            // lnkRegister
            this.lnkRegister.Text      = "Don't have an account? Register";
            this.lnkRegister.Location  = new System.Drawing.Point(80, 315);
            this.lnkRegister.Size      = new System.Drawing.Size(240, 20);
            this.lnkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);

            // lnkForgotPassword
            this.lnkForgotPassword.Text      = "Forgot Password?";
            this.lnkForgotPassword.Location  = new System.Drawing.Point(130, 340);
            this.lnkForgotPassword.Size      = new System.Drawing.Size(140, 20);
            this.lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgotPassword_LinkClicked);

            this.Controls.Add(this.panelMain);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label     lblTitle;
        private System.Windows.Forms.Label     lblSubtitle;
        private System.Windows.Forms.Label     lblEmail;
        private System.Windows.Forms.TextBox   txtEmail;
        private System.Windows.Forms.Label     lblPassword;
        private System.Windows.Forms.TextBox   txtPassword;
        private System.Windows.Forms.Button    btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.Panel     panelMain;
    }
}
