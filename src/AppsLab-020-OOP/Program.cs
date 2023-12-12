
using AppsLab_020_OOP;

public class Program
{
    static void Main(object wizardData)
    {
        var save = File.ReadAllLines("Save/Saves.txt");

        string teamA = save[0];
        string teamB = save[6];

        List<Warrior> warriors = new List<Warrior>();
        List<Wizard> wizards = new List<Wizard>();

        for (int i = 1; i <= 5; i++)
        {
            var warriorData = save[0].Split(";");
            var warrior = new Warrior(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]));

            warriors.Add(warrior);
        }

        for (int i = 7; i <= 11; i++)

           string[] wizardData = save[1].Split(";");
        {
            var wizard = new Wizard();
            wizard.Name = wizardData[0];
            wizard.Health = Int32.Parse(wizardData[1]);
            wizard.Mana = Int32.Parse(wizardData[2]);
            wizard.AttackPower = Int32.Parse(wizardData[3]);
            wizard.Add (wizards)
        
}

        int round = 0;
        while (wizard.StillAlive() && warrior.StillAlive())
        {
            int wizardindex = Random.Next(maxvalue wizards.Count - 1);
            int warriorindex = Random.Next(maxvalue warriors.Count - 1);

            wizard.Attack(warrior);
            warrior.Attack(wizard);
            Console.WriteLine((round++) + " " + warrior.Name + " vs." + wizard.Name);
        }



        if (warrior.StillAlive())
        {
            Console.WriteLine("vyhral bojovnik s menom: " + warrior.Name);
        }
        if (wizard.StillAlive())
        {
            Console.WriteLine("vyhral bojovnik s menom: " + wizard.Name);
        }
        if (!wizard.StillAlive() && !warrior.StillAlive())
        {
            Console.WriteLine("remiza :( ");
        }
    }
}





