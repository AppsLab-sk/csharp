using AppsLab_020_OOP.functions;
using CommonProblems._01_Problem;
using CommonProblems.DOD;
using System;

namespace CommonProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var playerpc = new PlayerVsPc();
            var pcpc = new PcVsPc();
            var intro = new Intro();
            intro.Print();

            Console.WriteLine("Vyberte možnosť: \n1 Hráč proti počítaču \n2 Počítač proti počítaču");
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                playerpc.Execute();
            }
            if (action == 2)
            {
                pcpc.Execute();
            }


            /*  var character = new Character();
              character.Name = "Charizard";
              character.Health = 100;
              character.AttackPower = 30;

              var enemy = new Enemy();
              enemy.Name = "Squirtle";
              enemy.Health = 100;
              enemy.AttackPower = 20;

              var enemy2 = new Enemy();
              enemy2.Name = "Ivysaur";
              enemy2.Health = 50;
              enemy2.AttackPower = 50;

              var enemy3 = new Enemy();
              enemy3.Name = "Grotle";
              enemy3.Health = 60;
              enemy3.AttackPower = 60;




              Console.WriteLine("Mission : defeat " + enemy.Name);
              Console.WriteLine(character.Name + " has " + character.Health + "HP");
              Console.WriteLine(enemy.Name + " has " + enemy.Health + "HP");

              while (character.Health >= 0 && enemy.Health >= 0)

              {
                  enemy.Health -= character.AttackPower;
                  Console.WriteLine(character.Name + " attacks " + enemy.Name + " with " + character.AttackPower + " Attack Power");
                  character.Health -= enemy.AttackPower;
                  Console.WriteLine(enemy.Name + " attacks " + character.Name + " with " + enemy.AttackPower + " Attack Power");
                  Console.WriteLine(enemy.Name + " has " + enemy.Health + "HP");
                  Console.WriteLine(character.Name + " has " + character.Health + "HP");
              }

              if (enemy.Health <= 0)

              {
                  Console.WriteLine(enemy.Name + " was defeated ");
                  Console.WriteLine("Reward : +50 HP , +30AP ");
                  character.Health += 50;
                  character.AttackPower += 30;
                  Console.WriteLine("Searching for another enemy...");
                  Thread.Sleep(1000);
                  Console.WriteLine("Searching...");
                  Thread.Sleep(1000);
                  Console.WriteLine("Searching...");
                  Thread.Sleep(1000);
                  Console.WriteLine("Searching...");
                  Thread.Sleep(2000);
              }

              if (character.Health <= 0)
              {
                  Console.WriteLine(character.Name + " was defeated ");
              }

              Console.WriteLine("Enemy found!");
              Console.WriteLine("Mission : defeat " + enemy2.Name);
              Console.WriteLine(enemy2.Name + " has " + enemy2.Health + "HP" + " and " + enemy2.AttackPower + "AP");
              Console.WriteLine("Press 1 for next battle");
              int action = int.Parse(Console.ReadLine());

              if (action == 1)
              {
                  while (character.Health >= 0 && enemy2.Health >= 0)
                  {
                      enemy2.Health -= character.AttackPower;
                      Console.WriteLine(character.Name + " attacks " + enemy2.Name + " with " + character.AttackPower + " Attack Power");
                      character.Health -= enemy2.AttackPower;
                      Console.WriteLine(enemy2.Name + " attacks " + character.Name + " with " + enemy2.AttackPower + " Attack Power");
                      Console.WriteLine(enemy2.Name + " has " + enemy2.Health + "HP");
                      Console.WriteLine(character.Name + " has " + character.Health + "HP");

                  }
              }

              if (enemy2.Health <= 0)

              {
                  Console.WriteLine(enemy2.Name + " was defeated ");
                  Console.WriteLine("Reward : +40 HP , +40AP ");
                  character.Health += 40;
                  character.AttackPower += 40;
                  Console.WriteLine("Searching for another enemy...");
                  Thread.Sleep(1000);
                  Console.WriteLine("Searching...");
                  Thread.Sleep(1000);
                  Console.WriteLine("Searching...");
                  Thread.Sleep(1000);
                  Console.WriteLine("Searching...");
                  Thread.Sleep(2000);

              }

              if (character.Health <= 0)
              {
                  Console.WriteLine(character.Name + " was defeated ");
              }




              Console.WriteLine("Enemy found!");
              Console.WriteLine("Mission : defeat " + enemy3.Name);
              Console.WriteLine(enemy3.Name + " has " + enemy3.Health + "HP" + " and " + enemy3.AttackPower + "AP");
              Console.WriteLine("Press 1 for next battle");
              int action2 = int.Parse(Console.ReadLine());

              if (action2 == 1)
              {
                  while (character.Health >= 0 && enemy3.Health >= 0)
                  {
                      enemy3.Health -= character.AttackPower;
                      Console.WriteLine(character.Name + " attacks " + enemy3.Name + " with " + character.AttackPower + " Attack Power");
                      character.Health -= enemy2.AttackPower;
                      Console.WriteLine(enemy3.Name + " attacks " + character.Name + " with " + enemy3.AttackPower + " Attack Power");
                      Console.WriteLine(enemy3.Name + " has " + enemy3.Health + "HP");
                      Console.WriteLine(character.Name + " has " + character.Health + "HP");

                  }
              }

              if (character.Health <= 0)
              {
                  Console.WriteLine(character.Name + " was defeated ");
              }

              if (enemy3.Health <= 0)
              {
                  Console.WriteLine(enemy3.Name + " was defeated ");
                  Console.WriteLine("You finished the game!");
              }
          }*/
        }
    }
}