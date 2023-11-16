using AppsLab_020_OOP;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        var warior = new Warior();
        warior.Name = "Anton";
        warior.Health = 2000;
        warior.AttackPower = 10;

        var enemy = new Enemy();
        enemy.Name = "Juraj";
        enemy.Health = 1000;
        enemy.Mana = 100;
        enemy.AttackPower = 20;
    
        int round = 0;
        while (enemy.StillAlive() && warior.StillAlive())
        {
            enemy.Attack(warior);
            warior.Attack(enemy);
            Console.WriteLine((round++) + " " + warior + " vs. " + enemy);







        }
    }
}
