using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

using Project_SMS;
using MySql.Data.MySqlClient;


namespace Project_SMS
{
    public partial class Homedash : Form
    {

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;database=sms_db;username=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        public Homedash()
        {
            InitializeComponent();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void accounttypetext_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static String p = null;
        public static String i = null;
        private void loginbutton_Click(object sender, EventArgs e)
        {
            
            String login_id = idtext.Text;
            String acc_type = accounttype.Text;
            String password = passtext.Text;

            string letters = string.Empty;
            string numbers = string.Empty;

            foreach (char c in login_id)
            {
                if (Char.IsLetter(c))
                {
                    letters += c;
                }
                if (Char.IsNumber(c))
                {
                    numbers += c;
                }
            }
            p = letters;
            i = numbers;




            if (acc_type == "" && login_id == "" && password == "")
            {
                MessageBox.Show("Please Input Credentials ");
            }
            else if (acc_type == "")
            {
                MessageBox.Show("Please Select User Type ");
            }
            else if (login_id == "")
            {
                MessageBox.Show("Please Enter Login ID ");
            }
            else if (password == "")
            {
                MessageBox.Show("Please Enter Password ");
            }
            else
            {
                
               
                try
                {
                  
                    if (acc_type == "Staff")
                    {
                        


                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT * FROM aslogin_details where prefix='" + letters + "' AND staff_id='" + numbers + "' AND password='" + password + "'";
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            staffdashboard sad = new staffdashboard();
                            sad.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login please check ID and Password");
                        }
                        con.Close();

                    }
                    else if (acc_type == "Teacher")
                    {
                        cmd = new MySqlCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT * FROM tlogin_details where log_prefix='" + letters + "' AND log_id='" + numbers + "' AND log_password='" + password + "'";
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            TeacherDash td = new TeacherDash();
                            td.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login please check ID and Password");
                        }
                        con.Close();
                    }
                    else
                    {
                        cmd = new MySqlCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT * FROM slogin_details where log_prefix='" + letters + "' AND log_id='" + numbers + "' AND log_password='" + password + "'";
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            Student_Dashboard sd = new Student_Dashboard();
                            sd.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login please check ID and Password");
                        }
                        con.Close();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }  


    }


    
        
    

