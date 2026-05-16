using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class ProfileForm : Form
    {
        private readonly UserService _userService = new UserService();

        public ProfileForm()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                LoadProfile();
            }
        }

        private void LoadProfile()
        {
            var user = SessionManager.CurrentUser;
            txtName.Text    = user.FullName;
            txtEmail.Text   = user.Email;
            txtPhone.Text   = user.Phone;
            txtAddress.Text = user.Address;
            lblRole.Text    = "Role: " + user.Role;
            lblStatus.Text  = "Status: " + user.Status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name    = txtName.Text.Trim();
            string phone   = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (ValidationHelper.IsEmpty(name) || ValidationHelper.IsEmpty(phone))
            {
                MessageHelper.ShowError("Name and phone cannot be empty."); return;
            }

            var user = SessionManager.CurrentUser;
            user.FullName = name;
            user.Phone    = phone;
            user.Address  = address;

            bool success = _userService.UpdateProfile(user);
            if (success)
                MessageHelper.ShowSuccess("Profile updated successfully.");
            else
                MessageHelper.ShowError("Could not update profile.");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }
    }
}
