namespace WaterSewageManagementSystem.Forms.MaintenanceEngineer
{
    partial class WaterQualityIssueForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle       = new System.Windows.Forms.Label();
            this.lblWarning     = new System.Windows.Forms.Label();
            this.panelWarning   = new System.Windows.Forms.Panel();
            this.lblIssueType   = new System.Windows.Forms.Label();
            this.cmbIssueType   = new System.Windows.Forms.ComboBox();
            this.lblArea        = new System.Windows.Forms.Label();
            this.txtArea        = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblEffect      = new System.Windows.Forms.Label();
            this.btnReport      = new System.Windows.Forms.Button();
            this.btnClose       = new System.Windows.Forms.Button();
            this.panelWarning.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.ClientSize    = new System.Drawing.Size(560, 500);
            this.Text          = "Report Water Quality Issue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor     = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox   = false;

            // Title
            this.lblTitle.Text      = "Report Water Quality Issue";
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.lblTitle.Location  = new System.Drawing.Point(80, 15);
            this.lblTitle.Size      = new System.Drawing.Size(400, 28);

            // Warning panel (red banner)
            this.panelWarning.BackColor = System.Drawing.Color.FromArgb(255, 235, 238);
            this.panelWarning.Location  = new System.Drawing.Point(20, 52);
            this.panelWarning.Size      = new System.Drawing.Size(520, 44);
            this.panelWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarning.Text      = "⚠  This action publishes an emergency notice and creates an urgent complaint.";
            this.lblWarning.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.lblWarning.Location  = new System.Drawing.Point(10, 12);
            this.lblWarning.Size      = new System.Drawing.Size(500, 22);
            this.panelWarning.Controls.Add(this.lblWarning);

            // Issue Type
            this.lblIssueType.Text     = "Issue Type *";
            this.lblIssueType.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIssueType.Location = new System.Drawing.Point(20, 115);
            this.lblIssueType.Size     = new System.Drawing.Size(160, 22);

            this.cmbIssueType.Location     = new System.Drawing.Point(190, 113);
            this.cmbIssueType.Size         = new System.Drawing.Size(350, 26);
            this.cmbIssueType.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIssueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueType.Items.AddRange(new object[] {
                "Contamination / Dirty Water",
                "Unusual Smell or Taste",
                "Discolouration (Brown/Yellow Water)",
                "Low Pressure / No Supply",
                "Sewage Backflow",
                "Chemical Contamination Suspected",
                "Other Quality Issue"
            });
            this.cmbIssueType.SelectedIndex = 0;

            // Area
            this.lblArea.Text     = "Affected Area *";
            this.lblArea.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArea.Location = new System.Drawing.Point(20, 160);
            this.lblArea.Size     = new System.Drawing.Size(160, 22);

            this.txtArea.Location    = new System.Drawing.Point(190, 158);
            this.txtArea.Size        = new System.Drawing.Size(350, 26);
            this.txtArea.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Description
            this.lblDescription.Text     = "Detailed Description *";
            this.lblDescription.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(20, 205);
            this.lblDescription.Size     = new System.Drawing.Size(180, 22);

            this.txtDescription.Location    = new System.Drawing.Point(20, 230);
            this.txtDescription.Size        = new System.Drawing.Size(520, 140);
            this.txtDescription.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Multiline   = true;
            this.txtDescription.ScrollBars  = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Effect label (explains what this form does)
            this.lblEffect.Text      = "Submitting will: publish an Emergency Notice + create an Urgent complaint for Admin.";
            this.lblEffect.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblEffect.ForeColor = System.Drawing.Color.DimGray;
            this.lblEffect.Location  = new System.Drawing.Point(20, 378);
            this.lblEffect.Size      = new System.Drawing.Size(520, 20);

            // Report button
            this.btnReport.Text      = "Report Issue";
            this.btnReport.Location  = new System.Drawing.Point(20, 415);
            this.btnReport.Size      = new System.Drawing.Size(160, 46);
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Click    += new System.EventHandler(this.btnReport_Click);

            // Close button
            this.btnClose.Text      = "Close";
            this.btnClose.Location  = new System.Drawing.Point(440, 415);
            this.btnClose.Size      = new System.Drawing.Size(100, 46);
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click    += new System.EventHandler(this.btnClose_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.panelWarning,
                this.lblIssueType, this.cmbIssueType,
                this.lblArea, this.txtArea,
                this.lblDescription, this.txtDescription,
                this.lblEffect, this.btnReport, this.btnClose });

            this.panelWarning.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label        lblTitle, lblWarning, lblIssueType, lblArea, lblDescription, lblEffect;
        private System.Windows.Forms.Panel        panelWarning;
        private System.Windows.Forms.ComboBox     cmbIssueType;
        private System.Windows.Forms.TextBox      txtArea, txtDescription;
        private System.Windows.Forms.Button       btnReport, btnClose;
    }
}
