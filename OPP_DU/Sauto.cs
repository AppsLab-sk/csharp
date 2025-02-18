using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_DU
{
    public class Sauto: Auto
    {
        
        public int MaxRychlost { get; set; }
        public double Zrychlenie { get; set; }


        public Sauto(string znacka, string model, decimal cenaZaDen, int maxRychlost, double zrychlenie) : base(znacka, model, cenaZaDen)
        {
            MaxRychlost = maxRychlost;
            Zrychlenie = zrychlenie;
        }

        public override string VypisInfo()
        {
            return VypisInfo() + $", Maximálna rýchlosť: {MaxRychlost} km za h, Zrýchlenie: {Zrychlenie} se";
        }
    }
}
