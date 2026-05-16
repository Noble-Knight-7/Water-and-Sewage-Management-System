namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class ServiceOfficerDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnMeterReading = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnReviewDisputes = new System.Windows.Forms.Button();
            this.btnCorrectBill = new System.Windows.Forms.Button();
            this.btnReviewConnections = new System.Windows.Forms.Button();
            this.btnVerifyDocuments = new System.Windows.Forms.Button();
            this.btnScheduleInstallation = new System.Windows.Forms.Button();
            this.btnBillingReport = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblOverview = new System.Windows.Forms.Label();
            this.cardMeter = new System.Windows.Forms.Panel();
            this.lblMeterCount = new System.Windows.Forms.Label();
            this.lblMeterText = new System.Windows.Forms.Label();
            this.cardBill = new System.Windows.Forms.Panel();
            this.lblBillCount = new System.Windows.Forms.Label();
            this.lblBillText = new System.Windows.Forms.Label();
            this.cardDispute = new System.Windows.Forms.Panel();
            this.lblDisputeCount = new System.Windows.Forms.Label();
            this.lblDisputeText = new System.Windows.Forms.Label();
            this.cardConnection = new System.Windows.Forms.Panel();
            this.lblConnectionCount = new System.Windows.Forms.Label();
            this.lblConnectionText = new System.Windows.Forms.Label();
            this.lblRecentRecords = new System.Windows.Forms.Label();
            this.dgvRecentRecords = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.cardMeter.SuspendLayout();
            this.cardBill.SuspendLayout();
            this.cardDispute.SuspendLayout();
            this.cardConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lbl_Welcome);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1136, 52);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(686, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Water and Sewage Management System - Service Officer";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcome.Location = new System.Drawing.Point(798, 18);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(204, 19);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "Welcome, Service Officer";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1034, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 31);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panelSidebar.Controls.Add(this.btnMeterReading);
            this.panelSidebar.Controls.Add(this.btnGenerateBill);
            this.panelSidebar.Controls.Add(this.btnReviewDisputes);
            this.panelSidebar.Controls.Add(this.btnCorrectBill);
            this.panelSidebar.Controls.Add(this.btnReviewConnections);
            this.panelSidebar.Controls.Add(this.btnVerifyDocuments);
            this.panelSidebar.Controls.Add(this.btnScheduleInstallation);
            this.panelSidebar.Controls.Add(this.btnBillingReport);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 52);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(212, 575);
            this.panelSidebar.TabIndex = 5;
            // 
            // btnMeterReading
            // 
            this.btnMeterReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnMeterReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMeterReading.FlatAppearance.BorderSize = 0;
            this.btnMeterReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeterReading.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMeterReading.ForeColor = System.Drawing.Color.White;
            this.btnMeterReading.Location = new System.Drawing.Point(0, 36);
            this.btnMeterReading.Name = "btnMeterReading";
            this.btnMeterReading.Size = new System.Drawing.Size(212, 40);
            this.btnMeterReading.TabIndex = 1;
            this.btnMeterReading.Text = "   📊  Enter Meter";
            this.btnMeterReading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeterReading.UseVisualStyleBackColor = false;
            this.btnMeterReading.Click += new System.EventHandler(this.btnMeterReading_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnGenerateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBill.FlatAppearance.BorderSize = 0;
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(0, 92);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(212, 40);
            this.btnGenerateBill.TabIndex = 2;
            this.btnGenerateBill.Text = "   💵  Generate Bill";
            this.btnGenerateBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // btnReviewDisputes
            // 
            this.btnReviewDisputes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnReviewDisputes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviewDisputes.FlatAppearance.BorderSize = 0;
            this.btnReviewDisputes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewDisputes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReviewDisputes.ForeColor = System.Drawing.Color.White;
            this.btnReviewDisputes.Location = new System.Drawing.Point(0, 148);
            this.btnReviewDisputes.Name = "btnReviewDisputes";
            this.btnReviewDisputes.Size = new System.Drawing.Size(212, 40);
            this.btnReviewDisputes.TabIndex = 3;
            this.btnReviewDisputes.Text = "   🔍  Review Disputes";
            this.btnReviewDisputes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewDisputes.UseVisualStyleBackColor = false;
            this.btnReviewDisputes.Click += new System.EventHandler(this.btnReviewDisputes_Click);
            // 
            // btnCorrectBill
            // 
            this.btnCorrectBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnCorrectBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrectBill.FlatAppearance.BorderSize = 0;
            this.btnCorrectBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrectBill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCorrectBill.ForeColor = System.Drawing.Color.White;
            this.btnCorrectBill.Location = new System.Drawing.Point(0, 204);
            this.btnCorrectBill.Name = "btnCorrectBill";
            this.btnCorrectBill.Size = new System.Drawing.Size(212, 40);
            this.btnCorrectBill.TabIndex = 4;
            this.btnCorrectBill.Text = "   ✏️  Correct Bill";
            this.btnCorrectBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrectBill.UseVisualStyleBackColor = false;
            this.btnCorrectBill.Click += new System.EventHandler(this.btnCorrectBill_Click);
            // 
            // btnReviewConnections
            // 
            this.btnReviewConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnReviewConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviewConnections.FlatAppearance.BorderSize = 0;
            this.btnReviewConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviewConnections.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReviewConnections.ForeColor = System.Drawing.Color.White;
            this.btnReviewConnections.Location = new System.Drawing.Point(0, 260);
            this.btnReviewConnections.Name = "btnReviewConnections";
            this.btnReviewConnections.Size = new System.Drawing.Size(212, 40);
            this.btnReviewConnections.TabIndex = 5;
            this.btnReviewConnections.Text = "   📋  Applications";
            this.btnReviewConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviewConnections.UseVisualStyleBackColor = false;
            this.btnReviewConnections.Click += new System.EventHandler(this.btnReviewConnections_Click);
            // 
            // btnVerifyDocuments
            // 
            this.btnVerifyDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnVerifyDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyDocuments.FlatAppearance.BorderSize = 0;
            this.btnVerifyDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyDocuments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnVerifyDocuments.ForeColor = System.Drawing.Color.White;
            this.btnVerifyDocuments.Location = new System.Drawing.Point(0, 316);
            this.btnVerifyDocuments.Name = "btnVerifyDocuments";
            this.btnVerifyDocuments.Size = new System.Drawing.Size(212, 40);
            this.btnVerifyDocuments.TabIndex = 6;
            this.btnVerifyDocuments.Text = "   ✅  Verify Documents";
            this.btnVerifyDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerifyDocuments.UseVisualStyleBackColor = false;
            this.btnVerifyDocuments.Click += new System.EventHandler(this.btnVerifyDocuments_Click);
            // 
            // btnScheduleInstallation
            // 
            this.btnScheduleInstallation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnScheduleInstallation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScheduleInstallation.FlatAppearance.BorderSize = 0;
            this.btnScheduleInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleInstallation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnScheduleInstallation.ForeColor = System.Drawing.Color.White;
            this.btnScheduleInstallation.Location = new System.Drawing.Point(0, 372);
            this.btnScheduleInstallation.Name = "btnScheduleInstallation";
            this.btnScheduleInstallation.Size = new System.Drawing.Size(212, 40);
            this.btnScheduleInstallation.TabIndex = 7;
            this.btnScheduleInstallation.Text = "   🗓️  Schedule Install";
            this.btnScheduleInstallation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleInstallation.UseVisualStyleBackColor = false;
            this.btnScheduleInstallation.Click += new System.EventHandler(this.btnScheduleInstallation_Click);
            // 
            // btnBillingReport
            // 
            this.btnBillingReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnBillingReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillingReport.FlatAppearance.BorderSize = 0;
            this.btnBillingReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBillingReport.ForeColor = System.Drawing.Color.White;
            this.btnBillingReport.Location = new System.Drawing.Point(1, 428);
            this.btnBillingReport.Name = "btnBillingReport";
            this.btnBillingReport.Size = new System.Drawing.Size(212, 40);
            this.btnBillingReport.TabIndex = 8;
            this.btnBillingReport.Text = "   📄  Billing Report";
            this.btnBillingReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillingReport.UseVisualStyleBackColor = false;
            this.btnBillingReport.Click += new System.EventHandler(this.btnBillingReport_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 484);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(212, 40);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "   👤  My Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelMain.Controls.Add(this.lblOverview);
            this.panelMain.Controls.Add(this.cardMeter);
            this.panelMain.Controls.Add(this.cardBill);
            this.panelMain.Controls.Add(this.cardDispute);
            this.panelMain.Controls.Add(this.cardConnection);
            this.panelMain.Controls.Add(this.lblRecentRecords);
            this.panelMain.Controls.Add(this.dgvRecentRecords);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(212, 52);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(924, 575);
            this.panelMain.TabIndex = 7;
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.lblOverview.Location = new System.Drawing.Point(24, 19);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(435, 46);
            this.lblOverview.TabIndex = 0;
            this.lblOverview.Text = "Service Officer Dashboard";
            // 
            // cardMeter
            // 
            this.cardMeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.cardMeter.Controls.Add(this.lblMeterCount);
            this.cardMeter.Controls.Add(this.lblMeterText);
            this.cardMeter.Location = new System.Drawing.Point(39, 97);
            this.cardMeter.Name = "cardMeter";
            this.cardMeter.Size = new System.Drawing.Size(186, 91);
            this.cardMeter.TabIndex = 1;
            // 
            // lblMeterCount
            // 
            this.lblMeterCount.AutoSize = true;
            this.lblMeterCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMeterCount.ForeColor = System.Drawing.Color.White;
            this.lblMeterCount.Location = new System.Drawing.Point(69, 3);
            this.lblMeterCount.Name = "lblMeterCount";
            this.lblMeterCount.Size = new System.Drawing.Size(46, 54);
            this.lblMeterCount.TabIndex = 0;
            this.lblMeterCount.Text = "0";
            // 
            // lblMeterText
            // 
            this.lblMeterText.AutoSize = true;
            this.lblMeterText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMeterText.ForeColor = System.Drawing.Color.White;
            this.lblMeterText.Location = new System.Drawing.Point(33, 60);
            this.lblMeterText.Name = "lblMeterText";
            this.lblMeterText.Size = new System.Drawing.Size(129, 23);
            this.lblMeterText.TabIndex = 1;
            this.lblMeterText.Text = "Meter Readings";
            // 
            // cardBill
            // 
            this.cardBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(151)))), ((int)(((byte)(9)))));
            this.cardBill.Controls.Add(this.lblBillCount);
            this.cardBill.Controls.Add(this.lblBillText);
            this.cardBill.Location = new System.Drawing.Point(259, 97);
            this.cardBill.Name = "cardBill";
            this.cardBill.Size = new System.Drawing.Size(186, 91);
            this.cardBill.TabIndex = 2;
            // 
            // lblBillCount
            // 
            this.lblBillCount.AutoSize = true;
            this.lblBillCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBillCount.ForeColor = System.Drawing.Color.White;
            this.lblBillCount.Location = new System.Drawing.Point(68, 3);
            this.lblBillCount.Name = "lblBillCount";
            this.lblBillCount.Size = new System.Drawing.Size(46, 54);
            this.lblBillCount.TabIndex = 0;
            this.lblBillCount.Text = "0";
            // 
            // lblBillText
            // 
            this.lblBillText.AutoSize = true;
            this.lblBillText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBillText.ForeColor = System.Drawing.Color.White;
            this.lblBillText.Location = new System.Drawing.Point(35, 60);
            this.lblBillText.Name = "lblBillText";
            this.lblBillText.Size = new System.Drawing.Size(124, 23);
            this.lblBillText.TabIndex = 1;
            this.lblBillText.Text = "Generated Bills";
            // 
            // cardDispute
            // 
            this.cardDispute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            this.cardDispute.Controls.Add(this.lblDisputeCount);
            this.cardDispute.Controls.Add(this.lblDisputeText);
            this.cardDispute.Location = new System.Drawing.Point(478, 97);
            this.cardDispute.Name = "cardDispute";
            this.cardDispute.Size = new System.Drawing.Size(186, 91);
            this.cardDispute.TabIndex = 3;
            // 
            // lblDisputeCount
            // 
            this.lblDisputeCount.AutoSize = true;
            this.lblDisputeCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDisputeCount.ForeColor = System.Drawing.Color.White;
            this.lblDisputeCount.Location = new System.Drawing.Point(68, 3);
            this.lblDisputeCount.Name = "lblDisputeCount";
            this.lblDisputeCount.Size = new System.Drawing.Size(46, 54);
            this.lblDisputeCount.TabIndex = 0;
            this.lblDisputeCount.Text = "0";
            // 
            // lblDisputeText
            // 
            this.lblDisputeText.AutoSize = true;
            this.lblDisputeText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDisputeText.ForeColor = System.Drawing.Color.White;
            this.lblDisputeText.Location = new System.Drawing.Point(21, 60);
            this.lblDisputeText.Name = "lblDisputeText";
            this.lblDisputeText.Size = new System.Drawing.Size(142, 23);
            this.lblDisputeText.TabIndex = 1;
            this.lblDisputeText.Text = "Pending Disputes";
            // 
            // cardConnection
            // 
            this.cardConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(153)))), ((int)(((byte)(93)))));
            this.cardConnection.Controls.Add(this.lblConnectionCount);
            this.cardConnection.Controls.Add(this.lblConnectionText);
            this.cardConnection.Location = new System.Drawing.Point(697, 97);
            this.cardConnection.Name = "cardConnection";
            this.cardConnection.Size = new System.Drawing.Size(186, 91);
            this.cardConnection.TabIndex = 4;
            // 
            // lblConnectionCount
            // 
            this.lblConnectionCount.AutoSize = true;
            this.lblConnectionCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblConnectionCount.ForeColor = System.Drawing.Color.White;
            this.lblConnectionCount.Location = new System.Drawing.Point(72, 3);
            this.lblConnectionCount.Name = "lblConnectionCount";
            this.lblConnectionCount.Size = new System.Drawing.Size(46, 54);
            this.lblConnectionCount.TabIndex = 0;
            this.lblConnectionCount.Text = "0";
            // 
            // lblConnectionText
            // 
            this.lblConnectionText.AutoSize = true;
            this.lblConnectionText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConnectionText.ForeColor = System.Drawing.Color.White;
            this.lblConnectionText.Location = new System.Drawing.Point(7, 60);
            this.lblConnectionText.Name = "lblConnectionText";
            this.lblConnectionText.Size = new System.Drawing.Size(171, 23);
            this.lblConnectionText.TabIndex = 1;
            this.lblConnectionText.Text = "Connection Requests";
            // 
            // lblRecentRecords
            // 
            this.lblRecentRecords.AutoSize = true;
            this.lblRecentRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentRecords.Location = new System.Drawing.Point(27, 218);
            this.lblRecentRecords.Name = "lblRecentRecords";
            this.lblRecentRecords.Size = new System.Drawing.Size(158, 28);
            this.lblRecentRecords.TabIndex = 5;
            this.lblRecentRecords.Text = "Recent Records";
            // 
            // dgvRecentRecords
            // 
            this.dgvRecentRecords.AllowUserToAddRows = false;
            this.dgvRecentRecords.AllowUserToDeleteRows = false;
            this.dgvRecentRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentRecords.ColumnHeadersHeight = 36;
            this.dgvRecentRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colType,
            this.colCustomer,
            this.colDate,
            this.colStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentRecords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentRecords.EnableHeadersVisualStyles = false;
            this.dgvRecentRecords.GridColor = System.Drawing.Color.White;
            this.dgvRecentRecords.Location = new System.Drawing.Point(31, 247);
            this.dgvRecentRecords.MultiSelect = false;
            this.dgvRecentRecords.Name = "dgvRecentRecords";
            this.dgvRecentRecords.ReadOnly = true;
            this.dgvRecentRecords.RowHeadersVisible = false;
            this.dgvRecentRecords.RowHeadersWidth = 51;
            this.dgvRecentRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentRecords.Size = new System.Drawing.Size(871, 287);
            this.dgvRecentRecords.TabIndex = 6;
            this.dgvRecentRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentRecords_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // ServiceOfficerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1136, 627);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ServiceOfficerDashboardForm";
            this.Text = "Service Officer";
            this.Load += new System.EventHandler(this.ServiceOfficerDashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.cardMeter.ResumeLayout(false);
            this.cardMeter.PerformLayout();
            this.cardBill.ResumeLayout(false);
            this.cardBill.PerformLayout();
            this.cardDispute.ResumeLayout(false);
            this.cardDispute.PerformLayout();
            this.cardConnection.ResumeLayout(false);
            this.cardConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnMeterReading;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Button btnReviewDisputes;
        private System.Windows.Forms.Button btnCorrectBill;
        private System.Windows.Forms.Button btnReviewConnections;
        private System.Windows.Forms.Button btnVerifyDocuments;
        private System.Windows.Forms.Button btnScheduleInstallation;
        private System.Windows.Forms.Button btnBillingReport;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.Panel cardMeter;
        private System.Windows.Forms.Label lblMeterCount;
        private System.Windows.Forms.Label lblMeterText;
        private System.Windows.Forms.Panel cardBill;
        private System.Windows.Forms.Label lblBillCount;
        private System.Windows.Forms.Label lblBillText;
        private System.Windows.Forms.Panel cardDispute;
        private System.Windows.Forms.Label lblDisputeCount;
        private System.Windows.Forms.Label lblDisputeText;
        private System.Windows.Forms.Panel cardConnection;
        private System.Windows.Forms.Label lblConnectionCount;
        private System.Windows.Forms.Label lblConnectionText;
        private System.Windows.Forms.Label lblRecentRecords;
        private System.Windows.Forms.DataGridView dgvRecentRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}