using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.DataAccess
{
    public class CustomerRepository
    {
        private readonly DbConnection _db;
        public CustomerRepository() { _db = new DbConnection(); }

        public Customer GetByUserID(int userID)
        {
            Customer c = null;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT c.*, u.FullName, u.Email, u.Phone, u.Address
                               FROM Customers c JOIN Users u ON c.UserID = u.UserID
                               WHERE c.UserID = @UserID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read()) c = MapCustomer(r);
                    }
                }
            }
            return c;
        }

        public Customer GetByID(int customerID)
        {
            Customer c = null;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT c.*, u.FullName, u.Email, u.Phone, u.Address
                               FROM Customers c JOIN Users u ON c.UserID = u.UserID
                               WHERE c.CustomerID = @CustomerID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read()) c = MapCustomer(r);
                    }
                }
            }
            return c;
        }

        public List<Customer> GetAll()
        {
            var list = new List<Customer>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT c.*, u.FullName, u.Email, u.Phone, u.Address
                               FROM Customers c JOIN Users u ON c.UserID = u.UserID
                               ORDER BY u.FullName";
                using (var cmd = new SqlCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read()) list.Add(MapCustomer(r));
                }
            }
            return list;
        }

        public bool Insert(Customer customer)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();

                string sql = @"INSERT INTO Customers (UserID, HoldingNumber, ConnectionType)
                       VALUES (@UserID, @HoldingNumber, @ConnectionType)";

                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", customer.UserID);
                    cmd.Parameters.AddWithValue("@HoldingNumber", customer.HoldingNumber ?? "");
                    cmd.Parameters.AddWithValue("@ConnectionType", customer.ConnectionType ?? "Residential");

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Customer MapCustomer(SqlDataReader r)
        {
            return new Customer
            {
                CustomerID = (int)r["CustomerID"],
                UserID = (int)r["UserID"],
                MeterNumber = r["MeterNumber"] == DBNull.Value ? (int?)null : (int)r["MeterNumber"],
                HoldingNumber = r["HoldingNumber"].ToString(),
                ConnectionType = r["ConnectionType"].ToString(),
                FullName = r["FullName"].ToString(),
                Email = r["Email"].ToString(),
                Phone = r["Phone"].ToString(),
                Address = r["Address"].ToString()
            };
        }
    }
}
