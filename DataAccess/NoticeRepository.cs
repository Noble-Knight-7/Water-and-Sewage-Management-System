using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.DataAccess
{
    public class NoticeRepository
    {
        private readonly DbConnection _db;
        public NoticeRepository() { _db = new DbConnection(); }

        public List<Notice> GetAll()
        {
            var list = new List<Notice>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT n.*, u.FullName AS PublishedByName
                               FROM Notices n
                               JOIN Users u ON n.PublishedBy = u.UserID
                               ORDER BY n.PublishDate DESC";
                using (var cmd = new SqlCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapNotice(r));
            }
            return list;
        }

        public bool Insert(Notice notice)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Notices (Title, Description, Area, NoticeType, PublishedBy, PublishDate)
                               VALUES (@Title, @Description, @Area, @NoticeType, @PublishedBy, GETDATE())";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Title", notice.Title);
                    cmd.Parameters.AddWithValue("@Description", notice.Description);
                    cmd.Parameters.AddWithValue("@Area", notice.Area ?? "");
                    cmd.Parameters.AddWithValue("@NoticeType", notice.NoticeType);
                    cmd.Parameters.AddWithValue("@PublishedBy", notice.PublishedBy);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int noticeID)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "DELETE FROM Notices WHERE NoticeID=@NoticeID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@NoticeID", noticeID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Notice MapNotice(SqlDataReader r)
        {
            return new Notice
            {
                NoticeID        = (int)r["NoticeID"],
                Title           = r["Title"].ToString(),
                Description     = r["Description"].ToString(),
                Area            = r["Area"].ToString(),
                NoticeType      = r["NoticeType"].ToString(),
                PublishedBy     = (int)r["PublishedBy"],
                PublishDate     = Convert.ToDateTime(r["PublishDate"]),
                PublishedByName = r["PublishedByName"].ToString()
            };
        }
    }
}
