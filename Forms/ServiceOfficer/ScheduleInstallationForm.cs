using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ScheduleInstallationForm : Form
    {
        private readonly ConnectionService _connectionService = new ConnectionService();

        public ScheduleInstallationForm()
        {
            InitializeComponent();
            LoadApplications();
        }

        private void LoadApplications()
        {
            dgvApplications.DataSource = null;
            dgvApplications.DataSource = _connectionService.GetAll();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select an approved application."); return; }
            int appID = (int)dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value;
            string approvalStatus = dgvApplications.SelectedRows[0].Cells["ApprovalStatus"].Value.ToString();
            if (approvalStatus != "Approved")
            {
                MessageHelper.ShowWarning("Only Approved applications can be scheduled for installation."); return;
            }
            DateTime installDate = dtpInstallDate.Value;
            if (installDate < DateTime.Today)
            {
                MessageHelper.ShowError("Installation date cannot be in the past."); return;
            }
            _connectionService.ScheduleInstallation(appID, installDate);
            MessageHelper.ShowSuccess("Installation scheduled for " + installDate.ToString("dd MMM yyyy") + ".");
            LoadApplications();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
