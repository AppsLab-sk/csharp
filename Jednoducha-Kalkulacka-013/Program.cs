using System;
using System.ComponentModel.Design;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Zadajte znak pre matematicku operaciu:");
            string? operation = Console.ReadLine();
            Console.WriteLine("Zadajte prve cislo:");
            string? number1 = Console.ReadLine();
            Console.WriteLine("Zadajte druhe cislo:");
            string? number2 = Console.ReadLine();

            double number1final = Double.Parse(number1);
            double number2final = Double.Parse(number2);


            if (operation == "+")
            {
                Console.WriteLine(number1final + number2final);
            }
            else if (operation == "-")
            {
                Console.WriteLine(number1final - number2final);
            }
            else if (operation == "*")
            {
                Console.WriteLine(number1final * number2final);
            }
            else if (operation == "/")
            {
                Console.WriteLine(number1final / number2final);
            }
            else
            {
                Console.WriteLine("Nespravny znak operacie!");
            }*/

            Console.WriteLine("Zadajte znak pre matematicku operaciu:");
            string? operation = Console.ReadLine();
            Console.WriteLine("Zadajte prve cislo:");
            string? number1 = Console.ReadLine();
            Console.WriteLine("Zadajte druhe cislo:");
            string? number2 = Console.ReadLine();
            Console.WriteLine("Vysledok:");

            double number1final = Double.Parse(number1);
            double number2final = Double.Parse(number2);

            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1final + number2final);
                    break;
                case "-":
                    Console.WriteLine(number1final - number2final);
                    break;
                case "*":
                    Console.WriteLine(number1final * number2final);
                    break;
                case "/":
                    if (number2final == 0)
                    {
                        Console.WriteLine("Nulou sa neda delit!");
                    }
                    else
                    {
                        Console.WriteLine(number1final / number1final);
                    }    
                    break;
                default:
                    Console.WriteLine("Neznamy operator");
                    break;
            }
        }
    }
}