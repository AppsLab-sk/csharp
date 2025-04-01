// See https://aka.ms/new-console-template for more information


using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = new int[5];

            //10 15 20 25 45
            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 20;
            numbers[3] = 25;
            numbers[4] = 45;

            Console.WriteLine(numbers[2] + numbers[4]);

            List<int> listNumbers = new List<int>();

            listNumbers.Add(10);
            listNumbers.Add(15);
            listNumbers.Add(20);
            listNumbers.Add(25);
            listNumbers.Add(45);

            listNumbers[1] = 10000;

            Console.WriteLine(listNumbers[1] + listNumbers[3]);

        List<string> listnames = new List<string>();

        listnames.Add("Martin ");
        listnames.Add("Leo ");
        listnames.Add("Matus ");
        listnames.Add("Peter ");
        listnames.Add("Rastislav");
             
            Console.WriteLine(listnames[0]+"\n"+listnames[1]+"\n"+listnames[2]+"\n"+listnames[3]+"\n"+listnames[4]);

            listnames.Remove("Peter");
            Console.WriteLine(listnames[3]);
        }
    }
}

