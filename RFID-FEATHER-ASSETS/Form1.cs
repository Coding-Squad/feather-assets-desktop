using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace RFID_FEATHER_ASSETS
{
    public partial class LoginActivity : Form
    {
        string connectionString = "server=128.199.83.107;port=3306;uid=root;pwd=aws123;database=feather_assets;";
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
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                try
                {
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT email,password FROM user WHERE email=@username and password=@password", con);
                    cmd.Parameters.Add(new MySqlParameter("@username", userName.Text));
                    cmd.Parameters.Add(new MySqlParameter("@password", passWord.Text));
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        con.Close();
                        dr.Close();
                        MainMenu MenuForm = new MainMenu(string.Empty);
                        MenuForm.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User! Try again with VALID username and password");
                    }
                    if (!dr.IsClosed)
                        dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                    con.Dispose();
                }
            }
        }
    }
}
