using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{
    public class Programator : Obcan
    {
        public string programovaciJazyk;
        public Programator (string meno, int vek, string programoaciJazyk) : base (meno, vek) 
        {
            this.programovaciJazyk = programoaciJazyk;
        }
            public override void VypisInfo()
            {
                Console.WriteLine(meno + " , " + vek +
                                  " rokov, pise kod v jazyku: " + programovaciJazyk + " Stav: " + stav);
            }
        
    }
}
