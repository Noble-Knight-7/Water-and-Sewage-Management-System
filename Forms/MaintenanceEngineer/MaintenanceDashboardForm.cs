using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class MaintenanceDashboardForm : Form
    {
        public MaintenanceDashboardForm()
        {
            InitializeComponent();

            if (SessionManager.CurrentUser != null)
            {
                lblWelcome.Text = "Welcome, " + SessionManager.CurrentUser.FullName;
            }
            else
            {
                lblWelcome.Text = "Welcome, Maintenance Engineer";
            }
        }

        private void btnAssignedComplaints_Click(object sender, EventArgs e)  => new AssignedComplaintsForm().ShowDialog();
        private void btnMaintenanceTasks_Click(object sender, EventArgs e)    => new MaintenanceTasksForm().ShowDialog();
        private void btnRepairProgress_Click(object sender, EventArgs e)      => new RepairProgressForm().ShowDialog();
        private void btnVisitDate_Click(object sender, EventArgs e)           => new VisitDateForm().ShowDialog();
        private void btnInspectionNotes_Click(object sender, EventArgs e)     => new InspectionNotesForm().ShowDialog();
        private void btnCompletionReport_Click(object sender, EventArgs e)    => new CompletionReportForm().ShowDialog();
        private void btnWaterQuality_Click(object sender, EventArgs e)        => new WaterQualityIssueForm().ShowDialog();
        private void btnProfile_Click(object sender, EventArgs e)             => new ProfileForm().ShowDialog();
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowConfirm("Are you sure you want to logout?") == DialogResult.Yes)
            {
                SessionManager.Logout();
                this.Close();
            }
        }

        private void MaintenanceDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
