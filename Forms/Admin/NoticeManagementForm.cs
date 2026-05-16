using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class NoticeManagementForm : Form
    {
        private readonly NoticeService _noticeService = new NoticeService();
        public NoticeManagementForm()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                LoadNotices();
            }
        }

        private void LoadNotices()
        {
            dgvNotices.DataSource = null;
            dgvNotices.DataSource = _noticeService.GetAll();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.IsEmpty(txtTitle.Text) || ValidationHelper.IsEmpty(txtDescription.Text))
            {
                MessageHelper.ShowError("Title and description are required."); return;
            }

            var notice = new Notice
            {
                Title       = txtTitle.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Area        = txtArea.Text.Trim(),
                NoticeType  = cmbType.SelectedItem?.ToString() ?? "General",
                PublishedBy = SessionManager.CurrentUser.UserID
            };

            if (_noticeService.Publish(notice))
            {
                MessageHelper.ShowSuccess("Notice published.");
                txtTitle.Clear(); txtDescription.Clear(); txtArea.Clear();
                LoadNotices();
            }
            else MessageHelper.ShowError("Failed to publish notice.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a notice to delete."); return; }
            int id = (int)dgvNotices.SelectedRows[0].Cells["NoticeID"].Value;
            if (MessageHelper.ShowConfirm("Delete this notice?") == DialogResult.Yes)
            {
                _noticeService.Delete(id);
                MessageHelper.ShowSuccess("Notice deleted.");
                LoadNotices();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void NoticeManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
