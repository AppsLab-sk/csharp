using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazar
{
    internal class Garaze
    {
        public List<Auto> ZoznamAut { get; set; }

        public void Pozicovna()
        {
            ZoznamAut = new List<Auto>();
        }

        public void Pozicovna(List<Auto> zoznamAut)
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
    }
}
