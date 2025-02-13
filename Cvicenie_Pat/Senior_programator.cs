using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Seniorprogramator : Programator
    {
        private int pocetProjektov;
        public int PocetProjektov { get { return pocetProjektov; } set { pocetProjektov = value; } }

        public Seniorprogramator()
        {
            
        }

        public Seniorprogramator(string meno, int vek, string programovacijazyk, int pocetprojektov) : base(meno, vek, programovacijazyk) 
        { 
          this.PocetProjektov = pocetprojektov;
        }
       
        public override void VypisInfo() 
        {
            Console.WriteLine("Meno: " + Meno + " || Vek " + Vek + " || Programuje v " + Programovacijazyk + " ma za sebou " + PocetProjektov + " || Stav obcana " + stav);
        }
    }
}
