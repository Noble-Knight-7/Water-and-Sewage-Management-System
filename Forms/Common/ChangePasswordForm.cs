using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class ChangePasswordForm : Form
    {
        private readonly UserService _userService = new UserService();

        public ChangePasswordForm() { InitializeComponent(); }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPass = txtOld.Text;
            string newPass = txtNew.Text;
            string confirm = txtConfirm.Text;

            if (ValidationHelper.IsEmpty(oldPass) || ValidationHelper.IsEmpty(newPass))
            {
                MessageHelper.ShowError("Please fill all fields."); return;
            }
            if (!ValidationHelper.IsValidPassword(newPass))
            {
                MessageHelper.ShowError("Password must be at least 4 characters."); return;
            }
            if (newPass != confirm)
            {
                MessageHelper.ShowError("New passwords do not match."); return;
            }

            bool success = _userService.ChangePassword(SessionManager.CurrentUser.UserID, oldPass, newPass);
            if (success)
            {
                MessageHelper.ShowSuccess("Password changed successfully.");
                this.Close();
            }
            else
            {
                MessageHelper.ShowError("Current password is incorrect.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void lblOld_Click(object sender, EventArgs e)
        {

        }
    }
}
