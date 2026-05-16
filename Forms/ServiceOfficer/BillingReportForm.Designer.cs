namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class BillingReportForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle    = new System.Windows.Forms.Label();
            this.dgvBills    = new System.Windows.Forms.DataGridView();
            this.btnLogReport = new System.Windows.Forms.Button();
            this.btnClose    = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvBills).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 520); this.Text = "Billing Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Billing Report"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(74,20,140); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(200, 30);

            this.dgvBills.Location = new System.Drawing.Point(20, 52); this.dgvBills.Size = new System.Drawing.Size(910, 415);
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.ReadOnly = true; this.dgvBills.AllowUserToAddRows = false;
            this.dgvBills.BackgroundColor = System.Drawing.Color.White; this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(74,20,140);
            this.dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBills.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBills.EnableHeadersVisualStyles = false;

            this.btnLogReport.Text = "Log Report"; this.btnLogReport.Location = new System.Drawing.Point(20, 477); this.btnLogReport.Size = new System.Drawing.Size(140, 35);
            this.btnLogReport.BackColor = System.Drawing.Color.FromArgb(74,20,140); this.btnLogReport.ForeColor = System.Drawing.Color.White;
            this.btnLogReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLogReport.FlatAppearance.BorderSize = 0; this.btnLogReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogReport.Click += new System.EventHandler(this.btnLogReport_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 477); this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvBills, this.btnLogReport, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvBills).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.Button btnLogReport, btnClose;
    }
}
