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

namespace RFID_FEATHER_ASSETS
{

    public partial class RegisterUser : Form
    {
        string tokenvalue;

        public RegisterUser(string tokenvaluesource)
        {
            InitializeComponent();
            tokenvalue = tokenvaluesource;
            //CCT.Completed += new EventHandler<PhotoResult>(capture_completed);
        }

        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: ERROR 400
            userInfo userinfo = new userInfo();
            userinfo.companyId = 1;
            userinfo.imageUrl = "wew";
            userinfo.password = "aws123";
            userinfo.confirmPassword = "aws123";
            userinfo.authorities = "user";
            userinfo.firstName = firstName.Text;
            userinfo.lastName = lastName.Text;
            userinfo.description = description.Text;
            userinfo.position = position.Text;
            userinfo.email = email.Text;
           

            if (firstName.Text.Length == 0 || lastName.Text.Length == 0 || position.Text.Length == 0 || description.Text.Length == 0 || email.Text.Length == 0)
            {
                MessageBox.Show("Complete information is required.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            RestClient client = new RestClient("http://feather-assets.herokuapp.com/");
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
                MessageBox.Show("User successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                this.Hide();
                MainMenu MenuForm = new MainMenu(tokenvalue, string.Empty, string.Empty);
                MenuForm.ShowDialog();
            }
            else
            {
                HttpStatusCode statusCode = response.StatusCode;
                int numericStatusCode = (int)statusCode;
                MessageBox.Show("Error" + numericStatusCode);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearFields()
        {
            firstName.Text = string.Empty;
            lastName.Text = string.Empty;
            position.Text = string.Empty;
            description.Text = string.Empty;
            email.Text = string.Empty;
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void CaptureImg_Click(object sender, EventArgs e)
        {
            cam.Stop();
            saveFileDialog1.InitialDirectory = @"C:\Users\USER\Pictures\";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName + ".jpg");
            }

            //string imageDir = saveFileDialog1.InitialDirectory + saveFileDialog1.FileName;
            
            //MessageBox.Show(imageDir);
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
            cam.Start();
        }

    }


    public class userInfo
    {
        public string firstName
        {
            get;
            set;
        }

        public int companyId
        {
            get;
            set;
        }

        public string confirmPassword
        {
            get;
            set;
        }

        public string authorities
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }

        public string imageUrl
        {
            get;
            set;
        }

        public string position
        {
            get;
            set;
        }
        public string description
        {
            get;
            set;
        }

        public string password
        {
            get;
            set;
        }
        //public string authenticationToken
        //{
        //    get;
        //    set;
        //}
        public string email
        {
            get;
            set;
        }

    }

    //public class CameraCaptureTask {
    //    private byte[] _imageBytes;      
    //    CameraCaptureTask CCT = new CameraCaptureTask();
    //    private static string imgFileName = "CharlesGay";
    //    string imageFolder = @"\CharlesHandsome\Not";
    //    string imageFileName = imgFileName+".jpg";

    }

