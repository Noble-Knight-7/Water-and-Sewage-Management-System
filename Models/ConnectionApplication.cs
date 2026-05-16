using System;

namespace WaterSewageManagementSystem.Models
{
    public class ConnectionApplication
    {
        public int ApplicationID { get; set; }
        public int CustomerID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string DocumentStatus { get; set; } // Pending, Verified, Rejected
        public string ApprovalStatus { get; set; } // Pending, Approved, Rejected
        public string RejectionReason { get; set; }
        public int? AssignedOfficer { get; set; }
        public DateTime? InstallationDate { get; set; }
        // For display
        public string CustomerName { get; set; }
        public string HoldingNumber { get; set; }
    }
}
