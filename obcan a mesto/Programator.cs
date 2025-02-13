using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
   public class Programator : Obcan
    {
        public string programovaciJazyk { get; set; }
       

        public Programator(string name, int age, string programovaciJazyk) : base(name, age)
        { 
            this.programovaciJazyk = programovaciJazyk;
        }
        public override void VypisInfo()
        {
            Console.WriteLine("Meno" + Name + ", Vek " + Age + ", pise kodiky v jazyku" + programovaciJazyk + " ,Stav: " + stav);
        }

        public Programator()
        {
        }
    }
}

