namespace WaterSewageManagementSystem.Forms.Common
{
    partial class ForgotPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblTitle      = new System.Windows.Forms.Label();
            this.lblEmail      = new System.Windows.Forms.Label();
            this.txtEmail      = new System.Windows.Forms.TextBox();
            this.lblNewPass    = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm    = new System.Windows.Forms.Label();
            this.txtConfirm    = new System.Windows.Forms.TextBox();
            this.btnReset      = new System.Windows.Forms.Button();
            this.btnCancel     = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Text = "Reset Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            this.lblTitle.Text = "Reset Password"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161); this.lblTitle.Location = new System.Drawing.Point(110, 20); this.lblTitle.Size = new System.Drawing.Size(200, 28);

            this.lblEmail.Text = "Registered Email"; this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblEmail.Location = new System.Drawing.Point(30, 70); this.lblEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.Location = new System.Drawing.Point(30, 93); this.txtEmail.Size = new System.Drawing.Size(350, 26); this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblNewPass.Text = "New Password"; this.lblNewPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblNewPass.Location = new System.Drawing.Point(30, 133); this.lblNewPass.Size = new System.Drawing.Size(140, 20);
            this.txtNewPassword.Location = new System.Drawing.Point(30, 156); this.txtNewPassword.Size = new System.Drawing.Size(350, 26); this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtNewPassword.PasswordChar = '*'; this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblConfirm.Text = "Confirm Password"; this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblConfirm.Location = new System.Drawing.Point(30, 196); this.lblConfirm.Size = new System.Drawing.Size(140, 20);
            this.txtConfirm.Location = new System.Drawing.Point(30, 219); this.txtConfirm.Size = new System.Drawing.Size(350, 26); this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtConfirm.PasswordChar = '*'; this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnReset.Text = "Reset Password"; this.btnReset.Location = new System.Drawing.Point(30, 260); this.btnReset.Size = new System.Drawing.Size(170, 36);
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(13, 71, 161); this.btnReset.ForeColor = System.Drawing.Color.White; this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnReset.FlatAppearance.BorderSize = 0; this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand; this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.btnCancel.Text = "Cancel"; this.btnCancel.Location = new System.Drawing.Point(210, 260); this.btnCancel.Size = new System.Drawing.Size(170, 36);
            this.btnCancel.BackColor = System.Drawing.Color.LightGray; this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand; this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblEmail, this.txtEmail, this.lblNewPass, this.txtNewPassword, this.lblConfirm, this.txtConfirm, this.btnReset, this.btnCancel });
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle, lblEmail, lblNewPass, lblConfirm;
        private System.Windows.Forms.TextBox txtEmail, txtNewPassword, txtConfirm;
        private System.Windows.Forms.Button btnReset, btnCancel;
    }
}
