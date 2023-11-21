using AppsLab_020_OOP;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");


        var warrior = new Warrior("Octaine", 1500, 50);

       
        var mage = new Mage("Measing", 1500, 150, 75);

        int round = 0;
        while (mage.StillALive() && warrior.StillALive())
        {
            mage.Attack(warrior);
            warrior.Attack(mage);
            Console.WriteLine(round++ + " " + warrior + " vs " + mage);
        }

        if (warrior.StillALive())
        {
            Console.WriteLine("vyhral bojovnik s menom: " + warrior.Name);  
        }
        if (mage.StillALive())
        {
            Console.WriteLine("vyhral bojovnik s menom: " + mage.Name);
        }
        if (!mage.StillALive() && !warrior.StillALive())
        {
            Console.WriteLine("remiza :( ");
        }
    }
}
