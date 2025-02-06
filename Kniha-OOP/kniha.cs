using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kniha_OOP
{
    public class kniha
    {
        private string nazov;
        private int pocetStran;

        public kniha() { }

        public kniha(string nazov, int pocetStran)
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
            set
            {
                if (pocetStran > 0)
                    pocetStran = value;

                else
                    Console.WriteLine("More mas problem!");
               
            }





        }
    }
}
