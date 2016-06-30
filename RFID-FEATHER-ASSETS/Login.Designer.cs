namespace RFID_FEATHER_ASSETS
{
    partial class LoginActivity
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserPasswordRequired = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSigningIn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCompanyList = new System.Windows.Forms.ComboBox();
            this.lblCompanyRequired = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUserName.Location = new System.Drawing.Point(33, 78);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(178, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPassword.Location = new System.Drawing.Point(33, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(178, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Orange;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(33, 176);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(126, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserPasswordRequired
            // 
            this.lblUserPasswordRequired.AutoSize = true;
            this.lblUserPasswordRequired.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserPasswordRequired.ForeColor = System.Drawing.Color.Red;
            this.lblUserPasswordRequired.Location = new System.Drawing.Point(30, 155);
            this.lblUserPasswordRequired.Name = "lblUserPasswordRequired";
            this.lblUserPasswordRequired.Size = new System.Drawing.Size(184, 13);
            this.lblUserPasswordRequired.TabIndex = 8;
            this.lblUserPasswordRequired.Text = "User Name and Password is required.";
            this.lblUserPasswordRequired.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(83, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "LOGIN";
            // 
            // lblSigningIn
            // 
            this.lblSigningIn.AutoSize = true;
            this.lblSigningIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSigningIn.ForeColor = System.Drawing.Color.Black;
            this.lblSigningIn.Location = new System.Drawing.Point(85, 220);
            this.lblSigningIn.Name = "lblSigningIn";
            this.lblSigningIn.Size = new System.Drawing.Size(88, 16);
            this.lblSigningIn.TabIndex = 10;
            this.lblSigningIn.Text = "Signing In...";
            this.lblSigningIn.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(227, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "COMPANY";
            this.label3.Visible = false;
            // 
            // cboCompanyList
            // 
            this.cboCompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompanyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboCompanyList.FormattingEnabled = true;
            this.cboCompanyList.Items.AddRange(new object[] {
            "Company1",
            "Company2"});
            this.cboCompanyList.Location = new System.Drawing.Point(230, 87);
            this.cboCompanyList.Name = "cboCompanyList";
            this.cboCompanyList.Size = new System.Drawing.Size(178, 24);
            this.cboCompanyList.TabIndex = 5;
            this.cboCompanyList.Visible = false;
            this.cboCompanyList.SelectedIndexChanged += new System.EventHandler(this.cboCompanyList_SelectedIndexChanged);
            // 
            // lblCompanyRequired
            // 
            this.lblCompanyRequired.AutoSize = true;
            this.lblCompanyRequired.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompanyRequired.ForeColor = System.Drawing.Color.Red;
            this.lblCompanyRequired.Location = new System.Drawing.Point(303, 69);
            this.lblCompanyRequired.Name = "lblCompanyRequired";
            this.lblCompanyRequired.Size = new System.Drawing.Size(105, 13);
            this.lblCompanyRequired.TabIndex = 12;
            this.lblCompanyRequired.Text = "Company is required.";
            this.lblCompanyRequired.Visible = false;
            // 
            // LoginActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(243, 251);
            this.Controls.Add(this.lblCompanyRequired);
            this.Controls.Add(this.cboCompanyList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSigningIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUserPasswordRequired);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feather Assets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginActivity_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserPasswordRequired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSigningIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCompanyList;
        private System.Windows.Forms.Label lblCompanyRequired;
    }
}

