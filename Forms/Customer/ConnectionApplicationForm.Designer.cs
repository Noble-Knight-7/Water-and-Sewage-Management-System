namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class ConnectionApplicationForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep4 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(80, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Connection Application";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location = new System.Drawing.Point(30, 55);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(460, 45);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Submitting this application will request a new water/sewage connection.\nA Service" +
    " Officer will review your application and contact you.";
            // 
            // lblStep1
            // 
            this.lblStep1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblStep1.Location = new System.Drawing.Point(30, 115);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(460, 28);
            this.lblStep1.TabIndex = 2;
            this.lblStep1.Text = "Step 1: Submit this application form";
            this.lblStep1.Click += new System.EventHandler(this.lblStep1_Click);
            // 
            // lblStep2
            // 
            this.lblStep2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lblStep2.Location = new System.Drawing.Point(30, 157);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(460, 28);
            this.lblStep2.TabIndex = 3;
            this.lblStep2.Text = "Step 2: Service Officer will verify your documents";
            // 
            // lblStep3
            // 
            this.lblStep3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblStep3.Location = new System.Drawing.Point(30, 199);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(460, 28);
            this.lblStep3.TabIndex = 4;
            this.lblStep3.Text = "Step 3: Application will be approved or rejected";
            // 
            // lblStep4
            // 
            this.lblStep4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.lblStep4.Location = new System.Drawing.Point(30, 241);
            this.lblStep4.Name = "lblStep4";
            this.lblStep4.Size = new System.Drawing.Size(460, 28);
            this.lblStep4.TabIndex = 5;
            this.lblStep4.Text = "Step 4: Installation will be scheduled if approved";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(30, 305);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(200, 42);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Submit Application";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(390, 305);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 42);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ConnectionApplicationForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.lblStep4);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConnectionApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply for New Connection";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label lblTitle, lblInfo, lblStep1, lblStep2, lblStep3, lblStep4;
        private System.Windows.Forms.Button btnApply, btnClose;
    }
}
