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


namespace Project_SMS.GUI
{
    public partial class viewnotice : Form
    {
        String pre = Homedash.p;
        String id = Homedash.i;
        public viewnotice()
        {
            InitializeComponent();
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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Dashboard h = new Student_Dashboard();
            h.Show();
        }

        private void studentlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homedash h = new Homedash();
            h.Show();
        }
        DBconnection obj = new DBconnection();
        private void viewnotice_Load(object sender, EventArgs e)
        {
            obj.Displaynotice(pre, id);
            noticedisplay.Image = DBconnection.noticeimg;
            

        }

        private void viewnotice_Shown(object sender, EventArgs e)
        {
            if (noticedisplay.Image == null)
            {

                MessageBox.Show("No Notices Avaialable !!!");
               

            }
        }
    }
}
