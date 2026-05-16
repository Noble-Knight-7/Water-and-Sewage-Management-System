namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class MaintenanceTasksForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle   = new System.Windows.Forms.Label();
            this.dgvTasks   = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose   = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 480); this.Text = "My Maintenance Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Maintenance Tasks"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0,105,92); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(240, 30);

            this.dgvTasks.Location = new System.Drawing.Point(20, 52); this.dgvTasks.Size = new System.Drawing.Size(910, 380);
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.ReadOnly = true; this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White; this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0,105,92);
            this.dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvTasks.EnableHeadersVisualStyles = false;

            this.btnRefresh.Text = "Refresh"; this.btnRefresh.Location = new System.Drawing.Point(20, 440); this.btnRefresh.Size = new System.Drawing.Size(120, 33);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21,101,192); this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.FlatAppearance.BorderSize = 0; this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 440); this.btnClose.Size = new System.Drawing.Size(90, 33);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvTasks, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnRefresh, btnClose;
    }
}
