namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class CorrectBillForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle     = new System.Windows.Forms.Label();
            this.lblBillIDLbl = new System.Windows.Forms.Label(); this.txtBillID = new System.Windows.Forms.TextBox(); this.btnLoad = new System.Windows.Forms.Button();
            this.lblBillInfo  = new System.Windows.Forms.Label();
            this.lblNewAmt    = new System.Windows.Forms.Label(); this.txtNewAmount = new System.Windows.Forms.TextBox();
            this.btnSave      = new System.Windows.Forms.Button(); this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(520, 280); this.Text = "Correct Bill Amount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Correct Bill Amount"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(183,28,28); this.lblTitle.Location = new System.Drawing.Point(120, 15); this.lblTitle.Size = new System.Drawing.Size(280, 28);

            this.lblBillIDLbl.Text = "Bill ID:"; this.lblBillIDLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblBillIDLbl.Location = new System.Drawing.Point(30, 62); this.lblBillIDLbl.Size = new System.Drawing.Size(120, 22);
            this.txtBillID.Location = new System.Drawing.Point(155, 60); this.txtBillID.Size = new System.Drawing.Size(200, 26); this.txtBillID.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtBillID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLoad.Text = "Load"; this.btnLoad.Location = new System.Drawing.Point(365, 58); this.btnLoad.Size = new System.Drawing.Size(120, 30);
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLoad.FlatAppearance.BorderSize = 0; this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            this.lblBillInfo.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblBillInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblBillInfo.Location = new System.Drawing.Point(30, 102); this.lblBillInfo.Size = new System.Drawing.Size(460, 22);

            this.lblNewAmt.Text = "New Amount (৳):"; this.lblNewAmt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblNewAmt.Location = new System.Drawing.Point(30, 138); this.lblNewAmt.Size = new System.Drawing.Size(140, 22);
            this.txtNewAmount.Location = new System.Drawing.Point(175, 136); this.txtNewAmount.Size = new System.Drawing.Size(200, 26); this.txtNewAmount.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtNewAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtNewAmount.Enabled = false;

            this.btnSave.Text = "Save Correction"; this.btnSave.Location = new System.Drawing.Point(30, 195); this.btnSave.Size = new System.Drawing.Size(170, 38); this.btnSave.Enabled = false;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(183,28,28); this.btnSave.ForeColor = System.Drawing.Color.White; this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSave.FlatAppearance.BorderSize = 0; this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(400, 195); this.btnClose.Size = new System.Drawing.Size(100, 38);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblBillIDLbl, this.txtBillID, this.btnLoad, this.lblBillInfo, this.lblNewAmt, this.txtNewAmount, this.btnSave, this.btnClose });
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle, lblBillIDLbl, lblBillInfo, lblNewAmt;
        private System.Windows.Forms.TextBox txtBillID, txtNewAmount;
        private System.Windows.Forms.Button btnLoad, btnSave, btnClose;
    }
}
