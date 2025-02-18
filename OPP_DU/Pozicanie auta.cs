using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_DU
{
    internal class Pozicanieauta
    {

        public List<Auto> ZoznamAut { get; set; } = new List<Auto>();

        public void PridajAuto(Auto auto)
        {
            ZoznamAut.Add(auto);
        }

        public void VypisVsetkyAuta()
        {
            for (int i = 0; i < ZoznamAut.Count; i++)
            {
                Console.WriteLine($"Auto {i}: {ZoznamAut[i].VypisInfo()}");
            }
        }

        public object VypocitajCenuPrenajmu(int indexAut, int dni)
        {
            if (indexAut >= 0 && indexAut < ZoznamAut.Count)
            {
                return ZoznamAut[indexAut].VypocitajCenu(dni);
            }
            return null;
        }
    }

}
