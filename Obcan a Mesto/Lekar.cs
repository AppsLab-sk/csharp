using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obcan_a_Mesto
{
    public class Lekar : Obcan
    {
        public Lekar(string Meno, int Vek) : base(Meno, Vek) { }
        public new void VypisInfo()
        {
            Console.WriteLine("Meno: " + Meno + " Vek: " + Vek + " je lekar " + "Stav: " + stav + "!");
        }
    }
}

