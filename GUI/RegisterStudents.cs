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
using System.Threading;
using Project_SMS.Classes;

namespace Project_SMS
{
    public partial class RegisterStudents : Form
    {
       
        public RegisterStudents()
        {
            InitializeComponent();
            String pre = Homedash.p;
            String id = Homedash.i;
            String rid=null;
         
            suname.ReadOnly = true;

            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;database=sms_db;username=root;password=");
            try
            {
              
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
            try
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT addmission_id FROM studentreg_details  ORDER BY addmission_id  DESC LIMIT 1;", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                     rid= (dr[0].ToString());
                }
                
                dr.Close();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            int ridC = int.Parse(rid);
            ridC++;
            addno.Text = "G" + ridC;

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

        private void addimage_Click(object sender, EventArgs e)
        {

            String imageLocation = "";
            Thread t = new Thread((ThreadStart)(() => {
                try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| ALL Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    accimage.ImageLocation = imageLocation;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

        }

        private void reset_Click(object sender, EventArgs e)
        {
          
            fname.Text = "";
            dob.Value = DateTime.Today;
            gender.Text = null;
            father.Text = "";
            mother.Text = "";
            doa.Value = DateTime.Today;
            guardian.Text = "";
            contact.Text = "";
            address.Text = "";
            grade.Text = null;
            reli.Text = null;
            house.Text = null;
            section.Text = null;
            accimage.Image = null;



        }
       
       

       public void register_Click(object sender, EventArgs e)
        {
            String adno = addno.Text;
            String name = fname.Text;
            DateTime dateofb = dob.Value;
            String gen = gender.Text;
            String f = father.Text;
            String m = mother.Text;
            DateTime dateofa = doa.Value;
            String g = guardian.Text;
            String cont = contact.Text;
            String add = address.Text;
            String grad = grade.Text;
            String rel = reli.Text;
            String hou = house.Text;
            String sec = section.Text;
            String img = accimage.ImageLocation;

            if (adno == "" || name == ""  || gen == null || f == "" || m == "" ||  g == "" || cont == "" || add == "" || grad == null || rel == null ||hou==null ||sec==null || img==null)
            {
                MessageBox.Show("Please fill all the details ");
            }
            
            else
            {
                registerstudents obj = new registerstudents(adno, name, dateofb, gen, f, m, dateofa, g, cont, add, grad, rel, hou, sec, img);
                obj.addstudents();
            }

           
            
        
        }
    }

}
