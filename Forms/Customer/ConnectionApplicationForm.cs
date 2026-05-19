using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

using WaterSewageManagementSystem;

namespace WaterSewageManagementSystem.Forms.Customer
{

    public partial class ConnectionApplicationForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ConnectionApplicationForm()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                MessageBox.Show("No logged-in user found. Please login again.");
                return;
            }

            int userID = LoginForm.LoggedInUserID;
            int customerID = 0;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                // Step 1: Find CustomerID of the logged-in customer
                string customerQuery = "SELECT CustomerID FROM Customers WHERE UserID = " + userID;

                SqlCommand customerCmd = new SqlCommand(customerQuery, conn);

                object customerResult = customerCmd.ExecuteScalar();

                if (customerResult == null)
                {
                    MessageBox.Show("Customer record not found.");
                    return;
                }

                customerID = Convert.ToInt32(customerResult);

                // Step 2: Check if this customer already has a pending application
                string checkQuery = "SELECT COUNT(*) FROM ConnectionApplications " +
                                    "WHERE CustomerID = " + customerID + " AND ApprovalStatus = 'Pending'";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);

                int pendingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (pendingCount > 0)
                {
                    MessageBox.Show("You already have a pending connection application.");
                    return;
                }

                // Step 3: Confirm before submitting
                DialogResult result = MessageBox.Show(
                    "Submit a new connection application?\n\nA Service Officer will review your request and contact you.",
                    "Confirm Application",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                // Step 4: Insert new application
                string insertQuery = "INSERT INTO ConnectionApplications " +
                                     "(CustomerID, ApplicationDate, DocumentStatus, ApprovalStatus) " +
                                     "VALUES (" + customerID + ", GETDATE(), 'Pending', 'Pending')";

                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                int rows = insertCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Connection application submitted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to submit application. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting connection application: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
