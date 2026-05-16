using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class ReviewDisputesForm : Form
    {
        private readonly DbConnection _db = new DbConnection();

        public ReviewDisputesForm() { InitializeComponent(); LoadDisputes(); }

        private void LoadDisputes()
        {
            var list = new System.Collections.Generic.List<BillDispute>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT d.*, u.FullName AS CustomerName, b.BillingMonth, b.Amount AS BillAmount
                               FROM BillDisputes d
                               JOIN Customers c ON d.CustomerID = c.CustomerID
                               JOIN Users u ON c.UserID = u.UserID
                               JOIN Bills b ON d.BillID = b.BillID
                               ORDER BY d.SubmittedAt DESC";
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new BillDispute
                        {
                            DisputeID    = (int)r["DisputeID"],
                            BillID       = (int)r["BillID"],
                            CustomerID   = (int)r["CustomerID"],
                            Reason       = r["Reason"].ToString(),
                            Status       = r["Status"].ToString(),
                            SubmittedAt  = Convert.ToDateTime(r["SubmittedAt"]),
                            CustomerName = r["CustomerName"].ToString(),
                            BillingMonth = r["BillingMonth"].ToString(),
                            BillAmount   = Convert.ToDecimal(r["BillAmount"])
                        });
                    }
                }
            }
            dgvDisputes.DataSource = list;
        }

        private void btnMarkReviewed_Click(object sender, EventArgs e)
        {
            if (dgvDisputes.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a dispute."); return; }
            int id = (int)dgvDisputes.SelectedRows[0].Cells["DisputeID"].Value;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE BillDisputes SET Status='Reviewed', ReviewedBy=@By WHERE DisputeID=@ID";
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@By", SessionManager.CurrentUser.UserID);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageHelper.ShowSuccess("Dispute marked as Reviewed. You can now open Correct Bill to adjust the amount.");
            LoadDisputes();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
