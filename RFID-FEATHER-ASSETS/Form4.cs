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
    public partial class RegisterUser : Form
    {
        string connectionString = "server=128.199.83.107;port=3306;uid=root;pwd=aws123;database=feather_assets;";
        public RegisterUser()
        {
            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            firstName.Text = string.Empty;
            lastName.Text = string.Empty;
            position.Text = string.Empty;
            description.Text = string.Empty;
            email.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "aws123";
            string authorities = "guard";
            DateTime created_at = DateTime.Now;
            DateTime updated_at = DateTime.Now;
            DateTime deleted_at = DateTime.Now;
            try
            {
                if (firstName.Text.Length == 0 || lastName.Text.Length == 0 || position.Text.Length == 0 || description.Text.Length == 0 || email.Text.Length == 0)
                {
                    MessageBox.Show("Complete information is required.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into user(company_id,first_name,last_name,position,description,email,password,authorities,created_at,updated_at) values (@company_id,@first_name, @last_name, @position, @description, @email,@password,@authorities,@created_at,@updated_at)", con);
                cmd.Parameters.AddWithValue("@company_id", 1);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@authorities", authorities);
                cmd.Parameters.AddWithValue("@created_at", created_at);
                cmd.Parameters.AddWithValue("@updated_at", updated_at);
                //cmd.Parameters.AddWithValue("@deleted_at", deleted_at);
                cmd.Parameters.AddWithValue("@first_name", firstName.Text);
                cmd.Parameters.AddWithValue("@last_name", lastName.Text);
                cmd.Parameters.AddWithValue("@position", position.Text);
                cmd.Parameters.AddWithValue("@description", description.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User successfully saved.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
