using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class TrackComplaintForm : Form
    {
        private readonly ComplaintService   _complaintService = new ComplaintService();
        private readonly CustomerRepository _customerRepo     = new CustomerRepository();

        public TrackComplaintForm() { InitializeComponent(); LoadComplaints(); }

        private void LoadComplaints()
        {
            var customer = _customerRepo.GetByUserID(SessionManager.CurrentUser.UserID);
            if (customer == null) { MessageHelper.ShowWarning("No customer record found."); return; }
            dgvComplaints.DataSource = null;
            dgvComplaints.DataSource = _complaintService.GetByCustomer(customer.CustomerID);
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadComplaints();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
