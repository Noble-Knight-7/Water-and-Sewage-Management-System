using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    // WaterQualityIssueForm lets the Maintenance Engineer report a water quality
    // problem by submitting it as a high-priority Complaint and publishing a Notice.
    // This form creates both records in the database in one action.
    public partial class WaterQualityIssueForm : Form
    {
        private readonly NoticeService    _noticeService    = new NoticeService();
        private readonly ComplaintService _complaintService = new ComplaintService();
        private readonly CustomerRepository _customerRepo   = new CustomerRepository();

        public WaterQualityIssueForm() { InitializeComponent(); }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string issueType  = cmbIssueType.SelectedItem?.ToString();
            string area       = txtArea.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (issueType == null)
            {
                MessageHelper.ShowError("Please select the type of water quality issue."); return;
            }
            if (ValidationHelper.IsEmpty(area))
            {
                MessageHelper.ShowError("Please enter the affected area."); return;
            }
            if (ValidationHelper.IsEmpty(description))
            {
                MessageHelper.ShowError("Please describe the issue in detail."); return;
            }

            if (MessageHelper.ShowConfirm(
                "This will publish an emergency notice and create a high-priority complaint.\n\nProceed?") != DialogResult.Yes)
                return;

            // 1. Publish an emergency notice so customers are aware
            var notice = new Notice
            {
                Title       = "⚠ Water Quality Alert: " + issueType,
                Description = $"Area: {area}. {description}",
                Area        = area,
                NoticeType  = "Emergency",
                PublishedBy = SessionManager.CurrentUser.UserID
            };
            _noticeService.Publish(notice);

            // 2. Create a high-priority complaint linked to the first customer
            //    (In a real system you'd link it to the zone, not a specific customer,
            //     but for this academic project we attach it to CustomerID 1 as a system entry)
            var customers = _customerRepo.GetAll();
            if (customers.Count > 0)
            {
                var complaint = new Complaint
                {
                    CustomerID  = customers[0].CustomerID,
                    Category    = "Water Quality",
                    Description = $"[Reported by Engineer {SessionManager.CurrentUser.FullName}] " +
                                  $"Issue Type: {issueType}. Area: {area}. Details: {description}",
                    Priority    = "Urgent"
                };
                _complaintService.Submit(complaint);
            }

            MessageHelper.ShowSuccess(
                "Water quality issue reported!\n\n" +
                "✔ Emergency notice published for customers.\n" +
                "✔ Urgent complaint ticket created for Admin review.");

            // Clear the form for a new entry
            txtArea.Clear();
            txtDescription.Clear();
            cmbIssueType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
