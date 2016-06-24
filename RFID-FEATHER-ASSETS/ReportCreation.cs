using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Win32;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID_FEATHER_ASSETS
{
    public partial class ReportCreation : Form
    {
        public Image PersonPhoto { get; set; }
        public string ExplanationNote { get; set; }

        string tokenvalue;
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        bool IsCameraConnected = false;

        public ReportCreation()
        {
            InitializeComponent();

            GetAssetSystemInfo();
            InitializeCamera();
            InitializePhotoLabel();
        }

        private void InitializePhotoLabel()
        {
            lblPersonPhoto.Text = "Step 1" + "\n" + lblPersonPhoto.Text;
            lblValidIDPhoto.Text = "Step 2" + "\n" + lblValidIDPhoto.Text;
        }

        private void InitializeCamera()
        {
            try
            {
                //Checking the camera status
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
                    btnCapturePhoto.Text = "Refresh Camera";
                }
                else
                {
                    comVideoDeviceBox.SelectedIndex = 0;
                    StartCamera();

                    IsCameraConnected = true;
                    cameraBox.BackColor = Color.White;
                    lblNoCameraAvailable.Visible = false;
                    //btnCapturePhoto.Text = "Capture Image";
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
                    txtSaveImageDir.Text = (string)(key.GetValue("PersonImagePath"));
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgCapture1.Image == null || imgCapture2.Image == null || txtExplanationNotes.Text.Length == 0)
                {
                    MessageBox.Show("Complete information is required.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtExplanationNotes.Focus();
                    return;
                }
                else
                {
                    //PersonPhoto = imgCapture1.Image;
                    //ExplanationNote = txtExplanationNote.Text;

                    DialogResult = DialogResult.OK;
                    //this.Dispose();
                }
                   
                ////For Web Service
                //Asset asset = new Asset();

                //asset.tag = txtRFIDTag.Text;
                //asset.tagType = 1;
                //asset.companyId = 1;
                //asset.description = txtDescription.Text;
                //asset.takeOutInfo = txtExplanationNote.Text;
                //asset.imageUrls = txtCapturedImagePath.Text;//txtImagePath.Text;

                //RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");//("http://feather-assets.herokuapp.com/");
                //RestRequest register = new RestRequest("/api/asset/add", Method.POST);

                //var authToken = tokenvalue;
                //register.AddHeader("X-Auth-Token", authToken);
                //register.AddHeader("Content-Type", "application/json; charset=utf-8");
                //register.RequestFormat = DataFormat.Json;
                //register.AddBody(asset);

                //lblSubmittingInformation.Visible = true;
                //this.Refresh();


                //IRestResponse response = client.Execute(register);
                //lblSubmittingInformation.Visible = false;

                //var content = response.Content;

                //if (response.StatusCode == HttpStatusCode.OK)//if (response.IsSuccessStatusCode)
                //{
                //    JsonDeserializer deserial = new JsonDeserializer();
                //    RestResult restResult = deserial.Deserialize<RestResult>(response);

                //    if (restResult.result == "OK")
                //    {
                //        MessageBox.Show("Record successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                          //DialogResult = DialogResult.OK;
                          //this.Dispose(); //ClearFields();
                //    }
                //    else
                //    {
                //        MessageBox.Show(restResult.result + " " + restResult.message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }

                //}
                //else
                //{
                //    MessageBox.Show("Error Code " +
                //    response.StatusCode /*+ " : Message - " + response.ErrorMessage*/);
                //    return;
                //}

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void ReportCreation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnCapturePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSaveImageDir.Text))
                {
                    MessageBox.Show("Please select Image Path.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnBrowseImagePath.Focus();
                    return;
                }
                else
                {
                    //btnGetRFIDTag.PerformClick();
                    //reader.CloseCom();
                    if (cam == null || btnCapturePhoto.Text == "Refresh Camera")
                    {
                        InitializeCamera();
                    }
                    else if (IsCameraConnected)
                    {
                        //Assigned captured image in each picture box
                        if (imgCapture1.Image == null)
                        {
                            imgCapture1.Image = cameraBox.Image;
                            lblPersonPhoto.Visible = false;
                            btnCapturePhoto.Text = "Capture Valid ID Photo";
                        }
                        else if (imgCapture2.Image == null)
                        {
                            imgCapture2.Image = cameraBox.Image;
                            lblValidIDPhoto.Visible = false;
                            btnCapturePhoto.Text = "Captured Completed";
                        }
                        else
                        {
                            MessageBox.Show("Captured Images exceeds the maximum limit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //Saving for captured images
                        string dirPath = txtSaveImageDir.Text.Trim() + @"\";//@"C:\Users\USER\Pictures\";
                        string fileName = "Image";
                        string[] files = Directory.GetFiles(dirPath);
                        int count = files.Count(file => { return file.Contains(fileName); });

                        string newFileName = (count == 0) ? "ReportedImage.jpg" : String.Format("{0}{1}.jpg", fileName, count + 1);

                        cameraBox.Image.Save(dirPath + newFileName);
                        txtCapturedImagePath.Text = txtCapturedImagePath.Text + "," + dirPath + newFileName;

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

        private void btnBrowseImagePath_Click(object sender, EventArgs e)
        {
            try
            {
                if (imagePathDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSaveImageDir.Text = imagePathDialog.SelectedPath;

                    //accessing the CurrentUser root element  
                    //and adding "PersonImagePath" subkey to the "SOFTWARE" subkey  
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AssetSystemInfo");

                    //storing the values  
                    key.SetValue("PersonImagePath", txtSaveImageDir.Text);
                    key.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (imgCapture1.Image != null || !string.IsNullOrEmpty(txtExplanationNotes.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the report creation?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    if (IsCameraConnected) cam.Stop();
                    DialogResult = DialogResult.Cancel;
                    this.Dispose();
                }
                //else
                //{
                //    //btnGetRFIDTag.Focus();
                //    //this.Dispose();
                //    return;
                //}
            }
            else
            {
                if (IsCameraConnected) cam.Stop();
                this.Dispose();
                //return;
            }
        }
    }
}
