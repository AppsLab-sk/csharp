using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopožičovňa
{
    internal class Pozicovna
    {
        public List<Auto> ZoznamAut { get; set; }

        public Pozicovna()
        {
            ZoznamAut = new List<Auto>();
        }

        public Pozicovna(List<Auto> zoznamAut)
        {
            ZoznamAut = zoznamAut;
        }
        public void PridajAuto(Auto auto)
        {
            ZoznamAut.Add(auto);
        }
        public void VypisVsetkyAuta()
        {
            foreach (var vozidlo in ZoznamAut)
            {
                vozidlo.VypisInfo();
            }
        }
        public void VypocitajCenuPrenajmu(int indexAuta, int dni)
        {
            if (indexAuta < 0 || indexAuta >= 3)
            {
                Console.WriteLine("Bud ho niekto ukradol alebo jednoducho neexistuje.");
                return;
            }

            Auto vybraneAuto = ZoznamAut[indexAuta];
            double cenaPredaju = vybraneAuto.VypocitajCenu(dni);
            Console.WriteLine($"Auto znacky {vybraneAuto.Znacka} {vybraneAuto.Model} je predane za {cenaPredaju} eur.");
        }
    }
}

