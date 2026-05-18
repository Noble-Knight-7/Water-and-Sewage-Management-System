using System;
using System.Drawing;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService = new AuthService();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email    = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (ValidationHelper.IsEmpty(email) && ValidationHelper.IsEmpty(password))
            {
                MessageHelper.ShowError("Please enter your email and password.");
                return;
            }
            if (ValidationHelper.IsEmpty(email))
            {
                MessageHelper.ShowError("Please enter your email.");
                return;
            }
            if (ValidationHelper.IsEmpty(password))
            {
                MessageHelper.ShowError("Please enter your password.");
                return;
            }

            bool success = _authService.Login(email, password);
            if (!success)
            {
                MessageHelper.ShowError("Invalid email or password, or your account is not active.");
                return;
            }

            // Open the correct dashboard based on the logged-in user's role
            string role = SessionManager.CurrentUser.Role;
            Form dashboard = null;

            switch (role)
            {
                case "Admin":
                    dashboard = new Forms.Admin.AdminDashboardForm();
                    break;
                case "Customer":
                    dashboard = new Forms.Customer.CustomerDashboardForm();
                    break;
                case "ServiceOfficer":
                    dashboard = new Forms.ServiceOfficer.ServiceOfficerDashboardForm();
                    break;
                case "MaintenanceEngineer":
                    dashboard = new Forms.MaintenanceEngineer.MaintenanceDashboardForm();
                    break;
                default:
                    MessageHelper.ShowError("Unknown role. Please contact admin.");
                    return;
            }

            this.Hide();
            dashboard.FormClosed += (s, args) => this.Close(); 
            dashboard.Show();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Forms.Common.RegisterForm();
            form.ShowDialog();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Forms.Common.ForgotPasswordForm();
            form.ShowDialog();
        }

        private void login_close_clicked(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
