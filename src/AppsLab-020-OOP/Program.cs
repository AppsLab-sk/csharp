 using AppsLab_020_OOP;
using System.Threading;

public static class Program
{
    static void Main(string[] args)
    {
        var save = File.ReadAllLines("Save/saves.txt");

        string[] mageData = save[0].Split(";");
        string[] warriorData = save[1].Split(';');

        Mage mage = new Mage(mageData[0] , Int32.Parse(mageData[1]), Int32.Parse(mageData[2]), Int32.Parse(mageData[3]), Int32.Parse(mageData[4]));
        Warrior warrior = new Warrior(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]), Int32.Parse(warriorData[3]));

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

