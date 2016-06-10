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
            this.lblNoCameraAvailable = new System.Windows.Forms.Label();
            this.comVideoDeviceBox = new System.Windows.Forms.ComboBox();
            this.CaptureImg = new System.Windows.Forms.Button();
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "image.jpg";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblNoCameraAvailable);
            this.groupBox1.Controls.Add(this.comVideoDeviceBox);
            this.groupBox1.Controls.Add(this.CaptureImg);
            this.groupBox1.Controls.Add(this.cameraBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 538);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera";
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
            this.comVideoDeviceBox.Location = new System.Drawing.Point(44, 456);
            this.comVideoDeviceBox.Name = "comVideoDeviceBox";
            this.comVideoDeviceBox.Size = new System.Drawing.Size(594, 21);
            this.comVideoDeviceBox.TabIndex = 16;
            // 
            // CaptureImg
            // 
            this.CaptureImg.BackColor = System.Drawing.Color.Orange;
            this.CaptureImg.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptureImg.Location = new System.Drawing.Point(44, 483);
            this.CaptureImg.Name = "CaptureImg";
            this.CaptureImg.Size = new System.Drawing.Size(594, 41);
            this.CaptureImg.TabIndex = 14;
            this.CaptureImg.Text = "Take Photo";
            this.CaptureImg.UseVisualStyleBackColor = false;
            this.CaptureImg.Click += new System.EventHandler(this.CaptureImg_Click_1);
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(44, 18);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(594, 422);
            this.cameraBox.TabIndex = 13;
            this.cameraBox.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Orange;
            this.btnStart.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(913, 590);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 41);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.groupBox2.Location = new System.Drawing.Point(708, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 538);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Owner Information";
            // 
            // authorities
            // 
            this.authorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorities.FormattingEnabled = true;
            this.authorities.Location = new System.Drawing.Point(212, 418);
            this.authorities.Name = "authorities";
            this.authorities.Size = new System.Drawing.Size(212, 21);
            this.authorities.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Authorities";
            // 
            // cpassword
            // 
            this.cpassword.Location = new System.Drawing.Point(212, 365);
            this.cpassword.Name = "cpassword";
            this.cpassword.Size = new System.Drawing.Size(212, 20);
            this.cpassword.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Confirm Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(212, 308);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(212, 20);
            this.password.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Password: ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(325, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 41);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(212, 469);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 41);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(212, 252);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(212, 20);
            this.email.TabIndex = 17;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(212, 86);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(212, 20);
            this.lastName.TabIndex = 11;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(212, 134);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(212, 20);
            this.position.TabIndex = 13;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(212, 186);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(212, 39);
            this.description.TabIndex = 15;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(212, 39);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(212, 20);
            this.firstName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "E-Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name: ";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1240, 660);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStart);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comVideoDeviceBox;
        private System.Windows.Forms.Button btnStart;
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
    }
}