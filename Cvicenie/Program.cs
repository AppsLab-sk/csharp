using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)    
        {
            Console.WriteLine("Zadaj text:");
            string text = Console.ReadLine();

            int pocetsamohlasok = PocetSamohlasok(text);

            if (pocetsamohlasok <= 4)
                Console.WriteLine("Text obsahuje " + pocetsamohlasok + " samohlásky.");
            else
                Console.WriteLine("Text obsahuje " + pocetsamohlasok + " samohlások.");
        }
        static int PocetSamohlasok(string text)
        {
            char[] samohlasky = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int pocet = 0;

            foreach (char pismeno in text)
            {
                if (Array.Exists(samohlasky, samohlaska => samohlaska == pismeno))
                {
                    pocet++;
                }
            }
            return pocet;
        }
    }
}