using System;
using System.Collections.Generic;
using System.Linq;
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

            List<Warrior> WarriorsList = new List<Warrior> { };

            WarriorsList.Add(new Warrior("Bojovník", 200, 50, 2));
            WarriorsList.Add(new Warrior("Bojovník2", 200, 50, 2));
            WarriorsList.Add(new Warrior("Bojovník3", 200, 50, 2));
            WarriorsList.Add(new Warrior("Bojovník4", 200, 50, 2));
            WarriorsList.Add(new Warrior("Bojovník5", 200, 50, 2));

            //var warrior = new Warrior(WarriorsList);

            List<Wizzard> WizzardList = new List<Wizzard> { };


            WizzardList.Add(new Wizzard("Čarodej", 100, 60, 2));
            WizzardList.Add(new Wizzard("Čarodej2", 100, 60, 2));
            WizzardList.Add(new Wizzard("Čarodej3", 100, 60, 2));
            WizzardList.Add(new Wizzard("Čarodej4", 100, 60, 2));
            WizzardList.Add(new Wizzard("Čarodej5", 100, 60, 2));


            var wizzard = new Wizzard(WizzardList);

            foreach (var warrior in WarriorsList) { }
            //while (warrior.Health > 0 && wizzard.Health > 0) 
            {
                var warrior = new Warrior(WarriorsList);
                Console.WriteLine(warrior.Name, warrior.Health, warrior.AttackPower, warrior.HealAmount );                
            }
        
        
        }
    }
}
