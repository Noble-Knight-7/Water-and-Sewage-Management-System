using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly UserRepository _userRepo = new UserRepository();

        public ForgotPasswordForm() { InitializeComponent(); }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email    = txtEmail.Text.Trim();
            string newPass  = txtNewPassword.Text;
            string confirm  = txtConfirm.Text;

            if (ValidationHelper.IsEmpty(email) || ValidationHelper.IsEmpty(newPass))
            {
                MessageHelper.ShowError("Please fill all fields.");
                return;
            }
            if (!ValidationHelper.IsValidEmail(email))
            {
                MessageHelper.ShowError("Invalid email address.");
                return;
            }
            if (newPass != confirm)
            {
                MessageHelper.ShowError("Passwords do not match.");
                return;
            }

            var user = _userRepo.GetByEmail(email);
            if (user == null)
            {
                MessageHelper.ShowError("No account found with this email.");
                return;
            }

            _userRepo.UpdatePassword(user.UserID, newPass);
            MessageHelper.ShowSuccess("Password reset successfully. You can now log in.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
