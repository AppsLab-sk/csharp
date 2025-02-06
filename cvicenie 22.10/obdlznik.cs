using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie_22._10
{
    internal class obdlznik
    {
        public int dlzka { get; set; }
        public int sirka { get; set; }

        public obdlznik(int dlzka, int sirka)
        {
            this.dlzka = dlzka;
            this.sirka = sirka;
        }
        public int Obsah()
        {
            return dlzka * sirka;
        }


    }
}
