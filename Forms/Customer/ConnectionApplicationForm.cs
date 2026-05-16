using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class ConnectionApplicationForm : Form
    {
        //private readonly ConnectionService  _connectionService = new ConnectionService();
        //private readonly CustomerRepository _customerRepo      = new CustomerRepository();

        public ConnectionApplicationForm() { InitializeComponent(); }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var customerRepo = new CustomerRepository();
            var connectionService = new ConnectionService();

            if (SessionManager.CurrentUser == null)
            {
                MessageHelper.ShowError("No logged-in user found.");
                return;
            }

            var customer = customerRepo.GetByUserID(SessionManager.CurrentUser.UserID);
            if (customer == null)
            {
                MessageHelper.ShowError("Customer record not found.");
                return;
            }

            var existing = connectionService.GetByCustomer(customer.CustomerID);

            foreach (var app in existing)
            {
                if (app.ApprovalStatus == "Pending")
                {
                    MessageHelper.ShowWarning("You already have a pending connection application ID: " + app.ApplicationID);
                    return;
                }
            }

            if (MessageHelper.ShowConfirm("Submit a new connection application?\n\nA Service Officer will review your request and contact you.") == DialogResult.Yes)
            {
                bool success = connectionService.Apply(customer.CustomerID);

                if (success)
                    MessageHelper.ShowSuccess("Application submitted successfully!");
                else
                    MessageHelper.ShowError("Failed to submit application. Please try again.");
            }
        }
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        private void lblStep1_Click(object sender, EventArgs e)
        {

        }
    }
}
