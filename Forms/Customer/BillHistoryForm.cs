using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class BillHistoryForm : Form
    {
        private readonly BillingService    _billingService = new BillingService();
        private readonly CustomerRepository _customerRepo  = new CustomerRepository();

        public BillHistoryForm() { InitializeComponent(); LoadHistory(); }

        private void LoadHistory()
        {
            var customer = _customerRepo.GetByUserID(SessionManager.CurrentUser.UserID);
            if (customer == null) { MessageHelper.ShowWarning("No customer record found."); return; }

            dgvBills.DataSource = null;
            dgvBills.DataSource = _billingService.GetBillsByCustomer(customer.CustomerID);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
