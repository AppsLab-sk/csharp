 using AppsLab_020_OOP;
using System.Threading;

public static class Program
{
    static void Main(string[] args)
    {
        var save = File.ReadAllLines("Save/saves.txt");

        string teamA = save[0];
        string teamB = save[6];
        

        List<Mage> mages = new List<Mage>();
        List<Warrior> warriors = new List<Warrior>();

        for (int i = 1; i <= 5; i++)
        {
            string[] mageData = save[i].Split(';');
            var mage = new Mage(mageData[0], Int32.Parse(mageData[1]), Int32.Parse(mageData[2]), Int32.Parse(mageData[3]), Int32.Parse(mageData[4]));
            mages.Add(mage);
        }
        for (int i = 7; i <= 11; i++)
        {
            string[] warriorData = save[i].Split(';');
            var warrior = new Warrior(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]), Int32.Parse(warriorData[3]));
            warriors.Add(warrior);
        }
        Random r = new Random();
        int round = 0;
        while (warriors.Count>0 && mages.Count>0)
        {
            int mageIndex = r.Next(mages.Count - 1);
            int warriorIndex = r.Next(warriors.Count - 1);


            warriors[warriorIndex].Attack(mages[mageIndex]);
            mages[mageIndex].Attack(warriors[warriorIndex]);
            mages[mageIndex].Heal();
            warriors[warriorIndex].Heal();

            if (mages[mageIndex].Health < 0)
                mages.RemoveAt(mageIndex);
            if (warriors[warriorIndex].Health < 0)
                warriors.RemoveAt(warriorIndex);
        }
            if (mages.Count > 0)
            {
                Console.WriteLine("Team" + " " + teamA + " has" + " " + "won.");
            }
            if (warriors.Count > 0)
            {
                Console.WriteLine("Team" + " " + teamB + " has" + " " + "won.");
        }
            if (mages.Count == 0 && warriors.Count == 0)
            {
                Console.WriteLine("Tie.");
            }

     }
}

