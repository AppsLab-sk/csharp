using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Civicenie_2
{
    public class Tim
    {
        private string Nazov { get; set; }

        private static int pocetTimov = 0;

        public Tim(string nazov)
        {
            Nazov = nazov;
            pocetTimov++;
        }

        public string ziskajNazov()
        {
            return Nazov;
        }

        public static int ziskajPocetTimov()
        {
            return pocetTimov;
        }
    }
}
