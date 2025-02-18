using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcanMesto
{
    class Lekar : Obcan
    {
        public Lekar(string meno, int vek) : base(meno, vek) { }

        public virtual void VypisInfo()
        {
            Console.WriteLine(meno + "," + vek + " rokov, lieci ludi." + "Stav:" + stav);
        }
        public Lekar()
        {
            
        }

    }
}
