using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class InspectionNotesForm : Form
    {
        private readonly MaintenanceService _maintenanceService = new MaintenanceService();

        public InspectionNotesForm() { InitializeComponent(); LoadTasks(); }

        private void LoadTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _maintenanceService.GetByEngineer(SessionManager.CurrentUser.UserID);
        }

        private void dgvTasks_SelectionChanged(object sender, System.EventArgs e)
        {
            // When engineer clicks a row, load its existing notes into the text box
            if (dgvTasks.SelectedRows.Count == 0) return;
            var row = dgvTasks.SelectedRows[0];
            string existingNotes = row.Cells["Notes"].Value?.ToString() ?? "";
            txtNotes.Text = existingNotes;
        }

        private void btnSaveNotes_Click(object sender, System.EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageHelper.ShowWarning("Select a task first."); return;
            }
            if (ValidationHelper.IsEmpty(txtNotes.Text))
            {
                MessageHelper.ShowError("Please enter inspection notes before saving."); return;
            }

            int taskID = (int)dgvTasks.SelectedRows[0].Cells["TaskID"].Value;

            // Get current status so we don't accidentally reset it
            string currentStatus = dgvTasks.SelectedRows[0].Cells["ProgressStatus"].Value?.ToString() ?? "InProgress";

            bool success = _maintenanceService.UpdateProgress(taskID, currentStatus, txtNotes.Text.Trim());
            if (success)
            {
                MessageHelper.ShowSuccess("Inspection notes saved successfully.");
                LoadTasks();
            }
            else
            {
                MessageHelper.ShowError("Failed to save notes. Please try again.");
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e) => txtNotes.Clear();
        private void btnClose_Click(object sender, System.EventArgs e) => this.Close();
    }
}
