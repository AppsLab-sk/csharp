using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetSamohlasok = 0;

            Console.Write("Napiste text: ");
            string text = Console.ReadLine() ?? "0";

            int length = SpocitajPismena(text);

            Char[] samohlasky = text.ToCharArray();                    

            foreach(char c in samohlasky)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    pocetSamohlasok++;
                }
            }

            Console.WriteLine("Text je dlhy " + text.Length + " znakov.");
            Console.WriteLine("Text obsahuje " + pocetSamohlasok + " samohlasok.");


        }

        public static int SpocitajPismena(string text)
        {
            return text.Length;
        }

       //DU: NECH SPOCITA SAMOHLASKY AJ, ROZISOVAT MALE A VELKE PISMENA> a,e,i,o,u / A,E,I,O,U;
    }
}