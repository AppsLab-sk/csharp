using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{
    public class SeniorProgramator1 : Programator
    {
        public int pocetProjektov;
        public SeniorProgramator1(string meno, int vek, string programoaciJazyk, string seniorProgramator, int pocetProjektov) :
            base (meno, vek, programoaciJazyk)
        {
          this.pocetProjektov = pocetProjektov;
        }
       public new void VypisInfo()
        {
            Console.WriteLine(Meno + " , " + " programuje v:" + programovaciJazyk + " a ma " + pocetProjektov + "projektov" + " Stav: " + stav);
        }
    }
}
