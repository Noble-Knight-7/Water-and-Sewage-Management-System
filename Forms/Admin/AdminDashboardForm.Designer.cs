namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            //this.panelMenu = new System.Windows.Forms.Panel();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnApproveEmployees = new System.Windows.Forms.Button();
            this.btnAssignComplaints = new System.Windows.Forms.Button();
            this.btnNotices = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
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
            this.lblWelcome.ForeColor = System.Drawing.Color.LightBlue;
            this.lblWelcome.Location = new System.Drawing.Point(20, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 22);
            this.lblWelcome.TabIndex = 1;
            // 
            // panelMenu
            // 
            //this.panelMenu.Location = new System.Drawing.Point(0, 0);
            //this.panelMenu.Name = "panelMenu";
            //this.panelMenu.Size = new System.Drawing.Size(200, 100);
            //this.panelMenu.TabIndex = 0;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(0, 0);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(75, 23);
            this.btnManageUsers.TabIndex = 0;
            // 
            // btnApproveEmployees
            // 
            this.btnApproveEmployees.Location = new System.Drawing.Point(0, 0);
            this.btnApproveEmployees.Name = "btnApproveEmployees";
            this.btnApproveEmployees.Size = new System.Drawing.Size(75, 23);
            this.btnApproveEmployees.TabIndex = 0;
            // 
            // btnAssignComplaints
            // 
            this.btnAssignComplaints.Location = new System.Drawing.Point(0, 0);
            this.btnAssignComplaints.Name = "btnAssignComplaints";
            this.btnAssignComplaints.Size = new System.Drawing.Size(75, 23);
            this.btnAssignComplaints.TabIndex = 0;
            // 
            // btnNotices
            // 
            this.btnNotices.Location = new System.Drawing.Point(0, 0);
            this.btnNotices.Name = "btnNotices";
            this.btnNotices.Size = new System.Drawing.Size(75, 23);
            this.btnNotices.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(0, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 23);
            this.btnReports.TabIndex = 0;
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

            // Manage Users
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.Location = new System.Drawing.Point(50, 100);
            this.btnManageUsers.Size = new System.Drawing.Size(200, 100);
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);

            // Approve Employees
            this.btnApproveEmployees.Text = "Approve Employees";
            this.btnApproveEmployees.Location = new System.Drawing.Point(285, 100);
            this.btnApproveEmployees.Size = new System.Drawing.Size(200, 100);
            this.btnApproveEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnApproveEmployees.ForeColor = System.Drawing.Color.White;
            this.btnApproveEmployees.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnApproveEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveEmployees.FlatAppearance.BorderSize = 0;
            this.btnApproveEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApproveEmployees.Click += new System.EventHandler(this.btnApproveEmployees_Click);

            // Assign Complaints
            this.btnAssignComplaints.Text = "Assign Complaints";
            this.btnAssignComplaints.Location = new System.Drawing.Point(520, 100);
            this.btnAssignComplaints.Size = new System.Drawing.Size(200, 100);
            this.btnAssignComplaints.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAssignComplaints.ForeColor = System.Drawing.Color.White;
            this.btnAssignComplaints.BackColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.btnAssignComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignComplaints.FlatAppearance.BorderSize = 0;
            this.btnAssignComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignComplaints.Click += new System.EventHandler(this.btnAssignComplaints_Click);

            // Notice Management
            this.btnNotices.Text = "Notice Management";
            this.btnNotices.Location = new System.Drawing.Point(50, 230);
            this.btnNotices.Size = new System.Drawing.Size(200, 100);
            this.btnNotices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNotices.ForeColor = System.Drawing.Color.White;
            this.btnNotices.BackColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.btnNotices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotices.FlatAppearance.BorderSize = 0;
            this.btnNotices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotices.Click += new System.EventHandler(this.btnNotices_Click);

            // System Reports
            this.btnReports.Text = "System Reports";
            this.btnReports.Location = new System.Drawing.Point(285, 230);
            this.btnReports.Size = new System.Drawing.Size(200, 100);
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(0, 96, 100);
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // My Profile
            this.btnProfile.Text = "My Profile";
            this.btnProfile.Location = new System.Drawing.Point(520, 230);
            this.btnProfile.Size = new System.Drawing.Size(200, 100);
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);

            // Logout
            this.btnLogout.Text = "Logout";
            this.btnLogout.Location = new System.Drawing.Point(50, 360);
            this.btnLogout.Size = new System.Drawing.Size(200, 100);
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // AdminDashboardForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 550);

            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnApproveEmployees);
            this.Controls.Add(this.btnAssignComplaints);
            this.Controls.Add(this.btnNotices);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelHeader);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - WASA Management System";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label  lblTitle, lblWelcome;
        private System.Windows.Forms.Button btnManageUsers, btnApproveEmployees, btnAssignComplaints;
        private System.Windows.Forms.Button btnNotices, btnReports, btnProfile, btnLogout;
    }
}
