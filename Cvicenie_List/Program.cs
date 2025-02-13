using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {           /* int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 20;
            numbers[3] = 25;
            numbers[4] = 45;

            Console.WriteLine(numbers[2] + numbers[4]);

            numbers[4] = 10;

            Console.WriteLine(numbers[2] + numbers[4]);

            List<int> listNumbers = new List<int>();

            listNumbers.Add(10);
            listNumbers.Add(15);
            listNumbers.Add(20);
            listNumbers.Add(25);
            listNumbers.Add(45);

            listNumbers[1] = 1000000; */

            List<string> listMena = new List<string>();

            listMena.Add("Matus");
            listMena.Add("Jakub");
            listMena.Add("Marek");
            listMena.Add("Juraj");
            listMena.Add("Mato");
            listMena.Add("Jano");

            Console.WriteLine(listMena[0]);
            Console.WriteLine(listMena[1]);
            Console.WriteLine(listMena[2]);
            Console.WriteLine(listMena[3]);
            Console.WriteLine(listMena[4]);
            Console.WriteLine(listMena[5]);
        }
    }
}

