using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenia4
{
    internal class Rectangle
    {

        public int sirka { get; set; }
        public int vyska { get; set; }

        public Rectangle(int sirka, int vyska)
        {
            this.sirka = sirka;
            this.vyska = vyska;
        }

        public int Obsah()
        {


            return sirka * vyska;   
        
        }
    }
    
    



    

}
