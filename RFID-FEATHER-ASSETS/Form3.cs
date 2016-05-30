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
        public MainMenu(string portnamesource)
        {
            InitializeComponent();
            cmbComPort.Text = portnamesource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbComPort.Text))
            {
                MessageBox.Show("Please select Port number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbComPort.Focus();
                return;
            }
            else
            {
                //TODO RFID SCAN CODE MISSING
                this.Hide();
                Verification m = new Verification(cmbComPort.Text);
                m.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbComPort.Text))
            {
                MessageBox.Show("Please select Port number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbComPort.Focus();
                return;
            }
            else
            {
                this.Hide();
                AssetRegistration registerAsset = new AssetRegistration(cmbComPort.Text);
                registerAsset.Show();
            } 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
