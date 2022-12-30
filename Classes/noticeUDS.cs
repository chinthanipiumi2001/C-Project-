using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_SMS.Interfaces;

namespace Project_SMS.Classes
{
    class noticeUDS : Notice
    {
     private String grade;
     private String section;
     private String location;


        DBconnection db = new DBconnection();
        internal void upnotice(string gradet, string sectiont, string img)// Update Notice
        {
            this.grade = gradet;
            this.section = sectiont;
            this.location = img;
        }
        public void updatenotice()
        {
            db.updatenotice(grade, section, location);
        }
        internal void searchnotice(string gradet1, string sectiont1) // Search Notice
        {
            this.grade = gradet1;
            this.section = sectiont1;

        }
        public void checknotice2()
        {
            db.checknoticeup(grade, section);
        }
        internal void deletenotice1(string gradet, string sectiont) // Delete Notice
        {
            this.grade = gradet;
            this.section = sectiont;
        }

       
        public void deletenotice()
        {
            db.deleteNotice(grade, section);
        }

       
    }
}
