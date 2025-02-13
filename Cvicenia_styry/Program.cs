using Cvicenia_styry;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadajte 1. cislo");
            int sirka = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Zadajte 2. cislo");
            int dlzka = Int32.Parse(Console.ReadLine());

            // operacia na nasobenie
            Obdlznik re = new Obdlznik(sirka,dlzka);

            int obsah = re.Nasobenie();

            Console.WriteLine("Obsah je " + obsah);

            //int nasobovac = 10;
            int duple = re.Sirka;
            int dupledva = re.Dlzka;
            Obdlznik ro = new Obdlznik(duple * 10, dupledva * 10);
            int obsahdva = ro.Nasobenie();
            Console.WriteLine("10 nasobny obsah je " + obsahdva);



        }
    }
}