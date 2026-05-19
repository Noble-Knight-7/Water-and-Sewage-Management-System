using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class SystemReportForm : Form
    {
        private readonly ReportService _reportService = new ReportService();
        public SystemReportForm() { InitializeComponent(); LoadReports(); }

        private void LoadReports()
        {
            dgvReports.DataSource = null;
            dgvReports.DataSource = _reportService.GetAll();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string type = cmbType.SelectedItem?.ToString();
            string desc = txtDescription.Text.Trim();
            if (type == null || ValidationHelper.IsEmpty(desc))
            {
                MessageHelper.ShowError("Select a report type and add a description."); return;
            }
            bool ok = _reportService.LogReport(SessionManager.CurrentUser.UserID, type, desc);
            if (ok) { MessageHelper.ShowSuccess("Report logged."); txtDescription.Clear(); LoadReports(); }
            else MessageHelper.ShowError("Failed to log report.");
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
