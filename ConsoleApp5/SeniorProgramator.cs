using ObcanMesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcanMesta
{
    class SeniorProgramator : Programator
    {
        public int pocetProjektov
        {
            get {  return pocetProjektov; }
            set {  pocetProjektov = value; }
        }

        public SeniorProgramator(string meno, int vek, string programovaciJazyk, int pocetProjektov) : base(meno, vek, programovaciJazyk)
        {
            this.pocetProjektov = pocetProjektov;
        }


        public override void VypisInfo()
        {
            Console.WriteLine(meno + ", " + vek + " program je v: " + programovaciJazyk + " a ma " + pocetProjektov + " projektov" + "Stav:" + stav);
        }
        public SeniorProgramator()
        {
            
        }
    }
}
