using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kniznica
{
    public class Kniha
    {
        private string nazov;
        private int pocetStran;

        public string Nazov
        {
           get { return nazov; }
           set { nazov = value; }
        }

        public int PocetStran
        {
            get { return pocetStran; }
            set {
                if (value > 0)
                    pocetStran = value;
                else
                    Console.WriteLine("Chyba: Pocet stran nemoze byt mensi alebo rovny nule!");
               
            }
        }
    }
}
