using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> menaList = new List<string>();

            Console.WriteLine("Mena v zozname:");
            Console.WriteLine("");
            Console.WriteLine("Zadaj meno:");

            while (true)
            {           
                string meno = Console.ReadLine() ?? "0";

                if (meno == "Quit") 
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Mena v zozname:");
                    menaList.Add(meno);
                    foreach (string mena in menaList)
                    {
                        Console.WriteLine(mena);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Zadaj meno:");

                }

            }
        }
    }
}