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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
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
         

        

        DBconnection obj = new DBconnection();
      

        private void id_TextChanged(object sender, EventArgs e)
        {
           
                String acctype = accounttype.Text;
                String uid = id.Text;
                obj.checkaccount(acctype, uid);//pass account type and id to checkaccount method in DBconnection class
                string pre1 = string.Empty;
                string id1 = string.Empty;
                foreach (char c in uid)
                {
                    if (Char.IsLetter(c))
                    {
                        pre1 += c;
                    }
                    if (Char.IsNumber(c))
                    {
                        id1 += c;
                    }
                }

                if (uid == "")
                {
                    fullname.Text = "";

                }
                else
                {
                    fullname.Text = DBconnection.fname;
                }

            
        }
        private void reset_Click(object sender, EventArgs e)
        {

            accounttype.Text = null;
            id.Text = "";
            password.Text = "";
            password2.Text = "";

        }

        private void createac_Click(object sender, EventArgs e)
        {
            
                if (password.Text != password2.Text)
                {
                    MessageBox.Show("Passwords Doesn't Match");
                }
                else
                {
                    string pre = string.Empty;
                    string id1 = string.Empty;
                    foreach (char c in id.Text)
                    {
                        if (Char.IsLetter(c))
                        {
                            pre += c;
                        }
                        if (Char.IsNumber(c))
                        {
                            id1 += c;
                        }
                    }
                    String actype = accounttype.Text;
                    String uname = fullname.Text;
                    String pass = password.Text;

                    obj.createaccount(pre, id1, actype, uname, pass);
                

            }

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            

                if (password.Text != password2.Text)
                {
                    MessageBox.Show("Passwords Doesn't Match");
                }
                else
                {
                    string pre = string.Empty;
                    string id1 = string.Empty;
                    foreach (char c in id.Text)
                    {
                        if (Char.IsLetter(c))
                        {
                            pre += c;
                        }
                        if (Char.IsNumber(c))
                        {
                            id1 += c;
                        }
                    }
                    String actype = accounttype.Text;
                    String uname = fullname.Text;
                    String pass = password.Text;

                    obj.createaccount(pre, id1, actype, uname, pass);
                


            
        }
    }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            staffdashboard h = new staffdashboard();
            h.Show();
        }

        private void studentlogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Homedash h = new Homedash();
            h.Show();
        }
    }
}
