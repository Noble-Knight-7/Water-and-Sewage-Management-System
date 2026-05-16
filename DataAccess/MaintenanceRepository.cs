using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.DataAccess
{
    public class MaintenanceRepository
    {
        private readonly DbConnection _db;
        public MaintenanceRepository() { _db = new DbConnection(); }

        public List<MaintenanceTask> GetByEngineerID(int engineerID)
        {
            var list = new List<MaintenanceTask>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT t.*, c.Description AS ComplaintDescription, c.Category,
                               u.FullName AS CustomerName
                               FROM MaintenanceTasks t
                               JOIN Complaints c ON t.ComplaintID = c.ComplaintID
                               JOIN Customers cu ON c.CustomerID = cu.CustomerID
                               JOIN Users u ON cu.UserID = u.UserID
                               WHERE t.EngineerID = @EngineerID
                               ORDER BY t.UpdatedAt DESC";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@EngineerID", engineerID);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(MapTask(r));
                }
            }
            return list;
        }

        public List<MaintenanceTask> GetAll()
        {
            var list = new List<MaintenanceTask>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT t.*, c.Description AS ComplaintDescription, c.Category,
                               u.FullName AS CustomerName
                               FROM MaintenanceTasks t
                               JOIN Complaints c ON t.ComplaintID = c.ComplaintID
                               JOIN Customers cu ON c.CustomerID = cu.CustomerID
                               JOIN Users u ON cu.UserID = u.UserID
                               ORDER BY t.UpdatedAt DESC";
                using (var cmd = new SqlCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapTask(r));
            }
            return list;
        }

        public MaintenanceTask GetByID(int taskID)
        {
            MaintenanceTask task = null;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT t.*, c.Description AS ComplaintDescription, c.Category,
                               u.FullName AS CustomerName
                               FROM MaintenanceTasks t
                               JOIN Complaints c ON t.ComplaintID = c.ComplaintID
                               JOIN Customers cu ON c.CustomerID = cu.CustomerID
                               JOIN Users u ON cu.UserID = u.UserID
                               WHERE t.TaskID = @TaskID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TaskID", taskID);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) task = MapTask(r);
                }
            }
            return task;
        }

        public bool Insert(MaintenanceTask task)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO MaintenanceTasks (ComplaintID, EngineerID, ProgressStatus, Notes, UpdatedAt)
                               VALUES (@ComplaintID, @EngineerID, 'Pending', '', GETDATE())";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ComplaintID", task.ComplaintID);
                    cmd.Parameters.AddWithValue("@EngineerID", task.EngineerID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateProgress(int taskID, string status, string notes)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE MaintenanceTasks SET ProgressStatus=@Status, Notes=@Notes, UpdatedAt=GETDATE() WHERE TaskID=@TaskID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Notes", notes ?? "");
                    cmd.Parameters.AddWithValue("@TaskID", taskID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateVisitDate(int taskID, DateTime visitDate)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE MaintenanceTasks SET VisitDate=@VisitDate, UpdatedAt=GETDATE() WHERE TaskID=@TaskID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@VisitDate", visitDate);
                    cmd.Parameters.AddWithValue("@TaskID", taskID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool SubmitCompletionReport(int taskID, string report)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE MaintenanceTasks SET CompletionReport=@Report, ProgressStatus='Completed', UpdatedAt=GETDATE() WHERE TaskID=@TaskID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Report", report);
                    cmd.Parameters.AddWithValue("@TaskID", taskID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private MaintenanceTask MapTask(SqlDataReader r)
        {
            return new MaintenanceTask
            {
                TaskID                = (int)r["TaskID"],
                ComplaintID           = (int)r["ComplaintID"],
                EngineerID            = (int)r["EngineerID"],
                VisitDate             = r["VisitDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["VisitDate"]),
                ProgressStatus        = r["ProgressStatus"].ToString(),
                Notes                 = r["Notes"].ToString(),
                CompletionReport      = r["CompletionReport"] == DBNull.Value ? "" : r["CompletionReport"].ToString(),
                UpdatedAt             = Convert.ToDateTime(r["UpdatedAt"]),
                ComplaintDescription  = r["ComplaintDescription"].ToString(),
                Category              = r["Category"].ToString(),
                CustomerName          = r["CustomerName"].ToString()
            };
        }
    }
}
