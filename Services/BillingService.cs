using System.Collections.Generic;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    public class BillingService
    {
        private readonly BillRepository _billRepo;
        private readonly CustomerRepository _customerRepo;
        private const decimal RATE_PER_UNIT = 8.0m; // Taka per unit

        public BillingService()
        {
            _billRepo = new BillRepository();
            _customerRepo = new CustomerRepository();
        }

        public List<Bill> GetBillsByCustomer(int customerID) => _billRepo.GetByCustomerID(customerID);
        public Bill GetLatestBill(int customerID) => _billRepo.GetLatestByCustomerID(customerID);
        public Bill GetBillByID(int billID) => _billRepo.GetByID(billID);
        public List<Bill> GetAllBills() => _billRepo.GetAll();

        // GenerateBill: Calculate amount from meter readings and save to DB
        public bool GenerateBill(int customerID, string billingMonth, decimal previousReading, decimal currentReading, decimal arrears)
        {
            decimal unitsUsed = currentReading - previousReading;
            if (unitsUsed < 0) return false; // current must be >= previous

            decimal amount = unitsUsed * RATE_PER_UNIT;
            var bill = new Bill
            {
                CustomerID      = customerID,
                BillingMonth    = billingMonth,
                PreviousReading = previousReading,
                CurrentReading  = currentReading,
                Amount          = amount,
                Arrears         = arrears,
                Status          = "Unpaid"
            };
            return _billRepo.Insert(bill);
        }

        public bool MarkBillPaid(int billID) => _billRepo.UpdateStatus(billID, "Paid");
        public bool MarkBillDisputed(int billID) => _billRepo.UpdateStatus(billID, "Disputed");
        public bool CorrectBillAmount(int billID, decimal newAmount) => _billRepo.UpdateAmount(billID, newAmount);

        public List<Customer> GetAllCustomers() => _customerRepo.GetAll();
    }
}
