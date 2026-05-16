using System;

namespace WaterSewageManagementSystem.Models
{
    public class Bill
    {
        public int BillID { get; set; }
        public int CustomerID { get; set; }
        public string BillingMonth { get; set; }
        public decimal PreviousReading { get; set; }
        public decimal CurrentReading { get; set; }
        public decimal Amount { get; set; }
        public decimal Arrears { get; set; }
        public string Status { get; set; } // Unpaid, Paid, Disputed
        public DateTime CreatedAt { get; set; }
        // For display
        public string CustomerName { get; set; }
        public string MeterNumber { get; set; }
    }
}
