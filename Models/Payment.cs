using System;

namespace WaterSewageManagementSystem.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int BillID { get; set; }
        public int CustomerID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; } // Cash, Card, Online
        public string ReceiptNo { get; set; }
    }
}
