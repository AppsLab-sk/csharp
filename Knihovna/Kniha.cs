using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{

    public class Kniha
    {
        private string nazov;
        private int pocetStran;

        public Kniha(string nazov, int pocetStran)
        {
            this.nazov = nazov;
            this.pocetStran = pocetStran;
        }

        public string Nazov
        {
            get { return nazov; }
            set { nazov = value; }
        }

        public int PocetStran
        {
            get { return pocetStran; }
            set { if (value > 0) pocetStran = value;
                else
                    Console.WriteLine("Chyba ! Pocet stran musi byt viac ako nula!");
        }
        }
    }
}
