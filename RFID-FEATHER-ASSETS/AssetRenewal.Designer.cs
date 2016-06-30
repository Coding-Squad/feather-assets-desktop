namespace RFID_FEATHER_ASSETS
{
    partial class AssetRenewal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSubmittingInformation = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbtnValidUnlimited = new System.Windows.Forms.RadioButton();
            this.rbtnValidUntil = new System.Windows.Forms.RadioButton();
            this.rbtnValidToday = new System.Windows.Forms.RadioButton();
            this.dtTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSubmittingInformation);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.rbtnValidUnlimited);
            this.groupBox1.Controls.Add(this.rbtnValidUntil);
            this.groupBox1.Controls.Add(this.rbtnValidToday);
            this.groupBox1.Controls.Add(this.dtTimePicker);
            this.groupBox1.Controls.Add(this.dtDatePicker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 188);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validity Expiration";
            // 
            // lblSubmittingInformation
            // 
            this.lblSubmittingInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubmittingInformation.AutoSize = true;
            this.lblSubmittingInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittingInformation.ForeColor = System.Drawing.Color.Green;
            this.lblSubmittingInformation.Location = new System.Drawing.Point(7, 109);
            this.lblSubmittingInformation.Name = "lblSubmittingInformation";
            this.lblSubmittingInformation.Size = new System.Drawing.Size(260, 16);
            this.lblSubmittingInformation.TabIndex = 81;
            this.lblSubmittingInformation.Text = "Submitting Information. Please wait...";
            this.lblSubmittingInformation.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(141, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 39);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(29, 133);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(106, 39);
            this.btnSubmit.TabIndex = 79;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbtnValidUnlimited
            // 
            this.rbtnValidUnlimited.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnValidUnlimited.AutoSize = true;
            this.rbtnValidUnlimited.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnValidUnlimited.Location = new System.Drawing.Point(15, 80);
            this.rbtnValidUnlimited.Name = "rbtnValidUnlimited";
            this.rbtnValidUnlimited.Size = new System.Drawing.Size(82, 20);
            this.rbtnValidUnlimited.TabIndex = 61;
            this.rbtnValidUnlimited.Text = "Unlimited";
            this.rbtnValidUnlimited.UseVisualStyleBackColor = true;
            // 
            // rbtnValidUntil
            // 
            this.rbtnValidUntil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnValidUntil.AutoSize = true;
            this.rbtnValidUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnValidUntil.Location = new System.Drawing.Point(15, 57);
            this.rbtnValidUntil.Name = "rbtnValidUntil";
            this.rbtnValidUntil.Size = new System.Drawing.Size(52, 20);
            this.rbtnValidUntil.TabIndex = 60;
            this.rbtnValidUntil.Text = "Until";
            this.rbtnValidUntil.UseVisualStyleBackColor = true;
            this.rbtnValidUntil.CheckedChanged += new System.EventHandler(this.rbtnValidUntil_CheckedChanged);
            // 
            // rbtnValidToday
            // 
            this.rbtnValidToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnValidToday.AutoSize = true;
            this.rbtnValidToday.Checked = true;
            this.rbtnValidToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnValidToday.Location = new System.Drawing.Point(15, 34);
            this.rbtnValidToday.Name = "rbtnValidToday";
            this.rbtnValidToday.Size = new System.Drawing.Size(66, 20);
            this.rbtnValidToday.TabIndex = 59;
            this.rbtnValidToday.TabStop = true;
            this.rbtnValidToday.Text = "Today";
            this.rbtnValidToday.UseVisualStyleBackColor = true;
            // 
            // dtTimePicker
            // 
            this.dtTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtTimePicker.Checked = false;
            this.dtTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimePicker.Location = new System.Drawing.Point(159, 56);
            this.dtTimePicker.Name = "dtTimePicker";
            this.dtTimePicker.ShowCheckBox = true;
            this.dtTimePicker.ShowUpDown = true;
            this.dtTimePicker.Size = new System.Drawing.Size(98, 22);
            this.dtTimePicker.TabIndex = 63;
            this.dtTimePicker.TabStop = false;
            this.dtTimePicker.ValueChanged += new System.EventHandler(this.dtTimePicker_ValueChanged);
            // 
            // dtDatePicker
            // 
            this.dtDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDatePicker.Checked = false;
            this.dtDatePicker.CustomFormat = "";
            this.dtDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatePicker.Location = new System.Drawing.Point(73, 56);
            this.dtDatePicker.Name = "dtDatePicker";
            this.dtDatePicker.Size = new System.Drawing.Size(85, 22);
            this.dtDatePicker.TabIndex = 62;
            this.dtDatePicker.TabStop = false;
            // 
            // AssetRenewal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 212);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AssetRenewal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Renewal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnValidUnlimited;
        private System.Windows.Forms.RadioButton rbtnValidUntil;
        private System.Windows.Forms.RadioButton rbtnValidToday;
        private System.Windows.Forms.DateTimePicker dtTimePicker;
        private System.Windows.Forms.DateTimePicker dtDatePicker;
        private System.Windows.Forms.Label lblSubmittingInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}