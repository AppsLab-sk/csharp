using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObcaniaAmesto
{
    public class Programator : Citizen
    {
        protected string programovaciJazyk { get; set; }
        public Programator(string name, int age, string programovaciJazyk) : base(name, age)
        {
            this.programovaciJazyk = programovaciJazyk;
        }

        public Programator()
        {
        }

        public override void VypisInfo()
        {
            Console.WriteLine("Meno: " + Name + ", Vek: " + Age + ", pise kodiky v jazyku " + programovaciJazyk + " Stav: " + Stav);
        }
    }
}
