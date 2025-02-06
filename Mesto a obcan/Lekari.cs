using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesto_a_obcan
{
    public class Lekari : Obcan
    {
        public Lekari(string meno, int vek) : base(meno, vek) 
        { 
        
        }
        public override void VypisInfo()
        {
            Console.WriteLine("Meno: " + meno + " Vek " + vek + " Lieci");
        }
    }

}
