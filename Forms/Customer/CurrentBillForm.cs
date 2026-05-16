using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class CurrentBillForm : Form
    {
        private readonly BillingService  _billingService  = new BillingService();
        private readonly CustomerRepository _customerRepo = new CustomerRepository();
        private Bill _currentBill;

        public CurrentBillForm()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                LoadBill();
            }
        }

        private void LoadBill()
        {
            if (SessionManager.CurrentUser == null)
            {
                lblBillID.Text = "No logged-in user.";
                btnDispute.Enabled = false;
                return;
            }
        
            var customer = _customerRepo.GetByUserID(SessionManager.CurrentUser.UserID);
            if (customer == null)
            {
                MessageHelper.ShowWarning("No customer record found.");
                return;
            }

            _currentBill = _billingService.GetLatestBill(customer.CustomerID);
            if (_currentBill == null)
            {
                lblBillID.Text       = "No bills found.";
                lblMonth.Text        = "";
                lblUnits.Text        = "";
                lblAmount.Text       = "";
                lblArrears.Text      = "";
                lblTotal.Text        = "";
                lblStatus.Text       = "";
                btnDispute.Enabled   = false;
                return;
            }

            lblBillID.Text  = "Bill #" + _currentBill.BillID;
            lblMonth.Text   = "Month: " + _currentBill.BillingMonth;
            decimal units   = _currentBill.CurrentReading - _currentBill.PreviousReading;
            lblUnits.Text   = $"Previous: {_currentBill.PreviousReading}  |  Current: {_currentBill.CurrentReading}  |  Units Used: {units}";
            lblAmount.Text  = "Bill Amount: ৳ " + _currentBill.Amount.ToString("N2");
            lblArrears.Text = "Arrears: ৳ " + _currentBill.Arrears.ToString("N2");
            lblTotal.Text   = "Total Due: ৳ " + (_currentBill.Amount + _currentBill.Arrears).ToString("N2");
            lblStatus.Text  = "Status: " + _currentBill.Status;
            lblStatus.ForeColor = _currentBill.Status == "Paid"
                ? System.Drawing.Color.Green
                : System.Drawing.Color.Red;

            btnDispute.Enabled = (_currentBill.Status != "Paid");
        }

        private void btnDispute_Click(object sender, EventArgs e)
        {
            if (_currentBill == null) return;
            var form = new SubmitBillDisputeForm(_currentBill.BillID);
            form.ShowDialog();
            LoadBill();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
