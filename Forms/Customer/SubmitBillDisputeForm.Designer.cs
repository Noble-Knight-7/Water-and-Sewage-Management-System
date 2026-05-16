namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class SubmitBillDisputeForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle  = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label(); this.txtBillID = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label(); this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button(); this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(460, 310); this.Text = "Submit Bill Dispute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Submit Bill Dispute"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(230,81,0); this.lblTitle.Location = new System.Drawing.Point(100, 15); this.lblTitle.Size = new System.Drawing.Size(260, 28);

            this.lblBillID.Text = "Bill ID:"; this.lblBillID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblBillID.Location = new System.Drawing.Point(30, 65); this.lblBillID.Size = new System.Drawing.Size(120, 22);
            this.txtBillID.Location = new System.Drawing.Point(160, 63); this.txtBillID.Size = new System.Drawing.Size(270, 26); this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtBillID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblReason.Text = "Reason for Dispute:"; this.lblReason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblReason.Location = new System.Drawing.Point(30, 105); this.lblReason.Size = new System.Drawing.Size(160, 22);
            this.txtReason.Location = new System.Drawing.Point(30, 130); this.txtReason.Size = new System.Drawing.Size(400, 100); this.txtReason.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtReason.Multiline = true; this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnSubmit.Text = "Submit Dispute"; this.btnSubmit.Location = new System.Drawing.Point(30, 250); this.btnSubmit.Size = new System.Drawing.Size(160, 38);
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(230,81,0); this.btnSubmit.ForeColor = System.Drawing.Color.White; this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSubmit.FlatAppearance.BorderSize = 0; this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand; this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnCancel.Text = "Cancel"; this.btnCancel.Location = new System.Drawing.Point(270, 250); this.btnCancel.Size = new System.Drawing.Size(160, 38);
            this.btnCancel.BackColor = System.Drawing.Color.Gray; this.btnCancel.ForeColor = System.Drawing.Color.White; this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnCancel.FlatAppearance.BorderSize = 0; this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand; this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblBillID, this.txtBillID, this.lblReason, this.txtReason, this.btnSubmit, this.btnCancel });
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle, lblBillID, lblReason;
        private System.Windows.Forms.TextBox txtBillID, txtReason;
        private System.Windows.Forms.Button btnSubmit, btnCancel;
    }
}
