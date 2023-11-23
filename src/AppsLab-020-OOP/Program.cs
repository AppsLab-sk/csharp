using AppsLab_020_OOP;
using System.Xml.Linq;

//string value = Console.ReadLine();
public class Program
{
    public static void Main(string[] args)
    {

        var warrior = new Warrior();
        warrior.Name = "Bojovník";
        warrior.Health = 2000;
        warrior.AttackPower = 10;

        var wizzard = new Wizzard();
        wizzard.Name = "carodejnik";
        wizzard.Health = 1000;
        wizzard.Mana = 1000;
        wizzard.AttackPower = 20;



        //int round = 0;
        while (wizzard.Health > 0 && warrior.Health > 0)
        {
            wizzard.Attack(warrior);
            warrior.Attack(wizzard);
            Console.WriteLine(warrior.Name + warrior.Health + " : " + wizzard.Name + wizzard.Health);

        }

        if (warrior.Health > 0)
        {
            Console.WriteLine("vyhral bojovník s menom:" + warrior.Name);
        }
        if (wizzard.Health > 0)
        {

            Console.WriteLine("vyhral bojovník s menom:" + wizzard.Name);
        }
        if (wizzard.Health > 0 && warrior.Health > 0)
        {
            Console.WriteLine("remíza: ( ");
        }

    }




}



