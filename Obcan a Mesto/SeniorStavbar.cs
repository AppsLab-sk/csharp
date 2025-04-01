using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obcan_a_Mesto
{
    public class SeniorStavbar : Stavbar
    {
        private int pocetTehiel;
        public SeniorStavbar(string Meno, int Vek, string typTehli, int pocetTehiel) : base(Meno, Vek, typTehli)
        {
            this.pocetTehiel = pocetTehiel;
        }
        public new void VypisInfo()
        {
            Console.WriteLine("Meno:" + Meno  + " Vek : " + Vek + " stava s "  + "a ma" + pocetTehiel + "Tehiel" + "Stav: " + stav + "!");
        }
    }
}

