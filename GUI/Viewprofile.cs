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
using Project_SMS.Classes;

namespace Project_SMS
{
    public partial class Viewprofile : Form
    {
        String pre = Homedash.p;
        String ID = Homedash.i;
        
        public Viewprofile()
        {
            InitializeComponent();
           
            suname.ReadOnly = true;
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;database=sms_db;username=root;password=");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT full_name FROM slogin_details where log_prefix='" + pre + "' AND log_id='" + ID + "'", con);
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

        private void studentlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homedash h = new Homedash();
            h.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Dashboard h = new Student_Dashboard();
            h.Show();
        }

        DBconnection obj = new DBconnection();
        

        private void Viewprofile_Load_1(object sender, EventArgs e)
        {


            obj.studentprofile(pre,ID);

            pictureBox2.Image = DBconnection.image;
            addid.Text = pre + "" + ID;
            sname.Text = DBconnection.sname;
            dob.Text = DBconnection.dob;
            gender.Text = DBconnection.gender;
            religion.Text = DBconnection.religion;
            fname.Text = DBconnection.fathern;
            mname.Text = DBconnection.mothern;
            gname.Text = DBconnection.gurdiann;
            contact.Text = DBconnection.contact;
            address.Text = DBconnection.addreess;
            doa.Text = DBconnection.doa;
            house.Text = DBconnection.house;
            grade.Text = DBconnection.grade;
            section.Text = DBconnection.section;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
