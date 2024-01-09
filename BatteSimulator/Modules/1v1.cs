using BatteSimulator.functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class _1v1
    {
        public void Execute(ICharacter usedCh, IEnemy enemy)
        {
            var print = new Print();
            Console.Clear();
            print.Intro();
            //Console.WriteLine("You succesfully got there!");
            //Console.WriteLine(usedCh.Name);
            //Console.WriteLine(enemy.Health);
            
            while (usedCh.Health > 0 && enemy.Health > 0) //pokiaľ sú všetci nažive
            {
                print.Stats(usedCh, enemy);

                Console.WriteLine($"Vyberte schopnosť: \n1 = Útok \n2 = Uzdraviť (počet: {usedCh.HealAmount})");
                int action = int.Parse(Console.ReadLine());

                if (action == 1) //útok
                {
                    usedCh.Attack(enemy);
                    print.PlayerAttack(usedCh, enemy);
                }
                if (action == 2) //uzdravenie
                {
                    if (usedCh.HealAmount > 0) //ak je čím, uzdraviť
                    {
                        usedCh.HealAmount = Math.Max(0, usedCh.HealAmount - 1);
                        usedCh.Heal();
                        Console.WriteLine($"Ostávajúci počet uzdravení: {usedCh.HealAmount}");
                    }
                    else //ak nie je čím, útok
                    {
                        usedCh.Attack(enemy);
                        print.PlayerAttack(usedCh, enemy);
                    }
                }

                if (enemy.Health > 0) //ak je nepriateľ naživu, tak sa pokračuje
                {
                    if (enemy.Health <= usedCh.AttackPower) //ak má nepriateľ menej životov ako bojovník, skúsi sa uzdraviť
                    {
                        if (enemy.HealAmount > 0) //ak sa má čím nepriateľ uzdraviť
                        {
                            enemy.HealAmount = Math.Max(0, enemy.HealAmount - 1);
                            enemy.Heal();
                            Console.WriteLine($"Ostávajúci počet uzdravení: {enemy.HealAmount} pre {enemy.Name}");
                        }
                        else //ak nie, zaútoč
                        {
                            enemy.Attack(usedCh);
                            print.EnemyAttack(usedCh, enemy);
                        }
                    }
                    else //ak má dostatok životov, zaútočí
                    {
                        enemy.Attack(usedCh);
                        print.EnemyAttack(usedCh, enemy);
                    }
                }
                print.Stats(usedCh, enemy);

                if (usedCh.Health > 0 && enemy.Health > 0) //pokiaľ sú obydvaja naživu, ide nové kolo
                {
                    Console.WriteLine("Stlač akúkoľvek klávesu pre pokračovanie . . .");
                    Console.ReadKey(true);
                    Console.Clear();
                    print.Intro();
                    print.NewRound();
                    print.Intro();
                }
            }
            if (usedCh.Health == 0 && enemy.Health == 0) //remíza
            {
                Thread.Sleep(2000);
                Console.Clear();
                print.Intro();
                print.Stats(usedCh, enemy);
                Console.WriteLine("Remíza.");
            }
            if (usedCh.Health <= 0 && enemy.Health > 0) //nepriateľ vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                print.Intro();
                print.Stats(usedCh, enemy);
                Console.WriteLine(enemy.Name + " vyhral.");
            }
            if (enemy.Health <= 0 && usedCh.Health > 0) //bojovník vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                print.Intro();
                print.Stats(usedCh, enemy);
                Console.WriteLine(usedCh.Name + " vyhral.");
            }
        }
    }
}
