using System;
using System.Windows.Forms;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    public partial class GenerateBillForm : Form
    {
        private readonly BillingService _billingService = new BillingService();

        public GenerateBillForm() { InitializeComponent(); LoadBills(); }

        private void LoadBills()
        {
            dgvBills.DataSource = null;
            dgvBills.DataSource = _billingService.GetAllBills();
        }

        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count == 0) { MessageHelper.ShowWarning("Select a bill first."); return; }
            int billID = (int)dgvBills.SelectedRows[0].Cells["BillID"].Value;
            string status = dgvBills.SelectedRows[0].Cells["Status"].Value.ToString();
            if (status == "Paid") { MessageHelper.ShowWarning("This bill is already paid."); return; }
            if (MessageHelper.ShowConfirm("Mark this bill as Paid?") == DialogResult.Yes)
            {
                _billingService.MarkBillPaid(billID);
                MessageHelper.ShowSuccess("Bill marked as Paid.");
                LoadBills();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadBills();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
