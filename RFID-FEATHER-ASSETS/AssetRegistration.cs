﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UHFDemo;
using System.IO;
using RestSharp;
using System.Net;
using RestSharp.Deserializers;
using AForge.Video.DirectShow;
using AForge.Video;
using Microsoft.Win32;
using System.Drawing.Imaging;
using System.Threading;
using System.Resources;
using System.Globalization;
using System.Reflection;

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
        string roleValue;
        string language;
        int userId;
        int companyId;
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        bool IsCameraConnected = false;
        string newImgFileNames;
        string ImgFileName;
        string validUntilValue;
        int assetId;
        string updatedImgFileNames;
        string readerInfo;
        bool isCameraChanged = false;
        string cameraDeviceName;

        public AssetRegistration()//(string tokenvaluesource, string portnamesource)
        {
            InitializeComponent();

            //portname = portnamesource;
            //tokenvalue = tokenvaluesource;
            //roleValue = roleSource;
            GetAssetSystemInfo();
            getLanguage();
            languageHandler();
            //InitializeOwner();
            InitializeCamera();
            InitializePhotoLabel();
        }
        private void getLanguage()
        {
            try
            {
                //opening the subkey  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AssetSystemInfo");

                //if it does exist, retrieve the stored values  
                if (key != null)
                {
                    language = (string)(key.GetValue("Language"));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void languageHandler()
        {
            if (language == "Japanese")
            {
                ResourceManager rm = new ResourceManager("RFID_FEATHER_ASSETS.Languages.AssetRegistration", Assembly.GetExecutingAssembly());
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
                this.Text = rm.GetString("title");
                lblMemo.Text = rm.GetString("lblMemo");
                lblDesc.Text = rm.GetString("lblDesc");
                lblTag.Text = rm.GetString("lblTag");
                grpCameraPreview.Text = rm.GetString("grpCameraPreview");
                grpAssetInfo.Text = rm.GetString("grpAssetInfo");
                grpCaptured.Text = rm.GetString("grpCaptured");
                btnCancel.Text = rm.GetString("btnCancel");
                btnSubmit.Text = rm.GetString("btnSubmit");
                lblNoCameraAvailable.Text = rm.GetString("lblNoCameraAvailable");
                rbtnValidToday.Text = rm.GetString("rbtnValidToday");
                rbtnValidUntil.Text = rm.GetString("rbtnValidUntil");
                rbtnNoExpiration.Text = rm.GetString("rbtnNoExpiration");
                grpExpiration.Text = rm.GetString("grpExpiration");
                btnGetRFIDTag.Text = rm.GetString("btnGetRFIDTag");
                //shorter
                btnGetAssetInfo.Text = rm.GetString("btnGetAssetInfo");
                //shorter
                lblOwnerPic.Text = rm.GetString("lblOwnerPic");
                lblLoadingInformation.Text = rm.GetString("lblLoadingInformation");
                lblAssetPic.Text = rm.GetString("lblAssetPic");
                lblOwnerPhoto.Text = rm.GetString("lblOwnerPhoto");
                lblValidIDPhoto.Text = rm.GetString("lblValidIDPhoto");
                lblAssetPhoto1.Text = rm.GetString("lblAssetPhoto1");
                lblAssetPhoto2.Text = rm.GetString("lblAssetPhoto2");
                lblAssetPhoto3.Text = rm.GetString("lblAssetPhoto3");
                btnCapturePhoto.Text = rm.GetString("btnCapturePhoto");
            }
        }
        private void InitializePhotoLabel()
        {
            if (language == "Japanese")
            {
                lblOwnerPhoto.Text = "第一ステップ" + "\n" + lblOwnerPhoto.Text;
                lblValidIDPhoto.Text = "第二ステップ" + "\n" + lblValidIDPhoto.Text;
                lblAssetPhoto1.Text = "第三ステップ" + "\n" + lblAssetPhoto1.Text;
                lblAssetPhoto2.Text = "第四ステップ" + "\n" + lblAssetPhoto2.Text;
                lblAssetPhoto3.Text = "第五ステップ" + "\n" + lblAssetPhoto3.Text;

            }
            else
            {
                lblOwnerPhoto.Text = "Step 1" + "\n" + lblOwnerPhoto.Text;
                lblValidIDPhoto.Text = "Step 2" + "\n" + lblValidIDPhoto.Text;
                lblAssetPhoto1.Text = "Step 3" + "\n" + lblAssetPhoto1.Text;
                lblAssetPhoto2.Text = "Step 4" + "\n" + lblAssetPhoto2.Text;
                lblAssetPhoto3.Text = "Step 5" + "\n" + lblAssetPhoto3.Text;
            }
        }

        private void GetAssetSystemInfo()
        {
            try
            {
                //opening the subkey  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AssetSystemInfo");

                //if it does exist, retrieve the stored values  
                if (key != null)
                {
                    tokenvalue = (string)(key.GetValue("authenticationToken"));
                    roleValue = (string)(key.GetValue("roles"));
                    portname = (string)(key.GetValue("DefaultPortName"));
                    txtSaveImageDir.Text = (string)(key.GetValue("AssetsImagePath"));
                    companyId = (int)(key.GetValue("companyId"));
                    userId = (int)(key.GetValue("UserId"));
                    lblLoginUserName.Text = "Username: " + (string)(key.GetValue("UserName")).ToString();//.ToUpper();
                    readerInfo = (string)(key.GetValue("readerInfo"));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void InitializeOwner()
        {
            //try
            //{
            //    //var company = 1;

            //    RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
            //    RestRequest ownerName = new RestRequest("/api/user/list/" + companyId, Method.GET);

            //    var authToken = tokenvalue;

            //    ownerName.RequestFormat = DataFormat.Json;
            //    ownerName.AddHeader("Content-Type", "application/json; charset=utf-8");
            //    ownerName.AddHeader("X-Auth-Token", authToken);

            //    var response = client.Execute<List<Owner>>(ownerName);
            //    var content = response.Content;

            //    if (response.StatusCode == HttpStatusCode.OK)
            //    {
            //        JsonDeserializer deserial = new JsonDeserializer();
            //        List<Owner> owner = deserial.Deserialize<List<Owner>>(response);

            //        this.comboOwner.DataSource = owner;
            //        this.comboOwner.ValueMember = "userId";
            //        this.comboOwner.DisplayMember = "fullName";
            //    }
            //    else
            //    {
            //        if (response.StatusCode == HttpStatusCode.InternalServerError)
            //        {
            //            MessageBox.Show("Unable to reach server. please try again later.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newImgFileNames = string.Empty;

            if (btnCancel.Text.ToUpper() == "BACK" || btnCancel.Text == "戻る")
            {
                CallMainMenu();
                return;
            }

            if (txtRFIDTag.Text.Length != 0 || imgCapture1.Image != null)
            {
                string cancelMsg;

                if (btnSubmit.Text.ToUpper() == "SUBMIT" || btnSubmit.Text == "提出する")
                {
                    if (language == "English") cancelMsg = "Are you sure you want to cancel the registration?";
                    else cancelMsg = "登録を取り消すにしてもよろしいですか？";
                }
                else
                {
                    if (language == "English") cancelMsg = "Are you sure you want to cancel the update?";
                    else cancelMsg = "更新を取り消すにしてもよろしいですか？";
                }

                DialogResult result = MessageBox.Show(cancelMsg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //CallMainMenu();
                    ClearFields();
                }
                else
                {
                    btnGetRFIDTag.Focus();
                    return;
                }
            }
            //else CallMainMenu();
        }  

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRFIDTag.Text.Length == 0 ||/* txtAssetName.Text.Length == 0 ||*/ txtDescription.Text.Length == 0 || txtTakeOutNote.Text.Length == 0 || imgCapture1.Image == null)
                {
                    if (language == "English") MessageBox.Show("Complete information is required.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    else if (language == "Japanese") MessageBox.Show("完全な情報は、必要とされます.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //btnBrowseImage.Focus();
                    btnGetRFIDTag.Focus();
                    return;
                }

                if (btnSubmit.Text.ToUpper() == "UPDATE" || btnSubmit.Text == "更新する")
                {
                    updateAssetInfo();
                }
                else
                {
                    //For Web Service
                    Asset asset = new Asset();

                    //int oId;
                    //bool parseOK = Int32.TryParse(comboOwner.SelectedValue.ToString(), out oId);

                    //int currentOwnerId =  Convert.ToInt32(((Owner)comboOwner.SelectedItem).userId);

                    asset.tag = txtRFIDTag.Text;
                    asset.tagType = 1;
                    asset.companyId = companyId;//1;
                    //asset.ownerId = currentOwnerId;//oId;
                    asset.name = txtDescription.Text.Trim();//txtAssetName.Text;
                    asset.description = txtDescription.Text.Trim();
                    //if (radbtnYes.Checked)
                    //{
                    //    asset.takeOutAllowed = true;
                    //}
                    //else
                    //{
                    //asset.takeOutAllowed = false;
                    //}
                    asset.takeOutInfo = txtTakeOutNote.Text.Trim();
                    asset.imageUrls = newImgFileNames; //txtCapturedImagePath.Text;//txtImagePath.Text;
                    asset.registerUserId = userId;//lblLoginUserName.Text.Substring(lblLoginUserName.Text.IndexOf(":") + 2);
                    asset.updateUserId = userId;
                    //For Validity Expiration
                    if (rbtnValidToday.Checked)
                    {
                        validUntilValue = DateTime.UtcNow.ToString("yyyy-MM-dd T") + "17:00";
                    }
                    else if (rbtnValidUntil.Checked)
                    {
                        if (dtTimePicker.Checked) validUntilValue = dtDatePicker.Value.ToString("yyyy-MM-dd") + dtTimePicker.Value.ToString("THH:mm");
                        else validUntilValue = dtDatePicker.Value.ToString("yyyy-MM-dd T") + "17:00";
                    }
                    else validUntilValue = null;

                    DateTime? dt = null;
                    asset.validUntil = validUntilValue != null ? Convert.ToDateTime(validUntilValue) : dt;


                    RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");//("http://feather-assets.herokuapp.com/");
                    RestRequest register = new RestRequest("/api/asset/add", Method.POST);

                    var authToken = tokenvalue;
                    register.AddHeader("X-Auth-Token", authToken);
                    register.AddHeader("Content-Type", "application/json; charset=utf-8");
                    register.RequestFormat = DataFormat.Json;
                    register.AddBody(asset);

                    lblSubmittingInformation.Visible = true;
                    this.Refresh();


                    IRestResponse response = client.Execute(register);
                    lblSubmittingInformation.Visible = false;

                    var content = response.Content;

                    if (response.StatusCode == HttpStatusCode.OK)//if (response.IsSuccessStatusCode)
                    {
                        JsonDeserializer deserial = new JsonDeserializer();
                        RestResult restResult = deserial.Deserialize<RestResult>(response);

                        if (restResult.result == "OK")
                        {
                            SaveTransaction();

                            if (language == "English") MessageBox.Show("Record successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else MessageBox.Show("レコードが正常に保存され.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void SaveTransaction()
        {
            //Saving to transaction table
            try
            {
                //For Web Service
                Transaction transactDet = new Transaction();

                transactDet.companyId = companyId;//1;
                transactDet.readerInfo = readerInfo;
                //transactDet.readerId = 1;
                //transactDet.notes = txtExplanationNotes.Text.Trim();
                //transactDet.imageUrl = newImgFileNames;//txtCapturedImagePath.Text;//txtImagePath.Text;

                //Gettting the assetId
                if (btnSubmit.Text.ToUpper() == "SUBMIT" || btnSubmit.Text == "提出する")
                {
                    GetAsset getAsset = new GetAsset();

                    getAsset.companyId = companyId;
                    getAsset.tag = txtRFIDTag.Text;
                    getAsset.tagType = 1;

                    RestClient clientinfo = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
                    RestRequest assetinfo = new RestRequest("/api/asset/company-tag", Method.POST);

                    assetinfo.RequestFormat = DataFormat.Json;
                    assetinfo.AddHeader("Content-Type", "application/json; charset=utf-8");
                    assetinfo.AddHeader("X-Auth-Token", tokenvalue);
                    assetinfo.AddBody(getAsset);

                    IRestResponse responseinfo = clientinfo.Execute(assetinfo);
                    var contentinfo = responseinfo.Content;

                    if (responseinfo.StatusCode == HttpStatusCode.OK)
                    {
                        JsonDeserializer deserial = new JsonDeserializer();
                        AssetInfo assetInfo = deserial.Deserialize<AssetInfo>(responseinfo);

                        assetId = assetInfo.assetId;
                    }
                }
                transactDet.assetId = assetId;
                //end-Getting assetId

                RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");//("http://feather-assets.herokuapp.com/");
                RestRequest transact = new RestRequest("/api/asset/transact", Method.POST);

                var authToken = tokenvalue;
                transact.AddHeader("X-Auth-Token", authToken);
                transact.AddHeader("Content-Type", "application/json; charset=utf-8");
                transact.RequestFormat = DataFormat.Json;
                transact.AddBody(transactDet);

                //lblSubmittingInformation.Visible = true;
                //this.Refresh();

                IRestResponse response = client.Execute(transact);
                lblSubmittingInformation.Visible = false;

                var content = response.Content;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JsonDeserializer deserial = new JsonDeserializer();
                    RestResult restResult = deserial.Deserialize<RestResult>(response);

                    if (restResult.result != "OK")
                    {
                        if (language == "English") MessageBox.Show("Saving transaction..." + "\n" + restResult.result + " " + restResult.message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("取引を保存します。。。" + "\n" + restResult.result + " " + restResult.message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    if (language == "English") MessageBox.Show("Saving transaction..." + "\n" + "Error Code " + response.StatusCode /*+ " : Message - " + response.ErrorMessage*/);
                    else MessageBox.Show("取引を保存します。。。" + "\n" + "Error Code " + response.StatusCode /*+ " : Message - " + response.ErrorMessage*/);
                    return;
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void updateAssetInfo()
        {
            Asset updateInfo = new Asset();

            updateInfo.companyId = companyId;//1;
            //updateInfo.registerUserId = userId;
            updateInfo.updateUserId = userId;
            updateInfo.assetId = assetId;
            updateInfo.name = txtDescription.Text.Trim();
            updateInfo.description = txtDescription.Text.Trim();

            if (newImgFileNames == null) updateInfo.imageUrls = updatedImgFileNames;
            else updateInfo.imageUrls = newImgFileNames; //updatedImgFileNames

            updateInfo.tag = txtRFIDTag.Text;
            updateInfo.tagType = 1;
            //updateInfo.takeOutAllowed = false;
            updateInfo.takeOutInfo = txtTakeOutNote.Text.Trim();

            if (rbtnValidToday.Checked)
            {
                validUntilValue = DateTime.UtcNow.ToString("yyyy-MM-dd T") + "17:00";
            }
            else if (rbtnValidUntil.Checked)
            {
                if (dtTimePicker.Checked) validUntilValue = dtDatePicker.Value.ToString("yyyy-MM-dd") + dtTimePicker.Value.ToString("THH:mm");
                else validUntilValue = dtDatePicker.Value.ToString("yyyy-MM-dd T") + "17:00";
            }
            else validUntilValue = null;
            DateTime? dt = null;

            updateInfo.validUntil = validUntilValue != null ? Convert.ToDateTime(validUntilValue) : dt;


            RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
            RestRequest updateAssetInfo = new RestRequest("/api/asset/update", Method.POST);

            updateAssetInfo.AddHeader("X-Auth-Token", tokenvalue);
            updateAssetInfo.AddHeader("Content-Type", "application/json; charset=utf-8");
            updateAssetInfo.RequestFormat = DataFormat.Json;
            updateAssetInfo.AddBody(updateInfo);

            lblSubmittingInformation.Visible = true;
            if (language == "English") lblSubmittingInformation.Text = "Updating Information. Please wait...";
            else lblSubmittingInformation.Text = "情報を更新します. お待ちください...";
            this.Refresh();


            IRestResponse response = client.Execute(updateAssetInfo);
            lblSubmittingInformation.Visible = false;
            if (language == "English") lblSubmittingInformation.Text = "Submitting Information. Please wait...";
            else lblSubmittingInformation.Text = "情報を提出します. お待ちください...";

            var content = response.Content;

            if (response.StatusCode == HttpStatusCode.OK)//if (response.IsSuccessStatusCode)
            {
                JsonDeserializer deserial = new JsonDeserializer();
                RestResult restResult = deserial.Deserialize<RestResult>(response);

                if (restResult.result == "OK")
                {
                    SaveTransaction();

                    if (language == "English") MessageBox.Show("Record successfully updated.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("レコードが正常に更新します.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SubmitImage()
        {
            Bitmap Image = (Bitmap)cameraBox.Image;
            Image.Save("img.jpg", ImageFormat.Jpeg);

            RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
            RestRequest upload = new RestRequest("/api/upload/image", Method.POST);

            upload.AddHeader("X-Auth-Token", tokenvalue);
            upload.AddHeader("Content-Type", "multipart/form-data");
            upload.AlwaysMultipartFormData = true;
            upload.AddFile("file", "img.jpg", "image/jpg");
            upload.AddParameter("companyId", companyId);
            upload.AddParameter("type", "asset");


            IRestResponse response = client.Execute(upload);
            getCaptureButtonText();
            if (language == "English") btnCancel.Text = "Cancel";
            else btnCancel.Text = "キャンセル";

            var content = response.Content;

            if (response.StatusCode == HttpStatusCode.OK)//if (response.IsSuccessStatusCode)
            {
                JsonDeserializer deserial = new JsonDeserializer();
                ImageResult imageResult = deserial.Deserialize<ImageResult>(response);

                ImgFileName = imageResult.message;
            }
            else
            {
                MessageBox.Show("Error Code " +
                response.StatusCode /*+ " : Message - " + response.ErrorMessage*/);
                return;
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

            //cameraBox.Image = null;
            imgCapture1.Image = null;
            imgCapture2.Image = null;
            imgCapture3.Image = null;
            imgCapture4.Image = null;
            imgCapture5.Image = null;

            lblOwnerPhoto.Visible = true;
            lblValidIDPhoto.Visible = true;
            lblAssetPhoto1.Visible = true;
            lblAssetPhoto2.Visible = true;
            lblAssetPhoto3.Visible = true;

            rbtnValidToday.Checked = true;
            if (language == "English")
            {
                btnCapturePhoto.Text = "Capture Owner Photo";
                btnSubmit.Text = "Submit";
                btnCancel.Text = "Back";
            }
            else
            {
                btnCapturePhoto.Text = "所有者の写真";
                btnSubmit.Text = "提出する";
                btnCancel.Text = "戻る";
            }
            this.Refresh();
            //btnGetRFIDTag.Focus();
        }

        #region old code
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

        //private void comboOwner_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //SqlConnection con = new SqlConnection(connectionString);
        //    //con.Open();
        //    //SqlCommand cmd = new SqlCommand("select * from User_Master where first_name ='" + comboOwner.Text.Trim() + "'", con);
        //    //SqlDataReader rd = cmd.ExecuteReader();

        //    //while (rd.Read())
        //    //{
        //    //    ownerid = rd["user_id"].ToString();
        //    //}
        //    //rd.Close();
        //}

        //private void comboOwner_DropDown(object sender, EventArgs e)
        //{
        //    //comboOwner.Items.Clear();

        //    //SqlConnection con = new SqlConnection(connectionString);
        //    //con.Open();
        //    //SqlCommand cmd = new SqlCommand("select * from User_Master", con);
        //    //SqlDataReader rd = cmd.ExecuteReader();

        //    //while (rd.Read())
        //    //{
        //    //    comboOwner.Items.Add(rd["first_name"].ToString());
        //    //}
        //    //rd.Close(); 
        //}
        #endregion

        private void RegisterAsset_FormClosed(object sender, FormClosedEventArgs e)
        {
            CallMainMenu();
        }

        private void btnGetRFIDTag_Click(object sender, EventArgs e)
        {
            //ReaderMethodProc();
            //ClearFields();
            try
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
                        txtDescription.Focus();//txtAssetName.Focus();
                        if (language == "English") btnCancel.Text = "Cancel";
                        else btnCancel.Text = "キャンセル";
                    }
                }
                //else if (nReturnValue == 0)
                //{
                //    MessageBox.Show("Successful execution of the command but no inventory to tag");
                //}
                else if (nReturnValue == -1)
                {
                    //MessageBox.Show("Reader Com Port Error", "Asset Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //cam.Stop();
                    //CallMainMenu();
                    CallSerialPortSelection();
                }
                else if (nReturnValue == -2)
                {
                    //MessageBox.Show("Reader Com Port Error", "Asset Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //cam.Stop();
                    //CallMainMenu();
                    CallSerialPortSelection();
                }
                else
                {
                    return;
                }
                ReaderMethodProc();
            }
            catch (Exception ex)
            {
                if (language == "English") MessageBox.Show(ex.Message + "\n" + "Reader is not connected.");
                else MessageBox.Show(ex.Message + "\n" + "リーダーが接続されていません.");
            }
        }

        private void CallSerialPortSelection()
        {
            try
            {
                //if (IsCameraConnected)
                //    cam.Stop();
                //reader.CloseCom();

                SerialPortSelection PortSelectionForm = new SerialPortSelection(tokenvalue, roleValue);

                // Show PortSelectionForm as a modal dialog and determine if DialogResult = OK.
                if (PortSelectionForm.ShowDialog(this) == DialogResult.OK)
                {
                    // Read the contents of PortSelectionForm's cmbComPortList.
                    portname = PortSelectionForm.cmbComPortList.Text;
                }
                else CallMainMenu();

                PortSelectionForm.Dispose();
                //ReaderMethodProc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CallMainMenu()
        {
            try
            {
                //this.Hide();
                //reader.CloseCom();
                //MainMenu MenuForm = new MainMenu(tokenvalue, portname);
                //MenuForm.Show();

                //Back to Main Menu 
                if (IsCameraConnected)
                cam.Stop();

                this.Hide();
                reader.CloseCom();
                MainMenu MenuForm = new MainMenu(tokenvalue, roleValue);
                MenuForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterAsset_Load(object sender, EventArgs e)
        {
            try
            {
                AssetValidUntilDateTime();

                CurrentTimer.Enabled = true;
                CurrentTimer.Interval = 1000;

                reader = new Reader.ReaderMethod();
                ////Callback
                //reader.AnalyCallback = AnalyData;
                //reader.ReceiveCallback = ReceiveData;
                //reader.SendCallback = SendData;
                //auto_connect();
                ReaderMethodProc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AssetValidUntilDateTime()
        {
            //For Valid Until Date
            if (!rbtnValidUntil.Checked)
            {
                dtDatePicker.CustomFormat = "'Date'";
                dtDatePicker.Format = DateTimePickerFormat.Custom;

                dtTimePicker.CustomFormat = "'Time'";
                dtTimePicker.Format = DateTimePickerFormat.Custom;
                dtTimePicker.Checked = false;
            }
            else
            {
                //For Valid Until Date
                dtDatePicker.CustomFormat = "MM/dd/yyyy";
                dtDatePicker.Format = DateTimePickerFormat.Custom;
                dtDatePicker.Value = DateTime.Now;
            }

            ////For Valid Until Date
            //if (!dtDatePicker.Checked)
            //{
            //    dtDatePicker.CustomFormat = "'Date'";
            //    dtDatePicker.Format = DateTimePickerFormat.Custom;
            //}
            //else
            //{
            //    //dtDatePicker.CustomFormat = "hh:mm tt";
            //    dtDatePicker.CustomFormat = "MM/dd/yyyy";
            //    dtDatePicker.Format = DateTimePickerFormat.Custom;
            //}

            ////For Valid Until Time
            //if (!dtTimePicker.Checked)
            //{
            //    dtTimePicker.CustomFormat = "'Time'";
            //    dtTimePicker.Format = DateTimePickerFormat.Custom;
            //}
            //else
            //{
            //    //dtTimePicker.CustomFormat = "hh:mm tt";
            //    dtTimePicker.CustomFormat = "h:mm tt";
            //    dtTimePicker.Format = DateTimePickerFormat.Custom;
            //}

        }

        private void ReaderMethodProc()
        {
            //reader = new Reader.ReaderMethod();
            //Callback
            reader.AnalyCallback = AnalyData;
            reader.ReceiveCallback = ReceiveData;
            reader.SendCallback = SendData;
            auto_connect();
        }

        #region Camera Procedure
        private void StartCamera()
        {
            try
            {
                cam = new VideoCaptureDevice(webcam[comVideoDeviceBox.SelectedIndex].MonikerString);
                cameraDeviceName = comVideoDeviceBox.SelectedItem.ToString();
                cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                cam.Start();
                //this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            cameraBox.Image = bit;
        }

        private void InitializeCamera()
        {
            try
            {
                //comVideoDeviceBox.SelectedIndex = 0;
                //Checking the camera status
                //comVideoDeviceBox.Items.Clear();
                //cameraBox.Image = null;

                //webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                //foreach (FilterInfo VideoCaptureDevice in webcam)
                //{
                //    comVideoDeviceBox.Items.Add(VideoCaptureDevice.Name);
                //}
                if (!isCameraChanged) getAvailableCamera();

                if (comVideoDeviceBox.Items.Count < 1)
                {
                    if (cam != null) cam.Stop();
                    IsCameraConnected = false;
                    cameraBox.BackColor = Color.Black;
                    lblNoCameraAvailable.Visible = true;
                    if (language == "English") btnCapturePhoto.Text = "Refresh Camera";
                    else if (language == "Japanese") btnCapturePhoto.Text = "リフレッシュカメラ";
                }
                else
                {
                    if (!isCameraChanged)
                    {
                        //isCameraChanged = false;
                        comVideoDeviceBox.SelectedIndex = 0;
                    }
                    StartCamera();

                    IsCameraConnected = true;
                    cameraBox.BackColor = Color.White;
                    lblNoCameraAvailable.Visible = false;

                    if (btnSubmit.Text.ToUpper() == "UPDATE" || btnSubmit.Text == "更新する") getCaptureButtonText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getCaptureButtonText()
        {
            if (language == "English")
            {
                if (imgCapture1.Image == null) btnCapturePhoto.Text = "Capture Owner Photo";
                else if (imgCapture2.Image == null) btnCapturePhoto.Text = "Capture Valid ID Photo";
                else if (imgCapture3.Image == null) btnCapturePhoto.Text = "Capture Asset Photo 1";
                else if (imgCapture4.Image == null) btnCapturePhoto.Text = "Capture Asset Photo 2";
                else if (imgCapture5.Image == null) btnCapturePhoto.Text = "Capture Asset Photo 3";
                else btnCapturePhoto.Text = "Captured Completed";
            }
            else
            {
                if (imgCapture1.Image == null) btnCapturePhoto.Text = "所有者の写真";
                else if (imgCapture2.Image == null) btnCapturePhoto.Text = "有効なIDの写真";
                else if (imgCapture3.Image == null) btnCapturePhoto.Text = "アセットの写真一";
                else if (imgCapture4.Image == null) btnCapturePhoto.Text = "アセットの写真二";
                else if (imgCapture5.Image == null) btnCapturePhoto.Text = "アセットの写真三";
                else btnCapturePhoto.Text = "完成しました";
            }
        }

        private void btnCapturePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (language == "English")
                {
                    if (cam == null || btnCapturePhoto.Text == "Refresh Camera")
                    {
                        InitializeCamera();
                    }
                    else if (IsCameraConnected)
                    {
                        if (imgCapture5.Image == null)
                        {
                            btnCapturePhoto.Text = "Processing. Please wait...";
                            btnCapturePhoto.Refresh();
                        }

                        //Assigned captured image in each picture box
                        if (imgCapture1.Image == null)
                        {
                            imgCapture1.Image = cameraBox.Image;
                            lblOwnerPhoto.Visible = false;
                            //btnCapturePhoto.Text = "Capture Valid ID Photo";
                        }
                        else if (imgCapture2.Image == null)
                        {
                            imgCapture2.Image = cameraBox.Image;
                            lblValidIDPhoto.Visible = false;
                            //btnCapturePhoto.Text = "Capture Asset Photo 1";
                        }
                        else if (imgCapture3.Image == null)
                        {
                            imgCapture3.Image = cameraBox.Image;
                            lblAssetPhoto1.Visible = false;
                            //btnCapturePhoto.Text = "Capture Asset Photo 2";
                        }
                        else if (imgCapture4.Image == null)
                        {
                            imgCapture4.Image = cameraBox.Image;
                            lblAssetPhoto2.Visible = false;
                            //btnCapturePhoto.Text = "Capture Asset Photo 3";
                        }
                        else if (imgCapture5.Image == null)
                        {
                            imgCapture5.Image = cameraBox.Image;
                            lblAssetPhoto3.Visible = false;
                            //btnCapturePhoto.Text = "Captured Completed";
                        }
                        else
                        {
                            MessageBox.Show("Captured Images exceeds the maximum limit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        SubmitImage();
                        newImgFileNames = newImgFileNames + "," + ImgFileName;
                        cam.Stop();
                        InitializeCamera();
                    }
                }
                else
                {
                    if (cam == null || btnCapturePhoto.Text == "リフレッシュカメラ")
                    {
                        InitializeCamera();
                    }
                    else if (IsCameraConnected)
                    {
                        if (imgCapture5.Image == null)
                        {
                            btnCapturePhoto.Text = "処理. お待ちください...";
                            btnCapturePhoto.Refresh();
                        }

                        //Assigned captured image in each picture box
                        if (imgCapture1.Image == null)
                        {
                            imgCapture1.Image = cameraBox.Image;
                            lblOwnerPhoto.Visible = false;
                            //btnCapturePhoto.Text = "有効なIDの写真";
                        }
                        else if (imgCapture2.Image == null)
                        {
                            imgCapture2.Image = cameraBox.Image;
                            lblValidIDPhoto.Visible = false;
                            //btnCapturePhoto.Text = "キャプチャー資産写真一";
                        }
                        else if (imgCapture3.Image == null)
                        {
                            imgCapture3.Image = cameraBox.Image;
                            lblAssetPhoto1.Visible = false;
                            //btnCapturePhoto.Text = "キャプチャー資産写真二";
                        }
                        else if (imgCapture4.Image == null)
                        {
                            imgCapture4.Image = cameraBox.Image;
                            lblAssetPhoto2.Visible = false;
                            //btnCapturePhoto.Text = "キャプチャー資産写真三";
                        }
                        else if (imgCapture5.Image == null)
                        {
                            imgCapture5.Image = cameraBox.Image;
                            lblAssetPhoto3.Visible = false;
                            //btnCapturePhoto.Text = "撮影し完成";
                        }
                        else
                        {
                            MessageBox.Show("撮影した写真は、最大限に超え.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        SubmitImage();
                        newImgFileNames = newImgFileNames + "," + ImgFileName;
                        cam.Stop();
                        InitializeCamera();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Reader Procedure
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
        #endregion

        private void CurrentTimer_Tick(object sender, EventArgs e)
        {
            lblCurrentDateTime.Text = DateTime.Now.ToString("h:mm:ss tt") + "\n " + DateTime.Now.ToString("MM/dd/yyyy");//DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            //if (dtDatePicker.Checked) dtDatePicker.Value = DateTime.Now;
            //if (dtTimePicker.Checked) dtTimePicker.Value = DateTime.Now;
        }

        private void btnBrowseImagePath_Click(object sender, EventArgs e)
        {
            try
            {
                if (imagePathDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSaveImageDir.Text = imagePathDialog.SelectedPath;

                    //accessing the CurrentUser root element  
                    //and adding "AssetsImagePath" subkey to the "SOFTWARE" subkey  
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AssetSystemInfo");

                    //storing the values  
                    key.SetValue("AssetsImagePath", txtSaveImageDir.Text);
                    key.Close();
                }
                //else CallMainMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AssetValidUntilTime();
        }

        private void AssetValidUntilTime()
        {
            //For Valid Until Time
            if (!dtTimePicker.Checked)
            {
                dtTimePicker.CustomFormat = "'Time'";
                dtTimePicker.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                //dtTimePicker.CustomFormat = "hh:mm tt";
                dtTimePicker.CustomFormat = "h:mm tt";
                dtTimePicker.Format = DateTimePickerFormat.Custom;
                //dtTimePicker.Value = DateTime.Now;
            }
        }

        private void rbtnValidUntil_CheckedChanged(object sender, EventArgs e)
        {
            AssetValidUntilDateTime();
        }

        private void btnGetAssetInfo_Click(object sender, EventArgs e)
        {
            //ClearFields();
            //txtRFIDTag.Text = string.Empty;
            btnGetRFIDTag.PerformClick();

            if (!string.IsNullOrEmpty(txtRFIDTag.Text)) getAssetInfo();
            btnGetAssetInfo.Focus();
        }

        private void getAssetInfo()
        {
            try
            {
                lblLoadingInformation.Visible = true;
                lblLoadingInformation.Refresh();

                GetAsset getAsset = new GetAsset();

                getAsset.companyId = companyId;
                getAsset.tag = txtRFIDTag.Text;
                getAsset.tagType = 1;

                RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
                RestRequest assetinfo = new RestRequest("/api/asset/company-tag", Method.POST);

                assetinfo.RequestFormat = DataFormat.Json;
                assetinfo.AddHeader("Content-Type", "application/json; charset=utf-8");
                assetinfo.AddHeader("X-Auth-Token", tokenvalue);
                assetinfo.AddBody(getAsset);

                IRestResponse response = client.Execute(assetinfo);
                var content = response.Content;

                lblLoadingInformation.Visible = false;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    JsonDeserializer deserial = new JsonDeserializer();
                    AssetInfo assetInfo = deserial.Deserialize<AssetInfo>(response);
 
                    assetId = assetInfo.assetId;
                    updatedImgFileNames = assetInfo.imageUrls;
                    txtDescription.Text = assetInfo.description;
                    txtTakeOutNote.Text = assetInfo.takeOutInfo;

                    //if (assetInfo.validUntil != Convert.ToDateTime(DateTime.Now.ToString("g")))
                    //{
                    if (assetInfo.validUntil == null) rbtnNoExpiration.Checked = true;
                    else
                    {
                        rbtnValidUntil.Checked = true;
                        validUntilValue = assetInfo.validUntil.Value.ToString("yyyy-MM-dd");
                        dtDatePicker.Value = Convert.ToDateTime(validUntilValue);

                        //if (Convert.ToDateTime(assetInfo.validUntil).ToString("HH:mm") != "00:00")
                        //{
                        validUntilValue = assetInfo.validUntil.Value.ToString("HH:mm tt");
                        dtTimePicker.Value = Convert.ToDateTime(validUntilValue);
                        dtTimePicker.Checked = true;
                        AssetValidUntilTime();
                        //}
                    }
                    //}
                    
                   string urls = assetInfo.imageUrls;
                   if (urls != null)
                   {
                       string[] ReadUrls = urls.Split(',');

                       //http://52.163.93.95:8080/FeatherAssets/api/images/{companyId}/{type}/

                       if (ReadUrls.Length > 1)
                       {
                           imgCapture1.Load("http://52.163.93.95:8080/FeatherAssets/api/images/1/asset/" + ReadUrls[1]);
                           lblOwnerPhoto.Visible = false;
                       }
                       if (ReadUrls.Length > 2)
                       {
                           imgCapture2.Load("http://52.163.93.95:8080/FeatherAssets/api/images/1/asset/" + ReadUrls[2]);
                           lblValidIDPhoto.Visible = false;
                       }
                       if (ReadUrls.Length > 3)
                       {
                           imgCapture3.Load("http://52.163.93.95:8080/FeatherAssets/api/images/1/asset/" + ReadUrls[3]);
                           lblAssetPhoto1.Visible = false;
                       }
                       if (ReadUrls.Length > 4)
                       {
                           imgCapture4.Load("http://52.163.93.95:8080/FeatherAssets/api/images/1/asset/" + ReadUrls[4]);
                           lblAssetPhoto2.Visible = false;
                       }
                       if (ReadUrls.Length > 5)
                       {
                           imgCapture5.Load("http://52.163.93.95:8080/FeatherAssets/api/images/1/asset/" + ReadUrls[5]);
                           lblAssetPhoto3.Visible = false;
                       }
                   }
                   getCaptureButtonText();
                   if (language == "English")
                   {
                       btnCancel.Text = "Cancel";
                       btnSubmit.Text = "Update";
                   }
                   else
                   {
                       btnCancel.Text = "キャンセル";
                       btnSubmit.Text = "更新する";
                   }
                    btnSubmit.Focus();

                    getCaptureButtonText();
                    return;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    if (language == "English") MessageBox.Show("Error connecting to server.. please try again later");
                    else MessageBox.Show("サーバーへの接続エラー.. 後でもう一度試してみてください");
                }
                else
                {
                    HttpStatusCode statusCode = response.StatusCode;
                    int numericStatusCode = (int)statusCode;
                    //show error code
                    MessageBox.Show("Error" + numericStatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkBoxChangeCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxChangeCamera.Checked)
            {
                comVideoDeviceBox.Visible = true;
                comVideoDeviceBox.Text = cameraDeviceName;

                isCameraChanged = true;
                //getAvailableCamera();
            }
            else
                comVideoDeviceBox.Visible = false;
        }

        private void getAvailableCamera()
        {
            //comVideoDeviceBox.SelectedIndex = 0;
            //Checking the camera status
            comVideoDeviceBox.Items.Clear();
            cameraBox.Image = null;

            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comVideoDeviceBox.Items.Add(VideoCaptureDevice.Name);
            }
        }

        private void comVideoDeviceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cam != null) cam.Stop();

            if (isCameraChanged) 
            {
                //isCameraChanged = true;
                InitializeCamera();  
            }
        }

        private void comVideoDeviceBox_DropDown(object sender, EventArgs e)
        {
            getAvailableCamera();
        }
    }

    public class Asset
    {
        public int assetId { get; set; }
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
        public DateTime? validUntil { get; set; }
        public int registerUserId { get; set; }
        public int updateUserId { get; set; }
    }

    //public class Owner
    //{
    //    public int userId { get; set; }
    //    public int companyId { get; set; }
    //    public string firstName { get; set; }
    //    public string lastName { get; set; }
    //    public string position { get; set; }
    //    public string description { get; set; }
    //    public string imageUrl { get; set; }
    //    public string email { get; set; }
    //    public string authorities { get; set; }
    //    public string fullName { get { return lastName + ", " + firstName; } }
    //}

    public class RestResult
    {
        public string result { get; set; }
        public string message { get; set; }
    }

    public class ImageResult
    {
        public string response { get; set; }
        public string message { get; set; }
    }

    public class AssetInfo
    {
        public int assetId { get; set; }
        public int companyId { get; set; }
        public int registerUserId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageUrls { get; set; }
        public string tag { get; set; }
        public int tagType { get; set; }
        public bool takeOutAllowed { get; set; }
        public string takeOutInfo { get; set; }
        public DateTime? validUntil { get; set; }
    }

    public class GetAsset
    {
        public int companyId { get; set; }
        public string tag { get; set; }
        public int tagType { get; set; }
    }

    //public class UpdateAsset
    //{
    //    public int companyId { get; set; }
    //    public int registerUserId { get; set; }
    //    public int updateUserId { get; set; }
    //    public int assetId { get; set; }
    //    public string name { get; set; }
    //    public string description { get; set; }
    //    public string imageUrls { get; set; }
    //    public string tag { get; set; }
    //    public int tagType { get; set; }
    //    public bool takeOutAllowed { get; set; }
    //    public string takeOutInfo { get; set; }
    //    public DateTime? validUntil { get; set; }
    //}
}
