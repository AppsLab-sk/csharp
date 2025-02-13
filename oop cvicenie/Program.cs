using oop_cvicenie;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle skodaFabia = new Vehicle();
            skodaFabia.EvidencneCisloAuta = "ZA254HI";
            skodaFabia.RokVyroby = 2003;
            skodaFabia.JePlatnaSTK = true;
            skodaFabia.PriemernaSpotreba = 7.5;
            skodaFabia.TypMotoru = 'D';


            Vehicle elonTesla = new Vehicle();
            
            skodaFabia.EvidencneCisloAuta = "ZA123EE";
            skodaFabia.RokVyroby = 2020;
            skodaFabia.JePlatnaSTK = true;
            skodaFabia.PriemernaSpotreba = 7.5;
            skodaFabia.TypMotoru = 'E';

            Vehicle toyotaCorolla = new Vehicle("BA99EE", 210, false, 9.9, 'B');

             
            Console.WriteLine("Info o mojom aute:" + skodaFabia.EvidencneCisloAuta);
            Console.WriteLine("Info o mojom aute v KRATKOM vypise:" + skodaFabia.VypisAuta(false));
            Console.WriteLine("Info o mojom aute v DLHOM vypise:" + skodaFabia.VypisAuta(true));
            
            List<Vehicle> list = new List<Vehicle>();
            List.Add(skodaFabia);
            List.Add(elonTesla);
            List.Add






        }
    }
}













