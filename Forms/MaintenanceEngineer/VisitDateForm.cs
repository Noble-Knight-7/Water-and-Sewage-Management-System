using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class VisitDateForm : Form
    {
        private readonly MaintenanceService _maintenanceService = new MaintenanceService();

        public VisitDateForm() { InitializeComponent(); LoadTasks(); }

        private void LoadTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _maintenanceService.GetByEngineer(SessionManager.CurrentUser.UserID);
        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageHelper.ShowWarning("Please select a task first."); return;
            }

            int taskID = (int)dgvTasks.SelectedRows[0].Cells["TaskID"].Value;
            DateTime visitDate = dtpVisitDate.Value;

            if (visitDate.Date < DateTime.Today)
            {
                MessageHelper.ShowError("Visit date cannot be in the past."); return;
            }

            bool success = _maintenanceService.SetVisitDate(taskID, visitDate);
            if (success)
            {
                MessageHelper.ShowSuccess("Visit date set to " + visitDate.ToString("dd MMM yyyy") + ".");
                LoadTasks();
            }
            else
            {
                MessageHelper.ShowError("Failed to set visit date. Please try again.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadTasks();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
