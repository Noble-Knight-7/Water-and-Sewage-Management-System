namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class CurrentBillForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle   = new System.Windows.Forms.Label();
            this.panelBill  = new System.Windows.Forms.Panel();
            this.lblBillID  = new System.Windows.Forms.Label();
            this.lblMonth   = new System.Windows.Forms.Label();
            this.lblUnits   = new System.Windows.Forms.Label();
            this.lblAmount  = new System.Windows.Forms.Label();
            this.lblArrears = new System.Windows.Forms.Label();
            this.lblTotal   = new System.Windows.Forms.Label();
            this.lblStatus  = new System.Windows.Forms.Label();
            this.btnDispute = new System.Windows.Forms.Button();
            this.btnClose   = new System.Windows.Forms.Button();
            this.panelBill.SuspendLayout();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(520, 420); this.Text = "Current Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(240,244,248);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Your Current Bill"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0,105,92); this.lblTitle.Location = new System.Drawing.Point(130, 15); this.lblTitle.Size = new System.Drawing.Size(260, 30);

            this.panelBill.BackColor = System.Drawing.Color.White;
            this.panelBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBill.Location = new System.Drawing.Point(30, 55); this.panelBill.Size = new System.Drawing.Size(460, 290);

            // System.Windows.Forms.Label[] infoLabels = { lblBillID, lblMonth, lblUnits, lblAmount, lblArrears, lblTotal, lblStatus };
            // for (int i = 0; i < infoLabels.Length; i++)
            // {
            //     infoLabels[i].Font     = new System.Drawing.Font("Segoe UI", 11F);
            //     infoLabels[i].Location = new System.Drawing.Point(20, 20 + i * 38);
            //     infoLabels[i].Size     = new System.Drawing.Size(420, 28);
            //     infoLabels[i].Text     = "";
            //     this.panelBill.Controls.Add(infoLabels[i]);
            // }
            // Bill ID
            this.lblBillID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillID.Location = new System.Drawing.Point(20, 20);
            this.lblBillID.Size = new System.Drawing.Size(420, 28);
            this.lblBillID.Text = "";
            this.panelBill.Controls.Add(this.lblBillID);

            // Month
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMonth.Location = new System.Drawing.Point(20, 58);
            this.lblMonth.Size = new System.Drawing.Size(420, 28);
            this.lblMonth.Text = "";
            this.panelBill.Controls.Add(this.lblMonth);

            // Units
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUnits.Location = new System.Drawing.Point(20, 96);
            this.lblUnits.Size = new System.Drawing.Size(420, 28);
            this.lblUnits.Text = "";
            this.panelBill.Controls.Add(this.lblUnits);

            // Amount
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAmount.Location = new System.Drawing.Point(20, 134);
            this.lblAmount.Size = new System.Drawing.Size(420, 28);
            this.lblAmount.Text = "";
            this.panelBill.Controls.Add(this.lblAmount);

            // Arrears
            this.lblArrears.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblArrears.Location = new System.Drawing.Point(20, 172);
            this.lblArrears.Size = new System.Drawing.Size(420, 28);
            this.lblArrears.Text = "";
            this.panelBill.Controls.Add(this.lblArrears);

            // Total
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.lblTotal.Location = new System.Drawing.Point(20, 210);
            this.lblTotal.Size = new System.Drawing.Size(420, 28);
            this.lblTotal.Text = "";
            this.panelBill.Controls.Add(this.lblTotal);

            // Status
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatus.Location = new System.Drawing.Point(20, 248);
            this.lblStatus.Size = new System.Drawing.Size(420, 28);
            this.lblStatus.Text = "";
            this.panelBill.Controls.Add(this.lblStatus);

            // this.lblBillID.Font  = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // this.lblTotal.Font   = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(183,28,28);

            this.btnDispute.Text = "Submit Dispute"; this.btnDispute.Location = new System.Drawing.Point(30, 365); this.btnDispute.Size = new System.Drawing.Size(160, 36);
            this.btnDispute.BackColor = System.Drawing.Color.FromArgb(230,81,0); this.btnDispute.ForeColor = System.Drawing.Color.White;
            this.btnDispute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDispute.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnDispute.FlatAppearance.BorderSize = 0; this.btnDispute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDispute.Click += new System.EventHandler(this.btnDispute_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(390, 365); this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.panelBill, this.btnDispute, this.btnClose });
            this.panelBill.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle, lblBillID, lblMonth, lblUnits, lblAmount, lblArrears, lblTotal, lblStatus;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Button btnDispute, btnClose;
    }
}
