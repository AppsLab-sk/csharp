using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tim
{
    public class Tim
    {
        private string nazov;
        private static int pocetTimov = 0;

        public Tim(string nazov)
        {
            this.nazov = nazov;
            timcounter++;
        }

        static int timcounter;

        public static int ZiskajPocetTimov()
        { return timcounter; }

        public string ZadajNazov()
        {
            return nazov;
        }
    }
}
