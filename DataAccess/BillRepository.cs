using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.DataAccess
{
    public class BillRepository
    {
        private readonly DbConnection _db;
        public BillRepository() { _db = new DbConnection(); }

        public List<Bill> GetByCustomerID(int customerID)
        {
            var list = new List<Bill>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT b.*, u.FullName, c.MeterNumber
                               FROM Bills b
                               JOIN Customers c ON b.CustomerID = c.CustomerID
                               JOIN Users u ON c.UserID = u.UserID
                               WHERE b.CustomerID = @CustomerID
                               ORDER BY b.CreatedAt DESC";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) list.Add(MapBill(r));
                }
            }
            return list;
        }

        public Bill GetLatestByCustomerID(int customerID)
        {
            Bill bill = null;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT TOP 1 b.*, u.FullName, c.MeterNumber
                               FROM Bills b
                               JOIN Customers c ON b.CustomerID = c.CustomerID
                               JOIN Users u ON c.UserID = u.UserID
                               WHERE b.CustomerID = @CustomerID
                               ORDER BY b.CreatedAt DESC";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) bill = MapBill(r);
                }
            }
            return bill;
        }

        public Bill GetByID(int billID)
        {
            Bill bill = null;
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT b.*, u.FullName, c.MeterNumber
                               FROM Bills b
                               JOIN Customers c ON b.CustomerID = c.CustomerID
                               JOIN Users u ON c.UserID = u.UserID
                               WHERE b.BillID = @BillID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@BillID", billID);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) bill = MapBill(r);
                }
            }
            return bill;
        }

        public List<Bill> GetAll()
        {
            var list = new List<Bill>();
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"SELECT b.*, u.FullName, c.MeterNumber
                               FROM Bills b
                               JOIN Customers c ON b.CustomerID = c.CustomerID
                               JOIN Users u ON c.UserID = u.UserID
                               ORDER BY b.CreatedAt DESC";
                using (var cmd = new SqlCommand(sql, con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) list.Add(MapBill(r));
            }
            return list;
        }

        public bool Insert(Bill bill)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = @"INSERT INTO Bills (CustomerID, BillingMonth, PreviousReading, CurrentReading, Amount, Arrears, Status, CreatedAt)
                               VALUES (@CustomerID, @BillingMonth, @PreviousReading, @CurrentReading, @Amount, @Arrears, @Status, GETDATE())";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", bill.CustomerID);
                    cmd.Parameters.AddWithValue("@BillingMonth", bill.BillingMonth);
                    cmd.Parameters.AddWithValue("@PreviousReading", bill.PreviousReading);
                    cmd.Parameters.AddWithValue("@CurrentReading", bill.CurrentReading);
                    cmd.Parameters.AddWithValue("@Amount", bill.Amount);
                    cmd.Parameters.AddWithValue("@Arrears", bill.Arrears);
                    cmd.Parameters.AddWithValue("@Status", bill.Status ?? "Unpaid");
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateStatus(int billID, string status)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE Bills SET Status=@Status WHERE BillID=@BillID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@BillID", billID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateAmount(int billID, decimal newAmount)
        {
            using (var con = _db.GetConnection())
            {
                con.Open();
                string sql = "UPDATE Bills SET Amount=@Amount WHERE BillID=@BillID";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Amount", newAmount);
                    cmd.Parameters.AddWithValue("@BillID", billID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private Bill MapBill(SqlDataReader r)
        {
            return new Bill
            {
                BillID          = (int)r["BillID"],
                CustomerID      = (int)r["CustomerID"],
                BillingMonth    = r["BillingMonth"].ToString(),
                PreviousReading = Convert.ToDecimal(r["PreviousReading"]),
                CurrentReading  = Convert.ToDecimal(r["CurrentReading"]),
                Amount          = Convert.ToDecimal(r["Amount"]),
                Arrears         = Convert.ToDecimal(r["Arrears"]),
                Status          = r["Status"].ToString(),
                CreatedAt       = Convert.ToDateTime(r["CreatedAt"]),
                CustomerName    = r["FullName"].ToString(),
                MeterNumber     = r["MeterNumber"].ToString()
            };
        }
    }
}
