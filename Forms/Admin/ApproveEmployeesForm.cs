using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class ApproveEmployeesForm : Form
    {
        private readonly UserService _userService = new UserService();
        public ApproveEmployeesForm() { InitializeComponent(); LoadPending(); }

        private void LoadPending()
        {
            dgvPending.DataSource = null;
            dgvPending.DataSource = _userService.GetPendingEmployees();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvPending.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select an employee to approve."); return; }
            int id = (int)dgvPending.SelectedRows[0].Cells["UserID"].Value;
            string name = dgvPending.SelectedRows[0].Cells["FullName"].Value.ToString();
            if (MessageHelper.ShowConfirm($"Approve {name}?") == DialogResult.Yes)
            {
                _userService.ApproveEmployee(id);
                MessageHelper.ShowSuccess($"{name} has been approved and can now log in.");
                LoadPending();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadPending();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void ApproveEmployeesForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPageIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
