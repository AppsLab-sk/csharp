using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knižnica___cvičenie
{
    internal class Casopis
    {
        public string Tema { get; set; }
        public int MesiacVydania { get; set; }


        public Casopis(string tema, int mesiacVydania)
        {
            Tema = tema;
            MesiacVydania = mesiacVydania;
        }
        public void VypisInfo()
        {
            Console.WriteLine($" Tema: {Tema}, MesiacVydania: {MesiacVydania}");
        }
    }
}
