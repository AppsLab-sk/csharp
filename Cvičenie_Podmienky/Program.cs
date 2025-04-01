// See https://aka.ms/new-console-template for more information


using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadajte prve cislo");
            double number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Zadajte znak pre matematicku operaciu:");
            string operation = Console.ReadLine();
            Console.WriteLine("Zadajte druhe cislo");
            double number2 = Double.Parse(Console.ReadLine());
            string operation2 = Console.ReadLine();
            /*double numbera1 = 10;
            double numbera2 = 5;

             if (operation == "+")
             {
                 Console.WriteLine(number1 + number2);
             }
             else if (operation == "-")
             {
                 Console.Write(number1 - number2);
             }
             else if (operation == "*")
             {
                 Console.WriteLine(number1 * number2);
             }
             else if (operation == "/")
             {
                 Console.WriteLine(number1 / number2);
             }
         }
     }
 }*/

            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        Console.WriteLine(number1 / number2);
                    }
                    else
                    {
                        Console.WriteLine("Nedá sa deliť nulou.");
                    }
                    Console.WriteLine(number1 / number2);
                    break;
                case "*" :
                    Console.WriteLine(number1 * number2);
                    break;
                default:
                    Console.WriteLine("Neplatná operácia !");
                    break;
            }
        }
    }
}