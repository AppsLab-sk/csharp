using cvicenie_22._10;
using System;
using System.Net.NetworkInformation;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj dlzku");
            int sirka = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Zadaj vysku");
            int vyska = Int32.Parse(Console.ReadLine());
            
            obdlznik o = new obdlznik(sirka, vyska);
            int obsah = o.Obsah();
            Console.WriteLine("Obsah obdlznika je " + obsah);

            /*obdlznik ob = new obdlznik(sirka * 10,vyska * 10);
            int obsah2 = ob.Obsah();
            Console.WriteLine(obsah2);*/

            int doprava = o.sirka;
            int hore = o.dlzka;
            obdlznik ob = new obdlznik(doprava * 10, hore * 10);
            int obsah2 = ob.Obsah();
            Console.WriteLine("Obsah obdlznika je " + obsah2);

            
        }
    }
}