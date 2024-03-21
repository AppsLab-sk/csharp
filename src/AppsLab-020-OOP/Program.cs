using AppsLab_020_OOP;

internal class Program
{
    static void Main(string[] args)
    {
        var save = File.ReadAllLines("Save/Saves.txt");

        string enemiesTeamName = save[0];
        string wariorsTeamName = save[6];

        List<Warior> Wariors = new List<Warior>();
        List<Enemy> Enemies = new List<Enemy>();

        for (int i = 1; i <= 5; i++)
        {
            string[] enemyData = save[i].Split(";");
            var enemy = new Enemy(enemyData[0], Int32.Parse(enemyData[1]), Int32.Parse(enemyData[2]), 
                Int32.Parse(enemyData[3]));
            Enemies.Add(enemy);
        }

        for (int i = 7; i <= 11; i++)
        {
            string[] wariorData = save[i].Split(";");
            var warior = new Warior(wariorData[0], Int32.Parse(wariorData[1]), 
                Int32.Parse(wariorData[2]));
            Wariors.Add(warior);
        }
        Random r = new Random();
        int round = 0;
        while (Enemies.Count>0 && Wariors.Count>0)
        {
            int EnemyIndex = r.Next(Enemies.Count-1);
            int WariorIndex = r.Next(Wariors.Count - 1);

            Enemies[EnemyIndex].Attack(Wariors[WariorIndex]);
            Wariors[WariorIndex].Attack(Enemies[EnemyIndex]);
            
            if (Enemies[EnemyIndex].Health < 0)
                Enemies.RemoveAt(EnemyIndex);
            if (Wariors[WariorIndex].Health < 0)
                Wariors.RemoveAt(WariorIndex);
        } 

        if (Wariors.Count>0)
        {
            Console.WriteLine("vyhral team s menom: " + wariorsTeamName);
        }
        if (Enemies.Count>0)
        {
            Console.WriteLine("vyhral team s menom: " + enemiesTeamName);
        }
        if (Enemies.Count==0 && Wariors.Count==0)
        {
            Console.WriteLine("remiza :( ");
        }
    }
}
