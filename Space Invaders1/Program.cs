using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static int playerPositionX;
    static int playerPositionY;
    static List<Projectile> playerProjectiles = new List<Projectile>();
    static List<Enemy> enemies = new List<Enemy>();
    static Random random = new Random();

    const int ConsoleWidth = 80;
    const int ConsoleHeight = 24;

    static void Main()
    {
        Console.Title = "Space Invaders";
        Console.WindowWidth = ConsoleWidth;
        Console.WindowHeight = ConsoleHeight;

        Console.CursorVisible = false;

        playerPositionX = ConsoleWidth / 2;
        playerPositionY = ConsoleHeight - 2;

        InitializeEnemies();

        while (true)
        {
            Console.Clear();
            DrawPlayer();
            DrawProjectiles();
            DrawEnemies();
            ProcessInput();
            MoveProjectiles();
            MoveEnemies();
            CheckCollisions();
            GameOver();
           
            Thread.Sleep(50); 
        }
    }

    static void InitializeEnemies()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                enemies.Add(new Enemy(j * 6, i * 3));
            }
        }
    }

    static void DrawPlayer()
    {
        Console.SetCursorPosition(playerPositionX, playerPositionY);
        Console.Write("A");
    }

    static void DrawProjectiles()
    {
        foreach (var projectile in playerProjectiles)
        {
            Console.SetCursorPosition(projectile.X, projectile.Y);
            Console.Write("|");
        }
    }

    static void DrawEnemies()
    {
        foreach (var enemy in enemies)
        {
            Console.SetCursorPosition(enemy.X, enemy.Y);
            Console.Write("X");
        }
    }

    static void ProcessInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.A:
                    if (playerPositionX > 0)
                        playerPositionX--;
                    break;

                case ConsoleKey.D:
                    if (playerPositionX < ConsoleWidth - 1)
                        playerPositionX++;
                    break;

                case ConsoleKey.Spacebar:
                    playerProjectiles.Add(new Projectile(playerPositionX, playerPositionY - 1));
                    break;
            }
        }
    }

    static void MoveProjectiles()
    {
        foreach (var projectile in playerProjectiles)
        {
            projectile.Y--;

            if (projectile.Y < 0)
                projectile.IsAlive = false;
        }

        playerProjectiles.RemoveAll(p => !p.IsAlive);
    }

    static void MoveEnemies()
    {
        foreach (var enemy in enemies)
        {

            enemy.X++;
            //enemy.X--;

            if (enemy.X >= ConsoleWidth - 30)
            {
            enemy.X--;
            }
             if (enemy.X < 0)
            {
             enemy.X++;
            }
            //enemy.IsAlive = false;
        }

        enemies.RemoveAll(e => !e.IsAlive);


 
    }
    static void GameOver()
    {
        if (enemies.Count == 0)
        {
            Console.SetCursorPosition(7, 20);
            Console.Write("You've slain all of the enemies! Congratulations!");
        }
    }

    static void CheckCollisions()
    {
        foreach (var projectile in playerProjectiles.ToList())
        {
            foreach (var enemy in enemies.ToList())
            {
                if (projectile.X == enemy.X && projectile.Y == enemy.Y)
                {
                    projectile.IsAlive = true;
                    enemy.IsAlive = false;
                }
            }
        }
    }
}

class Projectile
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsAlive { get; set; }

    public Projectile(int x, int y)
    {
        X = x;
        Y = y;
        IsAlive = true;
    }
}

class Enemy
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsAlive { get; set; }

    public Enemy(int x, int y)
    {
        X = x;
        Y = y;
        IsAlive = true;
    }
}

