namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class CustomerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCurrentBill = new System.Windows.Forms.Button();
            this.btnBillHistory = new System.Windows.Forms.Button();
            this.btnDispute = new System.Windows.Forms.Button();
            this.btnComplaint = new System.Windows.Forms.Button();
            this.btnTrackComplaint = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnTrackApp = new System.Windows.Forms.Button();
            this.btnNotices = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(200, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WASA Management System";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.LightCyan;
            this.lblWelcome.Location = new System.Drawing.Point(20, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 22);
            this.lblWelcome.TabIndex = 1;
            // 
            // btnCurrentBill
            // 
            this.btnCurrentBill.Location = new System.Drawing.Point(0, 0);
            this.btnCurrentBill.Name = "btnCurrentBill";
            this.btnCurrentBill.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentBill.TabIndex = 0;
            // 
            // btnBillHistory
            // 
            this.btnBillHistory.Location = new System.Drawing.Point(0, 0);
            this.btnBillHistory.Name = "btnBillHistory";
            this.btnBillHistory.Size = new System.Drawing.Size(75, 23);
            this.btnBillHistory.TabIndex = 0;
            // 
            // btnDispute
            // 
            this.btnDispute.Location = new System.Drawing.Point(0, 0);
            this.btnDispute.Name = "btnDispute";
            this.btnDispute.Size = new System.Drawing.Size(75, 23);
            this.btnDispute.TabIndex = 0;
            // 
            // btnComplaint
            // 
            this.btnComplaint.Location = new System.Drawing.Point(0, 0);
            this.btnComplaint.Name = "btnComplaint";
            this.btnComplaint.Size = new System.Drawing.Size(75, 23);
            this.btnComplaint.TabIndex = 0;
            // 
            // btnTrackComplaint
            // 
            this.btnTrackComplaint.Location = new System.Drawing.Point(0, 0);
            this.btnTrackComplaint.Name = "btnTrackComplaint";
            this.btnTrackComplaint.Size = new System.Drawing.Size(75, 23);
            this.btnTrackComplaint.TabIndex = 0;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(0, 0);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 0;
            // 
            // btnTrackApp
            // 
            this.btnTrackApp.Location = new System.Drawing.Point(0, 0);
            this.btnTrackApp.Name = "btnTrackApp";
            this.btnTrackApp.Size = new System.Drawing.Size(75, 23);
            this.btnTrackApp.TabIndex = 0;
            // 
            // btnNotices
            // 
            this.btnNotices.Location = new System.Drawing.Point(0, 0);
            this.btnNotices.Name = "btnNotices";
            this.btnNotices.Size = new System.Drawing.Size(75, 23);
            this.btnNotices.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            // 
            // CustomerDashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard - WASA Management System";
            this.Load += new System.EventHandler(this.CustomerDashboardForm_Load);

            // Current Bill
            this.btnCurrentBill.Text = "Current Bill";
            this.btnCurrentBill.Location = new System.Drawing.Point(30, 90);
            this.btnCurrentBill.Size = new System.Drawing.Size(185, 90);
            this.btnCurrentBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCurrentBill.ForeColor = System.Drawing.Color.White;
            this.btnCurrentBill.BackColor = System.Drawing.Color.FromArgb(0, 105, 92);
            this.btnCurrentBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentBill.FlatAppearance.BorderSize = 0;
            this.btnCurrentBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentBill.Click += new System.EventHandler(this.btnCurrentBill_Click);

            // Bill History
            this.btnBillHistory.Text = "Bill History";
            this.btnBillHistory.Location = new System.Drawing.Point(235, 90);
            this.btnBillHistory.Size = new System.Drawing.Size(185, 90);
            this.btnBillHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBillHistory.ForeColor = System.Drawing.Color.White;
            this.btnBillHistory.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnBillHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillHistory.FlatAppearance.BorderSize = 0;
            this.btnBillHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillHistory.Click += new System.EventHandler(this.btnBillHistory_Click);

            // Submit Dispute
            this.btnDispute.Text = "Submit Dispute";
            this.btnDispute.Location = new System.Drawing.Point(440, 90);
            this.btnDispute.Size = new System.Drawing.Size(185, 90);
            this.btnDispute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDispute.ForeColor = System.Drawing.Color.White;
            this.btnDispute.BackColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.btnDispute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispute.FlatAppearance.BorderSize = 0;
            this.btnDispute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDispute.Click += new System.EventHandler(this.btnDispute_Click);

            // Submit Complaint
            this.btnComplaint.Text = "Submit Complaint";
            this.btnComplaint.Location = new System.Drawing.Point(645, 90);
            this.btnComplaint.Size = new System.Drawing.Size(185, 90);
            this.btnComplaint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnComplaint.ForeColor = System.Drawing.Color.White;
            this.btnComplaint.BackColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.btnComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplaint.FlatAppearance.BorderSize = 0;
            this.btnComplaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplaint.Click += new System.EventHandler(this.btnComplaint_Click);

            // Track Complaint
            this.btnTrackComplaint.Text = "Track Complaint";
            this.btnTrackComplaint.Location = new System.Drawing.Point(30, 210);
            this.btnTrackComplaint.Size = new System.Drawing.Size(185, 90);
            this.btnTrackComplaint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTrackComplaint.ForeColor = System.Drawing.Color.White;
            this.btnTrackComplaint.BackColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.btnTrackComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackComplaint.FlatAppearance.BorderSize = 0;
            this.btnTrackComplaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackComplaint.Click += new System.EventHandler(this.btnTrackComplaint_Click);

            // New Connection
            this.btnConnection.Text = "New Connection";
            this.btnConnection.Location = new System.Drawing.Point(235, 210);
            this.btnConnection.Size = new System.Drawing.Size(185, 90);
            this.btnConnection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConnection.ForeColor = System.Drawing.Color.White;
            this.btnConnection.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);

            // Track Application
            this.btnTrackApp.Text = "Track Application";
            this.btnTrackApp.Location = new System.Drawing.Point(440, 210);
            this.btnTrackApp.Size = new System.Drawing.Size(185, 90);
            this.btnTrackApp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTrackApp.ForeColor = System.Drawing.Color.White;
            this.btnTrackApp.BackColor = System.Drawing.Color.FromArgb(0, 96, 100);
            this.btnTrackApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackApp.FlatAppearance.BorderSize = 0;
            this.btnTrackApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackApp.Click += new System.EventHandler(this.btnTrackApp_Click);

            // View Notices
            this.btnNotices.Text = "View Notices";
            this.btnNotices.Location = new System.Drawing.Point(645, 210);
            this.btnNotices.Size = new System.Drawing.Size(185, 90);
            this.btnNotices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNotices.ForeColor = System.Drawing.Color.White;
            this.btnNotices.BackColor = System.Drawing.Color.FromArgb(74, 20, 140);
            this.btnNotices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotices.FlatAppearance.BorderSize = 0;
            this.btnNotices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotices.Click += new System.EventHandler(this.btnNotices_Click);

            // My Profile
            this.btnProfile.Text = "My Profile";
            this.btnProfile.Location = new System.Drawing.Point(30, 330);
            this.btnProfile.Size = new System.Drawing.Size(185, 90);
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);

            // Logout
            this.btnLogout.Text = "Logout";
            this.btnLogout.Location = new System.Drawing.Point(235, 330);
            this.btnLogout.Size = new System.Drawing.Size(185, 90);
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(136, 14, 79);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Add controls to form
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnCurrentBill);
            this.Controls.Add(this.btnBillHistory);
            this.Controls.Add(this.btnDispute);
            this.Controls.Add(this.btnComplaint);
            this.Controls.Add(this.btnTrackComplaint);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.btnTrackApp);
            this.Controls.Add(this.btnNotices);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogout);

            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel  panelHeader;
        private System.Windows.Forms.Label  lblTitle, lblWelcome;
        private System.Windows.Forms.Button btnCurrentBill, btnBillHistory, btnDispute, btnComplaint;
        private System.Windows.Forms.Button btnTrackComplaint, btnConnection, btnTrackApp, btnNotices;
        private System.Windows.Forms.Button btnProfile, btnLogout;
    }
}
