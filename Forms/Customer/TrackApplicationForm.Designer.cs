namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class TrackApplicationForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle        = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.btnRefresh      = new System.Windows.Forms.Button();
            this.btnClose        = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvApplications).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 480); this.Text = "Track Connection Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "My Connection Applications"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0,96,100); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(320, 30);

            this.dgvApplications.Location = new System.Drawing.Point(20, 50); this.dgvApplications.Size = new System.Drawing.Size(860, 378);
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.ReadOnly = true; this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White; this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0,96,100);
            this.dgvApplications.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvApplications.EnableHeadersVisualStyles = false;

            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(20, 438); this.btnRefresh.Size = new System.Drawing.Size(120, 33);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.FlatAppearance.BorderSize = 0; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(780, 438); this.btnClose.Size = new System.Drawing.Size(100, 33);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvApplications, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvApplications).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Button btnRefresh, btnClose;
    }
}
