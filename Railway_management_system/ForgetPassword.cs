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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
            Dashboard DH = new Dashboard();
            string mysqlconn = DH.mysqlconn; //"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DMUIC\\LEVEL 1\\Visual Web Develoment\\Projects\\Sample1\\Sample1\\Employee_m_s.mdf;Integrated Security=True"; // collecting all the databse details 
            mySqlConnection = new SqlConnection(mysqlconn); // creating a new object from the class MySqlConnection which takas informations from the variable mysqlconn
        }
        private SqlConnection mySqlConnection;

        private bool updatepassword()
        {
            string query = $"UPDATE users SET psw = '{this.PSW.Text}' WHERE email = '{this.Email.Text}';";
            try
            {
                if (OpenConn())
                {
                    SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                    cmd.ExecuteNonQuery();
                    mySqlConnection.Close();
                    return true;


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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.PSW.Text != "" && this.Email.Text!="")
            {
                if (updatepassword())
                {
                    MessageBox.Show($"Password succesfully changed ");
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Password unsuccesfully changed ");
                }
            }
            else
            {
                MessageBox.Show("fill in all the boxes");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}
