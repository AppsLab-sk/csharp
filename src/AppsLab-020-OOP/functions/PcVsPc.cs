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

            Random random = new Random();
            int randomIndex = random.Next(warriors.Count);
            var choosenWarrior = warriors[randomIndex];
            var warrior = choosenWarrior;

            List<IWizzard> wizzards = new List<IWizzard>
            {
                new Wizzard("Čarodej", 100, 60, 2),
                new Wizzard2("Čarodej2", 100, 60, 2),
            };
            
            Random wrandom = new Random();
            int randomWIndex = wrandom.Next(wizzards.Count);
            var choosenWizzard = wizzards[randomWIndex];
            var wizzard = choosenWizzard;

            while (warrior.Health > 0 && wizzard.Health > 0)
            {
                if (warrior.Health <= wizzard.AttackPower)
                {
                    if (warrior.HealAmount > 0)
                    {
                        warrior.HealAmount = Math.Max(0, warrior.HealAmount - 1);
                        warrior.Heal(warrior);
                        Console.WriteLine("Ostávajúci počet uzdravení: " + warrior.HealAmount + " pre " + warrior.Name);
                    }
                    else
                    {
                        warrior.Attack(wizzard);
                        stats.WarriorAttack(warrior, wizzard);
                    }
                }
                else
                {
                    warrior.Attack(wizzard);
                    stats.WarriorAttack(warrior, wizzard);
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
                Thread.Sleep(2000);

                if (warrior.Health > 0 && wizzard.Health > 0) //pokiaľ sú obydvaja naživu, ide nové kolo
                {
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
