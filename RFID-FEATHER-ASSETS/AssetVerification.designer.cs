namespace RFID_FEATHER_ASSETS
{
    partial class Verification
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
            this.components = new System.ComponentModel.Container();
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.VerifyTimer = new System.Windows.Forms.Timer(this.components);
            this.BackgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.CurrentDateTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLoadingInformation = new System.Windows.Forms.Label();
            this.lblSubmittingInformation = new System.Windows.Forms.Label();
            this.lblAssetPhoto3 = new System.Windows.Forms.Label();
            this.lblAssetPhoto2 = new System.Windows.Forms.Label();
            this.lblAssetPhoto1 = new System.Windows.Forms.Label();
            this.lblValidIDPhoto = new System.Windows.Forms.Label();
            this.lblOwnerPhoto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imgCapture5 = new System.Windows.Forms.PictureBox();
            this.imgCapture4 = new System.Windows.Forms.PictureBox();
            this.imgCapture3 = new System.Windows.Forms.PictureBox();
            this.imgCapture2 = new System.Windows.Forms.PictureBox();
            this.imgCapture1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValidUntil = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTakeOutNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRFIDTag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpBoxReportedInfo = new System.Windows.Forms.GroupBox();
            this.txtReportedNote = new System.Windows.Forms.TextBox();
            this.picPersonBroughtOut = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOwnerDescription = new System.Windows.Forms.TextBox();
            this.btnVerifyAsset = new System.Windows.Forms.Button();
            this.txtOwnerPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picOwner = new System.Windows.Forms.PictureBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpBoxReportedInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonBroughtOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDateTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(834, 723);
            this.lblCurrentDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentDateTime.Size = new System.Drawing.Size(150, 26);
            this.lblCurrentDateTime.TabIndex = 42;
            // 
            // VerifyTimer
            // 
            this.VerifyTimer.Tick += new System.EventHandler(this.VerifyTimer_Tick);
            // 
            // BackgroundTimer
            // 
            this.BackgroundTimer.Tick += new System.EventHandler(this.BackgroundTimer_Tick);
            // 
            // CurrentDateTimer
            // 
            this.CurrentDateTimer.Tick += new System.EventHandler(this.CurrentTimer_Tick);
            // 
            // ClearTimer
            // 
            this.ClearTimer.Tick += new System.EventHandler(this.ClearTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLoadingInformation);
            this.groupBox1.Controls.Add(this.lblSubmittingInformation);
            this.groupBox1.Controls.Add(this.lblAssetPhoto3);
            this.groupBox1.Controls.Add(this.lblAssetPhoto2);
            this.groupBox1.Controls.Add(this.lblAssetPhoto1);
            this.groupBox1.Controls.Add(this.lblValidIDPhoto);
            this.groupBox1.Controls.Add(this.lblOwnerPhoto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblLoginUserName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.imgCapture5);
            this.groupBox1.Controls.Add(this.imgCapture4);
            this.groupBox1.Controls.Add(this.imgCapture3);
            this.groupBox1.Controls.Add(this.imgCapture2);
            this.groupBox1.Controls.Add(this.imgCapture1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grpBoxReportedInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 750);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // lblLoadingInformation
            // 
            this.lblLoadingInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoadingInformation.AutoSize = true;
            this.lblLoadingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingInformation.ForeColor = System.Drawing.Color.Green;
            this.lblLoadingInformation.Location = new System.Drawing.Point(36, 207);
            this.lblLoadingInformation.Name = "lblLoadingInformation";
            this.lblLoadingInformation.Size = new System.Drawing.Size(608, 42);
            this.lblLoadingInformation.TabIndex = 46;
            this.lblLoadingInformation.Text = "Getting Information. Please wait...";
            this.lblLoadingInformation.Visible = false;
            // 
            // lblSubmittingInformation
            // 
            this.lblSubmittingInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubmittingInformation.AutoSize = true;
            this.lblSubmittingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittingInformation.ForeColor = System.Drawing.Color.Green;
            this.lblSubmittingInformation.Location = new System.Drawing.Point(671, 267);
            this.lblSubmittingInformation.Name = "lblSubmittingInformation";
            this.lblSubmittingInformation.Size = new System.Drawing.Size(288, 18);
            this.lblSubmittingInformation.TabIndex = 76;
            this.lblSubmittingInformation.Text = "Submitting Information. Please wait...";
            this.lblSubmittingInformation.Visible = false;
            // 
            // lblAssetPhoto3
            // 
            this.lblAssetPhoto3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssetPhoto3.AutoSize = true;
            this.lblAssetPhoto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetPhoto3.Location = new System.Drawing.Point(749, 524);
            this.lblAssetPhoto3.Name = "lblAssetPhoto3";
            this.lblAssetPhoto3.Size = new System.Drawing.Size(125, 24);
            this.lblAssetPhoto3.TabIndex = 75;
            this.lblAssetPhoto3.Text = "Asset Photo 3";
            this.lblAssetPhoto3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAssetPhoto2
            // 
            this.lblAssetPhoto2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssetPhoto2.AutoSize = true;
            this.lblAssetPhoto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetPhoto2.Location = new System.Drawing.Point(426, 524);
            this.lblAssetPhoto2.Name = "lblAssetPhoto2";
            this.lblAssetPhoto2.Size = new System.Drawing.Size(125, 24);
            this.lblAssetPhoto2.TabIndex = 74;
            this.lblAssetPhoto2.Text = "Asset Photo 2";
            this.lblAssetPhoto2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAssetPhoto1
            // 
            this.lblAssetPhoto1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssetPhoto1.AutoSize = true;
            this.lblAssetPhoto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetPhoto1.Location = new System.Drawing.Point(120, 524);
            this.lblAssetPhoto1.Name = "lblAssetPhoto1";
            this.lblAssetPhoto1.Size = new System.Drawing.Size(125, 24);
            this.lblAssetPhoto1.TabIndex = 73;
            this.lblAssetPhoto1.Text = "Asset Photo 1";
            this.lblAssetPhoto1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValidIDPhoto
            // 
            this.lblValidIDPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidIDPhoto.AutoSize = true;
            this.lblValidIDPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidIDPhoto.Location = new System.Drawing.Point(426, 153);
            this.lblValidIDPhoto.Name = "lblValidIDPhoto";
            this.lblValidIDPhoto.Size = new System.Drawing.Size(128, 24);
            this.lblValidIDPhoto.TabIndex = 72;
            this.lblValidIDPhoto.Text = "Valid ID Photo";
            this.lblValidIDPhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOwnerPhoto
            // 
            this.lblOwnerPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOwnerPhoto.AutoSize = true;
            this.lblOwnerPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerPhoto.Location = new System.Drawing.Point(120, 153);
            this.lblOwnerPhoto.Name = "lblOwnerPhoto";
            this.lblOwnerPhoto.Size = new System.Drawing.Size(121, 24);
            this.lblOwnerPhoto.TabIndex = 71;
            this.lblOwnerPhoto.Text = "Owner Photo";
            this.lblOwnerPhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(29, 720);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(934, 10);
            this.label3.TabIndex = 70;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(669, 331);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(292, 35);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.BackColor = System.Drawing.Color.Orange;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(816, 290);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(145, 35);
            this.btnReport.TabIndex = 67;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(669, 290);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 35);
            this.btnSubmit.TabIndex = 66;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoginUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblLoginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUserName.Location = new System.Drawing.Point(5, 736);
            this.lblLoginUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(140, 14);
            this.lblLoginUserName.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 24);
            this.label14.TabIndex = 56;
            this.label14.Text = "Owner Pictures";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 24);
            this.label15.TabIndex = 57;
            this.label15.Text = "Asset Pictures";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(29, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(622, 10);
            this.label6.TabIndex = 46;
            // 
            // imgCapture5
            // 
            this.imgCapture5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture5.Location = new System.Drawing.Point(651, 410);
            this.imgCapture5.Name = "imgCapture5";
            this.imgCapture5.Size = new System.Drawing.Size(310, 310);
            this.imgCapture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture5.TabIndex = 44;
            this.imgCapture5.TabStop = false;
            // 
            // imgCapture4
            // 
            this.imgCapture4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture4.Location = new System.Drawing.Point(340, 410);
            this.imgCapture4.Name = "imgCapture4";
            this.imgCapture4.Size = new System.Drawing.Size(310, 310);
            this.imgCapture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture4.TabIndex = 43;
            this.imgCapture4.TabStop = false;
            // 
            // imgCapture3
            // 
            this.imgCapture3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture3.Location = new System.Drawing.Point(29, 410);
            this.imgCapture3.Name = "imgCapture3";
            this.imgCapture3.Size = new System.Drawing.Size(310, 310);
            this.imgCapture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture3.TabIndex = 42;
            this.imgCapture3.TabStop = false;
            // 
            // imgCapture2
            // 
            this.imgCapture2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture2.Location = new System.Drawing.Point(340, 46);
            this.imgCapture2.Name = "imgCapture2";
            this.imgCapture2.Size = new System.Drawing.Size(310, 310);
            this.imgCapture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture2.TabIndex = 41;
            this.imgCapture2.TabStop = false;
            // 
            // imgCapture1
            // 
            this.imgCapture1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture1.BackColor = System.Drawing.SystemColors.Control;
            this.imgCapture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture1.Location = new System.Drawing.Point(29, 46);
            this.imgCapture1.Name = "imgCapture1";
            this.imgCapture1.Size = new System.Drawing.Size(310, 310);
            this.imgCapture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture1.TabIndex = 40;
            this.imgCapture1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtValidUntil);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTakeOutNote);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAssetName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRFIDTag);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(669, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 244);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Information";
            // 
            // txtValidUntil
            // 
            this.txtValidUntil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValidUntil.BackColor = System.Drawing.Color.White;
            this.txtValidUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidUntil.Location = new System.Drawing.Point(155, 41);
            this.txtValidUntil.MaxLength = 45;
            this.txtValidUntil.Name = "txtValidUntil";
            this.txtValidUntil.ReadOnly = true;
            this.txtValidUntil.Size = new System.Drawing.Size(120, 22);
            this.txtValidUntil.TabIndex = 27;
            this.txtValidUntil.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(153, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Valid Until";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // txtTakeOutNote
            // 
            this.txtTakeOutNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTakeOutNote.BackColor = System.Drawing.Color.White;
            this.txtTakeOutNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTakeOutNote.Location = new System.Drawing.Point(17, 188);
            this.txtTakeOutNote.MaxLength = 100;
            this.txtTakeOutNote.Multiline = true;
            this.txtTakeOutNote.Name = "txtTakeOutNote";
            this.txtTakeOutNote.ReadOnly = true;
            this.txtTakeOutNote.Size = new System.Drawing.Size(258, 46);
            this.txtTakeOutNote.TabIndex = 6;
            this.txtTakeOutNote.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Take Out Note";
            // 
            // txtAssetName
            // 
            this.txtAssetName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssetName.BackColor = System.Drawing.Color.White;
            this.txtAssetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetName.Location = new System.Drawing.Point(248, 163);
            this.txtAssetName.MaxLength = 45;
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.ReadOnly = true;
            this.txtAssetName.Size = new System.Drawing.Size(27, 22);
            this.txtAssetName.TabIndex = 3;
            this.txtAssetName.TabStop = false;
            this.txtAssetName.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Asset Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // txtRFIDTag
            // 
            this.txtRFIDTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRFIDTag.BackColor = System.Drawing.Color.White;
            this.txtRFIDTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFIDTag.Location = new System.Drawing.Point(17, 72);
            this.txtRFIDTag.MaxLength = 45;
            this.txtRFIDTag.Name = "txtRFIDTag";
            this.txtRFIDTag.ReadOnly = true;
            this.txtRFIDTag.Size = new System.Drawing.Size(259, 22);
            this.txtRFIDTag.TabIndex = 11;
            this.txtRFIDTag.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "RFID Tag";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(16, 118);
            this.txtDescription.MaxLength = 45;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(259, 46);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TabStop = false;
            // 
            // grpBoxReportedInfo
            // 
            this.grpBoxReportedInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBoxReportedInfo.Controls.Add(this.txtReportedNote);
            this.grpBoxReportedInfo.Controls.Add(this.picPersonBroughtOut);
            this.grpBoxReportedInfo.Controls.Add(this.label5);
            this.grpBoxReportedInfo.Controls.Add(this.txtOwnerDescription);
            this.grpBoxReportedInfo.Controls.Add(this.btnVerifyAsset);
            this.grpBoxReportedInfo.Controls.Add(this.txtOwnerPosition);
            this.grpBoxReportedInfo.Controls.Add(this.label2);
            this.grpBoxReportedInfo.Controls.Add(this.picOwner);
            this.grpBoxReportedInfo.Controls.Add(this.txtOwnerName);
            this.grpBoxReportedInfo.Controls.Add(this.label1);
            this.grpBoxReportedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxReportedInfo.Location = new System.Drawing.Point(901, 381);
            this.grpBoxReportedInfo.Name = "grpBoxReportedInfo";
            this.grpBoxReportedInfo.Size = new System.Drawing.Size(60, 24);
            this.grpBoxReportedInfo.TabIndex = 48;
            this.grpBoxReportedInfo.TabStop = false;
            this.grpBoxReportedInfo.Text = "Reported Information";
            this.grpBoxReportedInfo.Visible = false;
            // 
            // txtReportedNote
            // 
            this.txtReportedNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReportedNote.BackColor = System.Drawing.Color.White;
            this.txtReportedNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReportedNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportedNote.Location = new System.Drawing.Point(18, 7);
            this.txtReportedNote.Multiline = true;
            this.txtReportedNote.Name = "txtReportedNote";
            this.txtReportedNote.ReadOnly = true;
            this.txtReportedNote.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtReportedNote.Size = new System.Drawing.Size(24, 10);
            this.txtReportedNote.TabIndex = 49;
            this.txtReportedNote.TabStop = false;
            this.txtReportedNote.Visible = false;
            // 
            // picPersonBroughtOut
            // 
            this.picPersonBroughtOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPersonBroughtOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPersonBroughtOut.Location = new System.Drawing.Point(-100, -21);
            this.picPersonBroughtOut.Name = "picPersonBroughtOut";
            this.picPersonBroughtOut.Size = new System.Drawing.Size(85, 85);
            this.picPersonBroughtOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonBroughtOut.TabIndex = 48;
            this.picPersonBroughtOut.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Description";
            this.label5.Visible = false;
            // 
            // txtOwnerDescription
            // 
            this.txtOwnerDescription.BackColor = System.Drawing.Color.White;
            this.txtOwnerDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerDescription.Location = new System.Drawing.Point(360, 130);
            this.txtOwnerDescription.MaxLength = 45;
            this.txtOwnerDescription.Multiline = true;
            this.txtOwnerDescription.Name = "txtOwnerDescription";
            this.txtOwnerDescription.ReadOnly = true;
            this.txtOwnerDescription.Size = new System.Drawing.Size(21, 21);
            this.txtOwnerDescription.TabIndex = 45;
            this.txtOwnerDescription.TabStop = false;
            this.txtOwnerDescription.Visible = false;
            // 
            // btnVerifyAsset
            // 
            this.btnVerifyAsset.BackColor = System.Drawing.Color.Orange;
            this.btnVerifyAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyAsset.Location = new System.Drawing.Point(238, 14);
            this.btnVerifyAsset.Name = "btnVerifyAsset";
            this.btnVerifyAsset.Size = new System.Drawing.Size(46, 22);
            this.btnVerifyAsset.TabIndex = 29;
            this.btnVerifyAsset.Text = "Click to verify RFID Tag";
            this.btnVerifyAsset.UseVisualStyleBackColor = false;
            this.btnVerifyAsset.Visible = false;
            // 
            // txtOwnerPosition
            // 
            this.txtOwnerPosition.BackColor = System.Drawing.Color.White;
            this.txtOwnerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerPosition.Location = new System.Drawing.Point(360, 110);
            this.txtOwnerPosition.MaxLength = 45;
            this.txtOwnerPosition.Multiline = true;
            this.txtOwnerPosition.Name = "txtOwnerPosition";
            this.txtOwnerPosition.ReadOnly = true;
            this.txtOwnerPosition.Size = new System.Drawing.Size(23, 22);
            this.txtOwnerPosition.TabIndex = 43;
            this.txtOwnerPosition.TabStop = false;
            this.txtOwnerPosition.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Position";
            this.label2.Visible = false;
            // 
            // picOwner
            // 
            this.picOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOwner.Location = new System.Drawing.Point(274, 94);
            this.picOwner.Name = "picOwner";
            this.picOwner.Size = new System.Drawing.Size(18, 22);
            this.picOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOwner.TabIndex = 42;
            this.picOwner.TabStop = false;
            this.picOwner.Visible = false;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.BackColor = System.Drawing.Color.White;
            this.txtOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerName.Location = new System.Drawing.Point(360, 88);
            this.txtOwnerName.MaxLength = 45;
            this.txtOwnerName.Multiline = true;
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.ReadOnly = true;
            this.txtOwnerName.Size = new System.Drawing.Size(23, 22);
            this.txtOwnerName.TabIndex = 40;
            this.txtOwnerName.TabStop = false;
            this.txtOwnerName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name";
            this.label1.Visible = false;
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 750);
            this.Controls.Add(this.lblCurrentDateTime);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Verification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Verification_FormClosed);
            this.Load += new System.EventHandler(this.Verification_Load);
            this.Shown += new System.EventHandler(this.Verification_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBoxReportedInfo.ResumeLayout(false);
            this.grpBoxReportedInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonBroughtOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentDateTime;
        private System.Windows.Forms.Timer VerifyTimer;
        private System.Windows.Forms.Timer BackgroundTimer;
        private System.Windows.Forms.Timer CurrentDateTimer;
        private System.Windows.Forms.Timer ClearTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxReportedInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOwnerDescription;
        private System.Windows.Forms.Button btnVerifyAsset;
        private System.Windows.Forms.TextBox txtOwnerPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picOwner;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoadingInformation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox imgCapture5;
        private System.Windows.Forms.PictureBox imgCapture4;
        private System.Windows.Forms.PictureBox imgCapture3;
        private System.Windows.Forms.PictureBox imgCapture2;
        private System.Windows.Forms.PictureBox imgCapture1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTakeOutNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRFIDTag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picPersonBroughtOut;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValidIDPhoto;
        private System.Windows.Forms.Label lblOwnerPhoto;
        private System.Windows.Forms.Label lblAssetPhoto3;
        private System.Windows.Forms.Label lblAssetPhoto2;
        private System.Windows.Forms.Label lblAssetPhoto1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSubmittingInformation;
        private System.Windows.Forms.TextBox txtReportedNote;
        private System.Windows.Forms.TextBox txtValidUntil;
        private System.Windows.Forms.Label label10;


    }
}