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
            this.btnVerifyAsset = new System.Windows.Forms.Button();
            this.ClearTimer = new System.Windows.Forms.Timer(this.components);
            this.VerifyTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTakeOutNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRFIDTag = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLoadingInformation = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imgCapture5 = new System.Windows.Forms.PictureBox();
            this.imgCapture4 = new System.Windows.Forms.PictureBox();
            this.imgCapture3 = new System.Windows.Forms.PictureBox();
            this.imgCapture2 = new System.Windows.Forms.PictureBox();
            this.imgCapture1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picOwner = new System.Windows.Forms.PictureBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.CurrentDateTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentDateTime = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerifyAsset
            // 
            this.btnVerifyAsset.BackColor = System.Drawing.Color.Orange;
            this.btnVerifyAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyAsset.Location = new System.Drawing.Point(153, 0);
            this.btnVerifyAsset.Name = "btnVerifyAsset";
            this.btnVerifyAsset.Size = new System.Drawing.Size(131, 26);
            this.btnVerifyAsset.TabIndex = 29;
            this.btnVerifyAsset.Text = "Click to verify RFID Tag";
            this.btnVerifyAsset.UseVisualStyleBackColor = false;
            this.btnVerifyAsset.Visible = false;
            this.btnVerifyAsset.Click += new System.EventHandler(this.btnVerifyAsset_Click);
            // 
            // ClearTimer
            // 
            this.ClearTimer.Tick += new System.EventHandler(this.ClearTimer_Tick);
            // 
            // VerifyTimer
            // 
            this.VerifyTimer.Tick += new System.EventHandler(this.VerifyTimer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtTakeOutNote);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAssetName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRFIDTag);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(69, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 277);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Information";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(24, 134);
            this.txtDescription.MaxLength = 45;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(259, 46);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TabStop = false;
            // 
            // txtTakeOutNote
            // 
            this.txtTakeOutNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTakeOutNote.BackColor = System.Drawing.Color.White;
            this.txtTakeOutNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTakeOutNote.Location = new System.Drawing.Point(22, 203);
            this.txtTakeOutNote.MaxLength = 100;
            this.txtTakeOutNote.Multiline = true;
            this.txtTakeOutNote.Name = "txtTakeOutNote";
            this.txtTakeOutNote.ReadOnly = true;
            this.txtTakeOutNote.Size = new System.Drawing.Size(258, 68);
            this.txtTakeOutNote.TabIndex = 6;
            this.txtTakeOutNote.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Take Out Note";
            // 
            // txtAssetName
            // 
            this.txtAssetName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssetName.BackColor = System.Drawing.Color.White;
            this.txtAssetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetName.Location = new System.Drawing.Point(24, 90);
            this.txtAssetName.MaxLength = 45;
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.ReadOnly = true;
            this.txtAssetName.Size = new System.Drawing.Size(259, 21);
            this.txtAssetName.TabIndex = 3;
            this.txtAssetName.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Asset Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRFIDTag
            // 
            this.txtRFIDTag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRFIDTag.BackColor = System.Drawing.Color.White;
            this.txtRFIDTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFIDTag.Location = new System.Drawing.Point(22, 46);
            this.txtRFIDTag.MaxLength = 45;
            this.txtRFIDTag.Name = "txtRFIDTag";
            this.txtRFIDTag.ReadOnly = true;
            this.txtRFIDTag.Size = new System.Drawing.Size(259, 21);
            this.txtRFIDTag.TabIndex = 11;
            this.txtRFIDTag.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "RFID Tag";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblLoadingInformation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.imgCapture5);
            this.groupBox1.Controls.Add(this.imgCapture4);
            this.groupBox1.Controls.Add(this.imgCapture3);
            this.groupBox1.Controls.Add(this.imgCapture2);
            this.groupBox1.Controls.Add(this.imgCapture1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 441);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asset Pictures";
            // 
            // lblLoadingInformation
            // 
            this.lblLoadingInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoadingInformation.AutoSize = true;
            this.lblLoadingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingInformation.Location = new System.Drawing.Point(181, 236);
            this.lblLoadingInformation.Name = "lblLoadingInformation";
            this.lblLoadingInformation.Size = new System.Drawing.Size(532, 37);
            this.lblLoadingInformation.TabIndex = 46;
            this.lblLoadingInformation.Text = "Getting Information. Please wait...";
            this.lblLoadingInformation.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(146, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(604, 13);
            this.label6.TabIndex = 46;
            // 
            // imgCapture5
            // 
            this.imgCapture5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture5.Location = new System.Drawing.Point(599, 273);
            this.imgCapture5.Name = "imgCapture5";
            this.imgCapture5.Size = new System.Drawing.Size(150, 150);
            this.imgCapture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture5.TabIndex = 44;
            this.imgCapture5.TabStop = false;
            // 
            // imgCapture4
            // 
            this.imgCapture4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture4.Location = new System.Drawing.Point(448, 273);
            this.imgCapture4.Name = "imgCapture4";
            this.imgCapture4.Size = new System.Drawing.Size(150, 150);
            this.imgCapture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture4.TabIndex = 43;
            this.imgCapture4.TabStop = false;
            // 
            // imgCapture3
            // 
            this.imgCapture3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture3.Location = new System.Drawing.Point(297, 273);
            this.imgCapture3.Name = "imgCapture3";
            this.imgCapture3.Size = new System.Drawing.Size(150, 150);
            this.imgCapture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture3.TabIndex = 42;
            this.imgCapture3.TabStop = false;
            // 
            // imgCapture2
            // 
            this.imgCapture2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture2.Location = new System.Drawing.Point(146, 273);
            this.imgCapture2.Name = "imgCapture2";
            this.imgCapture2.Size = new System.Drawing.Size(150, 150);
            this.imgCapture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture2.TabIndex = 41;
            this.imgCapture2.TabStop = false;
            // 
            // imgCapture1
            // 
            this.imgCapture1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgCapture1.BackColor = System.Drawing.SystemColors.Control;
            this.imgCapture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture1.Location = new System.Drawing.Point(316, 12);
            this.imgCapture1.Name = "imgCapture1";
            this.imgCapture1.Size = new System.Drawing.Size(260, 260);
            this.imgCapture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture1.TabIndex = 40;
            this.imgCapture1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.btnVerifyAsset);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.picOwner);
            this.groupBox3.Controls.Add(this.txtOwnerName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(396, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 277);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Owner\'s Information";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(290, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(253, 39);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Description";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(290, 140);
            this.textBox2.MaxLength = 45;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(253, 66);
            this.textBox2.TabIndex = 45;
            this.textBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(290, 94);
            this.textBox1.MaxLength = 45;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 43;
            this.textBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Position";
            // 
            // picOwner
            // 
            this.picOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOwner.Location = new System.Drawing.Point(23, 28);
            this.picOwner.Name = "picOwner";
            this.picOwner.Size = new System.Drawing.Size(250, 240);
            this.picOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOwner.TabIndex = 42;
            this.picOwner.TabStop = false;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.BackColor = System.Drawing.Color.White;
            this.txtOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerName.Location = new System.Drawing.Point(290, 49);
            this.txtOwnerName.MaxLength = 45;
            this.txtOwnerName.Multiline = true;
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.ReadOnly = true;
            this.txtOwnerName.Size = new System.Drawing.Size(253, 22);
            this.txtOwnerName.TabIndex = 40;
            this.txtOwnerName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name";
            // 
            // BackgroundTimer
            // 
            this.BackgroundTimer.Tick += new System.EventHandler(this.BackgroundTimer_Tick);
            // 
            // CurrentDateTimer
            // 
            this.CurrentDateTimer.Tick += new System.EventHandler(this.CurrentTimer_Tick);
            // 
            // lblCurrentDateTime
            // 
            this.lblCurrentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDateTime.Location = new System.Drawing.Point(810, 719);
            this.lblCurrentDateTime.Name = "lblCurrentDateTime";
            this.lblCurrentDateTime.Size = new System.Drawing.Size(254, 20);
            this.lblCurrentDateTime.TabIndex = 42;
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 750);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCurrentDateTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Verification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Verification_FormClosed);
            this.Load += new System.EventHandler(this.Verification_Load);
            this.Shown += new System.EventHandler(this.Verification_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerifyAsset;
        private System.Windows.Forms.Timer ClearTimer;
        private System.Windows.Forms.Timer VerifyTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTakeOutNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRFIDTag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox imgCapture5;
        private System.Windows.Forms.PictureBox imgCapture4;
        private System.Windows.Forms.PictureBox imgCapture3;
        private System.Windows.Forms.PictureBox imgCapture2;
        private System.Windows.Forms.PictureBox imgCapture1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picOwner;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLoadingInformation;
        private System.Windows.Forms.Timer BackgroundTimer;
        private System.Windows.Forms.Timer CurrentDateTimer;
        private System.Windows.Forms.Label lblCurrentDateTime;

    }
}