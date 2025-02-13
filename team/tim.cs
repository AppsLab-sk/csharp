using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team
{
    public class Tim
    {
        private string nazov;
        private static int pocetTimov = 0;

        public Tim(string nazov)
        {
            this.nazov = nazov;
            timcounter++;
        }

        static int timcounter;

        public static int getTimCounter()
        { return timcounter; }

        public string Zadajnazov()
        {
            return nazov;
        }

        public class Program
        {
            public static void Main()
            {
                Tim tim1 = new Tim("Draci");
                Tim tim2 = new Tim("Sokoli");
                Tim tim3 = new Tim("Orli");

                Console.WriteLine("Celkovy pocet timov je " + Tim.getTimCounter());
            }
        }



    }
}



