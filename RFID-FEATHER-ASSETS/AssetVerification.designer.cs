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
            this.label3 = new System.Windows.Forms.Label();
            this.picOwner = new System.Windows.Forms.PictureBox();
            this.btnVerifyAsset = new System.Windows.Forms.Button();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtTakeOutNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAssetName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRFIDTag = new System.Windows.Forms.TextBox();
            this.ClearTimer = new System.Windows.Forms.Timer(this.components);
            this.txtTakeOutAvailability = new System.Windows.Forms.TextBox();
            this.VerifyTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Take Out Availability";
            // 
            // picOwner
            // 
            this.picOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOwner.Location = new System.Drawing.Point(71, 46);
            this.picOwner.Name = "picOwner";
            this.picOwner.Size = new System.Drawing.Size(194, 183);
            this.picOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOwner.TabIndex = 30;
            this.picOwner.TabStop = false;
            // 
            // btnVerifyAsset
            // 
            this.btnVerifyAsset.BackColor = System.Drawing.Color.Orange;
            this.btnVerifyAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyAsset.Location = new System.Drawing.Point(71, 20);
            this.btnVerifyAsset.Name = "btnVerifyAsset";
            this.btnVerifyAsset.Size = new System.Drawing.Size(194, 26);
            this.btnVerifyAsset.TabIndex = 29;
            this.btnVerifyAsset.Text = "Click to verify RFID Tag";
            this.btnVerifyAsset.UseVisualStyleBackColor = false;
            this.btnVerifyAsset.Click += new System.EventHandler(this.btnVerifyAsset_Click);
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.BackColor = System.Drawing.Color.White;
            this.txtOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerName.Location = new System.Drawing.Point(36, 337);
            this.txtOwnerName.MaxLength = 45;
            this.txtOwnerName.Multiline = true;
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.ReadOnly = true;
            this.txtOwnerName.Size = new System.Drawing.Size(259, 22);
            this.txtOwnerName.TabIndex = 25;
            // 
            // txtTakeOutNote
            // 
            this.txtTakeOutNote.BackColor = System.Drawing.Color.White;
            this.txtTakeOutNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTakeOutNote.Location = new System.Drawing.Point(36, 448);
            this.txtTakeOutNote.MaxLength = 100;
            this.txtTakeOutNote.Multiline = true;
            this.txtTakeOutNote.Name = "txtTakeOutNote";
            this.txtTakeOutNote.ReadOnly = true;
            this.txtTakeOutNote.Size = new System.Drawing.Size(258, 68);
            this.txtTakeOutNote.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Take Out Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Owner Name";
            // 
            // txtAssetName
            // 
            this.txtAssetName.BackColor = System.Drawing.Color.White;
            this.txtAssetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssetName.Location = new System.Drawing.Point(36, 286);
            this.txtAssetName.MaxLength = 45;
            this.txtAssetName.Name = "txtAssetName";
            this.txtAssetName.ReadOnly = true;
            this.txtAssetName.Size = new System.Drawing.Size(259, 21);
            this.txtAssetName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Asset Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRFIDTag
            // 
            this.txtRFIDTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFIDTag.Location = new System.Drawing.Point(33, 233);
            this.txtRFIDTag.MaxLength = 45;
            this.txtRFIDTag.Name = "txtRFIDTag";
            this.txtRFIDTag.ReadOnly = true;
            this.txtRFIDTag.Size = new System.Drawing.Size(259, 24);
            this.txtRFIDTag.TabIndex = 22;
            this.txtRFIDTag.Visible = false;
            // 
            // ClearTimer
            // 
            this.ClearTimer.Tick += new System.EventHandler(this.ClearTimer_Tick);
            // 
            // txtTakeOutAvailability
            // 
            this.txtTakeOutAvailability.BackColor = System.Drawing.Color.White;
            this.txtTakeOutAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTakeOutAvailability.Location = new System.Drawing.Point(36, 392);
            this.txtTakeOutAvailability.MaxLength = 45;
            this.txtTakeOutAvailability.Multiline = true;
            this.txtTakeOutAvailability.Name = "txtTakeOutAvailability";
            this.txtTakeOutAvailability.ReadOnly = true;
            this.txtTakeOutAvailability.Size = new System.Drawing.Size(259, 22);
            this.txtTakeOutAvailability.TabIndex = 31;
            // 
            // VerifyTimer
            // 
            this.VerifyTimer.Tick += new System.EventHandler(this.VerifyTimer_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Orange;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(102, 534);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 39);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 616);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtTakeOutAvailability);
            this.Controls.Add(this.picOwner);
            this.Controls.Add(this.btnVerifyAsset);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.txtTakeOutNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAssetName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRFIDTag);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Verification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Verification_FormClosed);
            this.Load += new System.EventHandler(this.Verification_Load);
            this.Shown += new System.EventHandler(this.Verification_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picOwner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picOwner;
        private System.Windows.Forms.Button btnVerifyAsset;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtTakeOutNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAssetName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRFIDTag;
        private System.Windows.Forms.Timer ClearTimer;
        private System.Windows.Forms.TextBox txtTakeOutAvailability;
        private System.Windows.Forms.Timer VerifyTimer;
        private System.Windows.Forms.Button btnBack;

    }
}