using Cvicenie_OOP;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            weachile skoda = new weachile();
            skoda.JeplatnaSTK = (true);
            skoda.Cislovozidla = ("ZA789JP");
            skoda.Spotreba = (4.5);
            skoda.Typmotoru = ('D');
            skoda.Prejdenekilometre = (7890);

            Console.WriteLine("Je platna stk " + skoda.JeplatnaSTK + ". EVC vozidla je " + skoda.Cislovozidla);
            Console.WriteLine("Priemerna spoteba je " + skoda.Spotreba + ". Typ motoru je " + skoda.Typmotoru + ". Ma najazdene " + skoda.Prejdenekilometre);





        }
    }
}