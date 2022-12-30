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
    public partial class Addmarks : Form
    {
        public Addmarks()
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
        private void display()
        {
            String grade1 = grade.Text;
            String section1 = section.Text;
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;database=sms_db;username=root;password=");
            MySqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from marks_details WHERE Grade='" + grade1 + "'AND Section='" + section1 + "'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            fname.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            term.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            s.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            e2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            m.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            h.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            s2.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            r.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            i.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            m2.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        marksClass obj = new marksClass();
        private void search_Click(object sender, EventArgs e)
        {
            String grade1 = grade.Text;
            String section1 = section.Text;
            DataGridView dgrid = dataGridView1;

            obj.getsearch(grade1, section1, dgrid);
            obj.searchmarks();
        }

        private void add_Click(object sender, EventArgs e)
        {
            String addno = id.Text;
            String term1 = term.Text;
            String sin = s.Text;
            String eng = e2.Text;
            String maths = m.Text;
            String his = h.Text;
            String sci = s2.Text;
            String reli = r.Text;
            String it = i.Text;
            String music = m2.Text;
            if (term.Text != "" && s.Text != "" && e2.Text != "" && m.Text != ""&& h.Text != "" && s2.Text != "" && r.Text != "" && i.Text != ""  && m2.Text != "")
            {
                obj.getaddmarks(addno, term1, sin, eng, maths, his, sci, reli, it, music);
                obj.addmarks();
                display();
            }
            else
            {
                MessageBox.Show("Please Enter Details to Insert");
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            String addno = id.Text;
            String term1 = term.Text;
            String sin = s.Text;
            String eng = e2.Text;
            String maths = m.Text;
            String his = h.Text;
            String sci = s2.Text;
            String reli = r.Text;
            String it = i.Text;
            String music = m2.Text;
            if (term.Text != "" && s.Text != "" && e2.Text != "" && m.Text != "" && h.Text != "" && s2.Text != "" && r.Text != "" && i.Text != "" && m2.Text != "")
            {
                obj.updatemarks1(addno, term1, sin, eng, maths, his, sci, reli, it, music);
                obj.updatemarks();
                display();
            }
            else
            {
                MessageBox.Show("Please Enter Details to Update");
            }
        }
    }
}
