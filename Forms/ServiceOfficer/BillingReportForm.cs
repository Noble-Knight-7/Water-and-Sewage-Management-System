using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WaterSewageManagementSystem.Helpers;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class BillingReportForm : Form
    {
        string connectionString = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public BillingReportForm()
        {
            InitializeComponent();
            LoadBills();
        }

        private void LoadBills()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    b.BillID,
                                    b.CustomerID,
                                    u.FullName AS CustomerName,
                                    c.MeterNumber,
                                    b.BillingMonth,
                                    b.PreviousReading,
                                    b.CurrentReading,
                                    b.UnitUsed,
                                    b.Amount,
                                    b.Arrears,
                                    b.Status,
                                    b.CreatedAt
                                 FROM Bills b
                                 JOIN Customers c ON b.CustomerID = c.CustomerID
                                 JOIN Users u ON c.UserID = u.UserID
                                 ORDER BY b.CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvBills.DataSource = dt;
                dgvBills.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bills: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLogReport_Click(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("No logged in user found. Please login again.");
                return;
            }

            int createdBy = SessionManager.CurrentUser.UserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "INSERT INTO Reports (CreatedBy, ReportType, CreatedDate, Description) " +
                               "VALUES (" + createdBy + ", 'Billing', GETDATE(), 'Service Officer generated billing report.')";

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Billing report logged successfully.");
                }
                else
                {
                    MessageBox.Show("Report was not logged.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging report: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}