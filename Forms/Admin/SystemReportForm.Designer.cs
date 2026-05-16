namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class SystemReportForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label(); this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label(); this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvReports).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 550); this.Text = "System Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "System Reports"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0,96,100); this.lblTitle.Location = new System.Drawing.Point(20, 10); this.lblTitle.Size = new System.Drawing.Size(220, 30);

            this.lblType.Text = "Report Type:"; this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblType.Location = new System.Drawing.Point(20, 55); this.lblType.Size = new System.Drawing.Size(140, 22);
            this.cmbType.Location = new System.Drawing.Point(170, 53); this.cmbType.Size = new System.Drawing.Size(200, 26); this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] { "Billing", "Complaint", "Maintenance", "User", "Connection" }); this.cmbType.SelectedIndex = 0;

            this.lblDesc.Text = "Description:"; this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblDesc.Location = new System.Drawing.Point(20, 92); this.lblDesc.Size = new System.Drawing.Size(140, 22);
            this.txtDescription.Location = new System.Drawing.Point(170, 90); this.txtDescription.Size = new System.Drawing.Size(650, 26); this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnGenerate.Text = "Log Report"; this.btnGenerate.Location = new System.Drawing.Point(20, 130); this.btnGenerate.Size = new System.Drawing.Size(140, 36);
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(0,96,100); this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnGenerate.FlatAppearance.BorderSize = 0; this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            this.dgvReports.Location = new System.Drawing.Point(20, 185); this.dgvReports.Size = new System.Drawing.Size(860, 310);
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.ReadOnly = true; this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.BackgroundColor = System.Drawing.Color.White; this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0,96,100);
            this.dgvReports.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReports.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvReports.EnableHeadersVisualStyles = false;

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(780, 508); this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblType, this.cmbType, this.lblDesc, this.txtDescription, this.btnGenerate, this.dgvReports, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvReports).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle, lblType, lblDesc;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGenerate, btnClose;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}
