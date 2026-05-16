using System;

namespace WaterSewageManagementSystem.Models
{
    public class Complaint
    {
        public int ComplaintID { get; set; }
        public int CustomerID { get; set; }
        public string Category { get; set; } // Billing, Water Supply, Sewerage, Maintenance, Other
        public string Description { get; set; }
        public string Priority { get; set; } // Low, Medium, High, Urgent
        public string Status { get; set; }   // Pending, Assigned, InProgress, Resolved
        public int? AssignedEngineerID { get; set; }
        public DateTime DateSubmitted { get; set; }
        // For display
        public string CustomerName { get; set; }
        public string EngineerName { get; set; }
    }
}
