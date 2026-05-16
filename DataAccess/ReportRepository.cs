using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.DataAccess
{
    public class ReportRepository
    {
        private readonly DbConnection _db;
        public ReportRepository() { _db = new DbConnection(); }

        public List<Report> GetAll()
        {
            var list = new List<Report>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT r.*, u.FullName AS CreatedByName
                               FROM Reports r
                               JOIN Users u ON r.CreatedBy = u.UserID
                               ORDER BY r.CreatedDate DESC";
                using (var cmd = new SqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read()) list.Add(MapReport(reader));
            }
            return list;
        }

        public bool Insert(Report report)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Reports (CreatedBy, ReportType, CreatedDate, Description)
                               VALUES (@CreatedBy, @ReportType, GETDATE(), @Description)";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CreatedBy", report.CreatedBy);
                    cmd.Parameters.AddWithValue("@ReportType", report.ReportType);
                    cmd.Parameters.AddWithValue("@Description", report.Description ?? "");
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Report MapReport(SqlDataReader r)
        {
            return new Report
            {
                ReportID      = (int)r["ReportID"],
                CreatedBy     = (int)r["CreatedBy"],
                ReportType    = r["ReportType"].ToString(),
                CreatedDate   = Convert.ToDateTime(r["CreatedDate"]),
                Description   = r["Description"].ToString(),
                CreatedByName = r["CreatedByName"].ToString()
            };
        }
    }
}
