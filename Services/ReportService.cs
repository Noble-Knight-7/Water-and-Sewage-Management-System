using System.Collections.Generic;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    public class ReportService
    {
        private readonly ReportRepository _repo;
        public ReportService() { _repo = new ReportRepository(); }

        public List<Report> GetAll() => _repo.GetAll();

        public bool LogReport(int createdBy, string reportType, string description)
        {
            var report = new Report
            {
                CreatedBy   = createdBy,
                ReportType  = reportType,
                Description = description
            };
            return _repo.Insert(report);
        }
    }
}
