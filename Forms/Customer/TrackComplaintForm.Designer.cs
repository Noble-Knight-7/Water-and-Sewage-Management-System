namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class TrackComplaintForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle      = new System.Windows.Forms.Label();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.btnRefresh    = new System.Windows.Forms.Button();
            this.btnClose      = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvComplaints).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 480); this.Text = "Track My Complaints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "My Complaints"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(106,27,154); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(220, 30);

            this.dgvComplaints.Location = new System.Drawing.Point(20, 50); this.dgvComplaints.Size = new System.Drawing.Size(860, 375);
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.ReadOnly = true; this.dgvComplaints.AllowUserToAddRows = false;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.White; this.dgvComplaints.RowHeadersVisible = false;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(106,27,154);
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvComplaints.EnableHeadersVisualStyles = false;

            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(20, 438); this.btnRefresh.Size = new System.Drawing.Size(120, 33);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.FlatAppearance.BorderSize = 0; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(780, 438); this.btnClose.Size = new System.Drawing.Size(100, 33);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvComplaints, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvComplaints).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.Button btnRefresh, btnClose;
    }
}
