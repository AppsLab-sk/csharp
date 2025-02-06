using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_OPP
{
    public class Tim
    {
        private string nazov;

        private static int pocet_timov = 0;


        public Tim(string nazov)
        {
            this.nazov = nazov;
            ++pocet_timov;
        }
      
        public static int ZiskajPocetTimov()
        {
            return pocet_timov;
        }
        public string ZiskajNazov()
        {
            return nazov;
        }
   
    }
    public class Program
    {
        public static void Main()
        {
            Tim tim1 = new Tim("Downi");
            Tim tim2 = new Tim("Updowni");
            Tim tim3 = new Tim("Middowni");

            Console.WriteLine("Celkovy pocet timov: " + Tim.ZiskajPocetTimov()); //3
        }
    }
}

