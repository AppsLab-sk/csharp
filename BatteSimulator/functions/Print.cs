using BatteSimulator.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public void Input()
        {
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            EndLine();
            Console.SetCursorPosition(86, Console.CursorTop - 2);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);
        }


        //============== Difficulties =========================================

        public void DfChoose()
        {
            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);


            Console.Write("Choose difficulty: ");
        }                        //výber obtiažnosti

        public void DfList(int i, List<string> diffs)
        {
            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop);

            Console.Write($"{i + 1}. {diffs[i]}");

            Console.SetCursorPosition(86, Console.CursorTop);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);
        } //list obtiažností

        public void DfCustom()
        {
            Console.Clear();
            Intro();

            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            Console.WriteLine("Set custom difficulty: ");

            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
            Console.SetCursorPosition(86, Console.CursorTop - 2);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);
        }                        //vlastná obtiažnosť


        //============== Characters ===========================================

        public void ChChoose()
        {
            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            Console.Write($"Choose your character: ");
        }                          //výber postavy

        public void ChList(int i, List<ICharacter> ch) 
        {
            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop);

            Console.Write($"{i + 1}. {ch[i].Name}, Health: {ch[i].Health}, Damage: {ch[i].AttackPower}");

            Console.SetCursorPosition(86, Console.CursorTop);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);
        } //list postáv


        //============== Game Modes ===========================================

        public void GmChoose()
        {
            Console.WriteLine("Choose your game mode: ");

            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);
        }                          //výber režimu

        public void GmList(int i, List<IGameMode> gm)
        {
            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop);

            Console.Write($"{i + 1}. {gm[i].Name}");

            Console.SetCursorPosition(86, Console.CursorTop);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);
        }   //list režimov


        //============== Game Mode -- Comming soon... =========================

        public void Soon() { Console.WriteLine("Comming soon..."); }


        //============== Game Mode -- 1v1 =====================================

        public void _1v1Choose() 
        {
            Console.WriteLine("Vyberte schopnosť:");

            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);
        }                       //výber shopnosti

        public void _1v1List(int i, int j, MethodInfo[] chMethods)
        {
            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop);

            Console.Write($"{j}. {chMethods[i].Name}");

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        } //všetky schopnosti

        public void _1v1Stats(ICharacter usedCh, IEnemy enemy)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.WriteLine($"{usedCh.Name} {usedCh.Health} : {enemy.Name} {enemy.Health}");
            
            //Console.WriteLine();
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        } //vypíše životy hráča aj nepriateľa

        public void _1v1ChAttack(ICharacter usedCh, IEnemy enemy)
        {
            Console.WriteLine(usedCh.Name + " ubral: " + usedCh.AttackPower + " životov " + enemy.Name);
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        }//hráč zaútočil

        public void _1v1ChHeal(ICharacter usedCh)
        {
            Console.WriteLine($"Ostávajúci počet uzdravení: {usedCh.HealAmount}");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        } //hráč použil uzdravanie

        public void _1v1ChNoHeal(ICharacter usedCh)
        {
            Console.WriteLine("Neostali žiadne uzdravania.");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        } //hráčovi neostávajú uzdravania

        public void _1v1EnemyAttack(ICharacter usedCh, IEnemy enemy)
        {
            Console.WriteLine(enemy.Name + " ubral: " + enemy.AttackPower + " životov " + usedCh.Name);
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        } //nepriateľ zaútočil

        public void _1v1EHeal(IEnemy enemy)
        {
            Console.WriteLine($"Ostávajúci počet uzdravení: {enemy.HealAmount} pre {enemy.Name}");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        } //nepriateľ sa uzdravil

        public void _1v1Continue()
        {
            Console.WriteLine("Stlačte akúkoľvek klávesu pre pokračovanie . . .");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            EndLine();
            //Console.SetCursorPosition(0,Console.CursorTop - 2);
            Console.SetCursorPosition(86, Console.CursorTop - 2);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);
        } //pokračovanie

        public void _1v1NewRound()
        {
            Console.CursorVisible = false;
            Console.WriteLine("Nové kolo za:");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
            Thread.Sleep(1000);
            Console.Clear();

            Intro();
            Console.WriteLine("Nové kolo za:");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.WriteLine(@"
                                                                                      ║
██████╗                                                                               ║  
╚════██╗                                                                              ║ 
 █████╔╝                                                                              ║
 ╚═══██╗                                                                              ║
██████╔╝██╗██╗██╗                                                                     ║
╚═════╝ ╚═╝╚═╝╚═╝                                                                     ║
                                                                                      ║
                                                                                      ║ 
");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            EndLine();
            Thread.Sleep(1000);
            Console.Clear();

            Intro();
            Console.WriteLine("Nové kolo za:");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.WriteLine(@"
                                                                                      ║
██████╗                                                                               ║
╚════██╗                                                                              ║
 █████╔╝                                                                              ║
██╔═══╝                                                                               ║
███████╗██╗██╗██╗                                                                     ║
╚══════╝╚═╝╚═╝╚═╝                                                                     ║
                                                                                      ║
                                                                                      ║
");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            EndLine();
            Thread.Sleep(1000);
            Console.Clear();

            Intro();
            Console.WriteLine("Nové kolo za:");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.WriteLine(@"
                                                                                      ║
 ██╗                                                                                  ║
███║                                                                                  ║
╚██║                                                                                  ║
 ██║                                                                                  ║
 ██║██╗██╗██╗                                                                         ║
 ╚═╝╚═╝╚═╝╚═╝                                                                         ║
                                                                                      ║
                                                                                      ║
");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            EndLine();
            Thread.Sleep(1000);
            Console.Clear();

            Intro();
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.WriteLine(@"
                                                                                      ║
███████╗████████╗ █████╗ ██████╗ ████████╗                                            ║
██╔════╝╚══██╔══╝██╔══██╗██╔══██╗╚══██╔══╝                                            ║
███████╗   ██║   ███████║██████╔╝   ██║                                               ║
╚════██║   ██║   ██╔══██║██╔══██╗   ██║                                               ║
███████║   ██║   ██║  ██║██║  ██║   ██║                                               ║
╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝                                               ║
                                                                                      ║
                                                                                      ║
");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            EndLine();
            Thread.Sleep(1000);
            Console.Clear();
            Console.CursorVisible = true;
        } //nové kolo odpočet

        public void _1v1Draw() 
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.WriteLine("Remíza.");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        }//remíza

        public void _1v1Lose(IEnemy enemy) 
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.WriteLine(enemy.Name + " vyhral.");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            //Console.SetCursorPosition(0, Console.CursorTop - 1);
            //Line();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        }//hráč prehral

        public void _1v1Win(ICharacter usedCh) 
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Line();
            Console.WriteLine(usedCh.Name + " vyhral.");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            //Console.SetCursorPosition(0, Console.CursorTop - 1);
            //Line();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            EndLine();
        }//hráč vyhral


        //============== End ==================================================

        public void End()
        {
            Console.WriteLine("1. Play again");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            Console.WriteLine("2. Exit");
            Console.SetCursorPosition(86, Console.CursorTop - 1);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop + 1);
        }


        //======================================================================
    }
}
