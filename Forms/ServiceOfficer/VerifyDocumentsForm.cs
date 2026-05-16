using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;


namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class VerifyDocumentsForm : Form
    {
        private readonly ConnectionService _connectionService = new ConnectionService();

        public VerifyDocumentsForm()
        {
            InitializeComponent();
            LoadApplications();
        }
        private void LoadApplications()
        {
            dgvApplications.DataSource = null;
            dgvApplications.DataSource = _connectionService.GetAll();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select an application."); return; }
            int appID = (int)dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value;
            if (MessageHelper.ShowConfirm("Mark documents as Verified for this application?") == DialogResult.Yes)
            {
                _connectionService.VerifyDocuments(appID);
                MessageHelper.ShowSuccess("Documents verified. You can now approve the connection application.");
                LoadApplications();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
