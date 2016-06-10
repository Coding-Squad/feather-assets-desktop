﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UHFDemo;
using System.IO;
using RestSharp;
using System.Net;
using RestSharp.Deserializers;
using System.Threading;

namespace RFID_FEATHER_ASSETS
{
    public partial class Verification : Form
    {
        //string connectionString = "server=128.199.83.107;port=3306;uid=root;pwd=aws123;database=feather_assets;";

        private Reader.ReaderMethod reader;
        private ReaderSetting m_curSetting = new ReaderSetting();
        private InventoryBuffer m_curInventoryBuffer = new InventoryBuffer();
        private List<RealTimeTagData> RealTimeTagDataList = new List<RealTimeTagData>();
        private bool m_bDisplayLog = false;
        private int m_nTotal = 0;
        string portname; //= "COM3";
        string baudrate = "115200";
        bool IsPortError = false;
        string tokenvalue;
        bool IsCallingMainMenu = false;
        string roleValue;

        public Verification(string tokenvaluesource, string portnamesource, string roleSource)
        {
            InitializeComponent();

            portname = portnamesource;
            tokenvalue = tokenvaluesource;
            roleValue = roleSource;
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
            try
            {
                //ClearTimer.Interval = 7000;
                //VerifyTimer.Interval = 7000;
                BackgroundTimer.Interval = 250;

                CurrentDateTimer.Enabled = true;
                CurrentDateTimer.Interval = 1000;

                reader = new Reader.ReaderMethod();
                //Callback
                reader.AnalyCallback = AnalyData;
                reader.ReceiveCallback = ReceiveData;
                reader.SendCallback = SendData;
                auto_connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
        }

        private void btnVerifyAsset_Click(object sender, EventArgs e)
        {
            //try
            //{ 
            //    int nReturnValue = 0;
            //    string tagInfo = "";

            //    nReturnValue = realTimeInventory(255, 255, 1);  //Public address reader , fast inventory mode , 5 seconds timeout control

            //    if (nReturnValue == 1)
            //    {
            //        for (int i = 0; i < RealTimeTagDataList.Count; i++)
            //        {
            //            tagInfo = RealTimeTagDataList[i].strEpc;//tagInfo = RealTimeTagDataList[i].btAntId.ToString() + "    " + RealTimeTagDataList[i].strEpc + "    ";// tagInfo = "antenna" + RealTimeTagDataList[i].btAntId.ToString() + "    " + RealTimeTagDataList[i].strEpc + "    " + RealTimeTagDataList[i].strCarrierFrequency + "    " + RealTimeTagDataList[i].strRssi;
            //            //listBox1.Items.Add(tagInfo);
            //            txtRFIDTag.Text = tagInfo.ToString();
            //        }

            //        CheckRFIDTag();
            //    }
            //    //else if (nReturnValue == 0)
            //    //{
            //    //    MessageBox.Show("Successful execution of the command but no inventory to tag");
            //    //}
            //    else if (nReturnValue == -1)
            //    {
            //        MessageBox.Show("Reader Com Port Error.", "Asset Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        IsPortError = true;
            //        return;

            //        //LoopVerification();
            //        //MessageBox.Show("Reader Com Port Error");
            //    }
            //    else if (nReturnValue == -2)
            //    {
            //        //MessageBox.Show("Reader Com Port Error");
            //        MessageBox.Show("Reader Com Port Error.", "Asset Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        IsPortError = true;
            //        return;

            //        //LoopVerification();
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void CheckRFIDTag()
        {
            try
            { 
                //btnVerifyAsset.Text = "Verifying Tag. Please wait ...";
                //btnVerifyAsset.BackColor = Color.GreenYellow;
                //btnVerifyAsset.Refresh();
                lblLoadingInformation.Visible = true;
                lblLoadingInformation.Refresh();

                VerifyRequest verifyRequest = new VerifyRequest();
                verifyRequest.tag = txtRFIDTag.Text;
                verifyRequest.companyId = 1;
                verifyRequest.tagType = 1;

                //initialize web service
                RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
                RestRequest verify = new RestRequest("/api/asset/verify", Method.POST);
                var authToken = tokenvalue;

                verify.AddHeader("X-Auth-Token", authToken);
                verify.AddHeader("Content-Type", "application/json; charset=utf-8");
                verify.RequestFormat = DataFormat.Json;
                verify.AddBody(verifyRequest);

                //retrieve response
                IRestResponse response = client.Execute(verify);
                var content = response.Content;

                //btnVerifyAsset.Text = "Click to verify RFID Tag";
                //btnVerifyAsset.BackColor = Color.Orange;
                lblLoadingInformation.Visible = false;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //deserialize JSON -> Object
                    JsonDeserializer deserial = new JsonDeserializer();
                    VerifyResult verifyResult = deserial.Deserialize<VerifyResult>(response);

                    if (verifyResult.result == "OK")
                    {
                        txtAssetName.Text = verifyResult.name;
                        txtDescription.Text = verifyResult.description;
                        //if (Boolean.Parse(verifyResult.takOutAllowed.ToString()))
                        //{
                        //    txtTakeOutAvailability.Text = "Allowed to take-out.";
                        //}
                        //else
                        //{
                        //    txtTakeOutAvailability.Text = "Not allowed to take-out.";
                        //}
                        txtTakeOutNote.Text = verifyResult.takeOutInfo;
                        //if (File.Exists(verifyResult.imageUrls))
                        //{
                            //picOwner.Image = Image.FromFile(verifyResult.imageUrls);

                            string Urls = verifyResult.imageUrls;
                            string[] ReadUrls = Urls.Split(',');
                            foreach (string GetUrls in ReadUrls)
                            {
                                if (ReadUrls.Length > 1 && File.Exists(ReadUrls[1])) imgCapture1.Image = Image.FromFile(ReadUrls[1]);
                                if (ReadUrls.Length > 2 && File.Exists(ReadUrls[2])) imgCapture2.Image = Image.FromFile(ReadUrls[2]);
                                if (ReadUrls.Length > 3 && File.Exists(ReadUrls[3])) imgCapture3.Image = Image.FromFile(ReadUrls[3]);
                                if (ReadUrls.Length > 4 && File.Exists(ReadUrls[4])) imgCapture4.Image = Image.FromFile(ReadUrls[4]);
                                if (ReadUrls.Length > 5 && File.Exists(ReadUrls[5])) imgCapture5.Image = Image.FromFile(ReadUrls[5]);
                            }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Image not found for this path: " + verifyResult.imageUrls, "Asset Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    //btnVerifyAsset.Focus();
                        //    //return;
                        //}
                        //this.Refresh();

                        //VerifyTimer.Stop();
                        //VerifyTimer.Start();

                        //ClearTimer.Stop();
                        //ClearTimer.Start();

                        return;
                    }
                    else
                    {
                        MessageBox.Show(verifyResult.result + " " + verifyResult.message);
                        //MessageBox.Show("RFID Tag: " + txtRFIDTag.Text + " " + verifyResult.message);
                    }

                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Error connecting to server.. please try again later");
                }
                else
                {
                    HttpStatusCode statusCode = response.StatusCode;
                    int numericStatusCode = (int)statusCode;
                    //show error code
                    MessageBox.Show("Error" + numericStatusCode);
                }

                ClearFields();

                #region old connection
                /*MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from asset where rfid_tag='" + txtRFIDTag.Text + "'", con);
                MySqlDataReader rd = cmd.ExecuteReader();
                */
            

                /*if (rd.Read())
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
                }*/
                /*else
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
                
                }*/
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            //ClearFields();
            //ClearTimer.Stop();
        }

        private void ClearFields()
        {
            imgCapture1.Image = null;
            imgCapture2.Image = null;
            imgCapture3.Image = null;
            imgCapture4.Image = null;
            imgCapture5.Image = null;
            txtRFIDTag.Text = string.Empty;
            txtAssetName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtOwnerName.Text = string.Empty;
            //txtTakeOutAvailability.Text = string.Empty;
            txtTakeOutNote.Text = string.Empty;
            //picOwner.Image = null;
            //btnVerifyAsset.Focus();
            this.Refresh();
        }

        private void Verification_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            LoopVerification(); 
        }

        private void LoopVerification()
        {
            //while (IsPortError == false)
            //{
            //    //btnVerifyAsset.PerformClick();
            //    VerifyAssetProc();
            //}

            //RFID Reader Loop
            if (IsPortError == false)
            {
                BackgroundTimer.Stop();
                BackgroundTimer.Start();
            }
            else //(IsPortError)
            {
                CallMainMenu();
            }
        }

        private void VerifyAssetProc()
        {
            try
            { 
                int nReturnValue = 0;
                string tagInfo = "";

                nReturnValue = realTimeInventory(255, 255, 1);  //Public address reader , fast inventory mode , 5 seconds timeout control

                if (nReturnValue == 1)
                {
                    ClearFields();

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
                    MessageBox.Show("Reader Com Port Error.", "Asset Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsPortError = true;
                    //return;

                    //LoopVerification();
                }
                else if (nReturnValue == -2)
                {
                    MessageBox.Show("Reader Com Port Error.", "Asset Verification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IsPortError = true;
                    //return;

                    //LoopVerification();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VerifyTimer_Tick(object sender, EventArgs e)
        {
            ////ClearFields();
            //VerifyTimer.Stop();
            //LoopVerification();
        }

        private void Verification_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (roleValue == "ROLE_ADMIN")
            {
                CallMainMenu();
            }
            else if (roleValue == "ROLE_GUARD")
            {
                Environment.Exit(0);
            }
        }

        private void CallMainMenu()
        {
            //Return to Main Menu Form
            IsCallingMainMenu = true;

            this.Hide();
            reader.CloseCom();
            MainMenu MenuForm = new MainMenu(tokenvalue, portname, roleValue);
            MenuForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (roleValue == "ROLE_ADMIN")
            {
                CallMainMenu();
            }
            else if (roleValue == "ROLE_GUARD")
            {
                Environment.Exit(0);
            }
        }

        private void BackgroundTimer_Tick(object sender, EventArgs e)
        {
            //Always read the RFID Tag if not calling the Main Menu
            if (!IsCallingMainMenu)
            {
                BackgroundTimer.Stop();
                VerifyAssetProc();
                LoopVerification();
            }
        }

        private void CurrentTimer_Tick(object sender, EventArgs e)
        {
            //Display the current date and time
            lblCurrentDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy h:mm:ss tt");
        }
    }

    public class VerifyRequest
    {
        public int companyId {get; set;}

        public string tag {get; set;}

        public int tagType{get; set;}
    }

    public class VerifyResult
    {
        public string name {get; set;}

        public string description {get;set;}

        public string imageUrls {get;set;}

        public bool takOutAllowed {get;set;}

        public string takeOutInfo {get;set;}

        public string result {get;set;}

        public string message {get;set;}

    }
}

