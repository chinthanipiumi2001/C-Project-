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
    public partial class staffdashboard : Form
    {
        public staffdashboard()
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

        private void Admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void studentlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homedash h = new Homedash();
            h.Show();
        }

        private void regstudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterStudents b = new RegisterStudents();
            b.Show();
        }

        

        private void vustudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updatestudents b = new Updatestudents();
            b.Show();
        }

        private void createaccounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount b = new CreateAccount();
            b.Show();
        }
    }
}
