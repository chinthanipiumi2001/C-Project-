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
    public partial class notices : Form
    {
        public notices()
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
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private Image img;
        private void studentlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homedash h = new Homedash();
            h.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherDash h = new TeacherDash();
            h.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(grade.Text=="" && section.Text=="")
            {
                MessageBox.Show("Please Select Grade & Section ");
            }
            else
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
                            img1.ImageLocation = imageLocation;

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
           
        }
        noticeUDS obj = new noticeUDS();
       
        private void upload_Click(object sender, EventArgs e)
        {

            String gradet = grade.Text;
            String sectiont = section.Text;
            String img = img1.ImageLocation;

            if(gradet==null || sectiont==null || img==null)
            {
                MessageBox.Show("Please Select Grade,Section & Image");
            }
            else
            {
                obj.upnotice(gradet, sectiont, img);
                obj.updatenotice();

            }




           
        }

        private void search_Click(object sender, EventArgs e)
        {
           
            String gradet = grade.Text;
            String sectiont = section.Text;

            if (gradet=="" || sectiont=="")
            {
                MessageBox.Show("Please Select Grade & Section ");
            }
            else if
                 (gradet == "" && sectiont == "")
            {
                MessageBox.Show("Please Select Grade & Section ");
            }
            
            else
            {
                obj.searchnotice(gradet, sectiont);
                obj.checknotice2();

                img1.Image = DBconnection.image;
                
                
            }
          
        }

        private void delete_Click(object sender, EventArgs e)
        {
            String gradet = grade.Text;
            String sectiont = section.Text;
            if(gradet == "" || sectiont == "")
            {
                MessageBox.Show("Please Select Grade & Section ");
            }
            else if
                (gradet =="" && sectiont =="")
            {
                MessageBox.Show("Please Select Grade & Section ");
            }
           
            else
            {
                obj.deletenotice1(gradet, sectiont);
                obj.deletenotice();
                img1.Image = null;
            }
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            grade.Text = null;
            section.Text = null;
            img1.Image = null;

        }

       
    }
}
