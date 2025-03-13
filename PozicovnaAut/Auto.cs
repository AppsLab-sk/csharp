using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozicovnaAut
{
    public class Auto
    {
        public string Znacka { get; set; }
        public string Model { get; set; }
        public int CenaZaDen { get; set; }

        public Auto()
        {

        }

        public Auto(string znacka, string model, int cenaZaDen)
        {
            Znacka = znacka;
            Model = model;
            CenaZaDen = cenaZaDen;
        }

        public void VypisInfo()
        {
            Console.WriteLine("Znacka: " + Znacka + ", Model: " + Model + ", Cena Za Den: " + CenaZaDen);
        }
    }
}
