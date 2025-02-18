using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_DU
{
    public class Eauto:Auto
    {
        public double KapacitaBaterie { get; set; }
        public double DojazdNaNabitie { get; set; }

        public Eauto(string znacka, string model, int cenaZaDen, double kapacitaBaterie, double dojazdNaNabitie) : base(znacka, model, cenaZaDen)

        {
            KapacitaBaterie = kapacitaBaterie;
            DojazdNaNabitie = dojazdNaNabitie;
        }

        public new string VypisInfo()
        {
            return VypisInfo() + $", Kapacita batérie: {KapacitaBaterie} kW za h, Dojazd na nabitie: {DojazdNaNabitie} km";
        }
    }
}