using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopožičovňa
{
    internal class ElektrickeAuto : Auto
    {
        public int KapacitaBaterie;
        public int DojazdNaNabitie;

        public ElektrickeAuto(string znacka, string model, int cenazaden, int kapacitabaterie, int dojazdnanabitie) : base(znacka, model, cenazaden)
        {
            this.DojazdNaNabitie = dojazdnanabitie;
            this.KapacitaBaterie = kapacitabaterie;
        }
        public override void VypisInfo()
        {

            Console.WriteLine("2. Znacka: " + Znacka + " " + Model + " ||  Cena za den: " + Cenazaden + " eur || "
                + "  Dojazd na nabitie je: " + DojazdNaNabitie + " km" + " || Kapacita baterie je: " + KapacitaBaterie + " kWh");
        }

    }
}
