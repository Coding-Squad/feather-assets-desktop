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
using MySql.Data.MySqlClient;
using RestSharp;
using System.Net;
using RestSharp.Deserializers;
using Microsoft.Win32;

namespace RFID_FEATHER_ASSETS
{
    public partial class LoginActivity : Form
    {
        //string connectionString = "server=128.199.83.107;port=3306;uid=root;pwd=aws123;database=feather_assets;";

        public LoginActivity()
        {
            InitializeComponent();           
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
            RestClient client = new RestClient("http://feather-assets.herokuapp.com/");
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
                JsonDeserializer deserial = new JsonDeserializer();
                LoginResult loginResult = deserial.Deserialize<LoginResult>(response);
                
                
                //Registry.CurrentUser.DeleteSubKey("FeatherTraq", false);
                //RegistryKey rk = Registry.CurrentUser.CreateSubKey("FeatherTraq");
                //rk.SetValue("authenticationKey", loginResult.authenticationToken, RegistryValueKind.String);
                    
               
                //Registry.SetValue("Login Result" , "authToken", loginResult.authenticationToken);
                //Session["authToken"] = loginResult.authenticationToken;
                //test if response results are stored in object
                //MessageBox.Show("" + loginResult.authenticationToken);

                //go to main menu if result code OK
                this.Hide();
                MainMenu MenuForm = new MainMenu(loginResult.authenticationToken,  string.Empty);
                MenuForm.ShowDialog();
                
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
            
             
        }

        private void registryKeyHandler()
        {
            
        }

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
