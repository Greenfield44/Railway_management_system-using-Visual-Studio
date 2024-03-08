using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Railway_management_system
{
    public partial class Dashboard : Form
    {
        private SqlConnection mySqlConnection;
        public string mysqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\DMUIC\\LEVEL 1\\Visual Web Develoment\\code\\Railway_management_system\\Railway_management_system\\RailDB.mdf\";Integrated Security=True"; // collecting all the databse details 

        public Dashboard()
        {
            InitializeComponent();
            fillcombo(mysqlconn);
            mySqlConnection = new SqlConnection(mysqlconn);
            bindData(mysqlconn);
            bindDataR(mysqlconn);
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

        private bool deletetrains()
        {

          

            string query = $"DELETE FROM train WHERE trainname='{this.tname.Text}';";
            try
            {
                if (OpenConn())
                {
                    SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                    try
                    {
                        cmd.ExecuteNonQuery();
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

        private bool createtrains()
        {

            string query = $"INSERT INTO train (trainname,speed,departure,arrival,rout) VALUES ('{this.tname.Text}','{this.speed.Text}','{this.departure.Text}','{this.Arrival.Text}','{this.route.Text}');";
            try
            {
                if (OpenConn())
                {
                    SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                    try
                    {
                        cmd.ExecuteNonQuery();
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

        private bool updatetrains()
        {
            string query = $"UPDATE train SET trainname='{this.tname.Text}',speed='{this.speed.Text}',departure='{this.departure.Text}',arrival='{this.Arrival.Text}',rout='{this.route.Text}' WHERE trainname='{this.tname.Text}' ;";
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

        private bool searchtrains()
        {

            string query = $"SELECT * FROM train WHERE  trainname='{this.tname.Text}';";

            try
            {
                if (OpenConn())
                {
                    SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        traindatagrid.DataSource = dataTable;
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

        private bool createreservation()
         {

             string query = $"INSERT INTO reservation (passengername,passengeremail,passengerphone,passengergender,trainid) VALUES ('{this.textBox16.Text}','{this.textBox15.Text}','{this.textBox14.Text}','{this.textBox13.Text}','{this.comboBox1.Text}');";
             try
             {
                 if (OpenConn())
                 {
                     SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                     try
                     {
                         cmd.ExecuteNonQuery();
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

        private bool updatereservation()
         {
             string query = $"UPDATE reservation SET passengername='{this.textBox16.Text}',passengeremail='{this.textBox15.Text}',passengerphone='{this.textBox14.Text}',passengergender='{this.textBox13.Text}',trainid='{this.comboBox1.Text}' WHERE passengeremail='{this.textBox15.Text}' OR passengerphone='{this.textBox14.Text}' ;";
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

        private bool deletereservation()
         {

             string query = $"DELETE FROM reservation WHERE passengeremail='{this.textBox15.Text}';";

             try
             {
                 if (OpenConn())
                 {
                     SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                     try
                     {
                         cmd.ExecuteNonQuery();
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

        private bool searchtreservation()
        {

            string query = $"SELECT * FROM reservation WHERE  passengeremail='{this.textBox15.Text}';";

            try
            {
                if (OpenConn())
                {
                    SqlCommand cmd = new SqlCommand(query, mySqlConnection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        traindatagrid.DataSource = dataTable;
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

        void fillcombo(string mysqlconn)
        {
            //string mysqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DMUIC\\LEVEL 1\\Visual Web Develoment\\Projects\\Sample1\\Sample1\\Employee_m_s.mdf;Integrated Security=True"; // collecting all the databse details 
            string query = "select * from train;";
            SqlConnection conn = new SqlConnection(mysqlconn);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    int ID = myReader.GetInt32("id");
                    comboBox1.Items.Add(ID);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
                conn.Close();
            }
        }

        void bindData(string mysqlconn)
        {
            //string mysqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DMUIC\\LEVEL 1\\Visual Web Develoment\\Projects\\Sample1\\Sample1\\Employee_m_s.mdf;Integrated Security=True"; // collecting all the databse details 

            SqlConnection conn = new SqlConnection(mysqlconn);
            SqlCommand cmd = new SqlCommand("select * from train;", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            traindatagrid.DataSource = dt;
        }
        
        void bindDataR(string mysqlconn)
        {
            //string mysqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DMUIC\\LEVEL 1\\Visual Web Develoment\\Projects\\Sample1\\Sample1\\Employee_m_s.mdf;Integrated Security=True"; // collecting all the databse details 

            SqlConnection conn = new SqlConnection(mysqlconn);
            SqlCommand cmd = new SqlCommand("select * from reservation;", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            this.dataGridView4.DataSource = dt;
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (searchtrains())
            {
                MessageBox.Show("succesfull research train ");
            }
            else
            {
                MessageBox.Show("unsuccesfull research train ");
            }
        }

        private void trainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void train_Click(object sender, EventArgs e)
        {
            trainpanel.Show();
            welcome.Hide();

            reservationpanel.Hide();
        }

        private void station_Click(object sender, EventArgs e)
        {
            trainpanel.Hide();
            welcome.Hide();

            reservationpanel.Hide();
        }

        private void ticket_Click(object sender, EventArgs e)
        {
            trainpanel.Hide();
            welcome.Hide();

            reservationpanel.Hide();
        }

        private void reservation_Click(object sender, EventArgs e)
        {
            trainpanel.Hide();
            welcome.Hide();
            reservationpanel.Show();
        }

        private void createtrain_Click(object sender, EventArgs e)
        {
            if (createtrains())
            {
                MessageBox.Show("succesfull create train ");
                bindData(mysqlconn);
            }
            else
            {
                MessageBox.Show("unsuccesfull create train ");
            }
        }

        private void updatetrain_Click(object sender, EventArgs e)
        {
            if (updatetrains())
            {
                MessageBox.Show("succesfull updated train ");
                bindData(mysqlconn);
            }
            else
            {
                MessageBox.Show("unsuccesfull updated train ");
            }
        }

        private void deletetrain_Click(object sender, EventArgs e)
        {
            if (deletetrains())
            {
                MessageBox.Show("succesfull delete train ");
                bindData(mysqlconn);
            }
            else
            {
                MessageBox.Show("unsuccesfull delete train ");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (createreservation())
            {
                MessageBox.Show("succesfull create reservation ");
                bindDataR(mysqlconn);
            }
            else
            {
                MessageBox.Show("unsuccesfull create reservation ");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (updatereservation())
            {
                MessageBox.Show("succesfull updated reservation ");
                bindDataR(mysqlconn);
            }
            else
            {
                MessageBox.Show("unsuccesfull updated reservation ");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (deletereservation())
            {
                MessageBox.Show("succesfull delete reservation ");
                bindDataR(mysqlconn);
            }
            else
            {
                MessageBox.Show("unsuccesfull delete reservation ");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (searchtreservation())
            {
                MessageBox.Show("succesfull search reservation ");
               
            }
            else
            {
                MessageBox.Show("unsuccesfull search reservation ");
            }
        }
    }
}
