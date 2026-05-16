namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class ReviewConnectionApplicationsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle        = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.btnApprove      = new System.Windows.Forms.Button();
            this.btnReject       = new System.Windows.Forms.Button();
            this.btnRefresh      = new System.Windows.Forms.Button();
            this.btnClose        = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvApplications).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 500); this.Text = "Review Connection Applications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Connection Applications"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(46,125,50); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(280, 30);

            this.dgvApplications.Location = new System.Drawing.Point(20, 52); this.dgvApplications.Size = new System.Drawing.Size(910, 395);
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.ReadOnly = true; this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White; this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46,125,50);
            this.dgvApplications.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvApplications.EnableHeadersVisualStyles = false;

            this.btnApprove.Text = "Approve"; this.btnApprove.Location = new System.Drawing.Point(20, 458); this.btnApprove.Size = new System.Drawing.Size(120, 35);
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(46,125,50); this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnApprove.FlatAppearance.BorderSize = 0; this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);

            this.btnReject.Text = "Reject"; this.btnReject.Location = new System.Drawing.Point(150, 458); this.btnReject.Size = new System.Drawing.Size(120, 35);
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(183,28,28); this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnReject.FlatAppearance.BorderSize = 0; this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);

            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(280, 458); this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.FlatAppearance.BorderSize = 0; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 458); this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvApplications, this.btnApprove, this.btnReject, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvApplications).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Button btnApprove, btnReject, btnRefresh, btnClose;
    }
}
