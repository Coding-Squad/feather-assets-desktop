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
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using RestSharp;
using System.Net;
using RestSharp.Deserializers;
using AForge.Video.DirectShow;
using AForge.Video;

namespace RFID_FEATHER_ASSETS
{
    public partial class AssetRegistration : Form
    {
        ////string str = "Data Source=DESKTOPI5-PC\\MSSQL2014;Initial Catalog=RFID;User ID=sa;Password=systemadmin";
        //string connectionString = "server=128.199.83.107;port=3306;uid=root;pwd=aws123;database=feather_assets;";

        private Reader.ReaderMethod reader;
        private ReaderSetting m_curSetting = new ReaderSetting();
        private InventoryBuffer m_curInventoryBuffer = new InventoryBuffer();
        private List<RealTimeTagData> RealTimeTagDataList = new List<RealTimeTagData>();
        private bool m_bDisplayLog = false;
        private int m_nTotal = 0;
        string portname;// = "COM3";
        string baudrate = "115200";
        string tokenvalue;
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        bool IsCameraConnected = false;

        public AssetRegistration(string tokenvaluesource, string portnamesource)
        {
            InitializeComponent();
            InitializeCamera();

            portname = portnamesource;
            tokenvalue = tokenvaluesource;
            InitializeOwner();
        }

        private void InitializeOwner()
        {
            var company = 1;

            RestClient client = new RestClient("http://feather-assets.herokuapp.com/"/*"52.163.93.95:8080/FeatherAssets/"*/);
            RestRequest ownerName = new RestRequest("/api/user/list/" + company, Method.GET);

            var authToken = tokenvalue;

            ownerName.RequestFormat = DataFormat.Json;
            ownerName.AddHeader("Content-Type", "application/json; charset=utf-8");
            ownerName.AddHeader("X-Auth-Token", authToken);

            var response = client.Execute<List<Owner>>(ownerName);
            var content = response.Content;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                JsonDeserializer deserial = new JsonDeserializer();
                List<Owner> owner = deserial.Deserialize<List<Owner>>(response);


                this.comboOwner.DataSource = owner;
                this.comboOwner.ValueMember = "userId";
                this.comboOwner.DisplayMember = "fullName";
            }
            else
            {
                MessageBox.Show("Unable to reach server.. please try again later", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartCamera()
        {
            cam = new VideoCaptureDevice(webcam[comVideoDeviceBox.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //reader.CloseCom();
            //MainMenu MenuForm = new MainMenu(tokenvalue, portname);
            //MenuForm.Show();
            CallMainMenu();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRFIDTag.Text.Length == 0 || txtAssetName.Text.Length == 0 || txtDescription.Text.Length == 0 || txtTakeOutNote.Text.Length == 0 || imgCapture1.Image == null)
                {
                    MessageBox.Show("Complete information is required.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //btnBrowseImage.Focus();
                    btnCaptureImg.Focus();
                    return;
                }
                /*if (!CheckDuplicateRFID())
                {
                    MessageBox.Show("RFID Tag is already assigned.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRFIDTag.Focus();
                    return;
                }*/

                //For MySqlConnection
                //MySqlConnection con = new MySqlConnection(connectionString);
                //con.Open();
                //MySqlCommand cmd = new MySqlCommand("insert into asset(rfid_tag,company_id,name,description,images,take_out_allowed,take_out_info,created_at,updated_at) values (@rfid_tag,@company_id,@name,@description,@images,@take_out_allowed,@take_out_info,@created_at,@updated_at)", con);
                //cmd.Parameters.AddWithValue("@rfid_tag", txtRFIDTag.Text);
                ////cmd.Parameters.AddWithValue("@owner_id", 1);
                //cmd.Parameters.AddWithValue("@company_id", 1);
                //cmd.Parameters.AddWithValue("@name", txtAssetName.Text);
                //cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                //if (radbtnYes.Checked)
                //{
                //    cmd.Parameters.AddWithValue("@take_out_allowed", 1);
                //}
                //else
                //{
                //    cmd.Parameters.AddWithValue("@take_out_allowed", 0);
                //}
                //cmd.Parameters.AddWithValue("@take_out_info", txtTakeOutNote.Text);
                ////cmd.Parameters.AddWithValue("@Section", combosec.SelectedItem.ToString());  
                //cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                //cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                //cmd.Parameters.AddWithValue("@images", txtImagePath.Text);

                //cmd.ExecuteNonQuery();
                //con.Close();
                //MessageBox.Show("Asset successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearFields();

                //For Web Service
                //HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("http://feather-assets.herokuapp.com/");
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(
                //   new MediaTypeWithQualityHeaderValue("application/json"));

                Asset asset = new Asset();

                int oId;
                bool parseOK = Int32.TryParse(comboOwner.SelectedValue.ToString(), out oId);

                asset.tag = txtRFIDTag.Text;
                asset.tagType = 1;
                asset.companyId = 1;
                asset.ownerId = oId;
                asset.name = txtAssetName.Text;
                asset.description = txtDescription.Text;
                //if (radbtnYes.Checked)
                //{
                //    asset.takeOutAllowed = true;
                //}
                //else
                //{
                //    asset.takeOutAllowed = false;
                //}
                asset.takeOutInfo = txtTakeOutNote.Text;
                asset.imageUrls = txtCapturedImagePath.Text;//txtImagePath.Text;

                //var response = client.PostAsJsonAsync("api/asset", AssetDet).Result;

                RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
                RestRequest register = new RestRequest("/api/asset/add", Method.POST);
                var authToken = tokenvalue;

                register.AddHeader("X-Auth-Token", authToken);
                register.AddHeader("Content-Type", "application/json; charset=utf-8");
                register.RequestFormat = DataFormat.Json;
                register.AddBody(asset);

                btnSubmit.Text = "Submitting...";
                this.Refresh();
                IRestResponse response = client.Execute(register);
                btnSubmit.Text = "Submit";

                var content = response.Content;

                if (response.StatusCode == HttpStatusCode.OK)//if (response.IsSuccessStatusCode)
                {
                    JsonDeserializer deserial = new JsonDeserializer();
                    RestResult restResult = deserial.Deserialize<RestResult>(response);

                    if (restResult.result == "OK")
                    {
                        MessageBox.Show("Asset successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(restResult.result + " " + restResult.message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Error Code " +
                    response.StatusCode /*+ " : Message - " + response.ErrorMessage*/);
                    return;
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            txtRFIDTag.Text = string.Empty;
            //comboOwner.Items.Clear();
            txtAssetName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            //radbtnYes.Checked = false;
            txtTakeOutNote.Text = string.Empty;
            picOwner.Image = null;
            //btnBrowseImage.Focus();
            txtCapturedImagePath.Text = string.Empty;
            btnCaptureImg.Focus();
        }

        //private bool CheckDuplicateRFID()
        //{
        ////SqlConnection con = new SqlConnection(connectionString);
        ////con.Open();
        ////SqlCommand cmd = new SqlCommand("select * from asset where rfid_tag='" + txtRFIDTag.Text + "'", con);
        ////SqlDataReader rd = cmd.ExecuteReader();
        //MySqlConnection con = new MySqlConnection(connectionString);
        //con.Open();
        //MySqlCommand cmd = new MySqlCommand("select * from asset where rfid_tag='" + txtRFIDTag.Text + "'", con);
        //MySqlDataReader rd = cmd.ExecuteReader();
        //if (rd.HasRows)
        //{
        //    rd.Close();
        //    return false;
        //}
        //else
        //{
        //    rd.Close();
        //    return true;
        //}
        //} 

        private void RegisterAsset_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //reader.CloseCom();
            //MainMenu MenuForm = new MainMenu(tokenvalue, portname);
            //MenuForm.Show();
            CallMainMenu();
        }

        private void comboOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from User_Master where first_name ='" + comboOwner.Text.Trim() + "'", con);
            //SqlDataReader rd = cmd.ExecuteReader();

            //while (rd.Read())
            //{
            //    ownerid = rd["user_id"].ToString();
            //}
            //rd.Close();
        }

        private void comboOwner_DropDown(object sender, EventArgs e)
        {
            //comboOwner.Items.Clear();

            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from User_Master", con);
            //SqlDataReader rd = cmd.ExecuteReader();

            //while (rd.Read())
            //{
            //    comboOwner.Items.Add(rd["first_name"].ToString());
            //}
            //rd.Close(); 
        }

        private void btnGetRFIDTag_Click(object sender, EventArgs e)
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
                    txtAssetName.Focus();
                }
            }
            //else if (nReturnValue == 0)
            //{
            //    MessageBox.Show("Successful execution of the command but no inventory to tag");
            //}
            else if (nReturnValue == -1)
            {
                MessageBox.Show("Com Port Error", "Asset Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cam.Stop();
                CallMainMenu();
                //MessageBox.Show("Com port Error");
            }
            else if (nReturnValue == -2)
            {
                //MessageBox.Show("Com Port Error");
                MessageBox.Show("Com Port Error", "Asset Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cam.Stop();
                CallMainMenu();
            }
            else
            {
                return;
            }
        }

        private void CallMainMenu()
        {
            if (IsCameraConnected)
                cam.Stop();

            this.Hide();
            reader.CloseCom();
            MainMenu MenuForm = new MainMenu(tokenvalue, portname, string.Empty);
            MenuForm.Show();
        }

        private void RegisterAsset_Load(object sender, EventArgs e)
        {
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

        private void InitializeCamera()
        {
            comVideoDeviceBox.Items.Clear();
            cameraBox.Image = null;

            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comVideoDeviceBox.Items.Add(VideoCaptureDevice.Name);
            }

            if (comVideoDeviceBox.Items.Count < 1)
            {
                if (cam != null) cam.Stop();
                IsCameraConnected = false;
                cameraBox.BackColor = Color.Black;
                lblNoCameraAvailable.Visible = true;
                btnCaptureImg.Text = "Refresh Camera";
            }
            else
            {
                comVideoDeviceBox.SelectedIndex = 0;
                StartCamera();

                IsCameraConnected = true;
                cameraBox.BackColor = Color.White;
                lblNoCameraAvailable.Visible = false;
                btnCaptureImg.Text = "Capture Image";
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

        OpenFileDialog fd1 = new OpenFileDialog();

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            fd1.Filter = "image files|*.jpg;*.png;*.gif;*.icon;.*;";

            DialogResult dres1 = fd1.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;

            //if (!CheckDuplicatePicture())
            //{
            //    MessageBox.Show("Picture is already assigned.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    btnBrowseImage.Focus();
            //    return;
            //}
            //else
            //{
            txtImagePath.Text = fd1.FileName;

            picOwner.Image = Image.FromFile(fd1.FileName);
            MemoryStream ms1 = new MemoryStream();
            picOwner.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            //}
        }

        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            cameraBox.Image = bit;
        }

        private void btnCaptureImg_Click(object sender, EventArgs e)
        {
            if (cam == null || btnCaptureImg.Text == "Refresh Camera")
            {
                InitializeCamera();
            }
            else if (IsCameraConnected)
            {
                if (imgCapture1.Image == null) imgCapture1.Image = cameraBox.Image;
                else if (imgCapture2.Image == null) imgCapture2.Image = cameraBox.Image;
                else if (imgCapture3.Image == null) imgCapture3.Image = cameraBox.Image;
                else if (imgCapture4.Image == null) imgCapture4.Image = cameraBox.Image;
                else if (imgCapture5.Image == null) imgCapture5.Image = cameraBox.Image;
                else
                {
                    MessageBox.Show("Captured Images exceeds the maximum limit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cam.Stop();
                //saveFileDialog1.InitialDirectory = @"C:\Users\USER\Pictures\";
                //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    cameraBox.Image.Save(saveFileDialog1.FileName + ".jpg");
                //}
                //btnCaptureImg.Text = "Capturing Image. Please wait ...";
                //btnCaptureImg.Refresh();

                string dirPath = @"C:\Users\USER\Pictures\";//"C:\Users\";
                string fileName = "Image";
                string[] files = Directory.GetFiles(dirPath);
                int count = files.Count(file => { return file.Contains(fileName); });

                string newFileName = (count == 0) ? "Image.jpg" : String.Format("{0}{1}.jpg", fileName, count + 1);

                cameraBox.Image.Save(dirPath + newFileName);
                txtCapturedImagePath.Text = txtCapturedImagePath.Text + "," + dirPath + newFileName;

                //MessageBox.Show("Image successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                //StartCamera();
                InitializeCamera();
            }
            //else
            //{
            //    cam.Stop();
            //    return;
            //}

        }


        //private bool CheckDuplicatePicture()
        //{
        //    MySqlConnection con = new MySqlConnection(connectionString);
        //    con.Open();
        //    MySqlCommand cmd = new MySqlCommand("select * from asset where images like '%" + Path.GetFileName(fd1.FileName) + "%'", con);
        //    MySqlDataReader rd = cmd.ExecuteReader();
        //    if (rd.HasRows)
        //    {
        //        rd.Close();
        //        return false;
        //    }
        //    else
        //    {
        //        rd.Close();
        //        return true;
        //    }
        //}

    }

    public class Asset
    {
        public string tag { get; set; }
        public int tagType { get; set; }
        public int companyId { get; set; }
        public int ownerId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool takeOutAllowed { get; set; }
        public string takeOutInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string imageUrls { get; set; }
    }

    public class Owner
    {
        public int userId { get; set; }
        public int companyId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string position { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public string email { get; set; }
        public string authorities { get; set; }
        public string fullName { get { return lastName + ", " + firstName; } }
    }

    public class RestResult
    {
        public string result { get; set; }
        public string message { get; set; }
    }
}
