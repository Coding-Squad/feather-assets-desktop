using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestSharp.Deserializers;
using RestSharp;
using System.Net;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using Microsoft.Win32;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;
using System.Drawing.Imaging;

namespace RFID_FEATHER_ASSETS
{

    public partial class RegisterUser : Form
    {
        string tokenvalue;
        string ImgFileName;
        string language;
        int companyId;
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        bool IsCameraConnected = false;

        public RegisterUser(string tokenvaluesource)
        {
            InitializeComponent();
            getLanguage();
            languageHandler();
            tokenvalue = tokenvaluesource;
            InitializeCamera();          
            GetRegDefaultImagePath();
            GetCompanyPath();
            //CCT.Completed += new EventHandler<PhotoResult>(capture_completed);

            List<Role> roles = new List<Role>();
            if (language == "Japanese")
            {
                roles.Add(new Role() { roleName = "管理者", value = "ROLE_ADMIN" });
                roles.Add(new Role() { roleName = "警備", value = "ROLE_GUARD" });
                //roles.Add(new Role() { roleName = "User", value = "ROLE_USER" });
            }
            else
            {
                roles.Add(new Role() { roleName = "Administrator", value = "ROLE_ADMIN" });
                roles.Add(new Role() { roleName = "Security", value = "ROLE_GUARD" });
                //roles.Add(new Role() { roleName = "User", value = "ROLE_USER" });
            }
            this.authorities.DataSource = roles;
            this.authorities.ValueMember = "value";
            this.authorities.DisplayMember = "roleName";                   
        }
        private void GetCompanyPath()
        {
            try
            {
                //opening the subkey  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AssetSystemInfo");

                //if it does exist, retrieve the stored values  
                if (key != null)
                {
                    companyId = (int)(key.GetValue("companyId"));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                ResourceManager rm = new ResourceManager("RFID_FEATHER_ASSETS.Languages.UserRegistration", Assembly.GetExecutingAssembly());
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
                btnCancel.Text = rm.GetString("btnCancel");
                btnSubmit.Text = rm.GetString("btnSubmit");
                groupBox1.Text = rm.GetString("groupBox1");
                groupBox2.Text = rm.GetString("groupBox2");
                lblAuthorities.Text = rm.GetString("lblAuthorities");
                lblCpassword.Text = rm.GetString("lblCpassword");
                lblDesc.Text = rm.GetString("lblDesc");
                lblEmail.Text = rm.GetString("lblEmail");
                lblFname.Text = rm.GetString("lblFname");
                lblLname.Text = rm.GetString("lblLname");
                lblNoCameraAvailable.Text = rm.GetString("lblNoCameraAvailable");
                lblPassword.Text = rm.GetString("lblPassword");
                lblPosition.Text = rm.GetString("lblPosition");
                this.Text = rm.GetString("RegisterUser");
            }
        }
        private void SubmitImage()
        {
            Bitmap Image = (Bitmap)cameraBox.Image;
            Image.Save("user.jpg", ImageFormat.Jpeg);

            RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
            RestRequest upload = new RestRequest("/api/upload/image", Method.POST);

            upload.AddHeader("X-Auth-Token", tokenvalue);
            upload.AddHeader("Content-Type", "multipart/form-data");
            upload.AlwaysMultipartFormData = true;
            upload.AddFile("file", "user.jpg", "image/jpg");
            upload.AddParameter("companyId", companyId);
            upload.AddParameter("type", "asset");


            IRestResponse response = client.Execute(upload);

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
        private void GetRegDefaultImagePath()
        {
            try
            {
                //opening the subkey  
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SavedImagePath");

                //if it does exist, retrieve the stored values  
                if (key != null)
                {
                    txtSaveImageDir.Text = (string)(key.GetValue("DefaultImagePath"));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StartCamera()
        {
            try
            {
                cam = new VideoCaptureDevice(webcam[comVideoDeviceBox.SelectedIndex].MonikerString);
                cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                cam.Start();
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
                    if (language == "English") CaptureImg.Text = "Refresh Camera";
                    else if (language == "Japanese") CaptureImg.Text = "リフレシュカメラ";
                }
                else
                {
                    comVideoDeviceBox.SelectedIndex = 0;
                    StartCamera();
                    IsCameraConnected = true;
                    cameraBox.BackColor = Color.White;
                    lblNoCameraAvailable.Visible = false;
                    if (language == "English") CaptureImg.Text = "Capture Owner Photo";
                    else if (language == "Japanese") CaptureImg.Text = "所有者の写真";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            userInfo userinfo = new userInfo();

            if (firstName.Text.Length == 0 || lastName.Text.Length == 0 || position.Text.Length == 0 || description.Text.Length == 0 || email.Text.Length == 0 || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(cpassword.Text) /*|| imgCapture.Image == null*/)
            {
                if (language == "English") MessageBox.Show("Complete information is required.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else MessageBox.Show("完全な情報が必要とされています.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }
            else
            {
                if (password.Text.Length < 5)
                {
                    if (language == "English") MessageBox.Show("Password must have 6 or more characters");
                    else MessageBox.Show("パスワードは6文字以上を持っている必要があります");
                    return;
                }
                else
                {
                    if (password.Text != cpassword.Text)
                    {
                        if (language == "English") MessageBox.Show("Password do not match");
                        else MessageBox.Show("パスワードが一致しません");
                        return;
                    }
                    else
                    {
                        userinfo.companyId = companyId;
                        userinfo.imageUrl = ImgFileName;
                        userinfo.password = password.Text;
                        userinfo.confirmPassword = cpassword.Text;
                        userinfo.authorities = authorities.SelectedValue.ToString();
                        userinfo.firstName = firstName.Text;
                        userinfo.lastName = lastName.Text;
                        userinfo.description = description.Text;
                        userinfo.position = position.Text;
                        userinfo.email = email.Text;

                        RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
                        RestRequest user = new RestRequest("/api/user/add", Method.POST);
                        var authToken = tokenvalue;
                        user.AddHeader("X-Auth-Token", authToken);
                        user.AddHeader("Content-Type", "application/json; charset=utf-8");
                        user.RequestFormat = DataFormat.Json;
                        user.AddBody(userinfo);

                        IRestResponse response = client.Execute(user);
                        var content = response.Content;

                        if (response.StatusCode == HttpStatusCode.OK)
                        {

                            if (password.Text != cpassword.Text)
                            {
                                if (language == "English") MessageBox.Show("Password do not match");
                                else MessageBox.Show("パスワードが一致しません");

                                return;
                            }
                            if (language == "English") MessageBox.Show("User successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else MessageBox.Show("ユーザーが正常に保存され.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            //this.Hide();
                            //MainMenu MenuForm = new MainMenu(tokenvalue, string.Empty);
                            //MenuForm.ShowDialog();
                        }
                        else
                        {
                            HttpStatusCode statusCode = response.StatusCode;
                            int numericStatusCode = (int)statusCode;
                            MessageBox.Show("Error " + numericStatusCode);
                            return;
                        }
                    }
                }           
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            CallMainMenu();
            //cam.Stop();
        }
        private void CallMainMenu()
        {
            try
            {
                //Back to Main Menu 
                if (IsCameraConnected)
                    cam.Stop();
                
                this.Hide();
                MainMenu MenuForm = new MainMenu(tokenvalue, string.Empty);
                MenuForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            firstName.Text = string.Empty;
            lastName.Text = string.Empty;
            position.Text = string.Empty;
            description.Text = string.Empty;
            email.Text = string.Empty;
            imgCapture.Image = null;
            password.Text = string.Empty;
            cpassword.Text = string.Empty;          
            this.Refresh();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
        }
        private void CaptureImg_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cam == null || CaptureImg.Text == "Refresh Camera" || CaptureImg.Text == "リフレシュカメラ")
                {
                    InitializeCamera();
                }

                else if (IsCameraConnected)
                {
                    SubmitImage();
                    if (imgCapture.Image == null)
                    {
                        imgCapture.Image = cameraBox.Image;
                    }
                    else
                    {
                        if (language == "English") MessageBox.Show("You can save only 1 image.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else MessageBox.Show("写真を一つだけ.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cam.Stop();
                    InitializeCamera();
                    if (language == "English") CaptureImg.Text = "Captured Completed";
                    else CaptureImg.Text = "完成";
                }
            }
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBrowseImageDir_Click(object sender, EventArgs e)
        {
            try
            { 
                if (imagePathDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSaveImageDir.Text = imagePathDialog.SelectedPath;

                    //accessing the CurrentUser root element  
                    //and adding "DefaultImagePath" subkey to the "SOFTWARE" subkey  
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\SavedImagePath");

                    //storing the values  
                    key.SetValue("DefaultImagePath", txtSaveImageDir.Text);
                    key.Close();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void firstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSubmit_Click_1(sender, e);
            }
        }

        private void lastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSubmit_Click_1(sender, e);
            }
        }

        private void position_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSubmit_Click_1(sender, e);
            }
        }

        private void email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSubmit_Click_1(sender, e);
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSubmit_Click_1(sender, e);
            }
        }

        private void cpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSubmit_Click_1(sender, e);
            }
        }


    }

    
    


    public class userInfo
    {
        public string firstName { get; set; }
        public int companyId { get; set; }
        public string confirmPassword { get; set; }
        public string authorities { get; set; }
        public string lastName { get; set; }
        public string imageUrl { get; set; }
        public string position { get; set; }
        public string description {get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }

    public class Role
    {
        public string roleName { get; set; }
        public string value { get; set; }
    }
}