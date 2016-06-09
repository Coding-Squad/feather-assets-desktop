using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;
using RestSharp;
using System.Net;
using RestSharp.Deserializers;
using Microsoft.Win32;

namespace RFID_FEATHER_ASSETS
{

    
    public partial class LoginActivity : Form
    {
        //string connectionString = "server=128.199.83.107;port=3306;uid=root;pwd=aws123;database=feather_assets;";

        public LoginActivity(string portnamesource)
        {
            InitializeComponent();
            cmbComPort.Text = portnamesource;
        }

        private void ClearFields()
        {
            userName.Text = string.Empty;
            passWord.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginInfo loginInfo = new LoginInfo();
            //store information to object
            loginInfo.email = userName.Text;
            loginInfo.password = passWord.Text;

            //initialize web service
            //RestClient(request);
            RestClient client = new RestClient("http://52.163.93.95:8080/FeatherAssets/");
            RestRequest login = new RestRequest("/login", Method.POST);
            
        
            //pass information to web service
            login.AddHeader("Content-Type", "application/json; charset=utf-8");
            login.RequestFormat = DataFormat.Json;          
            login.AddBody(loginInfo);
           
            //retrieve response
            IRestResponse response = client.Execute(login);
            var content = response.Content;           

            //check for errors
            if (response.StatusCode == HttpStatusCode.OK)
            {
                
                //deserialize JSON -> Object
                LoginResult loginResult = new LoginResult();

                JsonDeserializer deserial = new JsonDeserializer();
                loginResult = deserial.Deserialize<LoginResult>(response);
                      
                //check authorities                       
                if (loginResult.roles == "ROLE_ADMIN")
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
                        MainMenu MenuForm = new MainMenu(loginResult.authenticationToken, cmbComPort.Text, loginResult.roles);
                        MenuForm.ShowDialog();
                    }
                }
                else if (loginResult.roles == "ROLE_GUARD")
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
                        Verification m = new Verification(loginResult.authenticationToken, cmbComPort.Text, loginResult.roles);
                        m.Show();
                    }
                }
                else if (loginResult.roles == "ROLE_USER")
                {
                    MessageBox.Show("Useless");
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
                MessageBox.Show("Error: " + numericStatusCode + response.ErrorMessage);
            }
            
             
        }

       
        /*private void registryKeyHandler()
        {
            
        }*/

        private void passWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                {
                    button1_Click(sender, e);
                }
          }

        private void LoginActivity_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
     }

    //Getters and Setters

    public class LoginInfo
    {
        public string email
        {
            get;
            set;
        }

        public string password
        {
            get;
            set;
        }
    }

    public class LoginResult
    {
        public int companyId
        {
            get;
            set;
        }

        public string companyName
        {
            get;
            set;
        }

        public int userId
        {
            get;
            set;
        }

        public string firstName
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }

        public string authenticationToken
        {
            get;
            set;
        }

        public string roles
        {
            get;
            set;
        }


    }
}
