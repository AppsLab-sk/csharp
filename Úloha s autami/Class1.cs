using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Úloha_s_autami
{
    public class Auto
    {
        public string Znacka { get; set; }
        public string Model { get; set; }
        public int CenaZaDen { get; set; }

        public Auto(string znacka, string model, int cenaZaDen)
        {
            Znacka = znacka;
            Model = model;
            CenaZaDen = cenaZaDen;
        }

        public Auto()
        {
        }

        public void VypisInfo()
        {
            Console.WriteLine("Znacka: " + Znacka + ", model " + Model + "Cena za den: " + CenaZaDen + ".");
        }

    }
}