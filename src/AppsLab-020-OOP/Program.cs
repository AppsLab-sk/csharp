using AppsLab_020_OOP;

internal class Program
{
    static void Main(string[] args)
    {
        var save = File.ReadAllLines("Save/Saves.txt");

        string[] wariorData = save[0].Split(";");
        string[] enemyData = save[1].Split(";");

        var warior = new Enemy(wariorData[0], Int32.Parse(wariorData[1]), Int32.Parse(wariorData[2]), Int32.Parse(wariorData[3]));
        var enemy = new Enemy(enemyData[0], Int32.Parse(enemyData[1]), Int32.Parse(enemyData[2]), Int32.Parse(enemyData[3]));



        int round = 0;
        while (enemy.StillAlive() && warior.StillAlive())
        {
            enemy.Attack(warior);
            warior.Attack(enemy);
            Console.WriteLine((round++) + " " + warior + " vs. " + enemy);
        } 

        if (warior.StillAlive())
        {
            Console.WriteLine("vyhral bojovnik s menom " + warior.Name);
        }
        if (enemy.StillAlive())
        {
            Console.WriteLine("vyhral bojovnik s menom " + enemy.Name);
        }
        if (!enemy.StillAlive() && !warior.StillAlive())
        {
            Console.WriteLine("remiza :( ");
        }
    }
}
