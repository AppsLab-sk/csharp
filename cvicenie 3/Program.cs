using System;
using System.Text.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Random rnd = new Random();
            int nahodneCislo = rnd.Next(1, 101);
            int pokus = 0;
            int tip = 0;

            Console.WriteLine("Uhadni cislo od 1 do 100!");

            while (tip != nahodneCislo)
            {
                Console.WriteLine("Zadaj svoj tip:");
                tip = int.Parse(Console.ReadLine());
                pokus++;

                if (tip < nahodneCislo)
                {
                    Console.WriteLine("Tvoj tip je prilis maly.");
                }
                else if (tip > nahodneCislo)
                {
                    Console.WriteLine("Tvoj tip je prilis velky.");
                }

                if (pokus == 11)
                {
                    Console.WriteLine("prehral si");
                    break;
                
                }
                 



                else
                {
                    Console.WriteLine("Gratulujem! Uhadol si spravne císlo.");

                    Console.WriteLine("Pocet pokusov: " + pokus);


                    
                }





















                /* string meno = ("Mato");
                 int vek = 15; 
                 bool programator = true;
                 double vyska = 177;
                 Console.WriteLine("meno:" + " " + meno);
                 Console.WriteLine("vek:" + " " + vek);
                 Console.WriteLine("Je programator:" + " " + programator);
                 Console.WriteLine("vyska:" +" "+ vyska + "cm");*/

                /* Console.WriteLine("Napíš vek:");
                 int vek = int.Parse(Console.ReadLine());

                 if ( vek >= 18)
                 {

                     Console.WriteLine("Si dospely prijaty pristup.");
                 }
                 else
                 {
                     Console.WriteLine("Nie si dospely pristup zamietnuty.");
                 }
             }
         }
                */



























            }
        }
    }
}       
