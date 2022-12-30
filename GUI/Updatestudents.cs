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
    public partial class Updatestudents : Form
    {
        public Updatestudents()
        {
            InitializeComponent();
            String pre = Homedash.p;
            String id = Homedash.i;
            suname.ReadOnly = true;
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;database=sms_db;username=root;password=");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT full_name FROM aslogin_details where prefix='" + pre + "' AND staff_id='" + id + "'", con);
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
            staffdashboard h = new staffdashboard();
            h.Show();
        }
        DBconnection obj = new DBconnection();
        private void addmissionno_TextChanged(object sender, EventArgs e)
        {
            String addno = addmissionno.Text;
            string prefix = string.Empty;
            string id1 = string.Empty;
            foreach (char c in addno)
            {
                if (Char.IsLetter(c))
                {
                    prefix += c;
                }
                if (Char.IsNumber(c))
                {
                    id1 += c;
                }
            }
            obj.setaddinfo(prefix, id1);

            if(addno=="" || id1!=DBconnection.adno)
            {
                userp.Image = null;
                id.Text = "";
                name.Text = "";
                dob.Text = "";
                gender.Text = "";
                religion.Text = "";
                father.Text = "";
                mother.Text = "";
                gurdian.Text = "";
                contact.Text = "";
                address.Text = "";
                adddate.Text = "";
                grade.Text = "";
                section.Text = "";
                house.Text = "";
            }
            else
            {
                userp.Image = DBconnection.image;
                id.Text = prefix+""+id1;
                name.Text = DBconnection.sname;
                dob.Text = DBconnection.dob;
                gender.Text = DBconnection.gender;
                religion.Text = DBconnection.religion;
                father.Text = DBconnection.fathern;
                mother.Text = DBconnection.mothern;
                gurdian.Text = DBconnection.gurdiann;
                contact.Text = DBconnection.contact;
                address.Text = DBconnection.addreess;
                adddate.Text = DBconnection.doa;
                grade.Text = DBconnection.grade;
                section.Text = DBconnection.section;
                house.Text = DBconnection.house;
            }
          

        }

        private void reset_Click(object sender, EventArgs e)
        {
            userp.Image = null;
            id.Text = "";
            name.Text = "";
            dob.Text = "";
            gender.Text = "";
            religion.Text = "";
            father.Text = "";
            mother.Text = "";
            gurdian.Text = "";
            contact.Text = "";
            address.Text = "";
            adddate.Text = "";
            grade.Text = "";
            section.Text = "";
            house.Text = "";
            addmissionno.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            String addno = id.Text;
            string prefix = string.Empty;
            string id1 = string.Empty;
            foreach (char c in addno)
            {
                if (Char.IsLetter(c))
                {
                    prefix += c;
                }
                if (Char.IsNumber(c))
                {
                    id1 += c;
                }
            }
            String guardian= gurdian.Text;
            String contact1 = contact.Text;
            String add = address.Text;
            String gr = grade.Text;
            String sec = section.Text;
            String h = house.Text;

            Updatedeletestudent obj = new Updatedeletestudent();
            obj.getupdate(prefix, id1, guardian, contact1, add, gr, sec, h);
            obj.updatestudent();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            String addno1 = id.Text;
            string prefix1 = string.Empty;
            string id11 = string.Empty;
            foreach (char c in addno1)
            {
                if (Char.IsLetter(c))
                {
                    prefix1 += c;
                }
                if (Char.IsNumber(c))
                {
                    id11 += c;
                }
            }

            Updatedeletestudent obj1 = new Updatedeletestudent();
            obj1.getdel(prefix1, id11);
            obj1.deletestudent();
        }
    }
}
