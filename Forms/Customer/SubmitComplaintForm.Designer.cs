namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class SubmitComplaintForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle       = new System.Windows.Forms.Label();
            this.lblCategory    = new System.Windows.Forms.Label(); this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPriority    = new System.Windows.Forms.Label(); this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label(); this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit      = new System.Windows.Forms.Button(); this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(500, 370); this.Text = "Submit Complaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Submit a Complaint"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(183,28,28); this.lblTitle.Location = new System.Drawing.Point(120, 15); this.lblTitle.Size = new System.Drawing.Size(260, 28);

            this.lblCategory.Text = "Category:"; this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblCategory.Location = new System.Drawing.Point(30, 65); this.lblCategory.Size = new System.Drawing.Size(130, 22);
            this.cmbCategory.Location = new System.Drawing.Point(170, 63); this.cmbCategory.Size = new System.Drawing.Size(280, 26); this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] { "Billing", "Water Supply", "Sewerage", "Maintenance", "Water Quality", "Other" }); this.cmbCategory.SelectedIndex = 0;

            this.lblPriority.Text = "Priority:"; this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblPriority.Location = new System.Drawing.Point(30, 108); this.lblPriority.Size = new System.Drawing.Size(130, 22);
            this.cmbPriority.Location = new System.Drawing.Point(170, 106); this.cmbPriority.Size = new System.Drawing.Size(280, 26); this.cmbPriority.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" }); this.cmbPriority.SelectedIndex = 1;

            this.lblDescription.Text = "Description:"; this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblDescription.Location = new System.Drawing.Point(30, 150); this.lblDescription.Size = new System.Drawing.Size(130, 22);
            this.txtDescription.Location = new System.Drawing.Point(30, 175); this.txtDescription.Size = new System.Drawing.Size(440, 120); this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtDescription.Multiline = true; this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnSubmit.Text = "Submit Complaint"; this.btnSubmit.Location = new System.Drawing.Point(30, 315); this.btnSubmit.Size = new System.Drawing.Size(180, 38);
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(183,28,28); this.btnSubmit.ForeColor = System.Drawing.Color.White; this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSubmit.FlatAppearance.BorderSize = 0; this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand; this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnCancel.Text = "Cancel"; this.btnCancel.Location = new System.Drawing.Point(290, 315); this.btnCancel.Size = new System.Drawing.Size(180, 38);
            this.btnCancel.BackColor = System.Drawing.Color.Gray; this.btnCancel.ForeColor = System.Drawing.Color.White; this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnCancel.FlatAppearance.BorderSize = 0; this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand; this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblCategory, this.cmbCategory, this.lblPriority, this.cmbPriority, this.lblDescription, this.txtDescription, this.btnSubmit, this.btnCancel });
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblTitle, lblCategory, lblPriority, lblDescription;
        private System.Windows.Forms.ComboBox cmbCategory, cmbPriority;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSubmit, btnCancel;
    }
}
