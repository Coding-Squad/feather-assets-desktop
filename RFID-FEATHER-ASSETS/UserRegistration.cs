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

namespace RFID_FEATHER_ASSETS
{

    public partial class RegisterUser : Form
    {
        string tokenvalue;
        string imagePath;

        public RegisterUser(string tokenvaluesource)
        {
            InitializeComponent();
            tokenvalue = tokenvaluesource;
            InitializeCamera();
            //CCT.Completed += new EventHandler<PhotoResult>(capture_completed);

            List<Role> roles = new List<Role>();
            roles.Add(new Role() { roleName = "Administrator", value = "ROLE_ADMIN" });
            roles.Add(new Role() { roleName = "Security", value = "ROLE_GUARD" });
            roles.Add(new Role() { roleName = "User", value = "ROLE_USER" });

            this.authorities.DataSource = roles;
            this.authorities.ValueMember = "value";
            this.authorities.DisplayMember = "roleName";                   
        }

        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        bool IsCameraConnected = false;
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
                    CaptureImg.Text = "Refresh Camera";
                }
                else
                {
                    comVideoDeviceBox.SelectedIndex = 0;
                    StartCamera();
                    IsCameraConnected = true;
                    cameraBox.BackColor = Color.White;
                    lblNoCameraAvailable.Visible = false;
                    CaptureImg.Text = "Capture Image";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            userInfo userinfo = new userInfo();

            if (firstName.Text.Length == 0 || lastName.Text.Length == 0 || position.Text.Length == 0 || description.Text.Length == 0 || email.Text.Length == 0 || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(cpassword.Text) || imgCapture.Image == null)
            {
                MessageBox.Show("Complete information is required.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }
            else
            {
                if (password.Text.Length < 5)
                {
                    MessageBox.Show("Password must have 6 or more characters");
                    return;
                }
                else
                {
                    if (password.Text != cpassword.Text)
                    {
                        MessageBox.Show("Password do not match");

                        return;
                    }
                    else
                    {
                        userinfo.companyId = 1;
                        userinfo.imageUrl = imagePath;
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
                                MessageBox.Show("Password do not match");

                                return;
                            }
                            MessageBox.Show("User successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CallMainMenu();
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
            this.Refresh();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            InitializeCamera();
        }
        private void CaptureImg_Click_1(object sender, EventArgs e)
        {
            //try
            //{
                if (cam == null || CaptureImg.Text == "Refresh Camera")
                {
                    InitializeCamera();
                }
                else if (IsCameraConnected)
                {                    
                    //DialogResult dialogResult = MessageBox.Show("Do you want to save image?", "Save", MessageBoxButtons.YesNo);
                    //if (dialogResult == DialogResult.Yes)
                    //{
                        string dirPath = @"C:\Users\USER\Pictures\";
                        string fileName = "User"+".jpg";
                        string[] files = Directory.GetFiles(dirPath);
                        int count = files.Count(file => { return file.Contains(fileName); });
                        string newFileName = (count == 0) ? "User.jpg" : String.Format("{0}{1}.jpg", fileName, count + 1);
                        cameraBox.Image.Save(dirPath + newFileName);
                        imagePath = dirPath + fileName;
                        if (imgCapture.Image == null) imgCapture.Image = cameraBox.Image;
                        else
                        {
                            MessageBox.Show("You can save only 1 image.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }                        
                    //}
                    //else if (dialogResult == DialogResult.No)
                    //{
                    //   InitializeCamera();
                    //}
                    //txtCapturedImagePath.Text = txtCapturedImagePath.Text + "," + dirPath + newFileName;
                    //cam.Stop();
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }      
        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            cameraBox.Image = bit;
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

