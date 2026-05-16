using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.DataAccess
{
    public class UserRepository
    {
        private readonly DbConnection _db;

        public UserRepository()
        {
            _db = new DbConnection();
        }

        public User GetByEmail(string email)
        {
            User user = null;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM Users WHERE Email = @Email";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) user = MapUser(reader);
                    }
                }
            }
            return user;
        }

        public User GetByID(int userID)
        {
            User user = null;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM Users WHERE UserID = @UserID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) user = MapUser(reader);
                    }
                }
            }
            return user;
        }

        public List<User> GetAll()
        {
            var list = new List<User>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM Users ORDER BY CreatedAt DESC";
                using (var cmd = new SqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) list.Add(MapUser(reader));
                }
            }
            return list;
        }

        public List<User> GetByRole(string role)
        {
            var list = new List<User>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM Users WHERE Role = @Role ORDER BY FullName";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Role", role);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) list.Add(MapUser(reader));
                    }
                }
            }
            return list;
        }

        public bool Insert(User user)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Users (FullName, Email, Phone, Password, Role, Address, Status, CreatedAt)
                               VALUES (@FullName, @Email, @Phone, @Password, @Role, @Address, @Status, GETDATE())";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    cmd.Parameters.AddWithValue("@Address", user.Address ?? "");
                    cmd.Parameters.AddWithValue("@Status", user.Status ?? "Active");
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Update(User user)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE Users SET FullName=@FullName, Phone=@Phone, Address=@Address WHERE UserID=@UserID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Phone", user.Phone);
                    cmd.Parameters.AddWithValue("@Address", user.Address ?? "");
                    cmd.Parameters.AddWithValue("@UserID", user.UserID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateStatus(int userID, string status)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE Users SET Status=@Status WHERE UserID=@UserID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdatePassword(int userID, string newPassword)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE Users SET Password=@Password WHERE UserID=@UserID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public int GetLastInsertedID()
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "SELECT TOP 1 UserID FROM Users ORDER BY UserID DESC";
                using (var cmd = new SqlCommand(sql, con))
                    return (int)cmd.ExecuteScalar();
            }
        }

        public bool EmailExists(string email)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private User MapUser(SqlDataReader reader)
        {
            return new User
            {
                UserID    = (int)reader["UserID"],
                FullName  = reader["FullName"].ToString(),
                Email     = reader["Email"].ToString(),
                Phone     = reader["Phone"].ToString(),
                Password  = reader["Password"].ToString(),
                Role      = reader["Role"].ToString(),
                Address   = reader["Address"].ToString(),
                Status    = reader["Status"].ToString(),
                CreatedAt = System.Convert.ToDateTime(reader["CreatedAt"])
            };
        }
    }
}
