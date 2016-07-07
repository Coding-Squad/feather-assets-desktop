namespace RFID_FEATHER_ASSETS
{
    partial class ReportCreation
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoxChangeCamera = new System.Windows.Forms.CheckBox();
            this.comVideoDeviceBox = new System.Windows.Forms.ComboBox();
            this.lblNoCameraAvailable = new System.Windows.Forms.Label();
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.btnCapturePhoto = new System.Windows.Forms.Button();
            this.lblSubmittingInformation = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblValidIDPhoto = new System.Windows.Forms.Label();
            this.lblPersonPhoto = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtExplanationNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imgCapture1 = new System.Windows.Forms.PictureBox();
            this.imgCapture2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaveImageDir = new System.Windows.Forms.TextBox();
            this.btnBrowseImagePath = new System.Windows.Forms.Button();
            this.txtCapturedImagePath = new System.Windows.Forms.TextBox();
            this.imagePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBoxChangeCamera);
            this.groupBox2.Controls.Add(this.comVideoDeviceBox);
            this.groupBox2.Controls.Add(this.lblNoCameraAvailable);
            this.groupBox2.Controls.Add(this.cameraBox);
            this.groupBox2.Controls.Add(this.btnCapturePhoto);
            this.groupBox2.Controls.Add(this.lblSubmittingInformation);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.lblValidIDPhoto);
            this.groupBox2.Controls.Add(this.lblPersonPhoto);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.txtExplanationNotes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.imgCapture1);
            this.groupBox2.Controls.Add(this.imgCapture2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSaveImageDir);
            this.groupBox2.Controls.Add(this.btnBrowseImagePath);
            this.groupBox2.Controls.Add(this.txtCapturedImagePath);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 443);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person Take Out Information";
            // 
            // chkBoxChangeCamera
            // 
            this.chkBoxChangeCamera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBoxChangeCamera.AutoSize = true;
            this.chkBoxChangeCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxChangeCamera.Location = new System.Drawing.Point(244, 24);
            this.chkBoxChangeCamera.Name = "chkBoxChangeCamera";
            this.chkBoxChangeCamera.Size = new System.Drawing.Size(125, 20);
            this.chkBoxChangeCamera.TabIndex = 77;
            this.chkBoxChangeCamera.Text = "Change Camera";
            this.chkBoxChangeCamera.UseVisualStyleBackColor = true;
            this.chkBoxChangeCamera.CheckedChanged += new System.EventHandler(this.chkBoxChangeCamera_CheckedChanged);
            // 
            // comVideoDeviceBox
            // 
            this.comVideoDeviceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comVideoDeviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comVideoDeviceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comVideoDeviceBox.FormattingEnabled = true;
            this.comVideoDeviceBox.Location = new System.Drawing.Point(14, 24);
            this.comVideoDeviceBox.Name = "comVideoDeviceBox";
            this.comVideoDeviceBox.Size = new System.Drawing.Size(227, 21);
            this.comVideoDeviceBox.TabIndex = 76;
            this.comVideoDeviceBox.Visible = false;
            this.comVideoDeviceBox.DropDown += new System.EventHandler(this.comVideoDeviceBox_DropDown);
            this.comVideoDeviceBox.SelectedIndexChanged += new System.EventHandler(this.comVideoDeviceBox_SelectedIndexChanged);
            // 
            // lblNoCameraAvailable
            // 
            this.lblNoCameraAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoCameraAvailable.AutoSize = true;
            this.lblNoCameraAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCameraAvailable.Location = new System.Drawing.Point(4, 182);
            this.lblNoCameraAvailable.Name = "lblNoCameraAvailable";
            this.lblNoCameraAvailable.Size = new System.Drawing.Size(374, 29);
            this.lblNoCameraAvailable.TabIndex = 64;
            this.lblNoCameraAvailable.Text = "There is no camera connected.";
            this.lblNoCameraAvailable.Visible = false;
            // 
            // cameraBox
            // 
            this.cameraBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cameraBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cameraBox.Location = new System.Drawing.Point(14, 45);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(350, 350);
            this.cameraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraBox.TabIndex = 60;
            this.cameraBox.TabStop = false;
            // 
            // btnCapturePhoto
            // 
            this.btnCapturePhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapturePhoto.BackColor = System.Drawing.Color.Orange;
            this.btnCapturePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapturePhoto.Location = new System.Drawing.Point(14, 395);
            this.btnCapturePhoto.Name = "btnCapturePhoto";
            this.btnCapturePhoto.Size = new System.Drawing.Size(352, 39);
            this.btnCapturePhoto.TabIndex = 59;
            this.btnCapturePhoto.Text = "Capture Person Photo";
            this.btnCapturePhoto.UseVisualStyleBackColor = false;
            this.btnCapturePhoto.Click += new System.EventHandler(this.btnCapturePhoto_Click);
            // 
            // lblSubmittingInformation
            // 
            this.lblSubmittingInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubmittingInformation.AutoSize = true;
            this.lblSubmittingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittingInformation.ForeColor = System.Drawing.Color.Green;
            this.lblSubmittingInformation.Location = new System.Drawing.Point(433, 373);
            this.lblSubmittingInformation.Name = "lblSubmittingInformation";
            this.lblSubmittingInformation.Size = new System.Drawing.Size(308, 20);
            this.lblSubmittingInformation.TabIndex = 75;
            this.lblSubmittingInformation.Text = "Submitting Information. Please wait...";
            this.lblSubmittingInformation.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(594, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 39);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblValidIDPhoto
            // 
            this.lblValidIDPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidIDPhoto.AutoSize = true;
            this.lblValidIDPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidIDPhoto.Location = new System.Drawing.Point(630, 78);
            this.lblValidIDPhoto.Name = "lblValidIDPhoto";
            this.lblValidIDPhoto.Size = new System.Drawing.Size(101, 18);
            this.lblValidIDPhoto.TabIndex = 71;
            this.lblValidIDPhoto.Text = "Valid ID Photo";
            this.lblValidIDPhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPersonPhoto
            // 
            this.lblPersonPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonPhoto.AutoSize = true;
            this.lblPersonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonPhoto.Location = new System.Drawing.Point(445, 78);
            this.lblPersonPhoto.Name = "lblPersonPhoto";
            this.lblPersonPhoto.Size = new System.Drawing.Size(100, 18);
            this.lblPersonPhoto.TabIndex = 70;
            this.lblPersonPhoto.Text = "Person Photo";
            this.lblPersonPhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(403, 396);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 39);
            this.btnSubmit.TabIndex = 69;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtExplanationNotes
            // 
            this.txtExplanationNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExplanationNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExplanationNotes.Location = new System.Drawing.Point(403, 249);
            this.txtExplanationNotes.MaxLength = 100;
            this.txtExplanationNotes.Multiline = true;
            this.txtExplanationNotes.Name = "txtExplanationNotes";
            this.txtExplanationNotes.Size = new System.Drawing.Size(371, 119);
            this.txtExplanationNotes.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Explanation Notes";
            // 
            // imgCapture1
            // 
            this.imgCapture1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgCapture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture1.Location = new System.Drawing.Point(403, 24);
            this.imgCapture1.Name = "imgCapture1";
            this.imgCapture1.Size = new System.Drawing.Size(185, 185);
            this.imgCapture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture1.TabIndex = 65;
            this.imgCapture1.TabStop = false;
            // 
            // imgCapture2
            // 
            this.imgCapture2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture2.Location = new System.Drawing.Point(589, 24);
            this.imgCapture2.Name = "imgCapture2";
            this.imgCapture2.Size = new System.Drawing.Size(185, 185);
            this.imgCapture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture2.TabIndex = 66;
            this.imgCapture2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(15, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Image Directory:";
            this.label8.Visible = false;
            // 
            // txtSaveImageDir
            // 
            this.txtSaveImageDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSaveImageDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSaveImageDir.Enabled = false;
            this.txtSaveImageDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaveImageDir.Location = new System.Drawing.Point(121, 375);
            this.txtSaveImageDir.MaxLength = 45;
            this.txtSaveImageDir.Name = "txtSaveImageDir";
            this.txtSaveImageDir.Size = new System.Drawing.Size(202, 21);
            this.txtSaveImageDir.TabIndex = 63;
            this.txtSaveImageDir.Visible = false;
            // 
            // btnBrowseImagePath
            // 
            this.btnBrowseImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseImagePath.BackColor = System.Drawing.Color.Wheat;
            this.btnBrowseImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImagePath.Location = new System.Drawing.Point(325, 373);
            this.btnBrowseImagePath.Name = "btnBrowseImagePath";
            this.btnBrowseImagePath.Size = new System.Drawing.Size(39, 23);
            this.btnBrowseImagePath.TabIndex = 62;
            this.btnBrowseImagePath.Text = "...";
            this.btnBrowseImagePath.UseVisualStyleBackColor = false;
            this.btnBrowseImagePath.Visible = false;
            this.btnBrowseImagePath.Click += new System.EventHandler(this.btnBrowseImagePath_Click);
            // 
            // txtCapturedImagePath
            // 
            this.txtCapturedImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapturedImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapturedImagePath.Location = new System.Drawing.Point(14, 378);
            this.txtCapturedImagePath.MaxLength = 45;
            this.txtCapturedImagePath.Name = "txtCapturedImagePath";
            this.txtCapturedImagePath.Size = new System.Drawing.Size(61, 21);
            this.txtCapturedImagePath.TabIndex = 74;
            this.txtCapturedImagePath.Visible = false;
            // 
            // ReportCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 474);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "ReportCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Creation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportCreation_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblValidIDPhoto;
        private System.Windows.Forms.Label lblPersonPhoto;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox imgCapture2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNoCameraAvailable;
        private System.Windows.Forms.TextBox txtSaveImageDir;
        private System.Windows.Forms.Button btnBrowseImagePath;
        private System.Windows.Forms.Button btnCapturePhoto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCapturedImagePath;
        private System.Windows.Forms.Label lblSubmittingInformation;
        private System.Windows.Forms.FolderBrowserDialog imagePathDialog;
        private System.Windows.Forms.PictureBox cameraBox;
        private System.Windows.Forms.PictureBox imgCapture1;
        protected System.Windows.Forms.TextBox txtExplanationNotes;
        private System.Windows.Forms.CheckBox chkBoxChangeCamera;
        private System.Windows.Forms.ComboBox comVideoDeviceBox;


    }
}