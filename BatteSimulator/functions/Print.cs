using BatteSimulator.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.functions
{
    public class Print
    {
        public void Intro()
        {
            string text = @"

 ██████╗ ██████╗ ███╗   ██╗███████╗ ██████╗ ██╗     ███████╗██████╗ ██████╗  ██████╗ 
██╔════╝██╔═══██╗████╗  ██║██╔════╝██╔═══██╗██║     ██╔════╝██╔══██╗██╔══██╗██╔════╝ 
██║     ██║   ██║██╔██╗ ██║███████╗██║   ██║██║     █████╗  ██████╔╝██████╔╝██║  ███╗
██║     ██║   ██║██║╚██╗██║╚════██║██║   ██║██║     ██╔══╝  ██╔══██╗██╔═══╝ ██║   ██║
╚██████╗╚██████╔╝██║ ╚████║███████║╚██████╔╝███████╗███████╗██║  ██║██║     ╚██████╔╝
 ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝      ╚═════╝ 
                                                                                 DEMO
                                                                         by Martas_SK

";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void Soon() { Console.WriteLine("Comming soon..."); }

        public void Stats(ICharacter usedCh, IEnemy enemy)
        {
            Console.WriteLine(usedCh.Name + " " + usedCh.Health + " : " + enemy.Name + " " + enemy.Health);
        }

        public void PlayerAttack(ICharacter usedCh, IEnemy enemy)
        {
            Console.WriteLine(usedCh.Name + " ubral: " + usedCh.AttackPower + " životov " + enemy.Name);
        }

        public void EnemyAttack(ICharacter usedCh, IEnemy enemy)
        {
            Console.WriteLine(enemy.Name + " ubral: " + enemy.AttackPower + " životov " + usedCh.Name);
        }

        public void NewRound()
        {
            var print = new Print();
            Console.WriteLine("Nové kolo za:");
            Thread.Sleep(1000);
            Console.Clear();

            print.Intro();
            Console.WriteLine("Nové kolo za:");
            Console.WriteLine(@"

██████╗          
╚════██╗         
 █████╔╝         
 ╚═══██╗         
██████╔╝██╗██╗██╗
╚═════╝ ╚═╝╚═╝╚═╝
                 

");
            Thread.Sleep(1000);
            Console.Clear();

            print.Intro();
            Console.WriteLine("Nové kolo za:");
            Console.WriteLine(@"

██████╗          
╚════██╗         
 █████╔╝         
██╔═══╝          
███████╗██╗██╗██╗
╚══════╝╚═╝╚═╝╚═╝
                 

");
            Thread.Sleep(1000);
            Console.Clear();

            print.Intro();
            Console.WriteLine("Nové kolo za:");
            Console.WriteLine(@"

 ██╗         
███║         
╚██║         
 ██║         
 ██║██╗██╗██╗
 ╚═╝╚═╝╚═╝╚═╝
             

");
            Thread.Sleep(1000);
            Console.Clear();

            print.Intro();
            Console.WriteLine(@"

███████╗████████╗ █████╗ ██████╗ ████████╗
██╔════╝╚══██╔══╝██╔══██╗██╔══██╗╚══██╔══╝
███████╗   ██║   ███████║██████╔╝   ██║   
╚════██║   ██║   ██╔══██║██╔══██╗   ██║   
███████║   ██║   ██║  ██║██║  ██║   ██║   
╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   
                                          

");
            Thread.Sleep(1000);
            Console.Clear();
        }

    }
}
