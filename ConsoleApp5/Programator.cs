using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObcanMesto
{
    class Programator : Obcan
    {
        protected string programovaciJazyk;

        public Programator(string meno, int vek, string programovaciJazyk) : 
            base(meno, vek) 
        { 
            this.programovaciJazyk = programovaciJazyk;
        }

        public virtual void VypisInfo()
        {
            Console.WriteLine(meno + "," + vek + 
                              " rokov, pise kod v jazyku: " + programovaciJazyk + "Stav:" + stav);
        }

        public Programator()
        {
            
        }

    }
}
