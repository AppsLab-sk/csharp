using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopozicovna
{
    class VelkeAuto : Auto
    {
        public int KapacitaPasa { get; set; }
        public int ObjemBatoziny { get; set; }

        public VelkeAuto(string znacka, string model, decimal cenaZaDen, int kapacitaPasa, int objemBatoziny): base(znacka, model, cenaZaDen)
        {
            KapacitaPasa = kapacitaPasa;
            ObjemBatoziny = objemBatoziny;
        }

        public override void VypisInfo()
        {
            base.VypisInfo();
            Console.WriteLine($"Kapacita pasazierov: {KapacitaPasa}, Objem batoziny: {ObjemBatoziny} litrov");
        }
    }
}
