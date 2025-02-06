using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopozicovna
{
    class SportoveAuto : Auto
    {
        public int MaxRychlost { get; set; }
        public double Zrychlenie { get; set; }

        public SportoveAuto(string znacka, string model, decimal cenaZaDen, int maxRychlost, double zrychlenie): base(znacka, model, cenaZaDen)
        {
            MaxRychlost = maxRychlost;
            Zrychlenie = zrychlenie;
        }

        public override void VypisInfo()
        {
            base.VypisInfo();
            Console.WriteLine($"Max. rychlost: {MaxRychlost} km/h, Zrýchlenie: {Zrychlenie} s");
        }
    }
}
