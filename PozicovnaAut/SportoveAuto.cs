using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozicovnaAut
{
    public class SportoveAuto : Auto
    {
        public int MaxRychlost { get; set; }
        public int Zrychlenie { get; set; }

        public SportoveAuto()
        {

        }

        public SportoveAuto(string znacka, string model, int cenaZaDen, int maxRychlost, int zrychlenie) : base(znacka, model, cenaZaDen)
        {
            MaxRychlost = maxRychlost;
            Zrychlenie = zrychlenie;
        }

        public new void VypisInfo()
        {
            Console.WriteLine("Znacka: " + Znacka + ", Model: " + Model + ", Cena Za Den: " + CenaZaDen +
                ", MaxRychlost (km/h): " + MaxRychlost + ", Zrychlenie (0-100 km/h): " + Zrychlenie);
        }
    }
}
