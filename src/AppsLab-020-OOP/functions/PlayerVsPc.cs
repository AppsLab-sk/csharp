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

            var warrior = new Warrior("Bojovník", 200, 50, 2);

            var wizzard = new Wizzard("Čarodej", 100, 60, 2);
            
            var stats = new Statistick();

            while (warrior.Health > 0 && wizzard.Health > 0) //pokiaľ sú všetci nažive
            {
                stats.Stats(warrior, wizzard);

                Console.WriteLine("Vyberte schopnosť: \n1 = Útok \n2 = Uzdraviť (počet: " + warrior.HealAmount + ")");
                int action = int.Parse(Console.ReadLine());

                if (action == 1) //útok
                {
                    warrior.Attack(wizzard);
                    stats.WarriorAttack(warrior, wizzard);
                }
                if (action == 2) //uzdravenie
                {
                    if (warrior.HealAmount > 0) //ak je čím, uzdraviť
                    {
                        warrior.HealAmount = Math.Max(0, warrior.HealAmount - 1);
                        warrior.Heal(warrior);
                        Console.WriteLine("Ostávajúci počet uzdravení: " + warrior.HealAmount);
                    }
                    else //ak nie je čím, útok
                    {
                        warrior.Attack(wizzard);
                        stats.WarriorAttack(warrior, wizzard);
                    }
                }

                if (wizzard.Health > 0) //ak je nepriateľ naživu, tak sa pokračuje
                {
                    if (wizzard.Health <= warrior.AttackPower) //ak má nepriateľ menej životov ako bojovník, skúsi sa uzdraviť
                    {
                        if (wizzard.HealAmount > 0) //ak sa má čím nepriateľ uzdraviť
                        {
                            wizzard.HealAmount = Math.Max(0, wizzard.HealAmount - 1);
                            wizzard.Heal(wizzard);
                            Console.WriteLine("Ostávajúci počet uzdravení: " + wizzard.HealAmount + " pre " + wizzard.Name);
                        }
                        else //ak nie, zaútočí
                        {
                            wizzard.Attack(warrior);
                            stats.WizzardAttack(warrior, wizzard);
                        }
                    }
                    else //ak má dostatok životov, zaútočí
                    {
                        wizzard.Attack(warrior);
                        stats.WizzardAttack(warrior, wizzard);
                    }
                }
                stats.Stats(warrior, wizzard);

                if (warrior.Health > 0 && wizzard.Health > 0) //pokiaľ sú obydvaja naživu, ide nové kolo
                {
                    Console.WriteLine("Stlač akúkoľvek klávesu pre pokračovanie . . .");
                    Console.ReadKey(true);
                    Console.Clear();
                    intro.Print();
                    stats.NewRound(intro);
                    intro.Print();
                }
            }
            if (warrior.Health == 0 && wizzard.Health == 0) //remíza
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine("Remíza.");
            }
            if (warrior.Health <= 0 && wizzard.Health > 0) //nepriateľ vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                stats.Stats(warrior, wizzard);
                Console.WriteLine(wizzard.Name + " vyhral.");
            }
            if (wizzard.Health <= 0 && warrior.Health > 0) //bojovník vyhral
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
