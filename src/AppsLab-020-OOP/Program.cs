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

        var warrior = new Warrior();
        warrior.Name = "Bojovník";
        warrior.AttackPower = 50;
        warrior.Health = 200;
        warrior.HealAmount = 2;

        var wizzard = new Wizzard();
        wizzard.Name = "Čarodej";
        wizzard.AttackPower = 60;
        wizzard.Health = 100;
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
                Console.WriteLine(warrior.Name + " ubral: " + warrior.AttackPower + " životov " + wizzard.Name);
            }
            if (action == 2)
            {
                warrior.Heal(warrior, wizzard);
                Console.WriteLine("Ostávajúci počet uzdravení: " + warrior.HealAmount);
            }

            if (wizzard.Health > 0)
            {
                if (wizzard.Health <= warrior.AttackPower) 
                { 
                    wizzard.Heal(wizzard, warrior);
                    Console.WriteLine("Ostávajúci počet uzdravení: " + wizzard.HealAmount + " pre " + wizzard.Name);
                }
                else 
                {
                    wizzard.Attack(warrior);
                    Console.WriteLine(wizzard.Name + " ubral: " + wizzard.AttackPower + " životov " + warrior.Name);
                }
            }
            stats.Stats(warrior, wizzard);

            if (warrior.Health > 0 && wizzard.Health > 0) 
            {
                Thread.Sleep(2000);
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