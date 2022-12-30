using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_SMS.Interfaces;

namespace Project_SMS.Classes
{
    class Updatedeletestudent : und
    {
        public string prefix;
        public string id1;
        public string guardian;
        public string contact1;
        public string add;
        public string gr;
        public string sec;
        public string h;

        public Updatedeletestudent()
        {
            
        }

        public void getupdate(string prefix, string id1, string guardian, string contact1, string add, string gr, string sec, string h){
            this.prefix = prefix;
            this.id1 = id1;
            this.guardian = guardian;
            this.contact1 = contact1;
            this.add = add;
            this.gr = gr;
            this.sec = sec;
            this.h = h;
        }
        public void getdel(String pre,String id)
        {
            this.prefix = pre;
            this.id1 = id;
        }
        DBconnection obj = new DBconnection();
        public void updatestudent()
        {
            obj.updatestudents(prefix, id1, guardian, contact1, add, gr, sec, h);
        }


        
       public void deletestudent()
        {
            obj.deletestudent(prefix, id1);
        }

    }
}
