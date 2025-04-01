using System;
using System.ComponentModel.Design;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Cvicenie

            /* string meno = ("Martin");
             int vek = 15;
             bool programator = true;
             double vyska = 175;

             Console.WriteLine("meno:" + " " + meno);
             Console.WriteLine("vek:" + " " + vek);
             Console.WriteLine("Je programator:" + " " + programator);
             Console.WriteLine("vyska:" + " " + vyska);

            // 2. Cvicenie

            Console.WriteLine("Zadaj svoj vek !");
            int vek = int.Parse(Console.ReadLine());

            if (vek >= 18)
            {
                Console.WriteLine("Ste dospely.");
            }
            else
            {
                Console.WriteLine("Ste neplnolety.");*/

            // 3. Cvicenie

            Random rnd = new Random();
            int vygenerovaneCislo = rnd.Next(maxValue: 100); 
            int pokus = 0;
            int tip = 0;
            int maxPokusov = 10;

            Console.WriteLine("Uhadni cislo od 1 do 100!");

            while (tip != vygenerovaneCislo)
            {
                Console.WriteLine("Zadaj svoj tip:");
                tip = int.Parse(Console.ReadLine()); 
                pokus++;

                if (tip < vygenerovaneCislo)
                {
                    Console.WriteLine("Tvoj tip je prilis maly.");
                }
                else if (tip > vygenerovaneCislo)
                {
                    Console.WriteLine("Tvoj tip je prilis velky.");                                  
                }
                else
                {
                    Console.WriteLine("Gratulujem! Uhadol si spravne císlo.");
                    Console.WriteLine("Pocet pokusov: " + pokus);
                    {
                    }
                }
            }
        }
    }
}

