using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rectangle
    {
        public int sirka { get; set; }
        public int vyska { get; set; }

        public Rectangle(int Sirka, int vyska) 
        {
            sirka = Sirka;
            this.vyska = vyska;
        }
        public int Obsah()
        {
            return sirka * vyska;
        }
    }

}
