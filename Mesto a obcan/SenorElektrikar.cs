using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class SenorElektrikar : Elekrikari 
    {
        private int pocetkablov;
        public int PocetKablov
        {
            get { return pocetkablov; }
            set { pocetkablov = value; }
        }
        public SenorElektrikar(string meno, int vek, string typkablu, int pocetkablov) : base(meno, vek, typkablu) 
        { 
           this.pocetkablov = pocetkablov; 
        }
        public SenorElektrikar()
        { 
        
        }
        public override void VypisInfo()
        {
            Console.WriteLine("Meno: " + meno + " Vek " + vek + " Elektrikuje s" 
                + "Pocet kablov" + " Stav: " + stav) ;
        }

    }
}

