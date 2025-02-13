using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[5];
            // 10 15 20 25 45
            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 20;
            numbers[3] = 25;
            numbers[4] = 45;

            Console.WriteLine(numbers[2]+numbers[4]);

            numbers[0] = 0;

            Console.WriteLine(numbers[2] + numbers[4]);*/


            

            List<string> listnames = new List<string>();

            listnames.Add("Jan");
            listnames.Add("Jakub");
            listnames.Add("Michal");
            listnames.Add("Fero");
            listnames.Add("Martin");
            listnames.Add("Peter");


           

            Console.WriteLine(listnames[0]);
            Console.WriteLine(listnames[1]);
            Console.WriteLine(listnames[2]);
            Console.WriteLine(listnames[3]);
            Console.WriteLine(listnames[4]);
            Console.WriteLine(listnames[5]);
        }
    }
}