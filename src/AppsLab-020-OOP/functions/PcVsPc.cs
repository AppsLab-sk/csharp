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
                new Warrior("Bojovník2", 200, 50, 2),
                new Warrior("Bojovník3", 200, 50, 2),
                new Warrior("Bojovník4", 200, 50, 2),
                new Warrior("Bojovník5", 200, 50, 2),
            };
            List<IWarrior> bWarriors = new List<IWarrior> { };
            bWarriors.AddRange(warriors);

            var warrior = stats.ChooseWarrior(bWarriors);

            List<IWizzard> wizzards = new List<IWizzard>
            {
                new Wizzard("Čarodej", 100, 60, 2),
                new Wizzard("Čarodej2", 100, 60, 2),
                new Wizzard("Čarodej3", 100, 60, 2),
                new Wizzard("Čarodej4", 100, 60, 2),
                new Wizzard("Čarodej5", 100, 60, 2),
            };
            List<IWizzard> bWizzards = new List<IWizzard> { };
            bWizzards.AddRange(wizzards);
            var wizzard = stats.ChooseWizzard(bWizzards);

            var battle = new Battle();

            while (stats.HasAlliveWarrior(bWarriors) && stats.HasAlliveWizzard(bWizzards) == true) 
            { 
                battle.Execute(warrior, wizzard, stats, intro, bWarriors, bWizzards);
            }

            if (stats.HasAlliveWarrior(bWarriors) == false && stats.HasAlliveWizzard(bWizzards) == false) //remíza
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine("Remíza.");
            }
            if (stats.HasAlliveWarrior(bWarriors) == false && stats.HasAlliveWizzard(bWizzards) == true) //nepriateľ vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine(wizzard.Name + " vyhral.");
            }
            if (stats.HasAlliveWarrior(bWarriors) == true && stats.HasAlliveWizzard(bWizzards) == false) //bojovník vyhral
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
