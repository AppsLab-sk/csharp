using System;

namespace MyApp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> menaList = new List<string>();
            Console.WriteLine("Vsetky mena v zozname:");

            Console.WriteLine("Zadaj meno:");

            while (true)
            {
                string Meno = Console.ReadLine();
                if (Meno == "Quit")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Mena v zozname:");
                    menaList.Add(Meno);
                    foreach(string mena  in menaList)
                    {
                        Console.WriteLine(mena);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Zadajte meno:");
                }
            }
        }
    }
}
