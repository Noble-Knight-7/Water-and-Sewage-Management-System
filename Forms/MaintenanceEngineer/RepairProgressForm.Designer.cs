namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class RepairProgressForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle   = new System.Windows.Forms.Label();
            this.dgvTasks   = new System.Windows.Forms.DataGridView();
            this.lblStatus  = new System.Windows.Forms.Label(); this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblNotes   = new System.Windows.Forms.Label(); this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnUpdate  = new System.Windows.Forms.Button(); this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 570); this.Text = "Update Repair Progress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Update Repair Progress"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(230,81,0); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(280, 30);

            this.dgvTasks.Location = new System.Drawing.Point(20, 52); this.dgvTasks.Size = new System.Drawing.Size(910, 310);
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.ReadOnly = true; this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White; this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230,81,0);
            this.dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvTasks.EnableHeadersVisualStyles = false;

            this.lblStatus.Text = "New Status:"; this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblStatus.Location = new System.Drawing.Point(20, 378); this.lblStatus.Size = new System.Drawing.Size(130, 22);
            this.cmbStatus.Location = new System.Drawing.Point(155, 376); this.cmbStatus.Size = new System.Drawing.Size(200, 26); this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] { "Pending", "InProgress", "Completed" }); this.cmbStatus.SelectedIndex = 1;

            this.lblNotes.Text = "Notes:"; this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblNotes.Location = new System.Drawing.Point(20, 420); this.lblNotes.Size = new System.Drawing.Size(130, 22);
            this.txtNotes.Location = new System.Drawing.Point(20, 445); this.txtNotes.Size = new System.Drawing.Size(910, 60); this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtNotes.Multiline = true; this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnUpdate.Text = "Update Progress"; this.btnUpdate.Location = new System.Drawing.Point(20, 520); this.btnUpdate.Size = new System.Drawing.Size(170, 36);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(230,81,0); this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnUpdate.FlatAppearance.BorderSize = 0; this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 520); this.btnClose.Size = new System.Drawing.Size(90, 36);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvTasks, this.lblStatus, this.cmbStatus, this.lblNotes, this.txtNotes, this.btnUpdate, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle, lblStatus, lblNotes;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnUpdate, btnClose;
    }
}
