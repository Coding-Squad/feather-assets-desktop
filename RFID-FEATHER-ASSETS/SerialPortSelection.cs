using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_FEATHER_ASSETS
{
    public partial class SerialPortSelection : Form
    {
        string roleValue;
        string tokenvalue;

        public SerialPortSelection(string tokenvaluesource, string roleSource)
        {
            InitializeComponent();

            GetSavedSerialPort();
            tokenvalue = tokenvaluesource;
            roleValue = roleSource;
        }

        private void GetSavedSerialPort()
        {
            try
            {
                //opening the subkey  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AssetSystemInfo");

                //if it does exist, retrieve the stored values  
                if (key != null)
                {
                    cmbComPortList.Text = (string)(key.GetValue("DefaultPortName"));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSerialPortOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbComPortList.Text.Trim()))
                {
                    //accessing the CurrentUser root element  
                    //and adding "PortName" subkey to the "SOFTWARE" subkey  
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AssetSystemInfo");

                    //storing the values  
                    key.SetValue("DefaultPortName", cmbComPortList.Text);
                    key.Close();

                    DialogResult = DialogResult.OK;
                    //this.Dispose();
                }
                else
                {
                    MessageBox.Show("Please select Com Port No.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbComPortList.Focus();
                    return;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //ValidateRule();
            this.Dispose();
            DialogResult = DialogResult.Cancel;
        }

        private void ValidateRule()
        {
            //if (roleValue == "ROLE_ADMIN")
            //{
            //    DialogResult = DialogResult.Cancel;
            //    //this.Dispose();//CallMainMenu();
            //}
            //else if (roleValue == "ROLE_GUARD")
            //{
            //    Environment.Exit(0);
            //}
        }
    }
}
