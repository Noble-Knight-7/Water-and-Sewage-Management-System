namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class GenerateBillForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle    = new System.Windows.Forms.Label();
            this.dgvBills    = new System.Windows.Forms.DataGridView();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            this.btnRefresh  = new System.Windows.Forms.Button();
            this.btnClose    = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvBills).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 520); this.Text = "All Bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "All Customer Bills"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0,105,92); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(250, 30);

            this.dgvBills.Location = new System.Drawing.Point(20, 52); this.dgvBills.Size = new System.Drawing.Size(910, 410);
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.ReadOnly = true; this.dgvBills.AllowUserToAddRows = false;
            this.dgvBills.BackgroundColor = System.Drawing.Color.White; this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0,105,92);
            this.dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBills.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBills.EnableHeadersVisualStyles = false;

            this.btnMarkPaid.Text = "Mark as Paid"; this.btnMarkPaid.Location = new System.Drawing.Point(20, 475); this.btnMarkPaid.Size = new System.Drawing.Size(140, 35);
            this.btnMarkPaid.BackColor = System.Drawing.Color.FromArgb(46,125,50); this.btnMarkPaid.ForeColor = System.Drawing.Color.White;
            this.btnMarkPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMarkPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnMarkPaid.FlatAppearance.BorderSize = 0; this.btnMarkPaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);

            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(170, 475); this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.FlatAppearance.BorderSize = 0; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 475); this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvBills, this.btnMarkPaid, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvBills).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.Button btnMarkPaid, btnRefresh, btnClose;
    }
}
