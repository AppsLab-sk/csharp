using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopozicovna
{
    class Auto
    {
        public string Znacka { get; set; }
        public string Model { get; set; }
        public decimal CenaZaDen { get; set; }

        public Auto(string znacka, string model, decimal cenaZaDen)
        {
            Znacka = znacka;
            Model = model;
            CenaZaDen = cenaZaDen;
        }

        public virtual void VypisInfo()
        {
            Console.WriteLine($"Znacka: {Znacka}, Model: {Model}, Cena za den: {CenaZaDen}");
        }

        public decimal VypocitajCenu(int dni)
        {
            return CenaZaDen * dni;
        }
    }

}
