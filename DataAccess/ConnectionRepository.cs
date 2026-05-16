using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.DataAccess
{
    public class ConnectionRepository
    {
        private readonly DbConnection _db;
        public ConnectionRepository() { _db = new DbConnection(); }

        public List<ConnectionApplication> GetAll()
        {
            var list = new List<ConnectionApplication>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT a.*, u.FullName AS CustomerName, c.HoldingNumber
                               FROM ConnectionApplications a
                               JOIN Customers c ON a.CustomerID = c.CustomerID
                               JOIN Users u ON c.UserID = u.UserID
                               ORDER BY a.ApplicationDate DESC";
                using (var cmd = new SqlCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapApp(r));
            }
            return list;
        }

        public List<ConnectionApplication> GetByCustomerID(int customerID)
        {
            var list = new List<ConnectionApplication>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT a.*, u.FullName AS CustomerName, c.HoldingNumber
                               FROM ConnectionApplications a
                               JOIN Customers c ON a.CustomerID = c.CustomerID
                               JOIN Users u ON c.UserID = u.UserID
                               WHERE a.CustomerID = @CustomerID
                               ORDER BY a.ApplicationDate DESC";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(MapApp(r));
                }
            }
            return list;
        }

        public ConnectionApplication GetByID(int appID)
        {
            ConnectionApplication app = null;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT a.*, u.FullName AS CustomerName, c.HoldingNumber
                               FROM ConnectionApplications a
                               JOIN Customers c ON a.CustomerID = c.CustomerID
                               JOIN Users u ON c.UserID = u.UserID
                               WHERE a.ApplicationID = @AppID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@AppID", appID);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) app = MapApp(r);
                }
            }
            return app;
        }

        public bool Insert(ConnectionApplication app)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO ConnectionApplications (CustomerID, ApplicationDate, DocumentStatus, ApprovalStatus)
                               VALUES (@CustomerID, GETDATE(), 'Pending', 'Pending')";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", app.CustomerID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateApproval(int appID, string approvalStatus, string rejectionReason, int officerID)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"UPDATE ConnectionApplications
                               SET ApprovalStatus=@Status, RejectionReason=@Reason, AssignedOfficer=@OfficerID
                               WHERE ApplicationID=@AppID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Status", approvalStatus);
                    cmd.Parameters.AddWithValue("@Reason", rejectionReason ?? "");
                    cmd.Parameters.AddWithValue("@OfficerID", officerID);
                    cmd.Parameters.AddWithValue("@AppID", appID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateDocumentStatus(int appID, string docStatus)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE ConnectionApplications SET DocumentStatus=@Status WHERE ApplicationID=@AppID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Status", docStatus);
                    cmd.Parameters.AddWithValue("@AppID", appID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool SetInstallationDate(int appID, DateTime date)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE ConnectionApplications SET InstallationDate=@Date WHERE ApplicationID=@AppID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@AppID", appID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private ConnectionApplication MapApp(SqlDataReader r)
        {
            return new ConnectionApplication
            {
                ApplicationID    = (int)r["ApplicationID"],
                CustomerID       = (int)r["CustomerID"],
                ApplicationDate  = Convert.ToDateTime(r["ApplicationDate"]),
                DocumentStatus   = r["DocumentStatus"].ToString(),
                ApprovalStatus   = r["ApprovalStatus"].ToString(),
                RejectionReason  = r["RejectionReason"] == DBNull.Value ? "" : r["RejectionReason"].ToString(),
                AssignedOfficer  = r["AssignedOfficer"] == DBNull.Value ? (int?)null : (int)r["AssignedOfficer"],
                InstallationDate = r["InstallationDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["InstallationDate"]),
                CustomerName     = r["CustomerName"].ToString(),
                HoldingNumber    = r["HoldingNumber"].ToString()
            };
        }
    }
}
