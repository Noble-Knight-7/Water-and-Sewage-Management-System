namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class ReviewDisputesForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle        = new System.Windows.Forms.Label();
            this.dgvDisputes     = new System.Windows.Forms.DataGridView();
            this.btnMarkReviewed = new System.Windows.Forms.Button();
            this.btnClose        = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvDisputes).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 500); this.Text = "Review Bill Disputes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Bill Disputes"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(230,81,0); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(200, 30);

            this.dgvDisputes.Location = new System.Drawing.Point(20, 52); this.dgvDisputes.Size = new System.Drawing.Size(910, 395);
            this.dgvDisputes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisputes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisputes.ReadOnly = true; this.dgvDisputes.AllowUserToAddRows = false;
            this.dgvDisputes.BackgroundColor = System.Drawing.Color.White; this.dgvDisputes.RowHeadersVisible = false;
            this.dgvDisputes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230,81,0);
            this.dgvDisputes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDisputes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvDisputes.EnableHeadersVisualStyles = false;

            this.btnMarkReviewed.Text = "Mark as Reviewed"; this.btnMarkReviewed.Location = new System.Drawing.Point(20, 458); this.btnMarkReviewed.Size = new System.Drawing.Size(170, 35);
            this.btnMarkReviewed.BackColor = System.Drawing.Color.FromArgb(230,81,0); this.btnMarkReviewed.ForeColor = System.Drawing.Color.White;
            this.btnMarkReviewed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkReviewed.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnMarkReviewed.FlatAppearance.BorderSize = 0; this.btnMarkReviewed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkReviewed.Click += new System.EventHandler(this.btnMarkReviewed_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 458); this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvDisputes, this.btnMarkReviewed, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvDisputes).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvDisputes;
        private System.Windows.Forms.Button btnMarkReviewed, btnClose;
    }
}
