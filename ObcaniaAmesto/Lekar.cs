using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObcaniaAmesto
{
    class Lekar : Citizen
    {
        public Lekar()
        {
        }

        private Lekar(string name, int age) : base(name, age) { }    
        

        public new void VypisInfo()
        {
            Console.WriteLine("Meno: " + Name + ", Vek: " + Age + ", lieci ludi." + " Stav: " + Stav);
        }
    }
}
   