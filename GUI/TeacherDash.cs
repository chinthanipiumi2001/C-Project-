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

namespace Project_SMS
{
    public partial class TeacherDash : Form
    {
        public TeacherDash()
        {
            InitializeComponent();
            String pre = Homedash.p;
            String id = Homedash.i;
            suname.ReadOnly = true;
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;database=sms_db;username=root;password=");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT full_name FROM tlogin_details where log_prefix='" + pre + "' AND log_id='" + id + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    suname.Text = (dr[0].ToString());
                }
                dr.Close();
                con.Close();
            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
            
            

        }

        private void studentlogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Homedash h = new Homedash();
            h.Show();
        }

        private void addmarks_Click(object sender, EventArgs e)
        {
            this.Hide();
           Addmarks  b = new Addmarks();
            b.Show();
        }

        

        private void notices_Click(object sender, EventArgs e)
        {
            this.Hide();
            notices b = new notices();
            b.Show();
        }
    }
}
