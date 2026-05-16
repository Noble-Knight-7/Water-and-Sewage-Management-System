using System;
using System.Collections.Generic;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    public class ConnectionService
    {
        private readonly ConnectionRepository _repo;
        public ConnectionService() { _repo = new ConnectionRepository(); }

        public List<ConnectionApplication> GetAll() => _repo.GetAll();
        public List<ConnectionApplication> GetByCustomer(int customerID) => _repo.GetByCustomerID(customerID);
        public ConnectionApplication GetByID(int appID) => _repo.GetByID(appID);

        public bool Apply(int customerID)
        {
            var app = new ConnectionApplication { CustomerID = customerID };
            return _repo.Insert(app);
        }

        public bool Approve(int appID, int officerID) => _repo.UpdateApproval(appID, "Approved", "", officerID);
        public bool Reject(int appID, int officerID, string reason) => _repo.UpdateApproval(appID, "Rejected", reason, officerID);
        public bool VerifyDocuments(int appID) => _repo.UpdateDocumentStatus(appID, "Verified");
        public bool ScheduleInstallation(int appID, DateTime date) => _repo.SetInstallationDate(appID, date);
    }
}
