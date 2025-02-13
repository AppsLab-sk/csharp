using System;

namespace MyApp
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int pokusy = 1; 
            Random rnd = new Random();
            int vygenerovaneCislo = rnd.Next(maxValue: 100);

            bool Game = true;

            while (Game == true) 
            {
                Console.WriteLine("Pokusy:" + pokusy);
                Console.WriteLine("Uhadni cislo:");
                string hadaneCislo = Console.ReadLine() ?? "0";
                int hadaneCisloint = int.Parse(hadaneCislo);

                if (hadaneCisloint == vygenerovaneCislo)
                {
                    Game = false;
                    Console.WriteLine("Vyhrali ste!");
                    pokusy++;
                }
                else if (hadaneCisloint > vygenerovaneCislo)
                {
                    Console.WriteLine("Vygenerovane cislo je mensie!");
                    pokusy++;
                }
                else if (hadaneCisloint < vygenerovaneCislo)
                {
                    Console.WriteLine("Vygenerovane cislo je vacsie!");
                    pokusy++;
                }
            }
        }
    }
}