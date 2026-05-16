using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class TrackApplicationForm : Form
    {
        private readonly ConnectionService  _connectionService = new ConnectionService();
        private readonly CustomerRepository _customerRepo      = new CustomerRepository();

        public TrackApplicationForm() { InitializeComponent(); LoadApplications(); }

        private void LoadApplications()
        {
            var customer = _customerRepo.GetByUserID(SessionManager.CurrentUser.UserID);
            if (customer == null) { MessageHelper.ShowWarning("No customer record found."); return; }
            dgvApplications.DataSource = null;
            dgvApplications.DataSource = _connectionService.GetByCustomer(customer.CustomerID);
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadApplications();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
