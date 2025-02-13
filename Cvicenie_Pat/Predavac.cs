using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pat
{
    internal class Predavac
    {
        public string Meno { get; set; }
        public int Vek { get; set; }

        public Predavac()
        {
        }

        public Predavac(string meno, int vek)
        {
            this.Meno = meno;
            this.Vek = vek;

        }
        public void Predavanie() 
        {
            Console.WriteLine("Meno: " + Meno + " || Vek " + Vek + " || Predava");
        }

    }
}
