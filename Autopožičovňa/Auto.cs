using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopožičovňa
{
    internal class Auto
    {
        public string Znacka { get; set; }
        public string Model { get; set; }
        public int Cenazaden { get; set; }


        public Auto(string znacka, string model, int cenazaden)
        {
            Znacka = znacka;
            Model = model;
            Cenazaden = cenazaden;
        }
        public virtual void VypisInfo()
        {
            Console.WriteLine("Znacka: " + Znacka + " " + Model + " || Cena za den: || " + Cenazaden);
        }
        public double VypocitajCenu(int dni)
        {
            return Cenazaden * dni;
        }
    }
}
