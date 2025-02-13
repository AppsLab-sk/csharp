using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadajte znak pre matematicku operaciu:");
            string operation = Console.ReadLine();
            Console.WriteLine("Zadaj prve cislo:");
            string number1 = Console.ReadLine();
            Console.WriteLine("Zadaj druhe cislo:");
            string number2 = Console.ReadLine();

            double number1final = Double.Parse(number1);
            double number2final = Double.Parse(number2);

            /* if (operation == "+")
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
                 Console.WriteLine("Nespravne zadany operator!!!");
             }*/

            Console.WriteLine("Chybne zadane udaje!");

            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1final + number2final);
                    break;
                case "-":
                    Console.WriteLine(number1final + number2final);
                    break;
                case "*":
                    Console.WriteLine(number1final + number2final);
                    break;
                case "/":
                    if (number2final == 0)
                    {
                        Console.WriteLine("Neda sa delit nulou!");
                    }
                    else
                    {
                        Console.WriteLine(number1final / number2final);
                    }
                    break;          
            }
        }
    }
}

