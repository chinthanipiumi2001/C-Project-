using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;

namespace Project_SMS
{
    class DBconnection
    {

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;database=sms_db;username=root;password=");

        public static String fname = null;
        public static String Id = null;

        

        public static String fname2 = null;
        public static String password = null;
        public static String Id2 = null;
        public static String sname = null;
        public static String dob = null;
        public static String fathern = null;
        public static String mothern = null;
        public static String gurdiann = null;
        public static String doa = null;
        public static String gender = null;
        public static String contact = null;
        public static String grade = null;
        public static String addreess = null;
        public static String religion = null;
        public static String house = null;
        public static String section = null, sectionop = null;
        public static Image image=null,noticeimg=null;
        public static String adno = null;
        public static String sin = null, eng = null, mat = null, sci = null, his = null, reli = null, it = null, music = null;
        public static String a1 = null, a2 = null, a3 = null, a4 = null;

        private String prefix;
        private String ID,ID2;
        private String Grade,Grade2;
        private String Section,Section2;
        private String Location;
        private String stat;
        private DataGridView dgv;
        private String date;
        private string name;

        public DBconnection()
        {
            Initialize();


        }
        private void Initialize()
        {



        }
       
       //Staff Dashboard 
        
        internal void setaddinfo(string prefix1, string id1)
        {
            this.prefix = prefix1;
            this.ID = id1;

            try
            {


                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT full_name,dob,gender,father_name,mother_name,gurdian_name,contact_no,religion,address,house,grade,section,student_picture,doa,addmission_id FROM studentreg_details where prefix='" + prefix + "' AND addmission_id='" + ID + "'", con);

                cmd.Parameters.AddWithValue(ID, ID);
                cmd.Parameters.AddWithValue(prefix, prefix);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                    sname = (dr1[0].ToString());

                    dob = (dr1[1].ToString());

                    gender = (dr1[2].ToString());

                    fathern = (dr1[3].ToString());

                    mothern = (dr1[4].ToString());

                    gurdiann = (dr1[5].ToString());

                    contact = (dr1[6].ToString());

                    religion = (dr1[7].ToString());

                    addreess = (dr1[8].ToString());

                    house = (dr1[9].ToString());

                    grade = (dr1[10].ToString());

                    section = (dr1[11].ToString());

                    byte[] img = (byte[])dr1[12];
                    MemoryStream ms = new MemoryStream(img);
                    image = Image.FromStream(ms);

                    doa = (dr1[13].ToString());
                    adno = (dr1[14].ToString());


                }
                dr1.Close();




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        internal void deletestudent(string prefix, string id1)
        {
            String p = prefix;
            String i = id1;
            try
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM studentreg_details WHERE prefix='" + p + "'AND addmission_id='" + i + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {


                }
                dr.Close();
                MessageBox.Show("Account ID : 'G" + i + "' Deleted Successfully!!!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void regstudents(string adno, string name, DateTime dateofb, string gen, string f, string m, DateTime dateofa, string g, string cont, string add, string grad, string rel, string hou, string sec, String img)
        {
            String id = adno;
            String Name = name;
            String dob = dateofb.ToString("MM/dd/yyyy");
            String gender = gen;
            String father = f;
            String mother = m;
            String doa = dateofa.ToString("MM/dd/yyyy");
            String gurdian = g;
            String Contact = cont;
            String address = add;
            String grade = grad;
            String religion = rel;
            String house = hou;
            String section = sec;
            String image = img;

            String cs = image.Replace(@"\", "/");

            string pre1 = string.Empty;
            string id1 = string.Empty;

            foreach (char c in id)
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

            bool check = false;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM studentreg_details where prefix='" + pre1 + "' AND addmission_id=" + id1 + "", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                check = dr.HasRows;

                if (check)
                {
                    MessageBox.Show("Account Already Exits");
                }
                dr.Close();
                if (!check)
                {
                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO studentreg_details Values('" + pre1 + "','" + id1 + "','" + Name + "','" + dob + "','" + gender + "','" + father + "','" + mother + "','" + gurdian + "','" + Contact + "','" + religion + "','" + address + "','" + house + "','" + grade + "','" + section + "',LOAD_FILE('" + cs + "'),'" + doa + "');", con);
                    MySqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {

                    }
                    MessageBox.Show("Student Registered Successfully");
                    MessageBox.Show("Student Addmission No : " + id);

                    dr2.Close();
                }



                con.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Insert to Marks

            
            try
            {
                con.Open();

                MySqlCommand cmd2 = new MySqlCommand("INSERT INTO marks_details(Admission_no, Full_Name, Grade, Section) VALUES ('"+id+ "','" + Name + "','" + grade + "','" + section + "');", con);
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {

                }

                dr2.Close();
                con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

             

} 
        internal void updatestudents(string prefix1, string id, string guardian, string contact1, string add, string gr, string sec, string h)
        {

            string pre = prefix1;
            string id2 = id;
            String g = guardian;
            String conatc = contact1;
            String a = add;
            String ga = gr;
            String section = sec;
            String house = h;
            String c =  pre+""+id2;


            try
            {
               
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE studentreg_details SET gurdian_name='" +g+ "' ,contact_no='" + conatc + "',address='" + a + "' ,house='" + house + "',grade='" + ga + "',section='" + section + "' WHERE addmission_id='" + id2 + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                MessageBox.Show("Student Account Sucessfully Updated !!");
                
                dr.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            try
            {
                con.Open();

                MySqlCommand cmd2 = new MySqlCommand("UPDATE marks_details SET Grade='"+ga+"',Section='"+section+"' WHERE Admission_no='"+c+"'", con);
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {

                }

                dr2.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

             
        }

        internal void checkaccount(string acctype, string uid)
        {

            String Acctype = acctype;
            String Id1 = uid;
            string pre1 = string.Empty;
            string id1 = string.Empty;

            foreach (char c in Id1)
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


            if (Acctype == "Student")
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT full_name,addmission_id,prefix FROM studentreg_details where prefix='" + pre1 + "' AND addmission_id='" + id1 + "'", con);

                    cmd.Parameters.AddWithValue(id1, id1);


                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fname = (dr[0].ToString());




                    }
                    dr.Close();




                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Acctype == "Teacher")
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT full_name,id,prefix FROM teacher_details where prefix='" + pre1 + "' AND id='" + id1 + "'", con);

                    cmd.Parameters.AddWithValue(id1, id1);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fname = (dr[0].ToString());





                    }
                    dr.Close();


                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        internal void createaccount(string pre, string id1, string actype, string uname, string pass)
        {
            String prefix = pre;
            String Id = id1;
            String Actype = actype;
            String name = uname;
            String password = pass;

            if (Actype == "Student")
            {
                bool check = false;
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM slogin_details where log_prefix='" + prefix + "' AND log_id=" + Id + "", con);
                    cmd.Parameters.AddWithValue(Id, id1);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    check = dr.HasRows;

                    if (check)
                    {
                        MessageBox.Show("Account Already Exits");
                    }
                    dr.Close();
                    if (!check)
                    {
                        MySqlCommand cmd2 = new MySqlCommand("INSERT INTO `slogin_details` Values('" + prefix + "','" + Id + "','" + name + "','" + Actype + "','" + password + "');", con);
                        MySqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {

                        }
                        MessageBox.Show("Student Account Created Successfully");
                        dr2.Close();
                    }



                    con.Close();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Actype == "Teacher")
            {
                bool check = false;
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tlogin_details where log_prefix='" + prefix + "' AND log_id=" + Id + "", con);
                    cmd.Parameters.AddWithValue(Id, id1);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    check = dr.HasRows;

                    if (check)
                    {
                        MessageBox.Show("Account Already Exits");
                    }
                    dr.Close();
                    if (!check)
                    {
                        MySqlCommand cmd2 = new MySqlCommand("INSERT INTO `tlogin_details` Values('" + prefix + "','" + Id + "','" + name + "','" + Actype + "','" + password + "');", con);
                        MySqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {

                        }
                        MessageBox.Show("Teacher Account Created Successfully");
                        dr2.Close();
                    }



                    con.Close();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Teacher Dashboard

        internal void updatenotice(string grade, string section, string location)
        {
            this.Grade = grade;
            this.Section = section;
            this.Location = location;
            String cs = Location.Replace(@"\", "/");     



            bool check = false;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT grade,section FROM notices_details where grade=" + Grade + " AND section='" + Section + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                check = dr.HasRows;

                if (check)
                {
                    MessageBox.Show("Notice Already Published Please Delete and Try Again");
                }
                dr.Close();
                if (!check)
                {
                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO notices_details Values('" + Grade + "','" + Section + "',LOAD_FILE('" + cs + "'));", con);
                    MySqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {

                    }
                    MessageBox.Show("Notice Successfully Added for Grade :" + Grade+""+Section+" Notice Board");
                    

                    dr2.Close();
                }



                con.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void checknoticeup(string grade, string section)
        {
           this.Grade = grade;
            this.Section = section;
            Image ig = null;
            bool check = false;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM notices_details where grade=" + Grade + " AND section='" + Section + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                check = dr.HasRows;

                if (!check)
                {
                    MessageBox.Show("No Notices Avaialable!!!");
                }
                dr.Close();

                if(check)
                {
                   
                    MySqlCommand cmd1 = new MySqlCommand("SELECT notice FROM notices_details where grade='" + Grade + "' AND section='" + Section + "'", con);

                    
                    MySqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {

                        byte[] img = (byte[])dr1[0];
                        MemoryStream ms = new MemoryStream(img);
                        ig=Image.FromStream(ms);
                      

                    }
                    dr1.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (ig == null)
            {
                image = null;
            }
            else
            {
                image = ig;
            }

        }
        internal void deleteNotice(string grade, string section)
        {
            this.Grade = grade;
            this.Section = section;

            bool check = false;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM notices_details where grade=" + Grade + " AND section='" + Section + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                check = dr.HasRows;

                if (!check)
                {
                    MessageBox.Show("No Notices Avaialable to Delete ");
                }
                dr.Close();

                if (check)
                {

                    MySqlCommand cmd1 = new MySqlCommand("DELETE FROM notices_details where grade='" + Grade + "' AND section='" + Section + "'", con);
                    MySqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {

                     
                    }
                    dr1.Close();
                    MessageBox.Show(Grade + "" + Section + " Notices Deleted Sucessfully!!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void updatemark(string addno1, string term11, string sin1, string eng1, string maths1, string his1, string sci1, string reli1, string it1, string music1)
        {

            try
            {
                con.Open();



                MySqlCommand cmd2 = new MySqlCommand("UPDATE marks_details SET Term=" + term11 + ",Sinhala=" + sin1 + ",English=" + eng1 + ",Maths=" + maths1 + ",Histroy=" + his1 + ",Science=" + sci1 + ",Religion=" + reli1 + ",ICT=" + it1 + ",Music=" + music1 + " WHERE Admission_no='" + addno1 + "'", con);

                MySqlDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {

                }
                MessageBox.Show("Record Updated Successfully");
                dr1.Close();
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        internal void searchmarks(string grade, string section, DataGridView dg)
        {
            this.Grade = grade;
            this.Section = section;
            this.dgv = dg;
            bool check = false;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from marks_details WHERE Grade='" + Grade + "'AND Section='" + Section + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                check = dr.HasRows;

                if (!check)
                {
                    MessageBox.Show("No Records !!!");
                }
                dr.Close();
                con.Close();
                if (check)
                {
                    MySqlDataAdapter adapt;
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new MySqlDataAdapter("select * from marks_details WHERE grade='" + Grade + "'AND section='" + Section + "'", con);
                    adapt.Fill(dt);
                    dgv.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void addmark(string addno, string term1, string sin, string eng, string maths, string his, string sci, string reli, string it, string music)
        {
            bool check = false;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from marks_details WHERE Admission_no='" +addno + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                check = dr.HasRows;

                if (check)
                {
                    MessageBox.Show("Already Values Have Been Inserted");
                }
                dr.Close();
                con.Close();
                if (!check)
                {
                    con.Open();
                    MySqlCommand cmd2;
                    cmd2 = new MySqlCommand("INSERT INTO marks_details(Term,Sinhala,English,Maths,Histroy,Science,Religion,ICT,Music) VALUES(" + term1 + "," + sin + "," + eng + "," + maths + "," + his + "," + sci + "," + reli + "," + it + "," + music + " WHERE Admission_no='" + addno + "'", con);
                    
                    MySqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {

                    }
                    MessageBox.Show("Record Inserted Successfully");
                    dr2.Close();
                    con.Close();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
         
         //Student Dashboard
         
        internal void studentprofile(string pre, string iD)
        {
            this.prefix = pre;
            this.ID = iD;
           
            try
            {


                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT full_name,dob,gender,father_name,mother_name,gurdian_name,contact_no,religion,address,house,grade,section,student_picture,doa FROM studentreg_details where prefix='" + prefix + "' AND addmission_id='" + ID + "'", con);

                cmd.Parameters.AddWithValue(ID, ID);
                cmd.Parameters.AddWithValue(prefix, prefix);
                MySqlDataReader dr1 = cmd.ExecuteReader();
                while (dr1.Read())
                {
                  sname  = (dr1[0].ToString());

                   dob = (dr1[1].ToString());

                     gender = (dr1[2].ToString());

                    fathern = (dr1[3].ToString());

                     mothern = (dr1[4].ToString());

                     gurdiann = (dr1[5].ToString());

                   contact = (dr1[6].ToString());

                    religion = (dr1[7].ToString());
                    addreess = (dr1[8].ToString());

                      house = (dr1[9].ToString());

                      grade = (dr1[10].ToString());

                      section = (dr1[11].ToString());

                    byte[] img = (byte[])dr1[12];
                    MemoryStream ms = new MemoryStream(img);
                   image = Image.FromStream(ms);

                     doa = (dr1[13].ToString());
                    


                }
              
                dr1.Close();




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        internal void Displaynotice(string pre, string id)
        {
            this.prefix = pre;
            this.ID = id;
            String getGrade=null;
            String getSection=null;
            Image i = null;
            
            try
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT grade,section FROM studentreg_details where prefix='" + prefix + "' AND addmission_id='" + ID + "'", con);
                
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    getGrade = (dr[0].ToString());

                    getSection = (dr[1].ToString());
                }
                dr.Close();
                con.Close();
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            try {
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT notice FROM notices_details where grade='" + getGrade + "' AND section='" + getSection + "'", con);
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {

                    byte[] img = (byte[])dr2[0];
                    MemoryStream ms = new MemoryStream(img);
                   i= Image.FromStream(ms);


                }
                dr2.Close();
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (i == null)
            {
                noticeimg = null;
            }
            else
            {
                noticeimg = i;
            }
        }
        internal void viewMarks(string addno, string grade, string section, string term1)
        {
            bool check = false;
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from marks_details WHERE Grade='" + grade + "'AND Section='" + section + "'AND Admission_no='"+addno+"'AND Term='"+term1+"'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                check = dr.HasRows;

                if (!check)
                {
                    MessageBox.Show("No Records !!!");
                }
                dr.Close();
                con.Close();
                if (check)
                {
                   
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand("select Admission_no,Full_Name,Sinhala,English,Maths,Science,Histroy,Religion,ICT,Music from marks_details  WHERE Grade='" + grade + "'AND Section='" + section + "'AND Admission_no='" + addno + "'AND Term='" + term1 + "'", con);
                    
                    MySqlDataReader dr1 = cmd2.ExecuteReader();
                    while (dr1.Read())
                    {
                        adno = (dr1[0].ToString());
                        fname = (dr1[1].ToString());
                        sin = (dr1[2].ToString());
                        eng = (dr1[3].ToString());
                        mat = (dr1[4].ToString());
                        sci = (dr1[5].ToString());
                          his = (dr1[6].ToString());
                        reli = (dr1[7].ToString());
                        it = (dr1[8].ToString());
                        music = (dr1[9].ToString());
                        
                    }
                    dr1.Close();
                    con.Close();
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(sin==null)
            {
                adno = null;
                fname = null;
                sin = null;
                eng = null;
                mat = null;
                sci = null;
                his = null;
                reli = null;
                it = null;
                music = null;
            }
        }
       
    }
}
