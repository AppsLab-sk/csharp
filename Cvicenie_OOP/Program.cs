using Cvicenie_OOP;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle skodaFabia = new Vehicle();
            skodaFabia.EvidencneCisloAuta = "ZA 016 IT";
            skodaFabia.RokVyroby = 2020;
            skodaFabia.JePlatnaSTK = true;
            skodaFabia.PriemernaSpotreba = 7.2;
            skodaFabia.TypMotoru = 'D';

            Vehicle elonTesla = new Vehicle()
            {
                EvidencneCisloAuta = "Za00IM5",
                RokVyroby = 2020,
                JePlatnaSTK = true,
                PriemernaSpotreba = 3,
                TypMotoru = 'D'
            };

            Vehicle toyotaCorala = new Vehicle("00IMJK2", 2024, false, 0.5, 'D');

            Console.WriteLine("Info o mojom aute v KRATKOM vypise:" + skodaFabia.VypisAuta(false));
            Console.WriteLine("Info o mojom aute v DLHOM vypise:" + skodaFabia.VypisAuta(true));

            List<Vehicle> list = new List<Vehicle>();
            list.Add(skodaFabia);
            list.Add(toyotaCorala);            

            foreach (Vehicle v in list)
            {
                Console.WriteLine(v.ToString());
            }                
        }
    }
}