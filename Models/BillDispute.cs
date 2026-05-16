using System;

namespace WaterSewageManagementSystem.Models
{
    public class BillDispute
    {
        public int DisputeID { get; set; }
        public int BillID { get; set; }
        public int CustomerID { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; } // Pending, Reviewed, Resolved
        public int? ReviewedBy { get; set; }
        public DateTime SubmittedAt { get; set; }
        // For display
        public string CustomerName { get; set; }
        public string BillingMonth { get; set; }
        public decimal BillAmount { get; set; }
    }
}
