using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WaterSewageManagementSystem;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class CurrentBillForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        int currentBillID = 0;
        int currentCustomerID = 0;
        string currentBillStatus = "";

        public CurrentBillForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadBill();
            }
        }

        private void LoadBill()
        {
            if (LoginForm.LoggedInUserID == 0)
            {
                lblBillID.Text = "No logged-in user.";
                lblMonth.Text = "";
                lblUnits.Text = "";
                lblAmount.Text = "";
                lblArrears.Text = "";
                lblTotal.Text = "";
                lblStatus.Text = "";

                btnDispute.Enabled = false;
                return;
            }

            int userID = LoginForm.LoggedInUserID;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT TOP 1
                                    b.BillID,
                                    b.CustomerID,
                                    b.BillingMonth,
                                    b.PreviousReading,
                                    b.CurrentReading,
                                    b.Amount,
                                    b.Arrears,
                                    b.Status,
                                    b.CreatedAt
                                 FROM Bills b
                                 JOIN Customers c ON b.CustomerID = c.CustomerID
                                 WHERE c.UserID = " + userID + @"
                                 ORDER BY b.CreatedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    lblBillID.Text = "No bills found.";
                    lblMonth.Text = "";
                    lblUnits.Text = "";
                    lblAmount.Text = "";
                    lblArrears.Text = "";
                    lblTotal.Text = "";
                    lblStatus.Text = "";

                    btnDispute.Enabled = false;
                    return;
                }

                DataRow row = dt.Rows[0];

                currentBillID = Convert.ToInt32(row["BillID"]);
                currentCustomerID = Convert.ToInt32(row["CustomerID"]);
                currentBillStatus = row["Status"].ToString();

                int previousReading = Convert.ToInt32(row["PreviousReading"]);
                int currentReading = Convert.ToInt32(row["CurrentReading"]);
                int unitsUsed = currentReading - previousReading;

                decimal amount = Convert.ToDecimal(row["Amount"]);
                decimal arrears = Convert.ToDecimal(row["Arrears"]);
                decimal totalDue = amount + arrears;

                lblBillID.Text = "Bill #" + currentBillID;
                lblMonth.Text = "Month: " + row["BillingMonth"].ToString();

                lblUnits.Text = "Previous: " + previousReading +
                                "  |  Current: " + currentReading +
                                "  |  Units Used: " + unitsUsed;

                lblAmount.Text = "Bill Amount: Tk. " + amount.ToString("N2");
                lblArrears.Text = "Arrears: Tk. " + arrears.ToString("N2");
                lblTotal.Text = "Total Due: Tk. " + totalDue.ToString("N2");
                lblStatus.Text = "Status: " + currentBillStatus;

                if (currentBillStatus == "Paid")
                {
                    lblStatus.ForeColor = Color.Green;
                    btnDispute.Enabled = false;
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    btnDispute.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading current bill: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CurrentBillForm_Load(object sender, EventArgs e)
        {

        }

        private void panelBill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMonth_Click(object sender, EventArgs e)
        {

        }

        private void lblBillID_Click(object sender, EventArgs e)
        {

        }

        private void lblUnits_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblArrears_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnDispute_Click(object sender, EventArgs e)
        {
            new SubmitBillDisputeForm(currentBillID).ShowDialog();
            //if (currentBillID == 0 || currentCustomerID == 0)
            //{
            //    MessageBox.Show("No bill selected for dispute.");
            //    return;
            //}

            //if (currentBillStatus == "Paid")
            //{
            //    MessageBox.Show("Paid bill cannot be disputed.");
            //    return;
            //}

            //string reason = Microsoft.VisualBasic.Interaction.InputBox(
            //    "Enter your dispute reason:",
            //    "Submit Bill Dispute",
            //    ""
            //);

            //if (reason == "")
            //{
            //    MessageBox.Show("Dispute reason is required.");
            //    return;
            //}

            //reason = reason.Replace("'", "''");

            //SqlConnection conn = new SqlConnection(connectionString);

            //try
            //{
            //    conn.Open();

            //    string checkQuery = "SELECT COUNT(*) FROM BillDisputes " +
            //                        "WHERE BillID = " + currentBillID +
            //                        " AND CustomerID = " + currentCustomerID +
            //                        " AND Status = 'Pending'";

            //    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);

            //    int pendingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

            //    if (pendingCount > 0)
            //    {
            //        MessageBox.Show("You already have a pending dispute for this bill.");
            //        return;
            //    }

            //    DialogResult result = MessageBox.Show(
            //        "Submit dispute for this bill?",
            //        "Confirm Dispute",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Question
            //    );

            //    if (result == DialogResult.No)
            //    {
            //        return;
            //    }

            //    string insertQuery = "INSERT INTO BillDisputes " +
            //                         "(BillID, CustomerID, Reason, Status, SubmittedAt) " +
            //                         "VALUES (" +
            //                         currentBillID + ", " +
            //                         currentCustomerID + ", '" +
            //                         reason + "', 'Pending', GETDATE())";

            //    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

            //    int rows = insertCmd.ExecuteNonQuery();

            //    if (rows > 0)
            //    {
            //        MessageBox.Show("Bill dispute submitted successfully.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Dispute was not submitted.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error submitting dispute: " + ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
