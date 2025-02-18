
using System;
using System.ComponentModel.Design;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Zadajte znak pre matematicku operaciu");
            string operation = Console.ReadLine();
            Console.WriteLine("Zadajte prve cislo");
            string number1 = Console.ReadLine();
            Console.WriteLine("Zadajte druhe cislo");
            string number2 = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;

                case "-":
                    Console.WriteLine(number1 - number2);
                    break;

                case "*":
                    Console.WriteLine(number1 * number2);
                    break;

                case "/":
                    Console.WriteLine(number1 / number2);
                    break;

                default:
                    Console.WriteLine(number1 + number2);
                    break;
            }

            /*if (operation == "+")
            {
                Console.WriteLine(number1 + number2);
            }

            else if (operation == "-")
            {
                Console.WriteLine(number1 - number2);
            }

            else if (operation == "*")
            {
                Console.WriteLine(number1 * number2);
            }

            else if (operation == "/")
            {
                Console.WriteLine(number1 / number2);
            }

            else if (operation == "%")
            {
                Console.WriteLine(number1 % number2);
            }
            else
            {
                Console.WriteLine("Nesprávny operator")`
            }*/
        }
    }
}


