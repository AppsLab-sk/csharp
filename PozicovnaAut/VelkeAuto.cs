using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PozicovnaAut
{
    public class VelkeAuto : Auto
    {
        public int KapacitaPasazierov { get; set; }
        public int ObjemBatozinovehoPriestoru { get; set; }

        public VelkeAuto()
        {

        }

        public VelkeAuto(string znacka, string model, int cenaZaDen, int kapacitaPasazierov, int objemBatozinovehoPriestoru) : base(znacka, model, cenaZaDen)
        {
            KapacitaPasazierov = kapacitaPasazierov;
            ObjemBatozinovehoPriestoru = objemBatozinovehoPriestoru;
        }

        public new void VypisInfo()
        {
            Console.WriteLine("Znacka: " + Znacka + ", Model: " + Model + ", Cena Za Den: " + CenaZaDen +
                ", Kapacita Pasazierov:" + KapacitaPasazierov + ", Objem B. Priestoru: " + ObjemBatozinovehoPriestoru);
        }
    }
}
