using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Tim
{
    public class Tim
    {
        public string nazov;

        private static int pocetTimov = 0;

        public Tim(string nazov)
        {
            this.nazov = nazov;
            pocetTimov++;
        }

        public static int ZiskajPocetTimov()
        {
            return pocetTimov;
        }

        public string ZiskajNazov()
        {
            return nazov;
        }
    }
}
