using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.DataAccess
{
    public class ComplaintRepository
    {
        private readonly DbConnection _db;
        public ComplaintRepository() { _db = new DbConnection(); }

        public List<Complaint> GetAll()
        {
            var list = new List<Complaint>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT c.*, u.FullName AS CustomerName,
                               ISNULL(e.FullName, 'Unassigned') AS EngineerName
                               FROM Complaints c
                               JOIN Customers cu ON c.CustomerID = cu.CustomerID
                               JOIN Users u ON cu.UserID = u.UserID
                               LEFT JOIN Users e ON c.AssignedEngineerID = e.UserID
                               ORDER BY c.DateSubmitted DESC";
                using (var cmd = new SqlCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapComplaint(r));
            }
            return list;
        }

        public List<Complaint> GetByCustomerID(int customerID)
        {
            var list = new List<Complaint>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT c.*, u.FullName AS CustomerName,
                               ISNULL(e.FullName, 'Unassigned') AS EngineerName
                               FROM Complaints c
                               JOIN Customers cu ON c.CustomerID = cu.CustomerID
                               JOIN Users u ON cu.UserID = u.UserID
                               LEFT JOIN Users e ON c.AssignedEngineerID = e.UserID
                               WHERE c.CustomerID = @CustomerID
                               ORDER BY c.DateSubmitted DESC";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(MapComplaint(r));
                }
            }
            return list;
        }

        public List<Complaint> GetByEngineerID(int engineerID)
        {
            var list = new List<Complaint>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT c.*, u.FullName AS CustomerName,
                               ISNULL(e.FullName, 'Unassigned') AS EngineerName
                               FROM Complaints c
                               JOIN Customers cu ON c.CustomerID = cu.CustomerID
                               JOIN Users u ON cu.UserID = u.UserID
                               LEFT JOIN Users e ON c.AssignedEngineerID = e.UserID
                               WHERE c.AssignedEngineerID = @EngineerID
                               ORDER BY c.DateSubmitted DESC";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@EngineerID", engineerID);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(MapComplaint(r));
                }
            }
            return list;
        }

        public bool Insert(Complaint complaint)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Complaints (CustomerID, Category, Description, Priority, Status, DateSubmitted)
                               VALUES (@CustomerID, @Category, @Description, @Priority, 'Pending', GETDATE())";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", complaint.CustomerID);
                    cmd.Parameters.AddWithValue("@Category", complaint.Category);
                    cmd.Parameters.AddWithValue("@Description", complaint.Description);
                    cmd.Parameters.AddWithValue("@Priority", complaint.Priority);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AssignEngineer(int complaintID, int engineerID)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE Complaints SET AssignedEngineerID=@EID, Status='Assigned' WHERE ComplaintID=@CID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@EID", engineerID);
                    cmd.Parameters.AddWithValue("@CID", complaintID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateStatus(int complaintID, string status)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE Complaints SET Status=@Status WHERE ComplaintID=@ComplaintID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ComplaintID", complaintID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Complaint MapComplaint(SqlDataReader r)
        {
            return new Complaint
            {
                ComplaintID        = (int)r["ComplaintID"],
                CustomerID         = (int)r["CustomerID"],
                Category           = r["Category"].ToString(),
                Description        = r["Description"].ToString(),
                Priority           = r["Priority"].ToString(),
                Status             = r["Status"].ToString(),
                AssignedEngineerID = r["AssignedEngineerID"] == DBNull.Value ? (int?)null : (int)r["AssignedEngineerID"],
                DateSubmitted      = Convert.ToDateTime(r["DateSubmitted"]),
                CustomerName       = r["CustomerName"].ToString(),
                EngineerName       = r["EngineerName"].ToString()
            };
        }
    }
}
