using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Autopožičovňa
{
    internal class VelkeAuto : Auto
    {
        public int Kapacitapasazierov;
        public int ObjemBatozinu;

        public VelkeAuto(string znacka, string model, int cenazaden, int kapacitapasazierov, int objembatozinu) : base(znacka, model, cenazaden)
        {
            this.Kapacitapasazierov = kapacitapasazierov;
            this.ObjemBatozinu = objembatozinu;
        }
        public override void VypisInfo()
        {

            Console.WriteLine("1. Znacka: " + Znacka + " " + Model + " || Cena za den: " + Cenazaden + " eur || " + "  Kapcita pasazierov " + Kapacitapasazierov +
                " || Objem Batozinoveho priestoru je " + ObjemBatozinu + " l ");
        }

    }
}

