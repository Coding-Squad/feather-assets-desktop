namespace RFID_FEATHER_ASSETS
{
    partial class AssetRegistration
    {
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
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.picOwner = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCaptureImg = new System.Windows.Forms.Button();
            this.lblNoCameraAvailable = new System.Windows.Forms.Label();
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.comVideoDeviceBox = new System.Windows.Forms.ComboBox();
            this.txtCapturedImagePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboOwner = new System.Windows.Forms.ComboBox();
            this.btnGetRFIDTag = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTakeOutNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radbtnNo = new System.Windows.Forms.RadioButton();
            this.radbtnYes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRFIDTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgCapture1 = new System.Windows.Forms.PictureBox();
            this.imgCapture2 = new System.Windows.Forms.PictureBox();
            this.imgCapture3 = new System.Windows.Forms.PictureBox();
            this.imgCapture4 = new System.Windows.Forms.PictureBox();
            this.imgCapture5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.Orange;
            this.btnRegisterUser.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.Location = new System.Drawing.Point(668, 874);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(40, 26);
            this.btnRegisterUser.TabIndex = 17;
            this.btnRegisterUser.Text = "Register User";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Visible = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseImage.BackColor = System.Drawing.Color.Orange;
            this.btnBrowseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.Location = new System.Drawing.Point(637, 870);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(43, 26);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Visible = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(733, 874);
            this.txtImagePath.MaxLength = 45;
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(43, 20);
            this.txtImagePath.TabIndex = 19;
            this.txtImagePath.Visible = false;
            // 
            // picOwner
            // 
            this.picOwner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOwner.Location = new System.Drawing.Point(598, 874);
            this.picOwner.Name = "picOwner";
            this.picOwner.Size = new System.Drawing.Size(37, 22);
            this.picOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOwner.TabIndex = 21;
            this.picOwner.TabStop = false;
            this.picOwner.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "image.jpg";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnCaptureImg);
            this.groupBox1.Controls.Add(this.lblNoCameraAvailable);
            this.groupBox1.Controls.Add(this.cameraBox);
            this.groupBox1.Controls.Add(this.comVideoDeviceBox);
            this.groupBox1.Controls.Add(this.txtCapturedImagePath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radbtnYes);
            this.groupBox1.Controls.Add(this.radbtnNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(31, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 495);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera Preview";
            // 
            // btnCaptureImg
            // 
            this.btnCaptureImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCaptureImg.BackColor = System.Drawing.Color.Orange;
            this.btnCaptureImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureImg.Location = new System.Drawing.Point(30, 435);
            this.btnCaptureImg.Name = "btnCaptureImg";
            this.btnCaptureImg.Size = new System.Drawing.Size(405, 39);
            this.btnCaptureImg.TabIndex = 1;
            this.btnCaptureImg.Text = "Capture Image";
            this.btnCaptureImg.UseVisualStyleBackColor = false;
            this.btnCaptureImg.Click += new System.EventHandler(this.btnCaptureImg_Click);
            // 
            // lblNoCameraAvailable
            // 
            this.lblNoCameraAvailable.AutoSize = true;
            this.lblNoCameraAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCameraAvailable.Location = new System.Drawing.Point(46, 165);
            this.lblNoCameraAvailable.Name = "lblNoCameraAvailable";
            this.lblNoCameraAvailable.Size = new System.Drawing.Size(374, 29);
            this.lblNoCameraAvailable.TabIndex = 29;
            this.lblNoCameraAvailable.Text = "There is no camera connected.";
            this.lblNoCameraAvailable.Visible = false;
            // 
            // cameraBox
            // 
            this.cameraBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cameraBox.Location = new System.Drawing.Point(30, 33);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(405, 401);
            this.cameraBox.TabIndex = 23;
            this.cameraBox.TabStop = false;
            // 
            // comVideoDeviceBox
            // 
            this.comVideoDeviceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comVideoDeviceBox.FormattingEnabled = true;
            this.comVideoDeviceBox.Location = new System.Drawing.Point(84, 418);
            this.comVideoDeviceBox.Name = "comVideoDeviceBox";
            this.comVideoDeviceBox.Size = new System.Drawing.Size(59, 24);
            this.comVideoDeviceBox.TabIndex = 26;
            this.comVideoDeviceBox.Visible = false;
            // 
            // txtCapturedImagePath
            // 
            this.txtCapturedImagePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCapturedImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapturedImagePath.Location = new System.Drawing.Point(30, 428);
            this.txtCapturedImagePath.MaxLength = 45;
            this.txtCapturedImagePath.Name = "txtCapturedImagePath";
            this.txtCapturedImagePath.Size = new System.Drawing.Size(405, 21);
            this.txtCapturedImagePath.TabIndex = 28;
            this.txtCapturedImagePath.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboOwner);
            this.groupBox2.Controls.Add(this.btnGetRFIDTag);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtTakeOutNote);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAssetName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRFIDTag);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(555, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 495);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Information";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // comboOwner
            // 
            this.comboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOwner.FormattingEnabled = true;
            this.comboOwner.Location = new System.Drawing.Point(30, 241);
            this.comboOwner.Name = "comboOwner";
            this.comboOwner.Size = new System.Drawing.Size(256, 23);
            this.comboOwner.Sorted = true;
            this.comboOwner.TabIndex = 5;
            // 
            // btnGetRFIDTag
            // 
            this.btnGetRFIDTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetRFIDTag.BackColor = System.Drawing.Color.Orange;
            this.btnGetRFIDTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRFIDTag.Location = new System.Drawing.Point(216, 34);
            this.btnGetRFIDTag.Name = "btnGetRFIDTag";
            this.btnGetRFIDTag.Size = new System.Drawing.Size(72, 26);
            this.btnGetRFIDTag.TabIndex = 2;
            this.btnGetRFIDTag.Text = "Get RFID Tag";
            this.btnGetRFIDTag.UseVisualStyleBackColor = false;
            this.btnGetRFIDTag.Click += new System.EventHandler(this.btnGetRFIDTag_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(163, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(32, 435);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 39);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(32, 165);
            this.txtDescription.MaxLength = 45;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 46);
            this.txtDescription.TabIndex = 4;
            // 
            // txtTakeOutNote
            // 
            this.txtTakeOutNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTakeOutNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTakeOutNote.Location = new System.Drawing.Point(30, 299);
            this.txtTakeOutNote.MaxLength = 100;
            this.txtTakeOutNote.Multiline = true;
            this.txtTakeOutNote.Name = "txtTakeOutNote";
            this.txtTakeOutNote.Size = new System.Drawing.Size(258, 68);
            this.txtTakeOutNote.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Take Out Note";
            // 
            // radbtnNo
            // 
            this.radbtnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radbtnNo.AutoSize = true;
            this.radbtnNo.Checked = true;
            this.radbtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnNo.Location = new System.Drawing.Point(314, 294);
            this.radbtnNo.Name = "radbtnNo";
            this.radbtnNo.Size = new System.Drawing.Size(41, 19);
            this.radbtnNo.TabIndex = 18;
            this.radbtnNo.TabStop = true;
            this.radbtnNo.Text = "No";
            this.radbtnNo.UseVisualStyleBackColor = true;
            this.radbtnNo.Visible = false;
            // 
            // radbtnYes
            // 
            this.radbtnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radbtnYes.AutoSize = true;
            this.radbtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnYes.Location = new System.Drawing.Point(258, 294);
            this.radbtnYes.Name = "radbtnYes";
            this.radbtnYes.Size = new System.Drawing.Size(45, 19);
            this.radbtnYes.TabIndex = 17;
            this.radbtnYes.Text = "Yes";
            this.radbtnYes.UseVisualStyleBackColor = true;
            this.radbtnYes.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Take Out Allowed?";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Owner";
            // 
            // txtAssetName
            // 
            this.txtAssetName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetName.Location = new System.Drawing.Point(32, 113);
            this.txtAssetName.MaxLength = 45;
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.Size = new System.Drawing.Size(259, 21);
            this.txtAssetName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Asset Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRFIDTag
            // 
            this.txtRFIDTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRFIDTag.BackColor = System.Drawing.Color.White;
            this.txtRFIDTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFIDTag.Location = new System.Drawing.Point(30, 63);
            this.txtRFIDTag.MaxLength = 45;
            this.txtRFIDTag.Name = "txtRFIDTag";
            this.txtRFIDTag.ReadOnly = true;
            this.txtRFIDTag.Size = new System.Drawing.Size(259, 20);
            this.txtRFIDTag.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "RFID Tag";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgCapture1
            // 
            this.imgCapture1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgCapture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture1.Location = new System.Drawing.Point(33, 538);
            this.imgCapture1.Name = "imgCapture1";
            this.imgCapture1.Size = new System.Drawing.Size(167, 160);
            this.imgCapture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture1.TabIndex = 28;
            this.imgCapture1.TabStop = false;
            // 
            // imgCapture2
            // 
            this.imgCapture2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture2.Location = new System.Drawing.Point(202, 538);
            this.imgCapture2.Name = "imgCapture2";
            this.imgCapture2.Size = new System.Drawing.Size(167, 160);
            this.imgCapture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture2.TabIndex = 29;
            this.imgCapture2.TabStop = false;
            // 
            // imgCapture3
            // 
            this.imgCapture3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture3.Location = new System.Drawing.Point(371, 538);
            this.imgCapture3.Name = "imgCapture3";
            this.imgCapture3.Size = new System.Drawing.Size(167, 160);
            this.imgCapture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture3.TabIndex = 30;
            this.imgCapture3.TabStop = false;
            // 
            // imgCapture4
            // 
            this.imgCapture4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture4.Location = new System.Drawing.Point(540, 538);
            this.imgCapture4.Name = "imgCapture4";
            this.imgCapture4.Size = new System.Drawing.Size(167, 160);
            this.imgCapture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture4.TabIndex = 31;
            this.imgCapture4.TabStop = false;
            // 
            // imgCapture5
            // 
            this.imgCapture5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture5.Location = new System.Drawing.Point(709, 538);
            this.imgCapture5.Name = "imgCapture5";
            this.imgCapture5.Size = new System.Drawing.Size(167, 160);
            this.imgCapture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture5.TabIndex = 32;
            this.imgCapture5.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(34, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(842, 10);
            this.label6.TabIndex = 33;
            // 
            // AssetRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(909, 750);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imgCapture5);
            this.Controls.Add(this.imgCapture4);
            this.Controls.Add(this.imgCapture3);
            this.Controls.Add(this.imgCapture2);
            this.Controls.Add(this.imgCapture1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picOwner);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnRegisterUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AssetRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterAsset_FormClosed);
            this.Load += new System.EventHandler(this.RegisterAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.PictureBox picOwner;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCaptureImg;
        private System.Windows.Forms.PictureBox cameraBox;
        private System.Windows.Forms.ComboBox comVideoDeviceBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetRFIDTag;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTakeOutNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radbtnNo;
        private System.Windows.Forms.RadioButton radbtnYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRFIDTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapturedImagePath;
        private System.Windows.Forms.Label lblNoCameraAvailable;
        private System.Windows.Forms.PictureBox imgCapture1;
        private System.Windows.Forms.PictureBox imgCapture2;
        private System.Windows.Forms.PictureBox imgCapture3;
        private System.Windows.Forms.PictureBox imgCapture4;
        private System.Windows.Forms.PictureBox imgCapture5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboOwner;

    }
}