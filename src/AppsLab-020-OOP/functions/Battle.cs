using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppsLab_020_OOP.functions
{
    public class Battle
    {
        public void Execute(IWarrior warrior, IWizzard wizzard, Statistick stats, Intro intro, List<IWarrior> warriors, List<IWizzard> wizzards, List<IWarrior> bWarriors, List<IWizzard> bWizzards) 
        {
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
                    if (warrior.Health == 0 )//&& stats.HasAlliveWarrior(bWarriors) == true)
                    {
                        bWarriors.RemoveAt(bWarriors.FindIndex(warrior => warrior.Health == 0));
                        stats.ChooseWarrior(bWarriors);
                        if (warrior == null) 
                        {
                            Console.WriteLine("Neostali žiadny bojovníci!");
                        }
                    }
                    if (wizzard.Health == 0 )//&& stats.HasAlliveWizzard(bWizzards) == true)
                    {
                        bWizzards.RemoveAt(bWizzards.FindIndex(wizzard => wizzard.Health == 0));
                        stats.ChooseWizzard(bWizzards);
                        if (wizzard == null)
                        {
                            Console.WriteLine("Neostali žiedny nepriatelia!");
                        }
                    }
                }
            }
        }
    }
}
