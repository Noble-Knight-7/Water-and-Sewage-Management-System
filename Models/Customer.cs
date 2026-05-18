namespace WaterSewageManagementSystem.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public int? MeterNumber { get; set; }
        public string HoldingNumber { get; set; }
        public string ConnectionType { get; set; } // Residential, Commercial
        // For display convenience
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
