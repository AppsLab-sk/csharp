using AppsLab_020_OOP;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var save = File.ReadAllLines("Save/Saves.txt"); 

        string[] warriorData = save[0].Split(';');
        string[] mageData = save[1].Split(";");

        var warrior = new Mage(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]), Int32.Parse(warriorData[3]));
        var mage = new Mage(mageData[0], Int32.Parse(mageData[1]), Int32.Parse(mageData[2]), Int32.Parse(mageData[3]));
       
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
