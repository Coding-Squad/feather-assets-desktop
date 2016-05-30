using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using UHFDemo;
using System.IO;
using MySql.Data.MySqlClient;
//using System.Threading;

namespace RFID_FEATHER_ASSETS
{
    public partial class Verification : Form
    {
        string connectionString = "server=128.199.83.107;port=3306;uid=root;pwd=aws123;database=feather_assets;";

        private Reader.ReaderMethod reader;
        private ReaderSetting m_curSetting = new ReaderSetting();
        private InventoryBuffer m_curInventoryBuffer = new InventoryBuffer();
        private List<RealTimeTagData> RealTimeTagDataList = new List<RealTimeTagData>();
        private bool m_bDisplayLog = false;
        private int m_nTotal = 0;
        string portname; //= "COM3";
        string baudrate = "115200";
        bool IsPortError = false;

        public Verification(string portnamesource)
        {
            InitializeComponent();
            portname = portnamesource;
        }

        private void auto_connect()
        {
            try // Await the task in a try block
            {
                string strException = string.Empty; // 
                string strComPort = portname;
                int nBaudrate = Convert.ToInt32(baudrate);////Convert.ToInt32(BaudBox.Text);

                int nRet = reader.OpenCom(strComPort, nBaudrate, out strException);

                ////string strLog = "Connection readers" + strComPort + "@" + nBaudrate.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Verification_Load(object sender, EventArgs e)
        {
            ////RFID Compare & Verify
            //string constring = "datasource=128.199.83.107;port=3306;Database=feather_assets;username=root;password=aws123";
            //string Query = "select * from asset WHERE rfid_tag = ";
            //MySqlConnection conn = new MySqlConnection(constring);
            //MySqlCommand command = new MySqlCommand(Query, conn);
            //MySqlDataReader myReader = command.ExecuteReader();
          
                
            //    while (myReader.Read())
            //    {
            //        txtAssetName.Text = (myReader["name"].ToString());
            //        txtAssetOwner.Text = (myReader["description"].ToString());
            //        txtTakeOutAvailability.Text = (myReader["take_out_allowed"].ToString());
            //        txtTakeOutNote.Text = (myReader["take_out_info"].ToString());

            //    }
            //    myReader.Close();
            ClearTimer.Interval = 7000;
            VerifyTimer.Interval = 7000;

            try
            {
                reader = new Reader.ReaderMethod();
                //Callback
                reader.AnalyCallback = AnalyData;
                reader.ReceiveCallback = ReceiveData;
                reader.SendCallback = SendData;
                ////BaudBox.SelectedIndex = 1;
                auto_connect();
                ////countRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnVerifyAsset_Click(object sender, EventArgs e)
        {
            int nReturnValue = 0;
            string tagInfo = "";
            //listBox1.Items.Clear();

            nReturnValue = realTimeInventory(255, 255, 1);  //Public address reader , fast inventory mode , 5 seconds timeout control

            if (nReturnValue == 1)
            {
                for (int i = 0; i < RealTimeTagDataList.Count; i++)
                {
                    tagInfo = RealTimeTagDataList[i].strEpc;//tagInfo = RealTimeTagDataList[i].btAntId.ToString() + "    " + RealTimeTagDataList[i].strEpc + "    ";// tagInfo = "antenna" + RealTimeTagDataList[i].btAntId.ToString() + "    " + RealTimeTagDataList[i].strEpc + "    " + RealTimeTagDataList[i].strCarrierFrequency + "    " + RealTimeTagDataList[i].strRssi;
                    //listBox1.Items.Add(tagInfo);
                    txtRFIDTag.Text = tagInfo.ToString();
                }

                CheckRFIDTag();
            }
            //else if (nReturnValue == 0)
            //{
            //    MessageBox.Show("Successful execution of the command but no inventory to tag");
            //}
            else if (nReturnValue == -1)
            {
                MessageBox.Show("Com Port Error", "Asset Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsPortError = true;
                LoopVerification();
                //MessageBox.Show("Com port Error");
            }
            else if (nReturnValue == -2)
            {
                //MessageBox.Show("Com Port Error");
                MessageBox.Show("Com Port Error", "Asset Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IsPortError = true;
                LoopVerification();
            }
            else
            {
                return;
            }
        }

        private void CheckRFIDTag()
        {
            btnVerifyAsset.Text = "Verifying Tag. Please wait ...";

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from asset where rfid_tag='" + txtRFIDTag.Text + "'", con);
            MySqlDataReader rd = cmd.ExecuteReader();

            btnVerifyAsset.Text = "Click to verify RFID Tag";

            if (rd.Read())
            {
                txtAssetName.Text = (rd["name"].ToString());
                txtOwnerName.Text = (rd["description"].ToString());
                ////txtTakeOutAvailability.Text = (rd["take_out_allowed"].ToString());
                if (Boolean.Parse(rd["take_out_allowed"].ToString()))
                {
                    txtTakeOutAvailability.Text = "Allowed to take-out.";
                }
                else
                {
                    txtTakeOutAvailability.Text = "Not allowed to take-out.";
                }
                txtTakeOutNote.Text = (rd["take_out_info"].ToString());

                if (File.Exists(rd["images"].ToString()))
                {
                    picOwner.Image = Image.FromFile(rd["images"].ToString());
                }
                else 
                {
                    MessageBox.Show("Image not found for this path: " + rd["images"].ToString(), "Asset Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnVerifyAsset.Focus();
                    rd.Close();
                    return;
                }

                VerifyTimer.Stop();
                VerifyTimer.Start();

                ClearTimer.Stop();
                ClearTimer.Start();

                rd.Close();
                return;
            }
            else
            {
                rd.Close();
                DialogResult result = MessageBox.Show("RFID Tag not found. Do you want to register the asset?", "Asset Verification", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    reader.CloseCom();
                    AssetRegistration AssetForm = new AssetRegistration(portname);
                    AssetForm.Show();
                }
                else
                {
                    btnVerifyAsset.Focus();
                    return;
                }
                
            }
        }

        //start of the Reader's default codes//
        private void ReceiveData(byte[] btAryReceiveData)
        {
            try
            {
                if (m_bDisplayLog)
                {
                    string strLog = CCommondMethod.ByteArrayToString(btAryReceiveData, 0, btAryReceiveData.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendData(byte[] btArySendData)
        {
            try
            {
                if (m_bDisplayLog)
                {
                    string strLog = CCommondMethod.ByteArrayToString(btArySendData, 0, btArySendData.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AnalyData(Reader.MessageTran msgTran)
        {
            try
            {
                if (msgTran.PacketType != 0xA0)
                {
                    return;
                }
                switch (msgTran.Cmd)
                {
                    case 0x81:
                        ProcessReadTag(msgTran);
                        break;
                    case 0x89:
                        ProcessInventoryReal(msgTran);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessReadTag(Reader.MessageTran msgTran)
        {
            string strCmd = "Reading the label";
            string strErrorCode = string.Empty;
            if (msgTran.AryData.Length == 1)
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure reasons:" + strErrorCode;
                m_curSetting.btRealInventoryFlag = 100; //The reader returns the error message
            }
            else
            {
                RealTimeTagData tagData = new RealTimeTagData();
                int nLen = msgTran.AryData.Length;
                int nDataLen = Convert.ToInt32(msgTran.AryData[nLen - 3]);
                int nEpcLen = Convert.ToInt32(msgTran.AryData[2]) - nDataLen - 4;

                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, 2);
                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5, nEpcLen);
                string strCRC = CCommondMethod.ByteArrayToString(msgTran.AryData, 5 + nEpcLen, 2);
                string strData = CCommondMethod.ByteArrayToString(msgTran.AryData, 7 + nEpcLen, nDataLen);

                byte byTemp = msgTran.AryData[nLen - 2];
                byte byAntId = (byte)((byTemp & 0x03) + 1);


                tagData.strEpc = strEPC;
                tagData.strPc = strPC;
                tagData.strTid = strData;
                tagData.btAntId = byAntId;

                RealTimeTagDataList.Add(tagData);

                int nReaddataCount = msgTran.AryData[0] * 255 + msgTran.AryData[1]; //The total number of data
                if (RealTimeTagDataList.Count == nReaddataCount)  //All data received
                {
                    m_curSetting.btRealInventoryFlag = 1; //The reader returns the error message
                }
            }
        }

        private void ProcessInventoryReal(Reader.MessageTran msgTran)
        {
            string strCmd = "";
            strCmd = "Real-time inventory";
            string strErrorCode = string.Empty;

            if (msgTran.AryData.Length == 1) //You receive an error message packet
            {
                strErrorCode = CCommondMethod.FormatErrorCode(msgTran.AryData[0]);
                string strLog = strCmd + "Failure, failure reasons: " + strErrorCode;
                m_curSetting.btRealInventoryFlag = 100; //The reader return inventory error
                //WriteLog(RecordLogBox, strLog, 1);


            }
            else if (msgTran.AryData.Length == 7) //End packet received command
            {
                m_curInventoryBuffer.nReadRate = Convert.ToInt32(msgTran.AryData[1]) * 256 + Convert.ToInt32(msgTran.AryData[2]);
                m_curInventoryBuffer.nDataCount = Convert.ToInt32(msgTran.AryData[3]) * 256 * 256 * 256 + Convert.ToInt32(msgTran.AryData[4]) * 256 * 256 + Convert.ToInt32(msgTran.AryData[5]) * 256 + Convert.ToInt32(msgTran.AryData[6]);
                m_curSetting.btRealInventoryFlag = 1; //Inventory command ends successfully received packet
                //WriteLog(RecordLogBox, strCmd, 0);
            }
            else //Receive real-time tag data
            {
                m_nTotal++;
                int nLength = msgTran.AryData.Length;
                int nEpcLength = nLength - 4;
                RealTimeTagData tagData = new RealTimeTagData();

                string strEPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 3, nEpcLength);
                string strPC = CCommondMethod.ByteArrayToString(msgTran.AryData, 1, 2);
                string strRSSI = (msgTran.AryData[nLength - 1] - 129).ToString() + " dBm";
                byte btTemp = msgTran.AryData[0];
                byte btAntId = (byte)((btTemp & 0x03) + 1);
                byte btFreq = (byte)(btTemp >> 2);
                // string strFreq = GetFreqString(btFreq) + " MHz";

                tagData.strEpc = strEPC;
                tagData.strPc = strPC;
                tagData.strRssi = strRSSI;
                //tagData.strCarrierFrequency = strFreq;
                tagData.btAntId = btAntId;

                RealTimeTagDataList.Add(tagData);
            }
        }

        //Note: In the function call in this function and do not update interface, because the UI thread is waiting for this function returns.
        private int realTimeInventory(byte btReaderId, byte btRepeat, byte btTimeOut)
        {
            DateTime startTime;
            TimeSpan timeOutControl;

            //The method used here waiting for data, after all the data has been received for processing
            m_curSetting.btRealInventoryFlag = 0;
            RealTimeTagDataList.Clear();  //Empty tag information table
            reader.InventoryReal(255, 1); // To send real-time inventory command, with 0xFF public address, each command is repeated once inventory
            startTime = DateTime.Now;

            while (m_curSetting.btRealInventoryFlag == 0) //Wait for the reader to return data is completed, if timeout, returning timeout flag
            {
                timeOutControl = DateTime.Now - startTime;
                if (timeOutControl.TotalMilliseconds > btTimeOut * 1000)//Timeout Returns
                {
                    return -2;
                }
            }

            if (m_curSetting.btRealInventoryFlag == 1) //The command completed successfully
            {
                if (RealTimeTagDataList.Count > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            if (m_curSetting.btRealInventoryFlag == 100) //Command fails
            {
                return -1;
            }
            return 0;
        }

        private void ClearTimer_Tick(object sender, EventArgs e)
        {
            ClearFields();
            ClearTimer.Stop();
        }

        private void ClearFields()
        {
            txtRFIDTag.Text = string.Empty;
            txtAssetName.Text = string.Empty;
            txtOwnerName.Text = string.Empty;
            txtTakeOutAvailability.Text = string.Empty;
            txtTakeOutNote.Text = string.Empty;
            picOwner.Image = null;
            //btnVerifyAsset.Focus();
        }

        //private void VerifyTimer_Tick(object sender, EventArgs e)
        //{
        //    VerifyTimer.Start();
        //}

        private void Verification_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            LoopVerification(); 
        }

        private void LoopVerification()
        {
            ////while (string.IsNullOrEmpty(txtRFIDTag.Text) && IsPortError == false)
            ////{
            ////    btnVerifyAsset.PerformClick();
            ////}

            if (IsPortError)
            {
                this.Hide();
                reader.CloseCom();
                MainMenu MenuForm = new MainMenu(portname);
                MenuForm.Show();
            }
        }

        private void VerifyTimer_Tick(object sender, EventArgs e)
        {
            ClearFields();
            VerifyTimer.Stop();
            LoopVerification();
        }

        private void Verification_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            reader.CloseCom();
            MainMenu MenuForm = new MainMenu(portname);
            MenuForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            reader.CloseCom();
            MainMenu MenuForm = new MainMenu(portname);
            MenuForm.Show();
        }
    }
}

