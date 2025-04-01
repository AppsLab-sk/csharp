using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obcan_a_Mesto
{
    public class Stavbar : Obcan
    {
        protected string typtehli { get; set; }
       public Stavbar(string meno, int Vek, string typtehli): base (meno, Vek)
        {
            this.typtehli = typtehli;
        }
        public override void VypisInfo()
        {
            Console.WriteLine("Meno: " + Meno + " Vek: " + Vek + " stava s " + typtehli + " tehla " + "Stav: " + stav + "!");
        }
    }
}
