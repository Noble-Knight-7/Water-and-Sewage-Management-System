using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class CompletionReportForm : Form
    {
        private readonly MaintenanceService _maintenanceService = new MaintenanceService();
        private readonly ReportService      _reportService      = new ReportService();

        public CompletionReportForm() { InitializeComponent(); LoadTasks(); }

        private void LoadTasks()
        {
            // Show only tasks that are InProgress or Pending - ones that still need a completion report
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _maintenanceService.GetByEngineer(SessionManager.CurrentUser.UserID);
        }

        private void dgvTasks_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0) return;
            // Load existing completion report if there is one
            string existing = dgvTasks.SelectedRows[0].Cells["CompletionReport"].Value?.ToString() ?? "";
            txtReport.Text = existing;
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageHelper.ShowWarning("Select a task to submit a completion report for."); return;
            }
            if (ValidationHelper.IsEmpty(txtReport.Text))
            {
                MessageHelper.ShowError("Please write the completion report before submitting."); return;
            }

            int taskID = (int)dgvTasks.SelectedRows[0].Cells["TaskID"].Value;

            if (MessageHelper.ShowConfirm("Submit this completion report? This will mark the task as Completed.") == DialogResult.Yes)
            {
                // Save completion report and mark task Completed
                bool success = _maintenanceService.SubmitCompletionReport(taskID, txtReport.Text.Trim());
                if (success)
                {
                    // Also log it in the Reports table
                    _reportService.LogReport(
                        SessionManager.CurrentUser.UserID,
                        "Maintenance",
                        "Completion report submitted for Task ID " + taskID + " by " + SessionManager.CurrentUser.FullName
                    );
                    MessageHelper.ShowSuccess("Completion report submitted. Task is now marked as Completed.");
                    txtReport.Clear();
                    LoadTasks();
                }
                else
                {
                    MessageHelper.ShowError("Failed to submit report. Please try again.");
                }
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e) => this.Close();
    }
}
