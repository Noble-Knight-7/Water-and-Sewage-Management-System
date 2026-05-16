namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class VisitDateForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle      = new System.Windows.Forms.Label();
            this.lblInfo       = new System.Windows.Forms.Label();
            this.dgvTasks      = new System.Windows.Forms.DataGridView();
            this.lblVisitDate  = new System.Windows.Forms.Label();
            this.dtpVisitDate  = new System.Windows.Forms.DateTimePicker();
            this.btnSetDate    = new System.Windows.Forms.Button();
            this.btnRefresh    = new System.Windows.Forms.Button();
            this.btnClose      = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize    = new System.Drawing.Size(950, 530);
            this.Text          = "Set Expected Visit Date";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox   = false;

            // Title
            this.lblTitle.Text      = "Set Expected Visit Date";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 96, 100);
            this.lblTitle.Location  = new System.Drawing.Point(20, 12);
            this.lblTitle.Size      = new System.Drawing.Size(300, 30);

            // Info label
            this.lblInfo.Text      = "Select a task from the list, then choose the date you plan to visit.";
            this.lblInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location  = new System.Drawing.Point(20, 46);
            this.lblInfo.Size      = new System.Drawing.Size(600, 20);

            // DataGridView
            this.dgvTasks.Location = new System.Drawing.Point(20, 72);
            this.dgvTasks.Size     = new System.Drawing.Size(910, 360);
            this.dgvTasks.AutoSizeColumnsMode    = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.SelectionMode          = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.ReadOnly               = true;
            this.dgvTasks.AllowUserToAddRows     = false;
            this.dgvTasks.BackgroundColor        = System.Drawing.Color.White;
            this.dgvTasks.RowHeadersVisible      = false;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 96, 100);
            this.dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvTasks.EnableHeadersVisualStyles = false;

            // Visit Date label
            this.lblVisitDate.Text      = "Visit Date:";
            this.lblVisitDate.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVisitDate.Location  = new System.Drawing.Point(20, 447);
            this.lblVisitDate.Size      = new System.Drawing.Size(110, 24);

            // DateTimePicker
            this.dtpVisitDate.Location = new System.Drawing.Point(135, 444);
            this.dtpVisitDate.Size     = new System.Drawing.Size(210, 26);
            this.dtpVisitDate.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpVisitDate.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVisitDate.Value    = System.DateTime.Today.AddDays(1);

            // Set Date button
            this.btnSetDate.Text      = "Set Visit Date";
            this.btnSetDate.Location  = new System.Drawing.Point(360, 442);
            this.btnSetDate.Size      = new System.Drawing.Size(150, 36);
            this.btnSetDate.BackColor = System.Drawing.Color.FromArgb(0, 96, 100);
            this.btnSetDate.ForeColor = System.Drawing.Color.White;
            this.btnSetDate.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDate.FlatAppearance.BorderSize = 0;
            this.btnSetDate.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSetDate.Click    += new System.EventHandler(this.btnSetDate_Click);

            // Refresh button
            this.btnRefresh.Text      = "Refresh";
            this.btnRefresh.Location  = new System.Drawing.Point(520, 442);
            this.btnRefresh.Size      = new System.Drawing.Size(100, 36);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click    += new System.EventHandler(this.btnRefresh_Click);

            // Close button
            this.btnClose.Text      = "Close";
            this.btnClose.Location  = new System.Drawing.Point(840, 442);
            this.btnClose.Size      = new System.Drawing.Size(90, 36);
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click    += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblInfo, this.dgvTasks,
                this.lblVisitDate, this.dtpVisitDate,
                this.btnSetDate, this.btnRefresh, this.btnClose });

            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label          lblTitle, lblInfo, lblVisitDate;
        private System.Windows.Forms.DataGridView   dgvTasks;
        private System.Windows.Forms.DateTimePicker dtpVisitDate;
        private System.Windows.Forms.Button         btnSetDate, btnRefresh, btnClose;
    }
}
