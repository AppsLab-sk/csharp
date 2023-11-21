 using AppsLab_020_OOP;
using System.Threading;

public static class Program
{
    static void Main(string[] args)
    {
        Mage mage = new Mage("Al" , 190, 25, 200, 2);
        Warrior warrior = new Warrior("Ed", 240, 15, 2);

        int round = 0;
        while (warrior.StillAlive() && mage.StillAlive())
        {
            warrior.Attack(mage);
            mage.Attack(warrior);
            mage.Heal();
            warrior.Heal();
            Console.WriteLine((round++) + " " + warrior + " vs " + mage);
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

