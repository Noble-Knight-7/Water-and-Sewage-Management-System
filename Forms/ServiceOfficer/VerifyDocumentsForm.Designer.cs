namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class VerifyDocumentsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnClose  = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvApplications).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(950, 500); this.Text = "Verify Application Documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Verify Documents"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(106,27,154); this.lblTitle.Location = new System.Drawing.Point(20, 12); this.lblTitle.Size = new System.Drawing.Size(220, 30);

            this.dgvApplications.Location = new System.Drawing.Point(20, 52); this.dgvApplications.Size = new System.Drawing.Size(910, 395);
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.ReadOnly = true; this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White; this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(106,27,154);
            this.dgvApplications.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvApplications.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvApplications.EnableHeadersVisualStyles = false;

            this.btnVerify.Text = "Verify Documents"; this.btnVerify.Location = new System.Drawing.Point(20, 458); this.btnVerify.Size = new System.Drawing.Size(170, 35);
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(106,27,154); this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnVerify.FlatAppearance.BorderSize = 0; this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);

            this.btnClose.Text = "Close"; this.btnClose.Location = new System.Drawing.Point(840, 458); this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.BackColor = System.Drawing.Color.Gray; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvApplications, this.btnVerify, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvApplications).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.Button btnVerify, btnClose;
    }
}
