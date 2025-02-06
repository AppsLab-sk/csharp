using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] numbers = new int[5];

              //15 15 20 25 45
              numbers[0] = 10;
              numbers[1] = 15;
              numbers[2] = 20;
              numbers[3] = 25;
              numbers[4] = 45;

             //Console.WriteLine(numbers[2]);
             Console.WriteLine(numbers[2] + numbers[4]);

             numbers[4] = 10;
             Console.WriteLine(numbers[2] + numbers[4]);



             List<int> listnumbers = new List<int>();

                 listnumbers.Add(10);
                 listnumbers.Add(15);
                 listnumbers.Add(20);
                 listnumbers.Add(25);
                 listnumbers.Add(45);

             listnumbers[1] = 10000;

             Console.WriteLine(listnumbers[1] + listnumbers[2]); */



            List<string> listnames = new List<string>();

            listnames.Add("Jozo");
            listnames.Add("Fero");
            listnames.Add("Andrej");
            listnames.Add("Martin");
            listnames.Add("Jakub");
            listnames.Add("Karol");

            Console.WriteLine(listnames[0] + "\n" + listnames[1] + "\n" + listnames[2] + "\n" + listnames[3] + "\n" + listnames[4] + "\n" + listnames[5]);


            listnames.Remove("Jakub");
            Console.WriteLine(listnames[4]);

           




        }
    }
}