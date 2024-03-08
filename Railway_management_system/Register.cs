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
    public partial class Register : Form
    {
        private SqlConnection mySqlConnection;

        public Register()
        {
            InitializeComponent();
            Dashboard dh = new Dashboard();
            string mysqlconn = dh.mysqlconn;
            mySqlConnection = new SqlConnection(mysqlconn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registration_Click(object sender, EventArgs e)
        {
            if(this.psw.Text == this.psw1.Text)
            {
                if (registrations())
                {
                    MessageBox.Show(" succesfully created user ", this.fullname.Text);
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" unsuccesfully created user ", this.fullname.Text);
                }
            }
            else
            {
                MessageBox.Show("password doesnot match");
            }

        }
        private bool ConOpen()
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

        private bool registrations()
        {
            // Prepare the SQL query
            string query = $"INSERT INTO users (fullname,Email,psw) VALUES('{this.fullname.Text}','{this.Email.Text}','{this.psw.Text}')";
            try
            {
                if (ConOpen())
                {
                    SqlCommand command = new SqlCommand(query, mySqlConnection);
                    try
                    {
                        command.ExecuteNonQuery();
                        mySqlConnection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Text, ex.Message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}
