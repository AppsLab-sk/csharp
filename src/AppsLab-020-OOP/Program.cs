using System.Collections;
using System.ComponentModel.Design;
using System.Reflection;
using System.Threading;

public class Program
{
    static void Main()
    {
        var intro = new Intro();
        intro.Print();

        var warrior = new Warrior
        {
            Name = "Bojovník",
            AttackPower = 50,
            Health = 200,
            HealAmount = 2
        };

        var wizzard = new Wizzard
        {
            Name = "Čarodej",
            AttackPower = 60,
            Health = 100,
            HealAmount = 2
        };

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