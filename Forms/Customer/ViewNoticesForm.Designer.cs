namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class ViewNoticesForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle  = new System.Windows.Forms.Label();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.btnClose  = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvNotices).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 480); this.Text = "Notices & Alerts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Notices & Service Alerts"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(74,20,140); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(300, 30);

            this.dgvNotices.Location = new System.Drawing.Point(20, 50); this.dgvNotices.Size = new System.Drawing.Size(860, 385);
            this.dgvNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.ReadOnly = true; this.dgvNotices.AllowUserToAddRows = false;
            this.dgvNotices.BackgroundColor = System.Drawing.Color.White; this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(74,20,140);
            this.dgvNotices.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNotices.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvNotices.EnableHeadersVisualStyles = false;

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(780, 440); this.btnClose.Size = new System.Drawing.Size(100, 33);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvNotices, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvNotices).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvNotices;
        private System.Windows.Forms.Button btnClose;
    }
}
