using System.Collections.Generic;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    public class ComplaintService
    {
        private readonly ComplaintRepository _repo;
        public ComplaintService() { _repo = new ComplaintRepository(); }

        public List<Complaint> GetAll() => _repo.GetAll();
        public List<Complaint> GetByCustomer(int customerID) => _repo.GetByCustomerID(customerID);
        public List<Complaint> GetByEngineer(int engineerID) => _repo.GetByEngineerID(engineerID);

        public bool Submit(Complaint complaint) => _repo.Insert(complaint);
        public bool Assign(int complaintID, int engineerID) => _repo.AssignEngineer(complaintID, engineerID);
        public bool MarkResolved(int complaintID) => _repo.UpdateStatus(complaintID, "Resolved");
        public bool MarkInProgress(int complaintID) => _repo.UpdateStatus(complaintID, "InProgress");
    }
}
