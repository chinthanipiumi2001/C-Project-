using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Project_SMS.GUI;

namespace Project_SMS
{
    public partial class Student_Dashboard : Form
    {

        public Student_Dashboard()
        {
            InitializeComponent();
            String pre = Homedash.p;
            String id = Homedash.i;
            
            suname.ReadOnly = true;
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;database=sms_db;username=root;password=");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT full_name FROM slogin_details where log_prefix='" + pre + "' AND log_id='" + id + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    suname.Text = (dr[0].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Student_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void studentlogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Homedash h = new Homedash();
            h.Show();
        }

        private void viewprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Viewprofile b = new Viewprofile();
            b.Show();
        }

        private void Repbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewreports b = new viewreports();
            b.Show();
        }

        

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewnotice b = new viewnotice();
            b.Show();
        }
    }
}
