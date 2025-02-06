using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            List<string> listmien = new List<string>();
            while (true)
            {
                Console.WriteLine("\nZadaj meno");
                var meno = Console.ReadLine();
                Console.Clear();
                if (meno == "exit")
                {
                    break;
                }
                else
                {
                    listmien.Add(meno);
                }

                Console.WriteLine("Zoznam mien\n");
                foreach (var meno2 in listmien)
                {
                   Console.WriteLine(meno2);
                }
            }
           
        }
    }
}
