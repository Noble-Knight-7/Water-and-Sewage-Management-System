namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class CompletionReportForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle   = new System.Windows.Forms.Label();
            this.lblInfo    = new System.Windows.Forms.Label();
            this.dgvTasks   = new System.Windows.Forms.DataGridView();
            this.lblReport  = new System.Windows.Forms.Label();
            this.txtReport  = new System.Windows.Forms.TextBox();
            this.btnSubmit  = new System.Windows.Forms.Button();
            this.btnClose   = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize    = new System.Drawing.Size(950, 620);
            this.Text          = "Submit Completion Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox   = false;

            // Title
            this.lblTitle.Text      = "Maintenance Completion Report";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblTitle.Location  = new System.Drawing.Point(20, 12);
            this.lblTitle.Size      = new System.Drawing.Size(380, 30);

            // Info
            this.lblInfo.Text      = "Select a task, write your completion report, then click Submit. This will mark the task as Completed.";
            this.lblInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location  = new System.Drawing.Point(20, 46);
            this.lblInfo.Size      = new System.Drawing.Size(800, 20);

            // DataGridView
            this.dgvTasks.Location = new System.Drawing.Point(20, 72);
            this.dgvTasks.Size     = new System.Drawing.Size(910, 300);
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.ReadOnly            = true;
            this.dgvTasks.AllowUserToAddRows  = false;
            this.dgvTasks.BackgroundColor     = System.Drawing.Color.White;
            this.dgvTasks.RowHeadersVisible   = false;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvTasks.EnableHeadersVisualStyles  = false;
            this.dgvTasks.SelectionChanged          += new System.EventHandler(this.dgvTasks_SelectionChanged);

            // Report label
            this.lblReport.Text      = "Completion Report:";
            this.lblReport.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReport.Location  = new System.Drawing.Point(20, 385);
            this.lblReport.Size      = new System.Drawing.Size(160, 22);

            // Report text area
            this.txtReport.Location    = new System.Drawing.Point(20, 410);
            this.txtReport.Size        = new System.Drawing.Size(910, 145);
            this.txtReport.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReport.Multiline   = true;
            this.txtReport.ScrollBars  = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Submit button
            this.btnSubmit.Text      = "Submit Completion Report";
            this.btnSubmit.Location  = new System.Drawing.Point(20, 568);
            this.btnSubmit.Size      = new System.Drawing.Size(220, 40);
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Click    += new System.EventHandler(this.btnSubmit_Click);

            // Close button
            this.btnClose.Text      = "Close";
            this.btnClose.Location  = new System.Drawing.Point(840, 568);
            this.btnClose.Size      = new System.Drawing.Size(90, 40);
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click    += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblInfo, this.dgvTasks,
                this.lblReport, this.txtReport,
                this.btnSubmit, this.btnClose });

            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label        lblTitle, lblInfo, lblReport;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.TextBox      txtReport;
        private System.Windows.Forms.Button       btnSubmit, btnClose;
    }
}
