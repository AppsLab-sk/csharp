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

 ██████╗ ██████╗ ███╗   ██╗███████╗ ██████╗ ██╗     ███████╗██████╗ ██████╗  ██████╗  ║
██╔════╝██╔═══██╗████╗  ██║██╔════╝██╔═══██╗██║     ██╔════╝██╔══██╗██╔══██╗██╔════╝  ║
██║     ██║   ██║██╔██╗ ██║███████╗██║   ██║██║     █████╗  ██████╔╝██████╔╝██║  ███╗ ║
██║     ██║   ██║██║╚██╗██║╚════██║██║   ██║██║     ██╔══╝  ██╔══██╗██╔═══╝ ██║   ██║ ║
╚██████╗╚██████╔╝██║ ╚████║███████║╚██████╔╝███████╗███████╗██║  ██║██║     ╚██████╔╝ ║
 ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝ ╚═════╝ ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝      ╚═════╝  ║
                                                                                 v0.1 ║
                                                                         by Martas_SK ║
                                                                                      ║
══════════════════════════════════════════════════════════════════════════════════════╣";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ResetColor();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            //Console.Write(new string('═', 86)+ "╣\n");
        }

        public void Line()
        {
            Console.Write(new string('═', 86) + "╣\n");
        }

        public void EndLine()
        {
            Console.WriteLine("══════════════════════════════════════════════════════════════════════════════════════╝");
        }
        
        public void Soon() { Console.WriteLine("Comming soon..."); }

        
        //==================== Game Mode -- 1v1 ====================
        
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

        //==========================================================

    }
}
