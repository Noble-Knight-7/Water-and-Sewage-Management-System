namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class AssignedComplaintsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle          = new System.Windows.Forms.Label();
            this.dgvComplaints     = new System.Windows.Forms.DataGridView();
            this.btnMarkInProgress = new System.Windows.Forms.Button();
            this.btnMarkResolved   = new System.Windows.Forms.Button();
            this.btnRefresh        = new System.Windows.Forms.Button();
            this.btnClose          = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvComplaints).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 500); this.Text = "My Assigned Complaints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Assigned Complaints"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(46,125,50); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(260, 30);

            this.dgvComplaints.Location = new System.Drawing.Point(20, 52); this.dgvComplaints.Size = new System.Drawing.Size(910, 393);
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.ReadOnly = true; this.dgvComplaints.AllowUserToAddRows = false;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.White; this.dgvComplaints.RowHeadersVisible = false;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46,125,50);
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvComplaints.EnableHeadersVisualStyles = false;

            this.btnMarkInProgress.Text = "Mark In Progress"; this.btnMarkInProgress.Location = new System.Drawing.Point(20, 456); this.btnMarkInProgress.Size = new System.Drawing.Size(160, 35);
            this.btnMarkInProgress.BackColor = System.Drawing.Color.FromArgb(230,81,0); this.btnMarkInProgress.ForeColor = System.Drawing.Color.White;
            this.btnMarkInProgress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnMarkInProgress.FlatAppearance.BorderSize = 0; this.btnMarkInProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkInProgress.Click += new System.EventHandler(this.btnMarkInProgress_Click);

            this.btnMarkResolved.Text = "Mark Resolved"; this.btnMarkResolved.Location = new System.Drawing.Point(190, 456); this.btnMarkResolved.Size = new System.Drawing.Size(150, 35);
            this.btnMarkResolved.BackColor = System.Drawing.Color.FromArgb(46,125,50); this.btnMarkResolved.ForeColor = System.Drawing.Color.White;
            this.btnMarkResolved.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkResolved.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnMarkResolved.FlatAppearance.BorderSize = 0; this.btnMarkResolved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkResolved.Click += new System.EventHandler(this.btnMarkResolved_Click);

            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(350, 456); this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.FlatAppearance.BorderSize = 0; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 456); this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvComplaints, this.btnMarkInProgress, this.btnMarkResolved, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvComplaints).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.Button btnMarkInProgress, btnMarkResolved, btnRefresh, btnClose;
    }
}
