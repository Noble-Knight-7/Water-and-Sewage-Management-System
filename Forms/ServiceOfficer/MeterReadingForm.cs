using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class MeterReadingForm : Form
    {
        private BillingService _billingService;

        public MeterReadingForm()
        {
            InitializeComponent();

            txtBillingMonth.Text = DateTime.Now.ToString("MMMM yyyy");

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                _billingService = new BillingService();
                LoadCustomers();
            }
        }

        private void LoadCustomers()
        {
            var customers = _billingService.GetAllCustomers();

            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "CustomerID";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (_billingService == null)
            {
                _billingService = new BillingService();
            }

            if (cmbCustomer.SelectedItem == null)
            {
                MessageHelper.ShowError("Please select a customer."); return;
            }
            if (!decimal.TryParse(txtPrevious.Text, out decimal prev) ||
                !decimal.TryParse(txtCurrent.Text,  out decimal curr))
            {
                MessageHelper.ShowError("Enter valid numeric meter readings."); return;
            }
            if (curr < prev)
            {
                MessageHelper.ShowError("Current reading cannot be less than previous reading."); return;
            }
            if (ValidationHelper.IsEmpty(txtBillingMonth.Text))
            {
                MessageHelper.ShowError("Enter billing month."); return;
            }

            decimal arrears = decimal.TryParse(txtArrears.Text, out decimal a) ? a : 0;
            int customerID  = (int)cmbCustomer.SelectedValue;

            bool success = _billingService.GenerateBill(customerID, txtBillingMonth.Text.Trim(), prev, curr, arrears);
            if (success)
            {
                decimal units  = curr - prev;
                decimal amount = units * 8; // 8 taka per unit
                MessageHelper.ShowSuccess($"Bill generated!\nUnits used: {units}\nAmount: ৳{amount:N2}\nArrears: ৳{arrears:N2}\nTotal Due: ৳{amount + arrears:N2}");
                txtPrevious.Clear(); txtCurrent.Clear(); txtArrears.Text = "0";
            }
            else MessageHelper.ShowError("Failed to generate bill. Please check the readings.");
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
