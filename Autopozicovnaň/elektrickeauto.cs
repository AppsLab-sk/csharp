using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopozicovna
{
    class ElektrickeAuto : Auto
    {
        public int KapacitaBaterie { get; set; }
        public int DojazdNaNabitie { get; set; }

        public ElektrickeAuto(string znacka, string model, decimal cenaZaDen, int kapacitaBaterie, int dojazdNaNabitie): base(znacka, model, cenaZaDen)
        {
            KapacitaBaterie = kapacitaBaterie;
            DojazdNaNabitie = dojazdNaNabitie;
        }

        public override void VypisInfo()
        {
            base.VypisInfo();
            Console.WriteLine($"Kapacita baterie: {KapacitaBaterie} kWh, Dojazd na nabitie: {DojazdNaNabitie} km");
        }
    }
}
