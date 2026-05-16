using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class BillingReportForm : Form
    {
        private readonly BillingService _billingService = new BillingService();
        private readonly ReportService  _reportService  = new ReportService();

        public BillingReportForm() { InitializeComponent(); LoadBills(); }

        private void LoadBills()
        {
            dgvBills.DataSource = null;
            dgvBills.DataSource = _billingService.GetAllBills();
        }

        private void btnLogReport_Click(object sender, EventArgs e)
        {
            _reportService.LogReport(SessionManager.CurrentUser.UserID, "Billing", "Service Officer generated billing report.");
            MessageHelper.ShowSuccess("Billing report logged successfully.");
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
