using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_SMS.Interfaces;

namespace Project_SMS.Classes
{
    class marksClass : Marks

    {
        private String grade;
        private String section;
        private DataGridView dg;
        private String addno;
        private String term1;
        private String sin;
        private String eng;
        private String maths;
        private String his;
        private String sci;
        private String reli;
        private String it;
        private String music;

        DBconnection obj = new DBconnection();
        internal void getsearch(string grade1, string section1, DataGridView dgrid)
        {
            this.grade = grade1;
            this.section = section1;
            this.dg = dgrid;
        }
        internal void getaddmarks(string addno, string term1, string sin, string eng, string maths, string his, string sci, string reli, string it, string music)
        {
            this.addno = addno;
            this.term1 = term1;
            this.sin = sin;
            this.eng = eng;
            this.maths = maths;
            this.his = his;
            this.sci = sci;
            this.reli = reli;
            this.it = it;
            this.music = music;

        }
        
        public void searchmarks()
        {
            obj.searchmarks(grade, section, dg);
        }

        public void addmarks()
        {
            obj.addmark(addno, term1, sin, eng, maths, his, sci, reli, it, music);
        }
        internal void updatemarks1(string addno, string term1, string sin, string eng, string maths, string his, string sci, string reli, string it, string music)
        {
            this.addno = addno;
            this.term1 = term1;
            this.sin = sin;
            this.eng = eng;
            this.maths = maths;
            this.his = his;
            this.sci = sci;
            this.reli = reli;
            this.it = it;
            this.music = music;
        }

        public void updatemarks()
        {
            obj.updatemark(addno, term1, sin, eng, maths, his, sci, reli, it, music);
        }
        internal void viewmymarks(string pre, string id, string gr, string sec, string ter)
        {
            this.addno = pre + "" + id;     
            this.grade = gr;
            this.section = sec;
            this.term1 = ter;
        }

        public void viewmarks()
        {
            obj.viewMarks(addno, grade, section, term1);
        }


    }
}
