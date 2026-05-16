namespace WaterSewageManagementSystem.Forms.Admin
{
    partial class NoticeManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNewNotice = new System.Windows.Forms.Label();
            this.lblNTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.dgvNotices = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Notice Management";
            // 
            // lblNewNotice
            // 
            this.lblNewNotice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewNotice.ForeColor = System.Drawing.Color.DimGray;
            this.lblNewNotice.Location = new System.Drawing.Point(20, 50);
            this.lblNewNotice.Name = "lblNewNotice";
            this.lblNewNotice.Size = new System.Drawing.Size(200, 22);
            this.lblNewNotice.TabIndex = 1;
            this.lblNewNotice.Text = "Publish New Notice";
            // 
            // lblNTitle
            // 
            this.lblNTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNTitle.Location = new System.Drawing.Point(20, 83);
            this.lblNTitle.Name = "lblNTitle";
            this.lblNTitle.Size = new System.Drawing.Size(155, 20);
            this.lblNTitle.TabIndex = 2;
            this.lblNTitle.Text = "Title *";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(180, 80);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(400, 30);
            this.txtTitle.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDesc.Location = new System.Drawing.Point(20, 118);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(155, 20);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Description *";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(180, 115);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(400, 55);
            this.txtDescription.TabIndex = 5;
            // 
            // lblArea
            // 
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArea.Location = new System.Drawing.Point(20, 183);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(155, 20);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArea.Location = new System.Drawing.Point(180, 180);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(200, 30);
            this.txtArea.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(20, 213);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(155, 20);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbType.Items.AddRange(new object[] {
            "General",
            "Maintenance",
            "Emergency"});
            this.cmbType.Location = new System.Drawing.Point(180, 211);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(180, 31);
            this.cmbType.TabIndex = 9;
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublish.FlatAppearance.BorderSize = 0;
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPublish.ForeColor = System.Drawing.Color.White;
            this.btnPublish.Location = new System.Drawing.Point(20, 250);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(150, 36);
            this.btnPublish.TabIndex = 10;
            this.btnPublish.Text = "Publish Notice";
            this.btnPublish.UseVisualStyleBackColor = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // dgvNotices
            // 
            this.dgvNotices.AllowUserToAddRows = false;
            this.dgvNotices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotices.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotices.ColumnHeadersHeight = 29;
            this.dgvNotices.EnableHeadersVisualStyles = false;
            this.dgvNotices.Location = new System.Drawing.Point(20, 305);
            this.dgvNotices.Name = "dgvNotices";
            this.dgvNotices.ReadOnly = true;
            this.dgvNotices.RowHeadersVisible = false;
            this.dgvNotices.RowHeadersWidth = 51;
            this.dgvNotices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotices.Size = new System.Drawing.Size(910, 240);
            this.dgvNotices.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(20, 558);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(840, 558);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NoticeManagementForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNewNotice);
            this.Controls.Add(this.lblNTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.dgvNotices);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NoticeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice Management";
            this.Load += new System.EventHandler(this.NoticeManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //private void R(System.Windows.Forms.Label lbl, string text, System.Windows.Forms.TextBox txt, int lx, int tx, int w, int y, bool pw)
        //{
        //    lbl.Text = text; lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); lbl.Location = new System.Drawing.Point(lx, y+3); lbl.Size = new System.Drawing.Size(155, 20);
        //    txt.Location = new System.Drawing.Point(tx, y); txt.Size = new System.Drawing.Size(w, 26); txt.Font = new System.Drawing.Font("Segoe UI", 10F); txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //    if (pw) txt.PasswordChar = '*';
        //}
        private System.Windows.Forms.Label lblTitle, lblNewNotice, lblNTitle, lblDesc, lblArea, lblType;
        private System.Windows.Forms.TextBox txtTitle, txtDescription, txtArea;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnPublish, btnDelete, btnClose;
        private System.Windows.Forms.DataGridView dgvNotices;
    }
}
