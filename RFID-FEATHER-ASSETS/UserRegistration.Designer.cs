namespace RFID_FEATHER_ASSETS
{
    partial class RegisterUser
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseImageDir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSaveImageDir = new System.Windows.Forms.TextBox();
            this.lblNoCameraAvailable = new System.Windows.Forms.Label();
            this.comVideoDeviceBox = new System.Windows.Forms.ComboBox();
            this.CaptureImg = new System.Windows.Forms.Button();
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.authorities = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imagePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "image.jpg";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnBrowseImageDir);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSaveImageDir);
            this.groupBox1.Controls.Add(this.lblNoCameraAvailable);
            this.groupBox1.Controls.Add(this.comVideoDeviceBox);
            this.groupBox1.Controls.Add(this.CaptureImg);
            this.groupBox1.Controls.Add(this.cameraBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 582);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera";
            // 
            // btnBrowseImageDir
            // 
            this.btnBrowseImageDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseImageDir.BackColor = System.Drawing.Color.Wheat;
            this.btnBrowseImageDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImageDir.Location = new System.Drawing.Point(557, 463);
            this.btnBrowseImageDir.Name = "btnBrowseImageDir";
            this.btnBrowseImageDir.Size = new System.Drawing.Size(85, 22);
            this.btnBrowseImageDir.TabIndex = 1;
            this.btnBrowseImageDir.Text = "...";
            this.btnBrowseImageDir.UseVisualStyleBackColor = false;
            this.btnBrowseImageDir.Click += new System.EventHandler(this.btnBrowseImageDir_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(45, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Image Directory:";
            // 
            // txtSaveImageDir
            // 
            this.txtSaveImageDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSaveImageDir.Enabled = false;
            this.txtSaveImageDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaveImageDir.Location = new System.Drawing.Point(143, 464);
            this.txtSaveImageDir.MaxLength = 45;
            this.txtSaveImageDir.Name = "txtSaveImageDir";
            this.txtSaveImageDir.Size = new System.Drawing.Size(408, 21);
            this.txtSaveImageDir.TabIndex = 33;
            // 
            // lblNoCameraAvailable
            // 
            this.lblNoCameraAvailable.AutoSize = true;
            this.lblNoCameraAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCameraAvailable.Location = new System.Drawing.Point(106, 192);
            this.lblNoCameraAvailable.Name = "lblNoCameraAvailable";
            this.lblNoCameraAvailable.Size = new System.Drawing.Size(446, 33);
            this.lblNoCameraAvailable.TabIndex = 17;
            this.lblNoCameraAvailable.Text = "There is no camera connected.";
            // 
            // comVideoDeviceBox
            // 
            this.comVideoDeviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comVideoDeviceBox.FormattingEnabled = true;
            this.comVideoDeviceBox.Location = new System.Drawing.Point(48, 493);
            this.comVideoDeviceBox.Name = "comVideoDeviceBox";
            this.comVideoDeviceBox.Size = new System.Drawing.Size(594, 24);
            this.comVideoDeviceBox.TabIndex = 2;
            // 
            // CaptureImg
            // 
            this.CaptureImg.BackColor = System.Drawing.Color.Orange;
            this.CaptureImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptureImg.Location = new System.Drawing.Point(48, 520);
            this.CaptureImg.Name = "CaptureImg";
            this.CaptureImg.Size = new System.Drawing.Size(594, 41);
            this.CaptureImg.TabIndex = 3;
            this.CaptureImg.Text = "Take Photo";
            this.CaptureImg.UseVisualStyleBackColor = false;
            this.CaptureImg.Click += new System.EventHandler(this.CaptureImg_Click_1);
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(48, 35);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(594, 422);
            this.cameraBox.TabIndex = 13;
            this.cameraBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.imgCapture);
            this.groupBox2.Controls.Add(this.authorities);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cpassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.lastName);
            this.groupBox2.Controls.Add(this.position);
            this.groupBox2.Controls.Add(this.description);
            this.groupBox2.Controls.Add(this.firstName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(739, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 718);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Owner Information";
            // 
            // imgCapture
            // 
            this.imgCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture.Location = new System.Drawing.Point(103, 35);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(282, 229);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture.TabIndex = 26;
            this.imgCapture.TabStop = false;
            // 
            // authorities
            // 
            this.authorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorities.FormattingEnabled = true;
            this.authorities.Location = new System.Drawing.Point(219, 609);
            this.authorities.Name = "authorities";
            this.authorities.Size = new System.Drawing.Size(212, 24);
            this.authorities.TabIndex = 11;
            this.authorities.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 603);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Authorities:";
            // 
            // cpassword
            // 
            this.cpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpassword.Location = new System.Drawing.Point(219, 563);
            this.cpassword.Name = "cpassword";
            this.cpassword.Size = new System.Drawing.Size(212, 22);
            this.cpassword.TabIndex = 10;
            this.cpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cpassword_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Confirm Password:";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(219, 521);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(212, 22);
            this.password.TabIndex = 9;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Password: ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(332, 660);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 41);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(219, 660);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 41);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(219, 477);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(212, 22);
            this.email.TabIndex = 8;
            this.email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_KeyDown);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(219, 336);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(212, 22);
            this.lastName.TabIndex = 5;
            this.lastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastName_KeyDown);
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(219, 376);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(212, 22);
            this.position.TabIndex = 6;
            this.position.KeyDown += new System.Windows.Forms.KeyEventHandler(this.position_KeyDown);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(219, 420);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(212, 39);
            this.description.TabIndex = 7;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(219, 294);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(212, 22);
            this.firstName.TabIndex = 4;
            this.firstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name: ";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1322, 865);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "User Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RegisterUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comVideoDeviceBox;
        private System.Windows.Forms.Button CaptureImg;
        private System.Windows.Forms.PictureBox cameraBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox authorities;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cpassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoCameraAvailable;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.Button btnBrowseImageDir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSaveImageDir;
        private System.Windows.Forms.FolderBrowserDialog imagePathDialog;
    }
}