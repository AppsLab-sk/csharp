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
        warrior.Health = 100;

        var wizzard = new Wizzard();
        wizzard.Name = "Čarodej";
        wizzard.AttackPower = 60;
        wizzard.Health = 100;

        var stats = new Statistick();

        while (warrior.Health > 0 && wizzard.Health > 0)
        {
            //warrior.Attack(wizzard);
            //wizzard.Attack(warrior);

            stats.Stats(warrior, wizzard);

            Console.WriteLine("Vyberte schopnosť: \n1 = Útok \n2 = Uzdraviť");
            int action = int.Parse(Console.ReadLine());

            if (action == 1) 
            {
                warrior.Attack(wizzard);
            }
            if (action == 2)
            {
                warrior.Heal(warrior);
            }

            if (wizzard.Health > 0)
            {
                if (wizzard.Health < warrior.AttackPower) 
                { 
                    wizzard.Heal(wizzard);
                }wizzard.Attack(warrior);
            }
            stats.Stats(warrior, wizzard);

            if (warrior.Health > 0 && wizzard.Health > 0) 
            {
                Thread.Sleep(2000);
                Console.Clear();
                intro.Print();
                Console.WriteLine("Nové kolo za:");
                Thread.Sleep(1000);
                Console.WriteLine("3...");
                Thread.Sleep(1000);
                Console.WriteLine("2...");
                Thread.Sleep(1000);
                Console.WriteLine("1...");
                Thread.Sleep(1000);
                Console.WriteLine("Štart!");
                Console.Clear();
                intro.Print();
            }
        }
        if (warrior.Health == 0 && wizzard.Health == 0)
        {
            Console.Clear();
            intro.Print();
            stats.Stats(warrior, wizzard);
            Console.WriteLine("Remíza.");
        }
        if (warrior.Health <= 0 && wizzard.Health > 0) 
        {
            Console.Clear();
            intro.Print();
            stats.Stats(warrior, wizzard);
            Console.WriteLine(wizzard.Name + " vyhral.");
        }
        if (wizzard.Health <= 0 && warrior.Health > 0)
        {
            Console.Clear();
            intro.Print();
            stats.Stats(warrior, wizzard);
            Console.WriteLine(warrior.Name + " vyhral.");
        }
    }
}