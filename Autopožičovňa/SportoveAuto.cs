using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopožičovňa
{
    internal class SportoveAuto : Auto
    {
        public int maxRychlost;
        public double zrychlenie;

        public SportoveAuto(string znacka, string model, int cenazaden, int maxrychlost, double zrychlenie) : base(znacka, model, cenazaden)
        {
            this.maxRychlost = maxrychlost;
            this.zrychlenie = zrychlenie;
        }
        public override void VypisInfo()
        {
            Console.WriteLine("0. Znacka: " + Znacka + " " + Model + " ||  Cena za den: " + Cenazaden + " eur || "  + "  Maximalna rychlost " +
                maxRychlost + "km/h" + " || Zrychlenie " + zrychlenie + ".0 sekundy");

        }
    }
}

