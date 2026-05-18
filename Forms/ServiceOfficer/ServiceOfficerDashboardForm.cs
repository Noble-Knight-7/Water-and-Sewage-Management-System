using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WaterSewageManagementSystem.Forms.Common;
using WaterSewageManagementSystem.Helpers;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ServiceOfficerDashboardForm : Form
    {
        //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ServiceOfficerDashboardForm()
        {
            InitializeComponent();

            if (SessionManager.CurrentUser != null)
            {
                lbl_Welcome.Text = "Welcome, " + SessionManager.CurrentUser.FullName;
            }
        }

        private void ServiceOfficerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData(); //Can we move it inside the Constructor? We can, but it's generally better to keep data loading in the Load event. This way, if we ever need to refresh the dashboard data without re-creating the form, we can just call LoadDashboardData() again.
        }

        private void LoadDashboardData()
        {
            LoadCounts();
            LoadRecentRecords();
        }

        private void LoadCounts()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conn.Open();

                string queryMeter = "SELECT COUNT(*) FROM Bills WHERE PreviousReading IS NOT NULL AND CurrentReading IS NOT NULL";
                SqlCommand cmdMeter = new SqlCommand(queryMeter, conn);
                lblMeterCount.Text = cmdMeter.ExecuteScalar().ToString();

                string queryBill = "SELECT COUNT(*) FROM Bills";
                SqlCommand cmdBill = new SqlCommand(queryBill, conn);
                lblBillCount.Text = cmdBill.ExecuteScalar().ToString();

                string queryDispute = "SELECT COUNT(*) FROM BillDisputes WHERE Status='Pending' OR Status IS NULL";
                SqlCommand cmdDispute = new SqlCommand(queryDispute, conn);
                lblDisputeCount.Text = cmdDispute.ExecuteScalar().ToString();

                string queryConnection = "SELECT COUNT(*) FROM ConnectionApplications WHERE ApprovalStatus='Pending' OR ApprovalStatus IS NULL";
                SqlCommand cmdConnection = new SqlCommand(queryConnection, conn);
                lblConnectionCount.Text = cmdConnection.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard counts: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadRecentRecords()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True");

            try
            {
                conn.Open();

                string query = @"
                    SELECT TOP 10 
                        ID,
                        Type,
                        Customer,
                        CONVERT(varchar(20), RecordDate, 106) AS Date,
                        Status
                    FROM
                    (
                        SELECT 
                            b.BillID AS ID,
                            'Bill' AS Type,
                            u.FullName AS Customer,
                            b.CreatedAt AS RecordDate,
                            b.Status AS Status
                        FROM Bills b
                        JOIN Customers c ON b.CustomerID = c.CustomerID
                        JOIN Users u ON c.UserID = u.UserID

                        UNION ALL

                        SELECT 
                            d.DisputeID AS ID,
                            'Bill Dispute' AS Type,
                            u.FullName AS Customer,
                            d.SubmittedAt AS RecordDate,
                            d.Status AS Status
                        FROM BillDisputes d
                        JOIN Customers c ON d.CustomerID = c.CustomerID
                        JOIN Users u ON c.UserID = u.UserID

                        UNION ALL

                        SELECT 
                            a.ApplicationID AS ID,
                            'Connection Application' AS Type,
                            u.FullName AS Customer,
                            a.ApplicationDate AS RecordDate,
                            a.ApprovalStatus AS Status
                        FROM ConnectionApplications a
                        JOIN Customers c ON a.CustomerID = c.CustomerID
                        JOIN Users u ON c.UserID = u.UserID
                    ) AS RecentRecords
                    ORDER BY RecordDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvRecentRecords.AutoGenerateColumns = false;

                colId.DataPropertyName = "ID";
                colType.DataPropertyName = "Type";
                colCustomer.DataPropertyName = "Customer";
                colDate.DataPropertyName = "Date";
                colStatus.DataPropertyName = "Status";

                dgvRecentRecords.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent records: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnMeterReading_Click(object sender, EventArgs e)
        {
            new MeterReadingBillGenerateForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnListofBill_Click(object sender, EventArgs e)
        {
            new CustomerBillListForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnReviewDisputes_Click(object sender, EventArgs e)
        {
            new ReviewDisputesForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnCorrectBill_Click(object sender, EventArgs e)
        {
            new CorrectBillForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnReviewConnections_Click(object sender, EventArgs e)
        {
            new ReviewConnectionApplicationsForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnVerifyDocuments_Click(object sender, EventArgs e)
        {
            new VerifyDocumentsForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnScheduleInstallation_Click(object sender, EventArgs e)
        {
            new ScheduleInstallationForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnBillingReport_Click(object sender, EventArgs e)
        {
            new BillingReportForm().ShowDialog();
            LoadDashboardData();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().ShowDialog();
        }

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
                SessionManager.Logout();

                LoginForm login = new LoginForm();
                login.Show();

                this.Hide();
            }
        }
    }
}