using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_T9m
{
    public class team
    {
        private string Nazov { get; set; }

        static int pocetTimov = 0;

        public team(string nazov)
        {
            Nazov = nazov;
            pocetTimov++;
        }
        public static int ziskajPocetTimov() 
        { 
            return pocetTimov; 
        }
    }
}
