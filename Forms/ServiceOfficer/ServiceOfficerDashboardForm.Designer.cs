namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class ServiceOfficerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnMeterReading = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnReviewDisputes = new System.Windows.Forms.Button();
            this.btnCorrectBill = new System.Windows.Forms.Button();
            this.btnReviewConnections = new System.Windows.Forms.Button();
            this.btnVerifyDocuments = new System.Windows.Forms.Button();
            this.btnScheduleInstallation = new System.Windows.Forms.Button();
            this.btnBillingReport = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 70);
            this.panelHeader.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WASA Management System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.LightBlue;
            this.lblWelcome.Location = new System.Drawing.Point(20, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(420, 22);
            this.lblWelcome.TabIndex = 1;
            // 
            // btnMeterReading
            // 
            this.btnMeterReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnMeterReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeterReading.FlatAppearance.BorderSize = 0;
            this.btnMeterReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeterReading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMeterReading.ForeColor = System.Drawing.Color.White;
            this.btnMeterReading.Location = new System.Drawing.Point(30, 90);
            this.btnMeterReading.Name = "btnMeterReading";
            this.btnMeterReading.Size = new System.Drawing.Size(185, 90);
            this.btnMeterReading.TabIndex = 0;
            this.btnMeterReading.Text = "Enter Meter Reading";
            this.btnMeterReading.UseVisualStyleBackColor = false;
            this.btnMeterReading.Click += new System.EventHandler(this.btnMeterReading_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnGenerateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBill.FlatAppearance.BorderSize = 0;
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(235, 90);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(185, 90);
            this.btnGenerateBill.TabIndex = 1;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // btnReviewDisputes
            // 
            this.btnReviewDisputes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnReviewDisputes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviewDisputes.FlatAppearance.BorderSize = 0;
            this.btnReviewDisputes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewDisputes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReviewDisputes.ForeColor = System.Drawing.Color.White;
            this.btnReviewDisputes.Location = new System.Drawing.Point(440, 90);
            this.btnReviewDisputes.Name = "btnReviewDisputes";
            this.btnReviewDisputes.Size = new System.Drawing.Size(185, 90);
            this.btnReviewDisputes.TabIndex = 2;
            this.btnReviewDisputes.Text = "Review Disputes";
            this.btnReviewDisputes.UseVisualStyleBackColor = false;
            this.btnReviewDisputes.Click += new System.EventHandler(this.btnReviewDisputes_Click);
            // 
            // btnCorrectBill
            // 
            this.btnCorrectBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCorrectBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrectBill.FlatAppearance.BorderSize = 0;
            this.btnCorrectBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrectBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCorrectBill.ForeColor = System.Drawing.Color.White;
            this.btnCorrectBill.Location = new System.Drawing.Point(645, 90);
            this.btnCorrectBill.Name = "btnCorrectBill";
            this.btnCorrectBill.Size = new System.Drawing.Size(185, 90);
            this.btnCorrectBill.TabIndex = 3;
            this.btnCorrectBill.Text = "Correct Bill";
            this.btnCorrectBill.UseVisualStyleBackColor = false;
            this.btnCorrectBill.Click += new System.EventHandler(this.btnCorrectBill_Click);
            // 
            // btnReviewConnections
            // 
            this.btnReviewConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnReviewConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviewConnections.FlatAppearance.BorderSize = 0;
            this.btnReviewConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewConnections.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReviewConnections.ForeColor = System.Drawing.Color.White;
            this.btnReviewConnections.Location = new System.Drawing.Point(30, 210);
            this.btnReviewConnections.Name = "btnReviewConnections";
            this.btnReviewConnections.Size = new System.Drawing.Size(185, 90);
            this.btnReviewConnections.TabIndex = 4;
            this.btnReviewConnections.Text = "Review Connections";
            this.btnReviewConnections.UseVisualStyleBackColor = false;
            this.btnReviewConnections.Click += new System.EventHandler(this.btnReviewConnections_Click);
            // 
            // btnVerifyDocuments
            // 
            this.btnVerifyDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnVerifyDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyDocuments.FlatAppearance.BorderSize = 0;
            this.btnVerifyDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyDocuments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerifyDocuments.ForeColor = System.Drawing.Color.White;
            this.btnVerifyDocuments.Location = new System.Drawing.Point(235, 210);
            this.btnVerifyDocuments.Name = "btnVerifyDocuments";
            this.btnVerifyDocuments.Size = new System.Drawing.Size(185, 90);
            this.btnVerifyDocuments.TabIndex = 5;
            this.btnVerifyDocuments.Text = "Verify Documents";
            this.btnVerifyDocuments.UseVisualStyleBackColor = false;
            this.btnVerifyDocuments.Click += new System.EventHandler(this.btnVerifyDocuments_Click);
            // 
            // btnScheduleInstallation
            // 
            this.btnScheduleInstallation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnScheduleInstallation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScheduleInstallation.FlatAppearance.BorderSize = 0;
            this.btnScheduleInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleInstallation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnScheduleInstallation.ForeColor = System.Drawing.Color.White;
            this.btnScheduleInstallation.Location = new System.Drawing.Point(440, 210);
            this.btnScheduleInstallation.Name = "btnScheduleInstallation";
            this.btnScheduleInstallation.Size = new System.Drawing.Size(185, 90);
            this.btnScheduleInstallation.TabIndex = 6;
            this.btnScheduleInstallation.Text = "Schedule Installation";
            this.btnScheduleInstallation.UseVisualStyleBackColor = false;
            this.btnScheduleInstallation.Click += new System.EventHandler(this.btnScheduleInstallation_Click);
            // 
            // btnBillingReport
            // 
            this.btnBillingReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnBillingReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillingReport.FlatAppearance.BorderSize = 0;
            this.btnBillingReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBillingReport.ForeColor = System.Drawing.Color.White;
            this.btnBillingReport.Location = new System.Drawing.Point(645, 210);
            this.btnBillingReport.Name = "btnBillingReport";
            this.btnBillingReport.Size = new System.Drawing.Size(185, 90);
            this.btnBillingReport.TabIndex = 7;
            this.btnBillingReport.Text = "Billing Report";
            this.btnBillingReport.UseVisualStyleBackColor = false;
            this.btnBillingReport.Click += new System.EventHandler(this.btnBillingReport_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(30, 330);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(185, 90);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(14)))), ((int)(((byte)(79)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(235, 330);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(185, 90);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ServiceOfficerDashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.btnMeterReading);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnReviewDisputes);
            this.Controls.Add(this.btnCorrectBill);
            this.Controls.Add(this.btnReviewConnections);
            this.Controls.Add(this.btnVerifyDocuments);
            this.Controls.Add(this.btnScheduleInstallation);
            this.Controls.Add(this.btnBillingReport);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceOfficerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Officer Dashboard - WASA Management System";
            this.Load += new System.EventHandler(this.ServiceOfficerDashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel  panelHeader;
        private System.Windows.Forms.Label  lblTitle, lblWelcome;
        private System.Windows.Forms.Button btnMeterReading, btnGenerateBill, btnReviewDisputes, btnCorrectBill;
        private System.Windows.Forms.Button btnReviewConnections, btnVerifyDocuments, btnScheduleInstallation;
        private System.Windows.Forms.Button btnBillingReport, btnProfile, btnLogout;
    }
}
