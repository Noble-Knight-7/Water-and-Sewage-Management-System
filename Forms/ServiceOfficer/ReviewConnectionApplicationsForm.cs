using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WaterSewageManagementSystem.Helpers;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ReviewConnectionApplicationsForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ReviewConnectionApplicationsForm()
        {
            InitializeComponent();
            LoadApplications();
        }

        private void LoadApplications()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    a.ApplicationID,
                                    a.CustomerID,
                                    u.FullName AS CustomerName,
                                    c.HoldingNumber,
                                    c.MeterNumber,
                                    c.ConnectionType,
                                    a.ApplicationDate,
                                    a.DocumentStatus,
                                    a.ApprovalStatus,
                                    a.RejectionReason,
                                    a.AssignedOfficer,
                                    a.InstallationDate
                                 FROM ConnectionApplications a
                                 JOIN Customers c ON a.CustomerID = c.CustomerID
                                 JOIN Users u ON c.UserID = u.UserID
                                 ORDER BY a.ApplicationDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvApplications.DataSource = dt;
                dgvApplications.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading connection applications: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an application first.");
                return;
            }

            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("No logged in user found. Please login again.");
                return;
            }

            int appID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            string currentStatus = dgvApplications.SelectedRows[0].Cells["ApprovalStatus"].Value.ToString();

            if (currentStatus == "Approved")
            {
                MessageBox.Show("This application is already approved.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Approve this connection application?",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            int officerID = SessionManager.CurrentUser.UserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE ConnectionApplications " +
                               "SET ApprovalStatus='Approved', RejectionReason='', AssignedOfficer=" + officerID +
                               " WHERE ApplicationID=" + appID;

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Application approved successfully.");
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Application was not approved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving application: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an application first.");
                return;
            }

            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("No logged in user found. Please login again.");
                return;
            }

            int appID = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            string currentStatus = dgvApplications.SelectedRows[0].Cells["ApprovalStatus"].Value.ToString();

            if (currentStatus == "Rejected")
            {
                MessageBox.Show("This application is already rejected.");
                return;
            }

            string reason = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter rejection reason:",
                "Reject Application",
                ""
            );

            if (reason == "")
            {
                MessageBox.Show("Rejection reason is required.");
                return;
            }

            reason = reason.Replace("'", "''");

            DialogResult result = MessageBox.Show(
                "Reject this connection application?",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            int officerID = SessionManager.CurrentUser.UserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE ConnectionApplications " +
                               "SET ApprovalStatus='Rejected', RejectionReason='" + reason + "', AssignedOfficer=" + officerID +
                               " WHERE ApplicationID=" + appID;

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Application rejected successfully.");
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Application was not rejected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error rejecting application: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}