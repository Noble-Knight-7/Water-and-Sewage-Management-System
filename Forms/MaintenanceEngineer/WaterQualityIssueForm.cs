using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    public partial class WaterQualityIssueForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public WaterQualityIssueForm()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string issueType = cmbIssueType.SelectedItem?.ToString();
            string area = txtArea.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (issueType == null || issueType == "")
            {
                MessageBox.Show("Please select the type of water quality issue.");
                return;
            }

            if (area == "")
            {
                MessageBox.Show("Please enter the affected area.");
                txtArea.Focus();
                return;
            }

            if (description == "")
            {
                MessageBox.Show("Please describe the issue in detail.");
                txtDescription.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                "This will publish an emergency notice and create a high-priority complaint. Proceed?",
                "Confirm Water Quality Report",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string noticeTitle = "Water Quality Alert: " + issueType;
                string noticeDescription = "Area: " + area + ". " + description;

                noticeTitle = noticeTitle.Replace("'", "''");
                noticeDescription = noticeDescription.Replace("'", "''");
                string safeArea = area.Replace("'", "''");

                string noticeQuery = "INSERT INTO Notices (Title, Description, Area, NoticeType, PublishedBy, PublishDate) " +
                                     "VALUES ('" + noticeTitle + "', '" + noticeDescription + "', '" + safeArea +
                                     "', 'Emergency', " + LoginForm.LoggedInUserID + ", GETDATE())";

                SqlCommand noticeCmd = new SqlCommand(noticeQuery, conn);
                int noticeRows = noticeCmd.ExecuteNonQuery();

                string customerQuery = "SELECT TOP 1 CustomerID FROM Customers ORDER BY CustomerID";
                SqlCommand customerCmd = new SqlCommand(customerQuery, conn);
                object customerResult = customerCmd.ExecuteScalar();

                int complaintRows = 0;

                if (customerResult != null && customerResult != DBNull.Value)
                {
                    int customerID = Convert.ToInt32(customerResult);

                    string complaintDescription = "[Reported by Engineer " + LoginForm.LoggedInFullName + "] " +
                                                  "Issue Type: " + issueType + ". Area: " + area + ". Details: " + description;
                    complaintDescription = complaintDescription.Replace("'", "''");

                    string complaintQuery = "INSERT INTO Complaints (CustomerID, Category, Description, Priority, Status, DateSubmitted) " +
                                            "VALUES (" + customerID + ", 'Water Quality', '" + complaintDescription +
                                            "', 'Urgent', 'Pending', GETDATE())";

                    SqlCommand complaintCmd = new SqlCommand(complaintQuery, conn);
                    complaintRows = complaintCmd.ExecuteNonQuery();
                }

                if (noticeRows > 0 && complaintRows > 0)
                {
                    MessageBox.Show("Water quality issue reported. Emergency notice published and urgent complaint created.");
                }
                else if (noticeRows > 0)
                {
                    MessageBox.Show("Emergency notice published. No customer was found, so complaint ticket was not created.");
                }
                else
                {
                    MessageBox.Show("Water quality issue was not reported.");
                }

                txtArea.Clear();
                txtDescription.Clear();
                cmbIssueType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reporting water quality issue: " + ex.Message);
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
