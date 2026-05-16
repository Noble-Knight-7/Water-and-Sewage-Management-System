using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class MaintenanceTasksForm : Form
    {
        private readonly MaintenanceService _maintenanceService = new MaintenanceService();

        public MaintenanceTasksForm() { InitializeComponent(); LoadTasks(); }

        private void LoadTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = _maintenanceService.GetByEngineer(SessionManager.CurrentUser.UserID);
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadTasks();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
