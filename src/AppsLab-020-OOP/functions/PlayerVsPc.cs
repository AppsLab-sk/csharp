using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppsLab_020_OOP.functions
{
    internal class PlayerVsPc
    {
        public void Execute() 
        {
            Console.Clear();
            var intro = new Intro();
            intro.Print();

            List<Warrior> WarriorsList = new List<Warrior>
            {

            };

            var warrior = new Warrior(WarriorsList);
            warrior.Name = "Bojovník";
            warrior.Health = 200;
            warrior.AttackPower = 50;
            warrior.HealAmount = 2;


            List<Wizzard> WizzardList = new List<Wizzard>
            {
                
            };

            var wizzard = new Wizzard(WizzardList);
            wizzard.Name = "Čarodej";
            wizzard.Health = 100;
            wizzard.AttackPower = 60;
            wizzard.HealAmount = 2;

            var stats = new Statistick();

            while (warrior.Health > 0 && wizzard.Health > 0)
            {
                //warrior.Attack(wizzard);
                //wizzard.Attack(warrior);

                stats.Stats(warrior, wizzard);

                Console.WriteLine("Vyberte schopnosť: \n1 = Útok \n2 = Uzdraviť (počet: " + warrior.HealAmount + ")");
                int action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    warrior.Attack(wizzard);
                    stats.WarriorAttack(warrior, wizzard);
                }
                if (action == 2)
                {
                    //warrior.Heal(warrior, wizzard);
                    if (warrior.HealAmount > 0)
                    {
                        warrior.HealAmount = Math.Max(0, warrior.HealAmount - 1);
                        warrior.Heal(warrior);
                        Console.WriteLine("Ostávajúci počet uzdravení: " + warrior.HealAmount);
                    }
                    else
                    {
                        warrior.Attack(wizzard);
                        stats.WarriorAttack(warrior, wizzard);
                    }
                }

                if (wizzard.Health > 0)
                {
                    if (wizzard.Health <= warrior.AttackPower)
                    {
                        if (wizzard.HealAmount > 0)
                        {
                            wizzard.HealAmount = Math.Max(0, wizzard.HealAmount - 1);
                            wizzard.Heal(wizzard);
                            Console.WriteLine("Ostávajúci počet uzdravení: " + wizzard.HealAmount + " pre " + wizzard.Name);
                        }
                        else
                        {
                            wizzard.Attack(warrior);
                            stats.WizzardAttack(warrior, wizzard);
                        }
                    }
                    else
                    {
                        wizzard.Attack(warrior);
                        stats.WizzardAttack(warrior, wizzard);
                    }
                }
                stats.Stats(warrior, wizzard);

                if (warrior.Health > 0 && wizzard.Health > 0)
                {
                    Console.WriteLine("Stlač akúkoľvek klávesu pre pokračovanie . . .");
                    Console.ReadKey(true);
                    Console.Clear();
                    intro.Print();
                    stats.NewRound(intro);
                    intro.Print();
                }
            }
            if (warrior.Health == 0 && wizzard.Health == 0)
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine("Remíza.");
            }
            if (warrior.Health <= 0 && wizzard.Health > 0)
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine(wizzard.Name + " vyhral.");
            }
            if (wizzard.Health <= 0 && warrior.Health > 0)
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
