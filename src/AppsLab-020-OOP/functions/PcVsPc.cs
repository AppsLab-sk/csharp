using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

            List<IWarrior> warriors = new List<IWarrior>
            {
                new Warrior("Bojovník", 200, 50, 2),
                new Warrior2("Bojovník2", 200, 50, 2),
                new Warrior3("Bojovník3", 200, 50, 2),
                new Warrior4("Bojovník4", 200, 50, 2),
                new Warrior5("Bojovník5", 200, 50, 2),
            };
            var warrior = stats.ChooseWarrior(warriors);

            List<IWizzard> wizzards = new List<IWizzard>
            {
                new Wizzard("Čarodej", 100, 60, 2),
                new Wizzard2("Čarodej2", 100, 60, 2),
                new Wizzard3("Čarodej3", 100, 60, 2),
                new Wizzard4("Čarodej4", 100, 60, 2),
                new Wizzard5("Čarodej5", 100, 60, 2),
            };
            var wizzard = stats.ChooseWizzard(wizzards);

            var battle = new Battle();

            while (stats.HasAlliveWarrior(warriors) && stats.HasAlliveWizzard(wizzards) == true) 
            { 
                battle.Execute(warrior, wizzard, stats, intro, warriors, wizzards);
            }

            if (stats.HasAlliveWarrior(warriors) == false && stats.HasAlliveWizzard(wizzards) == false) //remíza
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine("Remíza.");
            }
            if (stats.HasAlliveWarrior(warriors) == false && stats.HasAlliveWizzard(wizzards) == true) //nepriateľ vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine(wizzard.Name + " vyhral.");
            }
            if (stats.HasAlliveWarrior(warriors) == true && stats.HasAlliveWizzard(wizzards) == false) //bojovník vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine(warrior.Name + " vyhral.");
            }
        }
    }
}
