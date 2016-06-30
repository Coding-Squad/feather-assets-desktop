using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RFID_FEATHER_ASSETS
{
    public partial class MainMenu : Form
    {
        string tokenvalue;
        string roleValue;
        public MainMenu(string tokenvaluesource, /*string portnamesource,*/ string roleSource)
        {
            InitializeComponent();
            //cmbComPort.Text = portnamesource;
            tokenvalue = tokenvaluesource;
            roleValue = roleSource;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(cmbComPort.Text))
            {
                MessageBox.Show("Please select Port number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbComPort.Focus();
                return;
            }
            else
            {*/
                //TODO RFID SCAN CODE MISSING
                this.Hide();
                Verification m = new Verification();//tokenvalue, roleValue);
                m.Show();
            //}
        }

        private void btnRegisterAsset_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(cmbComPort.Text))
            {
                MessageBox.Show("Please select Port number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbComPort.Focus();
                return;
            }
            else
            {*/
                this.Hide();
                AssetRegistration registerAsset = new AssetRegistration();
                registerAsset.Show();
            //} 
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterUser registerUser = new RegisterUser(tokenvalue);
            registerUser.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMyAssets_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assets assets = new Assets(/*tokenvalue, roleValue*/);
            assets.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginActivity LoginForm = new LoginActivity();
            LoginForm.Show();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionHistory transactionHistory = new TransactionHistory();
            transactionHistory.Show();
        }
    }
}
