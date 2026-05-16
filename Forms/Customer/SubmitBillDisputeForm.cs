using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class SubmitBillDisputeForm : Form
    {
        private readonly CustomerRepository _customerRepo = new CustomerRepository();
        private int _preloadedBillID;

        // Default constructor - customer picks their bill
        public SubmitBillDisputeForm() { InitializeComponent(); _preloadedBillID = 0; }

        // Constructor when called from CurrentBillForm with a specific bill
        public SubmitBillDisputeForm(int billID) { InitializeComponent(); _preloadedBillID = billID; txtBillID.Text = billID.ToString(); txtBillID.ReadOnly = true; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBillID.Text, out int billID)) { MessageHelper.ShowError("Enter a valid Bill ID."); return; }
            if (ValidationHelper.IsEmpty(txtReason.Text)) { MessageHelper.ShowError("Please describe your reason."); return; }

            var customer = _customerRepo.GetByUserID(SessionManager.CurrentUser.UserID);
            if (customer == null) { MessageHelper.ShowError("Customer record not found."); return; }

            using (var con = new DbConnection().GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO BillDisputes (BillID, CustomerID, Reason, Status, SubmittedAt)
                               VALUES (@BillID, @CID, @Reason, 'Pending', GETDATE())";
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@BillID",  billID);
                    cmd.Parameters.AddWithValue("@CID",     customer.CustomerID);
                    cmd.Parameters.AddWithValue("@Reason",  txtReason.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                // Mark bill as disputed
                string updateSql = "UPDATE Bills SET Status='Disputed' WHERE BillID=@BillID";
                using (var cmd2 = new Microsoft.Data.SqlClient.SqlCommand(updateSql, con))
                {
                    cmd2.Parameters.AddWithValue("@BillID", billID);
                    cmd2.ExecuteNonQuery();
                }
            }
            MessageHelper.ShowSuccess("Dispute submitted. A Service Officer will review it.");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
