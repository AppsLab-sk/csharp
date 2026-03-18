using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_objekty
{
    public class student
    {
        public int age {  get; set; }
        public string name { get; set; }

        public string addres { get; set; }

        public char sex { get; set; }
         
        public bool isadult()
        {
            if (age >= 18)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public void addtoname(string surname)
        {
            name += " " + surname;
        }
        public string ShowInfo()
        {
            string info = "Meno: " + name +
                " vek " + age +
                " adresa" + addres +
                " pohlavie " + sex;
               
            return info;







        }


    }
}
