using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiestoAObec_cvicenie
{
    public class Lekar : Obcan
    {
        public Lekar (string meno, int vek) : base (meno, vek) { }
        public new void VypisInfo()
        {
            Console.WriteLine(meno + " , " + vek + " rokov, lieci ludi" + " Stav: " + stav);
        }
    }
}
