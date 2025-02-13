         nn n   //////'/'                 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_cvicenie
{
    public class Lekar : Obcan
    {
        
        public Lekar(string Name, int Age) : base(Name, Age) { }
       

        public new void VypisInfo()
        {
            Console.WriteLine("Meno: " + Name + " Vek: " + Age + " je Lekar/ka");


        }
    }
}

