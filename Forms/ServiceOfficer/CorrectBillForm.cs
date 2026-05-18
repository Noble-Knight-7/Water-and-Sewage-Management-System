using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class CorrectBillForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public CorrectBillForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtBillID.Text == "")
            {
                MessageBox.Show("Enter Bill ID.");
                return;
            }

            int billID;

            if (!int.TryParse(txtBillID.Text, out billID))
            {
                MessageBox.Show("Enter a valid Bill ID.");
                return;
            }

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
                                    b.Amount,
                                    b.Arrears,
                                    b.Status
                                 FROM Bills b
                                 JOIN Customers c ON b.CustomerID = c.CustomerID
                                 JOIN Users u ON c.UserID = u.UserID
                                 WHERE b.BillID = " + billID;

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bill not found.");
                    lblBillInfo.Text = "";
                    txtNewAmount.Text = "";
                    txtNewAmount.Enabled = false;
                    btnSave.Enabled = false;
                    return;
                }

                DataRow row = dt.Rows[0];

                lblBillInfo.Text = "Customer: " + row["CustomerName"].ToString()
                    + " | Meter: " + row["MeterNumber"].ToString()
                    + " | Month: " + row["BillingMonth"].ToString()
                    + " | Status: " + row["Status"].ToString();

                txtNewAmount.Text = Convert.ToDecimal(row["Amount"]).ToString("N2");

                txtNewAmount.Enabled = true;
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bill: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBillID.Text == "")
            {
                MessageBox.Show("Enter Bill ID.");
                return;
            }

            int billID;

            if (!int.TryParse(txtBillID.Text, out billID))
            {
                MessageBox.Show("Enter a valid Bill ID.");
                return;
            }

            decimal newAmount;

            if (!decimal.TryParse(txtNewAmount.Text, out newAmount))
            {
                MessageBox.Show("Enter a valid corrected amount.");
                return;
            }

            if (newAmount <= 0)
            {
                MessageBox.Show("Corrected amount must be greater than 0.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Correct this bill amount to Tk. " + newAmount.ToString("N2") + "?",
                "Confirm Correction",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string amountText = newAmount.ToString(CultureInfo.InvariantCulture);

                string query = "UPDATE Bills SET Amount = " + amountText + " WHERE BillID = " + billID;

                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Bill amount corrected successfully.");

                    txtBillID.Text = "";
                    txtNewAmount.Text = "";
                    lblBillInfo.Text = "";

                    txtNewAmount.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Bill correction failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error correcting bill: " + ex.Message);
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