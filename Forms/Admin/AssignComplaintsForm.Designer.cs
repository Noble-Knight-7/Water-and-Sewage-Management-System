namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class AssignComplaintsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.lblEngineer = new System.Windows.Forms.Label();
            this.cmbEngineer = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvComplaints).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 550); this.Text = "Assign Complaints to Engineers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Assign Complaints"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(13,71,161); this.lblTitle.Location = new System.Drawing.Point(20, 15); this.lblTitle.Size = new System.Drawing.Size(260, 30);

            this.dgvComplaints.Location = new System.Drawing.Point(20, 55); this.dgvComplaints.Size = new System.Drawing.Size(910, 380);
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.ReadOnly = true; this.dgvComplaints.AllowUserToAddRows = false;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.White; this.dgvComplaints.RowHeadersVisible = false;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230,81,0);
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvComplaints.EnableHeadersVisualStyles = false;

            this.lblEngineer.Text = "Assign to Engineer:"; this.lblEngineer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEngineer.Location = new System.Drawing.Point(20, 455); this.lblEngineer.Size = new System.Drawing.Size(160, 24);

            this.cmbEngineer.Location = new System.Drawing.Point(185, 453); this.cmbEngineer.Size = new System.Drawing.Size(250, 26);
            this.cmbEngineer.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbEngineer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnAssign.Text = "Assign"; this.btnAssign.Location = new System.Drawing.Point(450, 450); this.btnAssign.Size = new System.Drawing.Size(120, 36);
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(230,81,0); this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnAssign.FlatAppearance.BorderSize = 0; this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);

            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(580, 450); this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.FlatAppearance.BorderSize = 0; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(830, 450); this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvComplaints, this.lblEngineer, this.cmbEngineer, this.btnAssign, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvComplaints).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle, lblEngineer;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.ComboBox cmbEngineer;
        private System.Windows.Forms.Button btnAssign, btnRefresh, btnClose;
    }
}
