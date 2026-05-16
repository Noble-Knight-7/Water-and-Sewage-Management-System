using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class ViewNoticesForm : Form
    {
        private readonly NoticeService _noticeService = new NoticeService();

        public ViewNoticesForm() { InitializeComponent(); LoadNotices(); }

        private void LoadNotices()
        {
            dgvNotices.DataSource = null;
            dgvNotices.DataSource = _noticeService.GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
