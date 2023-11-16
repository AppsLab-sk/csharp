using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppsLab_020_OOP.functions
{
    internal class PcVsPc
    {
        public void Execute() 
        {
            Console.Clear();
            var intro = new Intro();
            intro.Print();

            var stats = new Statistick();

            var warrior = new Warrior("Bojovník", 200, 50, 2);
            var warrior2 = new Warrior2("Bojovník2", 200, 50, 2);


            var wizzard = new Wizzard("Čarodej", 100, 60, 2);

            var wizzard2 = new Wizzard2("Čarodej2", 100, 60, 2);





        }
    }
}
