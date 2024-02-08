using AppsLab_020_OOP;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

public static class Program
{
    static void Main(string[] args)
    {
        var save = File.ReadAllLines("Save/saves.txt");
        string teamA = save[0];
        string teamB = save[6];

        List<Warrior> warriors = new List<Warrior>();
        List<Enemy> enemies = new List<Enemy>();

        for (int i = 1; i <= 5; i++)
        {
            string[] enemyData = save[i].Split(";");
            var enemy = new Enemy(enemyData[0], Int32.Parse(enemyData[1]), Int32.Parse(enemyData[2]), Int32.Parse(enemyData[3]), Int32.Parse(enemyData[4]));
            enemies.Add(enemy);
        }
        for (int i = 7;i <= 11; i++)
        {
            string[] warriorData = save[i].Split(";");
            var warrior = new Warrior(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]), Int32.Parse(warriorData[3]));
            warriors.Add(warrior);
        }





        //string[] warriorData = save[1].Split(';');

        //Enemy enemy = new Enemy(enemyData[0], Int32.Parse(enemyData[1]), Int32.Parse(enemyData[2]), Int32.Parse(enemyData[3]), Int32.Parse(enemyData[4]));
        //Warrior warrior = new Warrior(warriorData[0], Int32.Parse(warriorData[1]), Int32.Parse(warriorData[2]), Int32.Parse(warriorData[3]));
        Random r = new Random();
        int round = 0;
        while (warriors.Count>0 && enemies.Count>0)
        {
            int warriorIndex = r.Next(warriors.Count-1);
            int enemyIndex = r.Next(enemies.Count - 1);

            warriors[warriorIndex].Attack(enemies[enemyIndex]);
            enemies[enemyIndex].Attack(warriors[warriorIndex]);

            if (warriors[warriorIndex].Health > 0)
            warriors.RemoveAt(warriorIndex);
            if (enemies[enemyIndex].Health < 0)
                enemies.RemoveAt(enemyIndex);

         
        }
        if (warriors.Count > 0 )
        {
            Console.WriteLine("vyhral team s menom " + teamB);
        }
        if (enemies.Count > 0)
        {
            Console.WriteLine("vyhral team s menom " + teamA);
        }
        if (warriors.Count == 0 && enemies.Count == 0)
        {
            Console.WriteLine("Tie.");
        }

    }
    
}