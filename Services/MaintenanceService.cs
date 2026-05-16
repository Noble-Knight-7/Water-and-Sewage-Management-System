using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    public class MaintenanceService
    {
        private readonly MaintenanceRepository _repo;
        private readonly ComplaintRepository _complaintRepo;

        public MaintenanceService()
        {
            _repo = new MaintenanceRepository();
            _complaintRepo = new ComplaintRepository();
        }

        public List<MaintenanceTask> GetByEngineer(int engineerID) => _repo.GetByEngineerID(engineerID);
        public List<MaintenanceTask> GetAll() => _repo.GetAll();
        public MaintenanceTask GetByID(int taskID) => _repo.GetByID(taskID);

        public bool UpdateProgress(int taskID, string status, string notes)
        {
            bool updated = _repo.UpdateProgress(taskID, status, notes);
            if (updated && status == "Completed")
            {
                var task = _repo.GetByID(taskID);
                if (task != null)
                    _complaintRepo.UpdateStatus(task.ComplaintID, "Resolved");
            }
            return updated;
        }

        public bool SetVisitDate(int taskID, DateTime visitDate) => _repo.UpdateVisitDate(taskID, visitDate);
        public bool SubmitCompletionReport(int taskID, string report) => _repo.SubmitCompletionReport(taskID, report);
    }
}
