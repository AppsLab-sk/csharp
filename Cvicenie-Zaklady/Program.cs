using System;
using System.Data;

/*namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napis text:");
            string text = Console.ReadLine();

            int length = SpocitajPismena(text);

            Console.WriteLine("Text je dlhy: " + text.Length + " pismen");

        }
            public static int SpocitajPismena(string text)
            {
               return text.Length;
            }
        //DU: spocita samohlasky aj rozlisovat male a velke pismena
        }
    }*/
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetSamohlasok = 0;

            Console.WriteLine("Napis text:");
            string text = Console.ReadLine() ?? "0";

            int length = SpocitajPismena(text);

            Char[] samohlasky = text.ToCharArray();

            foreach (char c in samohlasky)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                   pocetSamohlasok++;
                }
            }



            Console.WriteLine("Text je dlhy: " + text.Length + " pismen");
            Console.WriteLine("Text obsahuje " + pocetSamohlasok + " samohlasok");
        }


        public static int SpocitajPismena(string text)
        {
            return text.Length;
        }
    }
}