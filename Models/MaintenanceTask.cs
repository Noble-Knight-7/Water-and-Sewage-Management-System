using System;

namespace WaterSewageManagementSystem.Models
{
    public class MaintenanceTask
    {
        public int TaskID { get; set; }
        public int ComplaintID { get; set; }
        public int EngineerID { get; set; }
        public DateTime? VisitDate { get; set; }
        public string ProgressStatus { get; set; } // Pending, InProgress, Completed
        public string Notes { get; set; }
        public string CompletionReport { get; set; }
        public DateTime UpdatedAt { get; set; }
        // For display
        public string ComplaintDescription { get; set; }
        public string CustomerName { get; set; }
        public string Category { get; set; }
    }
}
