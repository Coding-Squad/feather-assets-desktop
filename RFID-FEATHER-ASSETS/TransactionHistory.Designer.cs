namespace RFID_FEATHER_ASSETS
{
    partial class TransactionHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtAssetID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDateToPicker = new System.Windows.Forms.DateTimePicker();
            this.dtDateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLoadingInformation = new System.Windows.Forms.Label();
            this.grdViewTransactions = new System.Windows.Forms.DataGridView();
            this.ColTransId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAssetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImgUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRFIDTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTakeOutNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValidUntil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPersonImgUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRegisterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1370, 385);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.txtAssetID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtDateToPicker);
            this.groupBox1.Controls.Add(this.dtDateFromPicker);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(468, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.BackColor = System.Drawing.Color.Orange;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(377, 24);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(85, 30);
            this.btnGenerate.TabIndex = 68;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(854, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "User ID";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asset ID";
            this.label3.Visible = false;
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(913, 18);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(92, 22);
            this.txtUserID.TabIndex = 5;
            this.txtUserID.Visible = false;
            // 
            // txtAssetID
            // 
            this.txtAssetID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetID.Location = new System.Drawing.Point(758, 15);
            this.txtAssetID.Name = "txtAssetID";
            this.txtAssetID.Size = new System.Drawing.Size(92, 22);
            this.txtAssetID.TabIndex = 4;
            this.txtAssetID.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date To";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date From";
            // 
            // dtDateToPicker
            // 
            this.dtDateToPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDateToPicker.CustomFormat = "MM/dd/yyyy";
            this.dtDateToPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateToPicker.Location = new System.Drawing.Point(263, 28);
            this.dtDateToPicker.Name = "dtDateToPicker";
            this.dtDateToPicker.Size = new System.Drawing.Size(92, 22);
            this.dtDateToPicker.TabIndex = 1;
            // 
            // dtDateFromPicker
            // 
            this.dtDateFromPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDateFromPicker.CustomFormat = "MM/dd/yyyy";
            this.dtDateFromPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFromPicker.Location = new System.Drawing.Point(98, 28);
            this.dtDateFromPicker.Name = "dtDateFromPicker";
            this.dtDateFromPicker.Size = new System.Drawing.Size(92, 22);
            this.dtDateFromPicker.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLoadingInformation);
            this.groupBox2.Controls.Add(this.grdViewTransactions);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1370, 323);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Details";
            // 
            // lblLoadingInformation
            // 
            this.lblLoadingInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoadingInformation.AutoSize = true;
            this.lblLoadingInformation.BackColor = System.Drawing.SystemColors.Window;
            this.lblLoadingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingInformation.ForeColor = System.Drawing.Color.Green;
            this.lblLoadingInformation.Location = new System.Drawing.Point(380, 136);
            this.lblLoadingInformation.Name = "lblLoadingInformation";
            this.lblLoadingInformation.Size = new System.Drawing.Size(703, 51);
            this.lblLoadingInformation.TabIndex = 68;
            this.lblLoadingInformation.Text = "Getting Information. Please wait...";
            this.lblLoadingInformation.Visible = false;
            // 
            // grdViewTransactions
            // 
            this.grdViewTransactions.AllowUserToAddRows = false;
            this.grdViewTransactions.AllowUserToDeleteRows = false;
            this.grdViewTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdViewTransactions.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdViewTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdViewTransactions.ColumnHeadersHeight = 25;
            this.grdViewTransactions.ColumnHeadersVisible = false;
            this.grdViewTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTransId,
            this.ColCompanyId,
            this.ColAssetId,
            this.ColDescription,
            this.ColImgUrl,
            this.ColRFIDTag,
            this.ColTakeOutNote,
            this.ColValidUntil,
            this.ColNotes,
            this.ColPersonImgUrl,
            this.ColRegisterId,
            this.ColCreatedAt,
            this.ColUpdateId,
            this.ColUpdatedAt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdViewTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdViewTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewTransactions.Location = new System.Drawing.Point(3, 22);
            this.grdViewTransactions.Name = "grdViewTransactions";
            this.grdViewTransactions.ReadOnly = true;
            this.grdViewTransactions.Size = new System.Drawing.Size(1364, 298);
            this.grdViewTransactions.TabIndex = 1;
            // 
            // ColTransId
            // 
            this.ColTransId.HeaderText = "Trans ID";
            this.ColTransId.Name = "ColTransId";
            this.ColTransId.ReadOnly = true;
            this.ColTransId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTransId.Visible = false;
            this.ColTransId.Width = 5;
            // 
            // ColCompanyId
            // 
            this.ColCompanyId.HeaderText = "Company ID";
            this.ColCompanyId.Name = "ColCompanyId";
            this.ColCompanyId.ReadOnly = true;
            this.ColCompanyId.Visible = false;
            this.ColCompanyId.Width = 5;
            // 
            // ColAssetId
            // 
            this.ColAssetId.HeaderText = "Asset ID";
            this.ColAssetId.Name = "ColAssetId";
            this.ColAssetId.ReadOnly = true;
            this.ColAssetId.Width = 5;
            // 
            // ColDescription
            // 
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            this.ColDescription.Width = 5;
            // 
            // ColImgUrl
            // 
            this.ColImgUrl.HeaderText = "Image URL";
            this.ColImgUrl.Name = "ColImgUrl";
            this.ColImgUrl.ReadOnly = true;
            this.ColImgUrl.Visible = false;
            this.ColImgUrl.Width = 5;
            // 
            // ColRFIDTag
            // 
            this.ColRFIDTag.HeaderText = "RFID Tag";
            this.ColRFIDTag.Name = "ColRFIDTag";
            this.ColRFIDTag.ReadOnly = true;
            this.ColRFIDTag.Width = 5;
            // 
            // ColTakeOutNote
            // 
            this.ColTakeOutNote.HeaderText = "Take Out Note";
            this.ColTakeOutNote.Name = "ColTakeOutNote";
            this.ColTakeOutNote.ReadOnly = true;
            this.ColTakeOutNote.Width = 5;
            // 
            // ColValidUntil
            // 
            this.ColValidUntil.HeaderText = "Valid Until";
            this.ColValidUntil.Name = "ColValidUntil";
            this.ColValidUntil.ReadOnly = true;
            this.ColValidUntil.Width = 5;
            // 
            // ColNotes
            // 
            this.ColNotes.HeaderText = "Notes";
            this.ColNotes.Name = "ColNotes";
            this.ColNotes.ReadOnly = true;
            this.ColNotes.Width = 5;
            // 
            // ColPersonImgUrl
            // 
            this.ColPersonImgUrl.HeaderText = "Person Image URL";
            this.ColPersonImgUrl.Name = "ColPersonImgUrl";
            this.ColPersonImgUrl.ReadOnly = true;
            this.ColPersonImgUrl.Visible = false;
            this.ColPersonImgUrl.Width = 5;
            // 
            // ColRegisterId
            // 
            this.ColRegisterId.HeaderText = "Created By";
            this.ColRegisterId.Name = "ColRegisterId";
            this.ColRegisterId.ReadOnly = true;
            this.ColRegisterId.Width = 5;
            // 
            // ColCreatedAt
            // 
            this.ColCreatedAt.HeaderText = "Created At";
            this.ColCreatedAt.Name = "ColCreatedAt";
            this.ColCreatedAt.ReadOnly = true;
            this.ColCreatedAt.Width = 5;
            // 
            // ColUpdateId
            // 
            this.ColUpdateId.HeaderText = "Update By";
            this.ColUpdateId.Name = "ColUpdateId";
            this.ColUpdateId.ReadOnly = true;
            this.ColUpdateId.Width = 5;
            // 
            // ColUpdatedAt
            // 
            this.ColUpdatedAt.HeaderText = "Updated At";
            this.ColUpdatedAt.Name = "ColUpdatedAt";
            this.ColUpdatedAt.ReadOnly = true;
            this.ColUpdatedAt.Width = 5;
            // 
            // TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 385);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TransactionHistory";
            this.Text = "Transaction History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionHistory_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtAssetID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDateToPicker;
        private System.Windows.Forms.DateTimePicker dtDateFromPicker;
        private System.Windows.Forms.DataGridView grdViewTransactions;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblLoadingInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAssetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImgUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRFIDTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTakeOutNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValidUntil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPersonImgUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRegisterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUpdateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUpdatedAt;

    }
}