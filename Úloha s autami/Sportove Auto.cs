using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Úloha_s_autami
{
    public class Sportove_Auto : Auto
    {
        public int MaxRychlost { get; set; }
        public int Zrychlenie { get; set; }
        public Sportove_Auto()
        {

        }

        public Sportove_Auto(string znacka, string model, int cenaZaDen, int maxRychlost, int zrychlenie) : base(znacka, model, cenaZaDen)
        
        {
            MaxRychlost = maxRychlost;
            Zrychlenie = zrychlenie;
        }

        public new void VypisInfo()
        {
            Console.WriteLine("Znacka: " + Zrychlenie + ", model" + Model + "Cena za den " + CenaZaDen + 
                                                        "Maximalna rychlost " + MaxRychlost + "Zrychlenie " + Zrychlenie);
        }

    }
}
