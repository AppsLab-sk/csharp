using AppsLab_020_OOP;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

public static class Program
{
    static void Main(string[] args)
    {
        Enemy enemy = new Enemy("Jožo", 20, 50, 200);
        Warrior warrior = new Warrior ("Hugo", 25,50, 150);
        int round = 0;
        while (warrior.StillAlive() && enemy.StillAlive())
        {
            warrior.Attack(enemy);
            enemy.Attack(warrior);
            Console.WriteLine((round++) + " " + warrior + " vs " + enemy);
        }
        if (enemy.StillAlive())
        {
            Console.WriteLine("Enemy" + " " + enemy.Name + " " + "won.");
        }
        if (warrior.StillAlive())
        {
            Console.WriteLine("Warrior" + " " + warrior.Name + " " + "won.");
        }
        if (!warrior.StillAlive() && !enemy.StillAlive())
        {
            Console.WriteLine("Tie.");
        }

    }
}