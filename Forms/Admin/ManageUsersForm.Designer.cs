namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class ManageUsersForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitle      = new System.Windows.Forms.Label();
            this.dgvUsers      = new System.Windows.Forms.DataGridView();
            this.btnActivate   = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnRefresh    = new System.Windows.Forms.Button();
            this.btnClose      = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvUsers).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 550); this.Text = "Manage Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White; this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; this.MaximizeBox = false;

            this.lblTitle.Text = "Manage Users"; this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161); this.lblTitle.Location = new System.Drawing.Point(20, 15); this.lblTitle.Size = new System.Drawing.Size(200, 30);

            this.dgvUsers.Location = new System.Drawing.Point(20, 60); this.dgvUsers.Size = new System.Drawing.Size(860, 410);
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.ReadOnly = true; this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White; this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.EnableHeadersVisualStyles = false;

            //StyleBtn(this.btnActivate, "Activate", 20, 485, System.Drawing.Color.FromArgb(46,125,50)); this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            //StyleBtn(this.btnDeactivate, "Deactivate", 155, 485, System.Drawing.Color.FromArgb(183,28,28)); this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            //StyleBtn(this.btnRefresh, "Refresh", 290, 485, System.Drawing.Color.FromArgb(21,101,192)); this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //StyleBtn(this.btnClose, "Close", 760, 485, System.Drawing.Color.Gray); this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // Activate Button
            this.btnActivate.Text = "Activate";
            this.btnActivate.Location = new System.Drawing.Point(20, 485);
            this.btnActivate.Size = new System.Drawing.Size(120, 36);
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivate.FlatAppearance.BorderSize = 0;
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);

            // Deactivate Button
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.Location = new System.Drawing.Point(155, 485);
            this.btnDeactivate.Size = new System.Drawing.Size(120, 36);
            this.btnDeactivate.BackColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.btnDeactivate.ForeColor = System.Drawing.Color.White;
            this.btnDeactivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivate.FlatAppearance.BorderSize = 0;
            this.btnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);

            // Refresh Button
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(290, 485);
            this.btnRefresh.Size = new System.Drawing.Size(120, 36);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // Close Button
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(760, 485);
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.dgvUsers, this.btnActivate, this.btnDeactivate, this.btnRefresh, this.btnClose });
            ((System.ComponentModel.ISupportInitialize)this.dgvUsers).EndInit();
            this.ResumeLayout(false);
        }
        //private void StyleBtn(System.Windows.Forms.Button btn, string text, int x, int y, System.Drawing.Color color)
        //{
        //    btn.Text = text; btn.Location = new System.Drawing.Point(x, y); btn.Size = new System.Drawing.Size(120, 36);
        //    btn.BackColor = color; btn.ForeColor = System.Drawing.Color.White;
        //    btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        //    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat; btn.FlatAppearance.BorderSize = 0; btn.Cursor = System.Windows.Forms.Cursors.Hand;
        //}

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnActivate, btnDeactivate, btnRefresh, btnClose;
    }
}
