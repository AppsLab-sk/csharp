using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopozicovna
{
    class Pozicovna
    {
        private List<Auto> zoznamAut = new List<Auto>();

        public void PridajAuto(Auto auto)
        {
            zoznamAut.Add(auto);
        }

        public void VypisVsetkyAut()
        {
            for (int i = 0; i < zoznamAut.Count; i++)
            {
                Console.WriteLine($"Auto {i + 1}:");
                zoznamAut[i].VypisInfo();
                Console.WriteLine();
            }
        }

        public decimal? VypocitajCenuPrenajmu(int cisloAuta, int dni)
        {
            if (cisloAuta >= 0 && cisloAuta < zoznamAut.Count)
            {
                return zoznamAut[cisloAuta].VypocitajCenu(dni);
            }
            else
            {
                Console.WriteLine("Neplatne cislo auta.");
                return null;
            }
        }
    }
}
