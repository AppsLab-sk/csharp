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
            stats.WarriorsWins = 0;
            stats.WizzardsWins = 0;

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

            while (bWarriors.Count > 0 && bWizzards.Count > 0)//stats.HasAlliveWarrior(bWarriors) == true && stats.HasAlliveWizzard(bWizzards) == true) 
            {
                //battle.Execute(warrior, wizzard, stats, intro,warriors, wizzards, bWarriors, bWizzards);
                while (warrior.Health > 0 && wizzard.Health > 0)
                {
                    Console.WriteLine(warrior.Name + " " + wizzard.Name);

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
                    else
                    {
                        if (warrior.Health == 0 && bWarriors.Count > 0)
                        {
                            stats.AddWinWizzards();
                            bWarriors.RemoveAt(bWarriors.FindIndex(warrior => warrior.Health == 0));
                            warrior = stats.ChooseWarrior(bWarriors);
                            if (warrior == null)
                            {
                                Console.WriteLine("Neostali žiadny bojovníci!");
                                break;
                            }
                            Console.Clear();
                            intro.Print();
                        }
                        if (wizzard.Health == 0 && bWizzards.Count > 0)
                        {
                            stats.AddWinWarriors();
                            bWizzards.RemoveAt(bWizzards.FindIndex(wizzard => wizzard.Health == 0));
                            wizzard = stats.ChooseWizzard(bWizzards);
                            if (wizzard == null)
                            {
                                Console.WriteLine("Neostali žiedny nepriatelia!");
                                break;
                            }
                            Console.Clear();
                            intro.Print();
                        }
                    }
                }
            }

            if (stats.HasAlliveWarrior(bWarriors) == false && stats.HasAlliveWizzard(bWizzards) == false) //remíza
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                //stats.Stats(warrior, wizzard);
                Console.WriteLine("Remíza.");
            }
            if (stats.HasAlliveWarrior(bWarriors) == false && stats.HasAlliveWizzard(bWizzards) == true) //nepriateľ vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                //stats.Stats(warrior, wizzard);
                Console.WriteLine("Počet víťazstiev pre Bojovníkov: " + stats.WarriorsWins);
                Console.WriteLine("Počet víťazstiev pre Čarodej: " + stats.WizzardsWins);
                Console.WriteLine("Čarodeji vyhrali.");
            }
            if (stats.HasAlliveWarrior(bWarriors) == true && stats.HasAlliveWizzard(bWizzards) == false) //bojovník vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                //stats.Stats(warrior, wizzard);
                Console.WriteLine("Počet víťazstiev pre Bojovníkov: " + stats.WarriorsWins);
                Console.WriteLine("Počet víťazstiev pre Čarodej: " + stats.WizzardsWins);
                Console.WriteLine("Bojovníci vyhrali.");
            }
        }
    }
}
