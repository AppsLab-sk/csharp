using Cvicenie_OOP;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle kiaCeed = new Vehicle(); //No nova neni urcite
            kiaCeed.EvidencneCisloAuta = "ZA016IT"; //Hasic Kubko
            kiaCeed.RokVyroby = 1897; //Stary si
            kiaCeed.JePlatnaSTK = true; //Ale hadam hej
            kiaCeed.Spotreba = -0.78954; //Pri ceste dole kopcom, vytvara benzin
            kiaCeed.TypMotoru = 'T'; //Trolejovo Napajana        

            Vehicle citroenGagarin = new Vehicle("00IMJK2", 2024, true, 0.5, 'L');
            Vehicle bugatiJakobs = new Vehicle("ZA587JT", 2022, true, 19.5, 'D');

            Console.WriteLine("Info o mojom aute: " + kiaCeed.VypisAuta(true));
            Console.WriteLine("Info o mojom aute: " + kiaCeed.VypisAuta(false));

            List<Vehicle> list = new List<Vehicle>();
            list.Add(kiaCeed);
            list.Add(citroenGagarin);
            list.Add(bugatiJakobs);

            foreach (Vehicle vehicle in list)
            {
                Console.WriteLine(vehicle.VypisAuta(true));
            }

        }
    }
}