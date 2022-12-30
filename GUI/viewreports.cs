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
    public partial class viewreports : Form
    {
        String pre = Homedash.p;
        String id = Homedash.i;
        public viewreports()
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
        marksClass obj = new marksClass();
        private void checkb_Click(object sender, EventArgs e)
        {
            String gr = grade.Text;
            String ter = term.Text;
            String sec = section.Text;
            obj.viewmymarks(pre, id, gr, sec, ter);
            obj.viewmarks();
            addid.Text = DBconnection.adno;
            sname.Text = DBconnection.fname;
            sin.Text = DBconnection.sin;
            eng.Text = DBconnection.eng;
            mat.Text = DBconnection.mat;
            his.Text = DBconnection.his;
            sci.Text = DBconnection.sci;
            reli.Text = DBconnection.reli;
            it.Text = DBconnection.it;
            musi.Text = DBconnection.music;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            grade.Text = null;
            section.Text = null;
            term.Text = null;
            addid.Text = "";
            sname.Text = "";
            sin.Text = "";
            eng.Text = "";
            mat.Text = "";
            his.Text = "";
            sci.Text = "";
            reli.Text = "";
            it.Text = "";
            musi.Text = "";
        }
    }
}
