namespace WaterSewageManagementSystem.Forms.ServiceOfficer
{
    partial class BillingReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.btnLogReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.lblTitle.Location = new System.Drawing.Point(363, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 40);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "📄 Billing Reports";
            // 
            // dgvBills
            // 
            this.dgvBills.AllowUserToAddRows = false;
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBills.ColumnHeadersHeight = 29;
            this.dgvBills.EnableHeadersVisualStyles = false;
            this.dgvBills.Location = new System.Drawing.Point(18, 52);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.ReadOnly = true;
            this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.Size = new System.Drawing.Size(910, 415);
            this.dgvBills.TabIndex = 5;
            // 
            // btnLogReport
            // 
            this.btnLogReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(20)))), ((int)(((byte)(140)))));
            this.btnLogReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogReport.FlatAppearance.BorderSize = 0;
            this.btnLogReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogReport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogReport.ForeColor = System.Drawing.Color.White;
            this.btnLogReport.Location = new System.Drawing.Point(18, 477);
            this.btnLogReport.Name = "btnLogReport";
            this.btnLogReport.Size = new System.Drawing.Size(140, 35);
            this.btnLogReport.TabIndex = 6;
            this.btnLogReport.Text = "Log Report";
            this.btnLogReport.UseVisualStyleBackColor = false;
            this.btnLogReport.Click += new System.EventHandler(this.btnLogReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(838, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BillingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(950, 520);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.btnLogReport);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BillingReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.Button btnLogReport;
        private System.Windows.Forms.Button btnClose;
    }
}