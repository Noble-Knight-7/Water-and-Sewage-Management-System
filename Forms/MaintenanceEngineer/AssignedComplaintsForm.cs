using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class AssignedComplaintsForm : Form
    {
        private readonly ComplaintService _complaintService = new ComplaintService();

        public AssignedComplaintsForm() { InitializeComponent(); LoadComplaints(); }

        private void LoadComplaints()
        {
            dgvComplaints.DataSource = null;
            dgvComplaints.DataSource = _complaintService.GetByEngineer(SessionManager.CurrentUser.UserID);
        }

        private void btnMarkInProgress_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a complaint."); return; }
            int id = (int)dgvComplaints.SelectedRows[0].Cells["ComplaintID"].Value;
            _complaintService.MarkInProgress(id);
            MessageHelper.ShowSuccess("Complaint marked as In Progress.");
            LoadComplaints();
        }

        private void btnMarkResolved_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a complaint."); return; }
            int id = (int)dgvComplaints.SelectedRows[0].Cells["ComplaintID"].Value;
            if (MessageHelper.ShowConfirm("Mark this complaint as Resolved?") == DialogResult.Yes)
            {
                _complaintService.MarkResolved(id);
                MessageHelper.ShowSuccess("Complaint marked as Resolved.");
                LoadComplaints();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadComplaints();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
