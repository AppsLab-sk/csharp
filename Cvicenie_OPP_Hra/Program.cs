using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Cvicenie_OPP_Hra
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //vupis hraca
            Hra kladnapostava = new Hra() { PlayerName = "Tommy", Power = 45, HP = 1000, Mana = 50, Critchanges = 25 };
            Hra zapornapostava = new Hra() { PlayerName = "Joel", Power = 45, HP = 1000, Mana = 50, Critchanges = 25 };

            Console.WriteLine("Zaporna postava HP:" + zapornapostava.HP);
            Console.WriteLine("Kladna postava HP:" + kladnapostava.HP);
            kladnapostava.Damage(zapornapostava);
            zapornapostava.Damage(kladnapostava);

            //boj
            while (true)
            {
                Console.WriteLine("Tommy :" + kladnapostava.HP);
                Console.WriteLine("Joel :" + zapornapostava.HP);
                kladnapostava.Damage(zapornapostava);
                zapornapostava.Damage(kladnapostava);
               

                if (kladnapostava.HP <= 20)
                {
                    bool bolauzsravena = kladnapostava.Heal();
                    if (bolauzsravena)
                    {
                        Console.WriteLine(kladnapostava + " bola uzdravena");
                    }
                    else
                    {
                        Console.WriteLine(kladnapostava + " nema manu a nebola uzdravena");
                    }
                }
                if (zapornapostava.HP <= 20)
                {
                    bool bolauzsravena = zapornapostava.Heal();
                    if (bolauzsravena)
                    {
                        Console.WriteLine( zapornapostava + " bola uzdravena");
                    }
                    else
                    {
                        Console.WriteLine( zapornapostava + " nema manu a nebola uzdravena");
                    }
                }

                
                Random rnd = new Random();
                int randomnuberjedna  = rnd.Next(0, 100);
                

                if (randomnuberjedna <= 5)
                {
                    kladnapostava.Refilmana(10);
                   
                    Console.WriteLine("Kladnej postave sa doplnila mana");                          
                }

                int randomnubertri = rnd.Next(0, 100);
                if (randomnubertri <= 5) 
                {
                    zapornapostava.Refilmana(10);

                    Console.WriteLine("Zaporna postave sa doplnila mana");
                }

                  // vypis vyhercu
                if (kladnapostava.HP < 0)
                {
                    Console.WriteLine("Joel wins !");
                    break;
                }
                if (zapornapostava.HP < 0)

                {
                    Console.WriteLine("Tommy wins !");
                    break;
                }
            }
        }
    }
}