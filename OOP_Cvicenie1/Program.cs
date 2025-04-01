using OOP_Cvicenie1;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle skodaFabia = new Vehicle();
            skodaFabia.EvidencneCisloAuta = " ZA254HI";
            skodaFabia.RokVyroby = 2009;
            skodaFabia.JePlatnaSTK = true;
            skodaFabia.PriemernaSpotreba = 7.5;
            skodaFabia.TypMotoru = 'D';

            Vehicle elonTesla = new Vehicle()
            {
                EvidencneCisloAuta = "ZA253HI",
                RokVyroby = 2020,
                JePlatnaSTK = true,
                PriemernaSpotreba = 3,
                TypMotoru = 'E',
            };

            Vehicle toyotaCorolla = new Vehicle("ZA999BE", 2010, false, 9.9, 'B');


            Console.WriteLine("Info o mojom aute v KRATKOM vypise : " + skodaFabia.VypisAuta(false));
            Console.WriteLine("Info o mojom aute v DLHOM vypise : " + skodaFabia.VypisAuta(true));

            List<Vehicle> list = new List<Vehicle>();
            list.Add(skodaFabia);
            list.Add(elonTesla);
            list.Add(toyotaCorolla);

            foreach(Vehicle vehicle in list)
            {
                Console.WriteLine(vehicle.VypisAuta(true));
            }

        }
    }
}