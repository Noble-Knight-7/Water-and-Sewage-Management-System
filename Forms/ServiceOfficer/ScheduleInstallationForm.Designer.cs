namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class ScheduleInstallationForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle        = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.lblDate         = new System.Windows.Forms.Label();
            this.dtpInstallDate  = new System.Windows.Forms.DateTimePicker();
            this.btnSchedule     = new System.Windows.Forms.Button();
            this.btnClose        = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvApplications).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 530); this.Text = "Schedule Installation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Schedule Installation"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0,96,100); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(250, 30);

            this.dgvApplications.Location = new System.Drawing.Point(20, 52); this.dgvApplications.Size = new System.Drawing.Size(910, 380);
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.ReadOnly = true; this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White; this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0,96,100);
            this.dgvApplications.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvApplications.EnableHeadersVisualStyles = false;

            this.lblDate.Text = "Installation Date:"; this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(20, 448); this.lblDate.Size = new System.Drawing.Size(150, 24);
            this.dtpInstallDate.Location = new System.Drawing.Point(175, 445); this.dtpInstallDate.Size = new System.Drawing.Size(200, 26);
            this.dtpInstallDate.Font = new System.Drawing.Font("Segoe UI", 10F); this.dtpInstallDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnSchedule.Text = "Schedule"; this.btnSchedule.Location = new System.Drawing.Point(390, 443); this.btnSchedule.Size = new System.Drawing.Size(130, 35);
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(0,96,100); this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSchedule.FlatAppearance.BorderSize = 0; this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 443); this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvApplications, this.lblDate, this.dtpInstallDate, this.btnSchedule, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvApplications).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle, lblDate;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.DateTimePicker dtpInstallDate;
        private System.Windows.Forms.Button btnSchedule, btnClose;
    }
}
