using System;

namespace WaterSewageManagementSystem.Models
{
    public class Report
    {
        public int ReportID { get; set; }
        public int CreatedBy { get; set; }
        public string ReportType { get; set; } // Billing, Complaint, Maintenance, User, Connection
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        // For display
        public string CreatedByName { get; set; }
    }
}
