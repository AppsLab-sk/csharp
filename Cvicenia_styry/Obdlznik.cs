using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenia_styry
{
    internal class Obdlznik
    {
        public int Sirka { get; set; }
        public int Dlzka { get; set; }
        public Obdlznik()
        {

        }
        public Obdlznik(int sirka, int dlzka)
        {
            Sirka = sirka;
            Dlzka = dlzka;        
        }
        public int Nasobenie() 
        {          
           return Dlzka * Sirka;           
        }
    }
}
