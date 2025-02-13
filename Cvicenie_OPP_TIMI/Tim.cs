using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_OPP_TIMI
{
    public class Tim
    {
        public string nazov;
        public static int pocetTimov = 0;

        public Tim(string nazov) 
        { 
          this.nazov = nazov;
          timcounter++; 
        }

        static int timcounter;
      
        public static int getTimCounter() 
        { return timcounter; }

        public  string Zadajnazov() { 
            return nazov; }

        internal class Program
        {
            static void Main(string[] args)
            {
                Tim menchester = new Tim("Deapool");
                Tim menchestery = new Tim("Wolwerine");
                Tim menchestero = new Tim("Blade");
                Tim menchesteru = new Tim("Gambit");
                Tim menchestere = new Tim("Elektra");

                Console.WriteLine("Celkovy pocet timov je " + Tim.getTimCounter());
             




            }
        }
    }



}

