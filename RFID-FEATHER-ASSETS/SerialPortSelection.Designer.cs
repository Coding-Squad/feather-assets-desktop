namespace RFID_FEATHER_ASSETS
{
    partial class SerialPortSelection
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComPortList = new System.Windows.Forms.ComboBox();
            this.btnSerialPortOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serial Port:";
            // 
            // cmbComPortList
            // 
            this.cmbComPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComPortList.FormattingEnabled = true;
            this.cmbComPortList.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.cmbComPortList.Location = new System.Drawing.Point(103, 24);
            this.cmbComPortList.Name = "cmbComPortList";
            this.cmbComPortList.Size = new System.Drawing.Size(62, 21);
            this.cmbComPortList.TabIndex = 7;
            // 
            // btnSerialPortOK
            // 
            this.btnSerialPortOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialPortOK.Location = new System.Drawing.Point(103, 51);
            this.btnSerialPortOK.Name = "btnSerialPortOK";
            this.btnSerialPortOK.Size = new System.Drawing.Size(62, 32);
            this.btnSerialPortOK.TabIndex = 9;
            this.btnSerialPortOK.Text = "OK";
            this.btnSerialPortOK.UseVisualStyleBackColor = true;
            this.btnSerialPortOK.Click += new System.EventHandler(this.btnSerialPortOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Make sure the Reader is connected.";
            // 
            // SerialPortSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 90);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSerialPortOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbComPortList);
            this.Name = "SerialPortSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM Port Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSerialPortOK;
        public System.Windows.Forms.ComboBox cmbComPortList;
        private System.Windows.Forms.Label label1;
    }
}