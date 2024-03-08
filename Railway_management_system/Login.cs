using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_management_system
{
    public partial class Login : Form
    {
        private SqlConnection mySqlConnection;
        public Login()
        {
            InitializeComponent();
            Dashboard dh = new Dashboard();
            string mysqlconn = dh.mysqlconn;
            mySqlConnection = new SqlConnection(mysqlconn);
        }
        private bool loginId()
        {
            string query = $"SELECT * FROM users WHERE  Email = '{this.Email.Text}' AND psw = '{this.psw.Text}';";
            try
            {
                if (OpenConn())
                {
                    SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        mySqlConnection.Close();
                        return true;
                    }

                    else
                    {
                        reader.Close();
                        mySqlConnection.Close();
                        return false;
                    }
                }
                else
                {
                    mySqlConnection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
                mySqlConnection.Close();
                return false;
            }
        }
        private bool OpenConn()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to the server failed");
                        break;
                    case 1024:
                        MessageBox.Show("Server username or password is incorrect");
                        break;
                }
                return false;
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            if(this.Email.Text != "" && this.psw.Text != "")
            {
                if (loginId())
                {
                    MessageBox.Show("welcome " + this.Email.Text);
                    Dashboard dh = new Dashboard();
                    dh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username and password doesnot match");
                }
            }
            else
            {
                MessageBox.Show("fill in all the boxes");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fg = new ForgetPassword();
            fg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
    }
}
