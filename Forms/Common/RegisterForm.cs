using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class RegisterForm : Form
    {
        // private readonly AuthService _authService = new AuthService();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name     = txtName.Text.Trim();
            string email    = txtEmail.Text.Trim();
            string phone    = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirm  = txtConfirm.Text;
            string role     = cmbRole.SelectedItem?.ToString();
            string address  = txtAddress.Text.Trim();

            if (ValidationHelper.IsEmpty(name) || ValidationHelper.IsEmpty(email) ||
                ValidationHelper.IsEmpty(phone) || ValidationHelper.IsEmpty(password) || role == null)
            {
                MessageHelper.ShowError("Please fill in all required fields.");
                return;
            }
            if (!ValidationHelper.IsValidEmail(email))
            {
                MessageHelper.ShowError("Please enter a valid email address.");
                return;
            }
            if (!ValidationHelper.IsValidPassword(password))
            {
                MessageHelper.ShowError("Password must be at least 4 characters.");
                return;
            }
            if (password != confirm)
            {
                MessageHelper.ShowError("Passwords do not match.");
                return;
            }

            var user = new User
            {
                FullName = name,
                Email    = email,
                Phone    = phone,
                Password = password,
                Role     = role,
                Address  = address
            };
            AuthService authService = new AuthService();
            bool success = authService.Register(user);
            if (success)
            {
                if (role != "Customer")
                    MessageHelper.ShowSuccess("Account created! Please wait for Admin approval before logging in.");
                else
                    MessageHelper.ShowSuccess("Registration successful! You can now log in.");
                this.Close();
            }
            else
            {
                MessageHelper.ShowError("This email is already registered. Please use a different email.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
