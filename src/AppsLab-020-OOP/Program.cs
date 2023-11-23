using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using AppsLab_020_OOP;

public static class Programe
{
    static void Main(string[] args)
    {
        var save = File.ReadAllLines("Save\\Saves.txt");
        string[] wizardData = save[0].Split(';');
        string[] orkData = save[0].Split(';');





        
        var wizard = new Ork(wizardData[0], Int32.Parse(wizardData[1]), Int32.Parse(wizardData[2]));
        var ork = new Ork(orkData[0], Int32.Parse(orkData[1]), Int32.Parse(orkData[2]));
        //var battle = new Battle();

        //public void SimulateBattle(Wizard wizard, Ork ork, int maxRounds)

        Console.WriteLine($"Battle begins between {wizard.Name} and {ork.Name}");
        int maxRounds = 5;
        for (int round = 1; round <= maxRounds; round++)
        {
            Console.WriteLine($"Round {round}");

            // Wizard attacks Ork
            wizard.Attack(ork);
            Console.WriteLine($"{ork.Name} attacks {ork.Name}. {ork.Name}'s health: {ork.Health}");

            // Check if Ork is still alive
            if (!ork.StillAlive())
            {
                Console.WriteLine($"{ork.Name} has been defeated!");
                break;
            }

            // Ork attacks Wizard
            ork.Attack(wizard);
            Console.WriteLine($"{ork.Name} attacks {wizard.Name}. {wizard.Name}'s health: {wizard.Health}");

            // Check if Wizard is still alive
            if (!wizard.StillAlive())
            {
                Console.WriteLine($"{wizard.Name} has been defeated!");
                break;
            }
        }

        Console.WriteLine("Battle ended.");
    }
}



                        
