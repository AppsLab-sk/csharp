using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Archer = new Archer();
            Archer.Name = "Legolas";
            Archer.Health = 800;
            Archer.AttackPower = 145;
            Archer.Defend = 100;

            var Enemy = new Enemy();
            Enemy.Name = "Shelob";
            Enemy.Health = 400;
            Enemy.AttackPower = 180;
            Enemy.Heal = 90;

            while (Enemy.Health > 0 && Archer.Health > 0)
            {
                Console.WriteLine(Archer.Name + " attacks " + Enemy.Name + " with " + Archer.AttackPower + " AP");
                Thread.Sleep(500);
                Enemy.Health -= Archer.AttackPower;
                Thread.Sleep(500);
                Console.WriteLine(Enemy.Name + " attacks " + Archer.Name + " with " + Enemy.AttackPower + " AP");
                Thread.Sleep(500);
                Archer.Health -= Enemy.AttackPower;
                Thread.Sleep(500);
                Console.WriteLine(Enemy.Name + " has " + Enemy.Health + " HP ");
                Thread.Sleep(500);
                Console.WriteLine(Archer.Name + " has " + Archer.Health + " HP ");

            }
            if (Archer.Health <= 0)
            {
                Console.WriteLine(Archer.Name + " was defeated ");
                Console.WriteLine(Enemy.Name + " wins !!!");
            }
            
            if (Enemy.Health <= 0)
            {
                Console.WriteLine(Enemy.Name + " was defeated ");
                Console.WriteLine(Archer.Name  + " wins !!!");
            }
            
            if (Enemy.Health <= 0 && Archer.Health <= 0)
                Console.WriteLine("It is a Tie !!!!");


        }
    }
}

