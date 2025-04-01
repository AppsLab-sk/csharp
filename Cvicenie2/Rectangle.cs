using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie2
{
    public class Rectangle
    {
        public int sirka { get; set; }
        public int vyska { get; set; }
        public Rectangle(int sirka, int vyska)
        {
            this.sirka = sirka;
            this.vyska = vyska;
        }
        public int ObsahObdlznika()
        {
            return sirka * vyska;
        }
    }
}




      