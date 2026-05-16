namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class MaintenanceDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAssignedComplaints = new System.Windows.Forms.Button();
            this.btnMaintenanceTasks = new System.Windows.Forms.Button();
            this.btnRepairProgress = new System.Windows.Forms.Button();
            this.btnVisitDate = new System.Windows.Forms.Button();
            this.btnInspectionNotes = new System.Windows.Forms.Button();
            this.btnCompletionReport = new System.Windows.Forms.Button();
            this.btnWaterQuality = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 70);
            this.panelHeader.TabIndex = 9;
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
            this.lblWelcome.ForeColor = System.Drawing.Color.LightGreen;
            this.lblWelcome.Location = new System.Drawing.Point(20, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(420, 22);
            this.lblWelcome.TabIndex = 1;
            // 
            // btnAssignedComplaints
            // 
            this.btnAssignedComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAssignedComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignedComplaints.FlatAppearance.BorderSize = 0;
            this.btnAssignedComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignedComplaints.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssignedComplaints.ForeColor = System.Drawing.Color.White;
            this.btnAssignedComplaints.Location = new System.Drawing.Point(50, 90);
            this.btnAssignedComplaints.Name = "btnAssignedComplaints";
            this.btnAssignedComplaints.Size = new System.Drawing.Size(235, 100);
            this.btnAssignedComplaints.TabIndex = 0;
            this.btnAssignedComplaints.Text = "Assigned Complaints";
            this.btnAssignedComplaints.UseVisualStyleBackColor = false;
            this.btnAssignedComplaints.Click += new System.EventHandler(this.btnAssignedComplaints_Click);
            // 
            // btnMaintenanceTasks
            // 
            this.btnMaintenanceTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnMaintenanceTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenanceTasks.FlatAppearance.BorderSize = 0;
            this.btnMaintenanceTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintenanceTasks.ForeColor = System.Drawing.Color.White;
            this.btnMaintenanceTasks.Location = new System.Drawing.Point(315, 90);
            this.btnMaintenanceTasks.Name = "btnMaintenanceTasks";
            this.btnMaintenanceTasks.Size = new System.Drawing.Size(235, 100);
            this.btnMaintenanceTasks.TabIndex = 1;
            this.btnMaintenanceTasks.Text = "Maintenance Tasks";
            this.btnMaintenanceTasks.UseVisualStyleBackColor = false;
            this.btnMaintenanceTasks.Click += new System.EventHandler(this.btnMaintenanceTasks_Click);
            // 
            // btnRepairProgress
            // 
            this.btnRepairProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnRepairProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepairProgress.FlatAppearance.BorderSize = 0;
            this.btnRepairProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepairProgress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRepairProgress.ForeColor = System.Drawing.Color.White;
            this.btnRepairProgress.Location = new System.Drawing.Point(580, 90);
            this.btnRepairProgress.Name = "btnRepairProgress";
            this.btnRepairProgress.Size = new System.Drawing.Size(235, 100);
            this.btnRepairProgress.TabIndex = 2;
            this.btnRepairProgress.Text = "Update Repair Progress";
            this.btnRepairProgress.UseVisualStyleBackColor = false;
            this.btnRepairProgress.Click += new System.EventHandler(this.btnRepairProgress_Click);
            // 
            // btnVisitDate
            // 
            this.btnVisitDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnVisitDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitDate.FlatAppearance.BorderSize = 0;
            this.btnVisitDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVisitDate.ForeColor = System.Drawing.Color.White;
            this.btnVisitDate.Location = new System.Drawing.Point(50, 220);
            this.btnVisitDate.Name = "btnVisitDate";
            this.btnVisitDate.Size = new System.Drawing.Size(235, 100);
            this.btnVisitDate.TabIndex = 3;
            this.btnVisitDate.Text = "Set Visit Date";
            this.btnVisitDate.UseVisualStyleBackColor = false;
            this.btnVisitDate.Click += new System.EventHandler(this.btnVisitDate_Click);
            // 
            // btnInspectionNotes
            // 
            this.btnInspectionNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnInspectionNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInspectionNotes.FlatAppearance.BorderSize = 0;
            this.btnInspectionNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspectionNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInspectionNotes.ForeColor = System.Drawing.Color.White;
            this.btnInspectionNotes.Location = new System.Drawing.Point(315, 220);
            this.btnInspectionNotes.Name = "btnInspectionNotes";
            this.btnInspectionNotes.Size = new System.Drawing.Size(235, 100);
            this.btnInspectionNotes.TabIndex = 4;
            this.btnInspectionNotes.Text = "Inspection Notes";
            this.btnInspectionNotes.UseVisualStyleBackColor = false;
            this.btnInspectionNotes.Click += new System.EventHandler(this.btnInspectionNotes_Click);
            // 
            // btnCompletionReport
            // 
            this.btnCompletionReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnCompletionReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompletionReport.FlatAppearance.BorderSize = 0;
            this.btnCompletionReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompletionReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCompletionReport.ForeColor = System.Drawing.Color.White;
            this.btnCompletionReport.Location = new System.Drawing.Point(580, 220);
            this.btnCompletionReport.Name = "btnCompletionReport";
            this.btnCompletionReport.Size = new System.Drawing.Size(235, 100);
            this.btnCompletionReport.TabIndex = 5;
            this.btnCompletionReport.Text = "Completion Report";
            this.btnCompletionReport.UseVisualStyleBackColor = false;
            this.btnCompletionReport.Click += new System.EventHandler(this.btnCompletionReport_Click);
            // 
            // btnWaterQuality
            // 
            this.btnWaterQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnWaterQuality.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaterQuality.FlatAppearance.BorderSize = 0;
            this.btnWaterQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaterQuality.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnWaterQuality.ForeColor = System.Drawing.Color.White;
            this.btnWaterQuality.Location = new System.Drawing.Point(50, 350);
            this.btnWaterQuality.Name = "btnWaterQuality";
            this.btnWaterQuality.Size = new System.Drawing.Size(235, 100);
            this.btnWaterQuality.TabIndex = 6;
            this.btnWaterQuality.Text = "Water Quality Issue";
            this.btnWaterQuality.UseVisualStyleBackColor = false;
            this.btnWaterQuality.Click += new System.EventHandler(this.btnWaterQuality_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(315, 350);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(235, 100);
            this.btnProfile.TabIndex = 7;
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
            this.btnLogout.Location = new System.Drawing.Point(580, 350);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(235, 100);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MaintenanceDashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.btnAssignedComplaints);
            this.Controls.Add(this.btnMaintenanceTasks);
            this.Controls.Add(this.btnRepairProgress);
            this.Controls.Add(this.btnVisitDate);
            this.Controls.Add(this.btnInspectionNotes);
            this.Controls.Add(this.btnCompletionReport);
            this.Controls.Add(this.btnWaterQuality);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MaintenanceDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance Engineer Dashboard - WASA Management System";
            this.Load += new System.EventHandler(this.MaintenanceDashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel  panelHeader;
        private System.Windows.Forms.Label  lblTitle, lblWelcome;
        private System.Windows.Forms.Button btnAssignedComplaints, btnMaintenanceTasks, btnRepairProgress;
        private System.Windows.Forms.Button btnVisitDate, btnInspectionNotes, btnCompletionReport;
        private System.Windows.Forms.Button btnWaterQuality, btnProfile, btnLogout;
    }
}
