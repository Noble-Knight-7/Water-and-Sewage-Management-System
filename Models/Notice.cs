using System;

namespace WaterSewageManagementSystem.Models
{
    public class Notice
    {
        public int NoticeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Area { get; set; }
        public string NoticeType { get; set; } // Maintenance, Emergency, General
        public int PublishedBy { get; set; }
        public DateTime PublishDate { get; set; }
        // For display
        public string PublishedByName { get; set; }
    }
}
