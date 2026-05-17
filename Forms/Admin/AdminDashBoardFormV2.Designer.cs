namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class AdminDashBoardFormV2
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
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
            this.panelHeader.TabIndex = 1;
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
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Location = new System.Drawing.Point(50, 95);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(200, 100);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnApproveEmployees
            // 
            this.btnApproveEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnApproveEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApproveEmployees.FlatAppearance.BorderSize = 0;
            this.btnApproveEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnApproveEmployees.ForeColor = System.Drawing.Color.White;
            this.btnApproveEmployees.Location = new System.Drawing.Point(285, 95);
            this.btnApproveEmployees.Name = "btnApproveEmployees";
            this.btnApproveEmployees.Size = new System.Drawing.Size(200, 100);
            this.btnApproveEmployees.TabIndex = 3;
            this.btnApproveEmployees.Text = "Approve Employees";
            this.btnApproveEmployees.UseVisualStyleBackColor = false;
            // 
            // btnAssignComplaints
            // 
            this.btnAssignComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnAssignComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignComplaints.FlatAppearance.BorderSize = 0;
            this.btnAssignComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignComplaints.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAssignComplaints.ForeColor = System.Drawing.Color.White;
            this.btnAssignComplaints.Location = new System.Drawing.Point(520, 95);
            this.btnAssignComplaints.Name = "btnAssignComplaints";
            this.btnAssignComplaints.Size = new System.Drawing.Size(200, 100);
            this.btnAssignComplaints.TabIndex = 4;
            this.btnAssignComplaints.Text = "Assign Complaints";
            this.btnAssignComplaints.UseVisualStyleBackColor = false;
            // 
            // btnNotices
            // 
            this.btnNotices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnNotices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotices.FlatAppearance.BorderSize = 0;
            this.btnNotices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNotices.ForeColor = System.Drawing.Color.White;
            this.btnNotices.Location = new System.Drawing.Point(50, 225);
            this.btnNotices.Name = "btnNotices";
            this.btnNotices.Size = new System.Drawing.Size(200, 100);
            this.btnNotices.TabIndex = 5;
            this.btnNotices.Text = "Notice Management";
            this.btnNotices.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(285, 225);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 100);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "System Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(520, 225);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 100);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(50, 355);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 100);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // AdminDashBoardFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnApproveEmployees);
            this.Controls.Add(this.btnAssignComplaints);
            this.Controls.Add(this.btnNotices);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogout);
            this.Name = "AdminDashBoardFormV2";
            this.Text = "AdminDashBoardFormV2";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnApproveEmployees;
        private System.Windows.Forms.Button btnAssignComplaints;
        private System.Windows.Forms.Button btnNotices;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
    }
}