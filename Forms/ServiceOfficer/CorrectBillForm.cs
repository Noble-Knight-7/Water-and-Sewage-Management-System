using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class CorrectBillForm : Form
    {
        private readonly BillingService _billingService = new BillingService();

        public CorrectBillForm() { InitializeComponent(); }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBillID.Text, out int billID))
            {
                MessageHelper.ShowError("Enter a valid Bill ID."); return;
            }
            var bill = _billingService.GetBillByID(billID);
            if (bill == null)
            {
                MessageHelper.ShowError("Bill not found."); return;
            }
            lblBillInfo.Text    = $"Customer: {bill.CustomerName}   |   Month: {bill.BillingMonth}   |   Status: {bill.Status}";
            txtNewAmount.Text   = bill.Amount.ToString("N2");
            txtNewAmount.Enabled = true;
            btnSave.Enabled      = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBillID.Text, out int billID)) return;
            if (!decimal.TryParse(txtNewAmount.Text, out decimal newAmount) || newAmount <= 0)
            {
                MessageHelper.ShowError("Enter a valid corrected amount."); return;
            }
            if (MessageHelper.ShowConfirm($"Correct this bill amount to ৳{newAmount:N2}?") == DialogResult.Yes)
            {
                _billingService.CorrectBillAmount(billID, newAmount);
                MessageHelper.ShowSuccess("Bill amount corrected successfully.");
                txtBillID.Clear(); txtNewAmount.Clear(); txtNewAmount.Enabled = false;
                lblBillInfo.Text = ""; btnSave.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
