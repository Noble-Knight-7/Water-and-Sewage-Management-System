using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class RepairProgressForm : Form
    {
        private readonly MaintenanceService _maintenanceService = new MaintenanceService();

        public RepairProgressForm() { InitializeComponent(); LoadTasks(); }

        private void LoadTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _maintenanceService.GetByEngineer(SessionManager.CurrentUser.UserID);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a task."); return; }
            if (cmbStatus.SelectedItem == null) { MessageHelper.ShowWarning("Select a status."); return; }
            int taskID = (int)dgvTasks.SelectedRows[0].Cells["TaskID"].Value;
            string status = cmbStatus.SelectedItem.ToString();
            string notes  = txtNotes.Text.Trim();
            bool success  = _maintenanceService.UpdateProgress(taskID, status, notes);
            if (success)
            {
                MessageHelper.ShowSuccess("Progress updated successfully.");
                txtNotes.Clear();
                LoadTasks();
            }
            else MessageHelper.ShowError("Failed to update progress.");
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
