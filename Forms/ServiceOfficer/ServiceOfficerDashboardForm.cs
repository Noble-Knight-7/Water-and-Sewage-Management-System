using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ServiceOfficerDashboardForm : Form
    {
        public ServiceOfficerDashboardForm()
        {
            InitializeComponent();

            if (SessionManager.CurrentUser != null)
            {
                lblWelcome.Text = "Welcome, " + SessionManager.CurrentUser.FullName;
            }
            else
            {
                lblWelcome.Text = "Welcome, Service Officer";
            }
        }

        private void btnMeterReading_Click(object sender, EventArgs e)           => new MeterReadingForm().ShowDialog();
        private void btnGenerateBill_Click(object sender, EventArgs e)           => new GenerateBillForm().ShowDialog();
        private void btnReviewDisputes_Click(object sender, EventArgs e)         => new ReviewDisputesForm().ShowDialog();
        private void btnCorrectBill_Click(object sender, EventArgs e)            => new CorrectBillForm().ShowDialog();
        private void btnReviewConnections_Click(object sender, EventArgs e)      => new ReviewConnectionApplicationsForm().ShowDialog();
        private void btnVerifyDocuments_Click(object sender, EventArgs e)        => new VerifyDocumentsForm().ShowDialog();
        private void btnScheduleInstallation_Click(object sender, EventArgs e)   => new ScheduleInstallationForm().ShowDialog();
        private void btnBillingReport_Click(object sender, EventArgs e)          => new BillingReportForm().ShowDialog();
        private void btnProfile_Click(object sender, EventArgs e)                => new ProfileForm().ShowDialog();
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowConfirm("Are you sure you want to logout?") == DialogResult.Yes)
            {
                SessionManager.Logout();
                this.Close();
            }
        }

        private void ServiceOfficerDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
