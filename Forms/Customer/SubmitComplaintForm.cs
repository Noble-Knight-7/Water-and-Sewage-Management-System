using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class SubmitComplaintForm : Form
    {
        private readonly ComplaintService   _complaintService = new ComplaintService();
        private readonly CustomerRepository _customerRepo     = new CustomerRepository();

        public SubmitComplaintForm() { InitializeComponent(); }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.IsEmpty(txtDescription.Text))
            {
                MessageHelper.ShowError("Please describe your complaint."); return;
            }

            var customer = _customerRepo.GetByUserID(SessionManager.CurrentUser.UserID);
            if (customer == null) { MessageHelper.ShowError("Customer record not found."); return; }

            var complaint = new Complaint
            {
                CustomerID  = customer.CustomerID,
                Category    = cmbCategory.SelectedItem?.ToString() ?? "Other",
                Description = txtDescription.Text.Trim(),
                Priority    = cmbPriority.SelectedItem?.ToString() ?? "Medium"
            };

            if (_complaintService.Submit(complaint))
            {
                MessageHelper.ShowSuccess("Complaint submitted successfully. We will attend to it shortly.");
                txtDescription.Clear();
            }
            else MessageHelper.ShowError("Failed to submit complaint. Please try again.");
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
