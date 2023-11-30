using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var save = File.ReadAllLines("Save / Saves.txt");

            string teamA = save[0];
            string teamB = save[6];

            List<Archer> archers = new List<Archer>();
            List<Enemy> enemies = new List<Enemy>();

            for (int i = 1; i < 5; i++)

            {
                string[] archerData = save[i].Split(',');
                var archer = new Archer(archerData[0],
                Int32.Parse(archerData[1]),
                Int32.Parse(archerData[2]),
                Int32.Parse(archerData[3]));
                archers.Add(archer);

            }

            for (int i = 7; i < 11; i++)

            {
                string[] enemyData = save[i].Split(',');
                var enemy = new Enemy(enemyData[0],
                Int32.Parse(enemyData[1]),
                Int32.Parse(enemyData[2]),
                Int32.Parse(enemyData[3]));
                enemies.Add(enemy);

            }

            Random r = new Random();
            int round = 0;
            while (archers.Count > 0 && enemies.Count > 0)
            {
                int archerIndex = r.Next(archers.Count - 1);
                int enemyIndex = r.Next(enemies.Count - 1);
                archers[archerIndex].Attack(enemies[enemyIndex]);
                enemies[enemyIndex].Attack(archers[archerIndex]);

                if (archers[archerIndex].Health > 0)
                    archers.RemoveAt(archerIndex);
                if (enemies[enemyIndex].Health > 0)
                    enemies.RemoveAt(enemyIndex);



            }
        }
    }
}
}