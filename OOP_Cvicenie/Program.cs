using OOP_Cvicenie;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Vehicle kiaCeed = new Vehicle();// pekne auticko
            kiaCeed.EvidencneCisloAuta = "ZA 016 IT";// hasic kupko
            kiaCeed.RokVyroby = 2020; //dufam
            kiaCeed.JePlatnaSTK = true;// hadam hej
            kiaCeed.Spoteba = 5.2; // typ
            kiaCeed.TypMotora = "Benzin";// googlil som

            Vehicle citroenGagarin = new Vehicle("00IMJK2" , 2024 , true, 0.5 , "Lietadlovy ");

            Console.WriteLine("Info o nasom aute v KRATKOM vypise "  + kiaCeed.VypisAuta(false));
            Console.WriteLine("Info o kubkovom aute v DLHOM vypise " + kiaCeed.VypisAuta(true));

            List<Vehicle> list = new List<Vehicle>();
            list.Add(kiaCeed);
            list.Add(citroenGagarin);

            foreach (Vehicle vehicle in list)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}
