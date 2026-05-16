namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class ApproveEmployeesForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle   = new System.Windows.Forms.Label();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose   = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvPending).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(800, 480); this.Text = "Approve Employee Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Pending Employee Approvals"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161); this.lblTitle.Location = new System.Drawing.Point(20, 15); this.lblTitle.Size = new System.Drawing.Size(350, 30);

            this.dgvPending.Location = new System.Drawing.Point(20, 55); this.dgvPending.Size = new System.Drawing.Size(760, 360);
            this.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPending.ReadOnly = true; this.dgvPending.AllowUserToAddRows = false;
            this.dgvPending.BackgroundColor = System.Drawing.Color.White; this.dgvPending.RowHeadersVisible = false;
            this.dgvPending.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(46,125,50);
            this.dgvPending.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPending.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvPending.EnableHeadersVisualStyles = false;

            this.btnApprove.Text = "Approve Selected"; this.btnApprove.Location = new System.Drawing.Point(20, 430); this.btnApprove.Size = new System.Drawing.Size(160, 36);
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(46,125,50); this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnApprove.FlatAppearance.BorderSize = 0; this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);

            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(190, 430); this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.FlatAppearance.BorderSize = 0; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(680, 430); this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvPending, this.btnApprove, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvPending).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.Button btnApprove, btnRefresh, btnClose;
    }
}
