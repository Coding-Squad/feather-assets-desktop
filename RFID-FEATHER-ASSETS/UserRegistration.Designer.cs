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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(112, 19);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(159, 20);
            this.firstName.TabIndex = 5;
            this.firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(113, 135);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(159, 39);
            this.description.TabIndex = 6;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(112, 94);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(159, 20);
            this.position.TabIndex = 7;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(112, 54);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(159, 20);
            this.lastName.TabIndex = 8;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(113, 191);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(159, 20);
            this.email.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(200, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(112, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(307, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.position);
            this.Controls.Add(this.description);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterUser";
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.RegisterUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}