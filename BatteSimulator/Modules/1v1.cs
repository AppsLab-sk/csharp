using BatteSimulator.functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class _1v1 : IGameMode
    {
        public string Name {  get; set; }
        public _1v1(string name) { Name = name; }

        public void Execute(ICharacter usedCh, IEnemy enemy)
        {
            var print = new Print();
            Console.Clear();
            print.Intro();
            
            while (usedCh.Health > 0 && enemy.Health > 0) //pokiaľ sú všetci nažive
            {
                //print.Stats(usedCh, enemy);
                print._1v1Choose();// \n1 = Útok \n2 = Uzdraviť (počet: {usedCh.HealAmount})");
                
                ICharacter chInstance = usedCh;
                Type chType = chInstance.GetType();
                MethodInfo[] chMethods = chType.GetMethods();
                int j = 1; 
                for (int i = 0; i < chMethods.Length; i++) 
                {
                    if (!chMethods[i].Name.StartsWith("set_") && chMethods[i].ReturnType == typeof(void)) //vypíše schopnosť
                    {
                        print._1v1List(i, j, chMethods);

                        j = j + 1;
                    }
                }

                print.Input();

                int action = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(0, Console.CursorTop + 1);

                if (action == 1) //útok
                {
                    usedCh.Attack(enemy);
                    print._1v1ChAttack(usedCh, enemy);
                }
                if (action == 2) //uzdravenie
                {
                    if (usedCh.HealAmount > 0) //ak je čím, uzdraviť
                    {
                        usedCh.HealAmount = Math.Max(0, usedCh.HealAmount - 1);
                        usedCh.Heal();
                        print._1v1ChHeal(usedCh);
                    }
                    else //ak nie je čím, útok
                    {
                        print._1v1ChNoHeal(usedCh);
                        usedCh.Attack(enemy);
                        print._1v1ChAttack(usedCh, enemy);
                    }
                }

                if (enemy.Health > 0) //ak je nepriateľ naživu, tak sa pokračuje
                {
                    if (enemy.Health <= usedCh.AttackPower) //ak má nepriateľ menej životov ako bojovník, skúsi sa uzdraviť
                    {
                        if (enemy.HealAmount > 0) //ak sa má čím nepriateľ uzdraviť
                        {
                            enemy.HealAmount = Math.Max(0, enemy.HealAmount - 1);
                            enemy.Heal();
                            print._1v1EHeal(enemy);
                        }
                        else //ak nie, zaútoč
                        {
                            enemy.Attack(usedCh);
                            print._1v1EnemyAttack(usedCh, enemy);
                        }
                    }
                    else //ak má dostatok životov, zaútočí
                    {
                        enemy.Attack(usedCh);
                        print._1v1EnemyAttack(usedCh, enemy);
                    }
                }
                print._1v1Stats(usedCh, enemy);

                if (usedCh.Health > 0 && enemy.Health > 0) //pokiaľ sú obydvaja naživu, ide nové kolo
                {
                    print._1v1Continue();
                    Console.ReadKey(true);
                    Console.Clear();
                    print.Intro();
                    print._1v1NewRound();
                    print.Intro();
                }
            }
            if (usedCh.Health == 0 && enemy.Health == 0) //remíza
            {
                Thread.Sleep(2000);
                Console.Clear();
                print.Intro();
                print._1v1Stats(usedCh, enemy);
                print._1v1Draw();
                print._1v1Continue();
                Console.ReadKey(true);
            }
            if (usedCh.Health <= 0 && enemy.Health > 0) //nepriateľ vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                print.Intro();
                print._1v1Stats(usedCh, enemy);
                print._1v1Lose(enemy);
                print._1v1Continue();
                Console.ReadKey(true);
            }
            if (enemy.Health <= 0 && usedCh.Health > 0) //hráč vyhral
            {
                Thread.Sleep(2000);
                Console.Clear();
                print.Intro();
                print._1v1Stats(usedCh, enemy);
                print._1v1Win(usedCh);
                print._1v1Continue();
                Console.ReadKey(true);
            }
        }
    }
}
