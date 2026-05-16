using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ReviewConnectionApplicationsForm : Form
    {
        private readonly ConnectionService _connectionService = new ConnectionService();
        public ReviewConnectionApplicationsForm()
        {
            InitializeComponent();
            LoadApplications();
        }
        private void LoadApplications()
        {
            dgvApplications.DataSource = null;
            dgvApplications.DataSource = _connectionService.GetAll();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select an application."); return; }
            int appID = (int)dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value;
            if (MessageHelper.ShowConfirm("Approve this connection application?") == DialogResult.Yes)
            {
                _connectionService.Approve(appID, SessionManager.CurrentUser.UserID);
                MessageHelper.ShowSuccess("Application approved.");
                LoadApplications();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select an application."); return; }
            int appID = (int)dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value;
            string reason = Microsoft.VisualBasic.Interaction.InputBox("Enter rejection reason:", "Reject Application", "");
            if (string.IsNullOrWhiteSpace(reason)) return;
            _connectionService.Reject(appID, SessionManager.CurrentUser.UserID, reason);
            MessageHelper.ShowSuccess("Application rejected.");
            LoadApplications();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
