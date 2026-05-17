namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class ReviewDisputesForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDisputes = new System.Windows.Forms.DataGridView();
            this.btnMarkReviewed = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisputes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(365, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " Bill Disputes";
            // 
            // dgvDisputes
            // 
            this.dgvDisputes.AllowUserToAddRows = false;
            this.dgvDisputes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisputes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDisputes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisputes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDisputes.ColumnHeadersHeight = 29;
            this.dgvDisputes.EnableHeadersVisualStyles = false;
            this.dgvDisputes.Location = new System.Drawing.Point(20, 52);
            this.dgvDisputes.Name = "dgvDisputes";
            this.dgvDisputes.ReadOnly = true;
            this.dgvDisputes.RowHeadersVisible = false;
            this.dgvDisputes.RowHeadersWidth = 51;
            this.dgvDisputes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisputes.Size = new System.Drawing.Size(910, 395);
            this.dgvDisputes.TabIndex = 1;
            // 
            // btnMarkReviewed
            // 
            this.btnMarkReviewed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnMarkReviewed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkReviewed.FlatAppearance.BorderSize = 0;
            this.btnMarkReviewed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarkReviewed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarkReviewed.ForeColor = System.Drawing.Color.White;
            this.btnMarkReviewed.Location = new System.Drawing.Point(20, 458);
            this.btnMarkReviewed.Name = "btnMarkReviewed";
            this.btnMarkReviewed.Size = new System.Drawing.Size(170, 35);
            this.btnMarkReviewed.TabIndex = 2;
            this.btnMarkReviewed.Text = "Mark as Reviewed";
            this.btnMarkReviewed.UseVisualStyleBackColor = false;
            this.btnMarkReviewed.Click += new System.EventHandler(this.btnMarkReviewed_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(840, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReviewDisputesForm
            // 
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvDisputes);
            this.Controls.Add(this.btnMarkReviewed);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReviewDisputesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Bill Disputes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisputes)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvDisputes;
        private System.Windows.Forms.Button btnMarkReviewed, btnClose;
    }
}
