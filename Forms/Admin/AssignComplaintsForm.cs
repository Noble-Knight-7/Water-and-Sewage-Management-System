using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class AssignComplaintsForm : Form
    {
        private readonly ComplaintService _complaintService = new ComplaintService();
        private readonly UserService _userService = new UserService();

        public AssignComplaintsForm() { InitializeComponent(); LoadData(); }

        private void LoadData()
        {
            dgvComplaints.DataSource = null;
            dgvComplaints.DataSource = _complaintService.GetAll();

            cmbEngineer.DataSource    = null;
            cmbEngineer.DataSource    = _userService.GetEngineers();
            cmbEngineer.DisplayMember = "FullName";
            cmbEngineer.ValueMember   = "UserID";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a complaint."); return; }
            if (cmbEngineer.SelectedItem == null) { MessageHelper.ShowWarning("Select an engineer."); return; }

            int complaintID = (int)dgvComplaints.SelectedRows[0].Cells["ComplaintID"].Value;
            int engineerID  = (int)cmbEngineer.SelectedValue;

            bool success = _complaintService.Assign(complaintID, engineerID);
            if (success) { MessageHelper.ShowSuccess("Complaint assigned successfully."); LoadData(); }
            else MessageHelper.ShowError("Failed to assign complaint.");
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
