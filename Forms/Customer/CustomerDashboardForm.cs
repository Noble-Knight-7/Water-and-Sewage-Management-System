using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using WaterSewageManagementSystem.Forms.Common;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public CustomerDashboardForm()
        {
            InitializeComponent();

            SetWelcomeText();
            LoadNotices();
        }

        private void SetWelcomeText()
        {
            if (!string.IsNullOrWhiteSpace(LoginForm.LoggedInFullName))
            {
                lblWelcome.Text = "Welcome, " + LoginForm.LoggedInFullName;
            }
            else
            {
                lblWelcome.Text = "Welcome, Customer";
            }
        }

        private void LoadNotices()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            NoticeID,
                            Title,
                            Description,
                            Area,
                            NoticeType,
                            PublishedBy,
                            CONVERT(varchar(20), PublishDate, 106) AS PublishDate
                        FROM Notices
                        ORDER BY PublishDate DESC, NoticeID DESC;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dgvNotices.AutoGenerateColumns = true;
                        dgvNotices.DataSource = dt;

                        FormatNoticeGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading notices: " + ex.Message,
                    "Notice Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FormatNoticeGrid()
        {
            if (dgvNotices.Columns.Count == 0)
                return;

            dgvNotices.ReadOnly = true;
            dgvNotices.AllowUserToAddRows = false;
            dgvNotices.AllowUserToDeleteRows = false;
            dgvNotices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotices.MultiSelect = false;
            dgvNotices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotices.RowHeadersVisible = false;

            if (dgvNotices.Columns.Contains("NoticeID"))
                dgvNotices.Columns["NoticeID"].HeaderText = "Notice ID";

            if (dgvNotices.Columns.Contains("NoticeType"))
                dgvNotices.Columns["NoticeType"].HeaderText = "Notice Type";

            if (dgvNotices.Columns.Contains("PublishedBy"))
                dgvNotices.Columns["PublishedBy"].HeaderText = "Published By";

            if (dgvNotices.Columns.Contains("PublishDate"))
                dgvNotices.Columns["PublishDate"].HeaderText = "Publish Date";

            if (dgvNotices.Columns.Contains("Description"))
                dgvNotices.Columns["Description"].FillWeight = 180;
        }

        private void lblRecentRecords_Click(object sender, EventArgs e)
        {

        }

        private void dgvNotices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadNotices();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCurrentBill_Click(object sender, EventArgs e)
        {
            new CurrentBillForm().ShowDialog();
        }

        private void btnBillHistory_Click(object sender, EventArgs e)
        {
            new BillHistoryForm().ShowDialog();
        }

        private void btnDispute_Click(object sender, EventArgs e)
        {
            new SubmitBillDisputeForm().ShowDialog();
        }

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            new SubmitComplaintForm().ShowDialog();
        }

        private void btnTrackComplaint_Click(object sender, EventArgs e)
        {
            new TrackComplaintForm().ShowDialog();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            new ConnectionApplicationForm().ShowDialog();
        }

        private void btnTrackApp_Click(object sender, EventArgs e)
        {
            new TrackApplicationForm().ShowDialog();
        }

        private void btnNotices_Click(object sender, EventArgs e)
        {
            new ViewNoticesForm().ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().ShowDialog();
        }

        //private void btnLogout_Click(object sender, EventArgs e)
        //{
        //    if (MessageHelper.ShowConfirm("Are you sure you want to logout?") == DialogResult.Yes)
        //    {
        //        SessionManager.Logout();
        //        LoginForm login = new LoginForm();
        //        login.Show();

        //        this.Hide();
        //    }
        //}
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm.LoggedInUserID = 0;
                LoginForm.LoggedInFullName = "";
                LoginForm.LoggedInEmail = "";
                LoginForm.LoggedInRole = "";
                LoginForm.LoggedInStatus = "";

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
