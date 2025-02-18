using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Obcan
    {
        public string meno;
        public int vek;

        public Obcan(string meno, int vek) 
        {
            this.meno = meno;
            this.vek = vek;
        }

        public void VypisInfo() 
        {
            Console.WriteLine("Meno:" + meno + ", Vek: " + vek);
        }
    }

}
