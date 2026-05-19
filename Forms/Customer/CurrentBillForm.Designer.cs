namespace WaterSewageManagementSystem.Forms.Customer
{
    partial class CurrentBillForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBill = new System.Windows.Forms.Panel();
            this.lblBillID = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblArrears = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDispute = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTitle.Location = new System.Drawing.Point(130, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Your Current Bill";
            // 
            // panelBill
            // 
            this.panelBill.BackColor = System.Drawing.Color.White;
            this.panelBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBill.Controls.Add(this.lblBillID);
            this.panelBill.Controls.Add(this.lblMonth);
            this.panelBill.Controls.Add(this.lblUnits);
            this.panelBill.Controls.Add(this.lblAmount);
            this.panelBill.Controls.Add(this.lblArrears);
            this.panelBill.Controls.Add(this.lblTotal);
            this.panelBill.Controls.Add(this.lblStatus);
            this.panelBill.Location = new System.Drawing.Point(30, 57);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(460, 290);
            this.panelBill.TabIndex = 5;
            this.panelBill.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBill_Paint);
            // 
            // lblBillID
            // 
            this.lblBillID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillID.Location = new System.Drawing.Point(20, 20);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(420, 28);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Click += new System.EventHandler(this.lblBillID_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMonth.Location = new System.Drawing.Point(20, 58);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(420, 28);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Click += new System.EventHandler(this.lblMonth_Click);
            // 
            // lblUnits
            // 
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUnits.Location = new System.Drawing.Point(20, 96);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(420, 28);
            this.lblUnits.TabIndex = 2;
            this.lblUnits.Click += new System.EventHandler(this.lblUnits_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAmount.Location = new System.Drawing.Point(20, 134);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(420, 28);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblArrears
            // 
            this.lblArrears.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblArrears.Location = new System.Drawing.Point(20, 172);
            this.lblArrears.Name = "lblArrears";
            this.lblArrears.Size = new System.Drawing.Size(420, 28);
            this.lblArrears.TabIndex = 4;
            this.lblArrears.Click += new System.EventHandler(this.lblArrears_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 210);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(420, 28);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatus.Location = new System.Drawing.Point(20, 248);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(420, 28);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnDispute
            // 
            this.btnDispute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnDispute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDispute.FlatAppearance.BorderSize = 0;
            this.btnDispute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDispute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDispute.ForeColor = System.Drawing.Color.White;
            this.btnDispute.Location = new System.Drawing.Point(30, 367);
            this.btnDispute.Name = "btnDispute";
            this.btnDispute.Size = new System.Drawing.Size(160, 36);
            this.btnDispute.TabIndex = 6;
            this.btnDispute.Text = "Submit Dispute";
            this.btnDispute.UseVisualStyleBackColor = false;
            this.btnDispute.Click += new System.EventHandler(this.btnDispute_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(390, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CurrentBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(520, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelBill);
            this.Controls.Add(this.btnDispute);
            this.Controls.Add(this.btnClose);
            this.Name = "CurrentBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Bill";
            this.Load += new System.EventHandler(this.CurrentBillForm_Load);
            this.panelBill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblArrears;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDispute;
        private System.Windows.Forms.Button btnClose;
    }
}