using System;

namespace WaterSewageManagementSystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }   // Admin, Customer, ServiceOfficer, MaintenanceEngineer
        public string Address { get; set; }
        public string Status { get; set; } // Active, Inactive, Pending
        public DateTime CreatedAt { get; set; }
    }
}
