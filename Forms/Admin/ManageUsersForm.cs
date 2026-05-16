using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class ManageUsersForm : Form
    {
        private readonly UserService _userService = new UserService();

        public ManageUsersForm() { InitializeComponent(); LoadUsers(); }

        private void LoadUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _userService.GetAllUsers();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a user first."); return; }
            int id = (int)dgvUsers.SelectedRows[0].Cells["UserID"].Value;
            _userService.ActivateUser(id);
            MessageHelper.ShowSuccess("User activated.");
            LoadUsers();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a user first."); return; }
            int id = (int)dgvUsers.SelectedRows[0].Cells["UserID"].Value;
            if (MessageHelper.ShowConfirm("Deactivate this user?") == DialogResult.Yes)
            {
                _userService.DeactivateUser(id);
                MessageHelper.ShowSuccess("User deactivated.");
                LoadUsers();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadUsers();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
