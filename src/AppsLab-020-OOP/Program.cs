 using AppsLab_020_OOP;
using System.Threading;

public static class Program
{
     static void Main(string[] args)
     {
        Mage mage = new Mage();
        mage.Name = "Octavius";
        mage.Health = 190;
        mage.AttackPower = 25;
        mage.Mana = 200;
        mage.HealthPots = 2;
        Warrior warrior = new Warrior();
        warrior.Name = "Ed";
        warrior.Health = 240;
        warrior.AttackPower = 15;
        warrior.Bandages = 2;

        int round = 0;
        while (warrior.StillAlive() && mage.StillAlive())
        {
            warrior.Attack(mage);
            mage.Attack(warrior);
            Console.WriteLine((round++) + " " + warrior + "vs" + mage);
        }
            if (mage.StillAlive())
            {
                Console.WriteLine("Mage" + " " + mage.Name + " " + "won.");
            }
            if (warrior.StillAlive())
            {
                Console.WriteLine("Warrior" + " "  + warrior.Name + " " + "won.");
            }
            if (!warrior.StillAlive() && !mage.StillAlive())
            {
                Console.WriteLine("Tie.");
            }

     }
}

