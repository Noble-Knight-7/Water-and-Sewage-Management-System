namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class InspectionNotesForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle     = new System.Windows.Forms.Label();
            this.lblInfo      = new System.Windows.Forms.Label();
            this.dgvTasks     = new System.Windows.Forms.DataGridView();
            this.lblNotes     = new System.Windows.Forms.Label();
            this.txtNotes     = new System.Windows.Forms.TextBox();
            this.btnSaveNotes = new System.Windows.Forms.Button();
            this.btnClear     = new System.Windows.Forms.Button();
            this.btnClose     = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize    = new System.Drawing.Size(950, 600);
            this.Text          = "Field Inspection Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox   = false;

            // Title
            this.lblTitle.Text      = "Field Inspection Notes";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.lblTitle.Location  = new System.Drawing.Point(20, 12);
            this.lblTitle.Size      = new System.Drawing.Size(280, 30);

            // Info
            this.lblInfo.Text      = "Click a task row to load its current notes, edit them, then click Save Notes.";
            this.lblInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfo.Location  = new System.Drawing.Point(20, 46);
            this.lblInfo.Size      = new System.Drawing.Size(650, 20);

            // DataGridView
            this.dgvTasks.Location = new System.Drawing.Point(20, 72);
            this.dgvTasks.Size     = new System.Drawing.Size(910, 290);
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.ReadOnly            = true;
            this.dgvTasks.AllowUserToAddRows  = false;
            this.dgvTasks.BackgroundColor     = System.Drawing.Color.White;
            this.dgvTasks.RowHeadersVisible   = false;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersDefaultCellStyle.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvTasks.EnableHeadersVisualStyles  = false;
            this.dgvTasks.SelectionChanged          += new System.EventHandler(this.dgvTasks_SelectionChanged);

            // Notes label
            this.lblNotes.Text      = "Inspection Notes:";
            this.lblNotes.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location  = new System.Drawing.Point(20, 376);
            this.lblNotes.Size      = new System.Drawing.Size(150, 22);

            // Notes text area
            this.txtNotes.Location    = new System.Drawing.Point(20, 400);
            this.txtNotes.Size        = new System.Drawing.Size(910, 120);
            this.txtNotes.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.Multiline   = true;
            this.txtNotes.ScrollBars  = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Save Notes button
            this.btnSaveNotes.Text      = "Save Notes";
            this.btnSaveNotes.Location  = new System.Drawing.Point(20, 535);
            this.btnSaveNotes.Size      = new System.Drawing.Size(150, 38);
            this.btnSaveNotes.BackColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.btnSaveNotes.ForeColor = System.Drawing.Color.White;
            this.btnSaveNotes.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNotes.FlatAppearance.BorderSize = 0;
            this.btnSaveNotes.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSaveNotes.Click    += new System.EventHandler(this.btnSaveNotes_Click);

            // Clear button
            this.btnClear.Text      = "Clear";
            this.btnClear.Location  = new System.Drawing.Point(180, 535);
            this.btnClear.Size      = new System.Drawing.Size(100, 38);
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(230, 81, 0);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click    += new System.EventHandler(this.btnClear_Click);

            // Close button
            this.btnClose.Text      = "Close";
            this.btnClose.Location  = new System.Drawing.Point(840, 535);
            this.btnClose.Size      = new System.Drawing.Size(90, 38);
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click    += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.lblInfo, this.dgvTasks,
                this.lblNotes, this.txtNotes,
                this.btnSaveNotes, this.btnClear, this.btnClose });

            ((System.ComponentModel.ISupportInitialize)this.dgvTasks).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label        lblTitle, lblInfo, lblNotes;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.TextBox      txtNotes;
        private System.Windows.Forms.Button       btnSaveNotes, btnClear, btnClose;
    }
}
