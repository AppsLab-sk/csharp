using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    class Lekar : Obcan
    {
        public Lekar(string meno, int vek) : base(meno, vek) { }


        public override void VypisInfo()
        {
            Console.WriteLine("Meno: " + Meno + " || Vek " + Vek + " || Lieci");
        }
    }

}

