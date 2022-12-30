using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SMS.Classes
{
    class registerstudents : Rabstract
    {
        public registerstudents(string adno, string name, DateTime dateofb, string gen, string f, string m, DateTime dateofa, string g, string cont, string add, string grad, string rel, string hou, string sec, String img)
        {
            Adno = adno;
            Name = name;
            Dateofb = dateofb;
            Gen = gen;
            F = f;
            M = m;
            Dateofa = dateofa;
            G = g;
            Cont = cont;
            Add = add;
            Grad = grad;
            Rel = rel;
            Hou = hou;
            Sec = sec;
            Img = img;
        }

        public string Adno;
        public string Name;
        public DateTime Dateofb;
        public string Gen;
        public string F;
        public string M;
        public DateTime Dateofa;
        public string G;
        public string Cont;
        public string Add;
        public string Grad;
        public string Rel;
        public string Hou;
        public string Sec;
        public string Img;

        public override void addstudents()
        {


            DBconnection obj = new DBconnection();
            obj.regstudents(Adno, Name, Dateofb, Gen, F, M, Dateofa, G, Cont, Add, Grad, Rel, Hou, Sec, Img);




        }



    }




}
