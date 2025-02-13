
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadajte 1. cislo");
            double number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Zadajte znak pre matematicku operaciu!");
            string operation = Console.ReadLine();
            Console.WriteLine("Zadajte 2. cislo");
            double number2 = Double.Parse(Console.ReadLine());

            /* Console.WriteLine("Zadajte znak pre matematicku operaciu!");
             string operation = Console.ReadLine();
             double number1 = 10;
             double number2 = 5;
            
            if (operation == "+")
            {
                Console.WriteLine(number1 + number2); 
            }
            else if (operation == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (operation == "*")
            {
                Console.WriteLine(number2 * number1); 
            }
            else if (operation == "/")
            {
                Console.WriteLine(number1 / number2);  
            }
            else if (operation != "+ - / *")
             {
                Console.WriteLine("Nespravny znak");*/

            
            
            switch (operation)
            {
                case "+":
                    Console.WriteLine(number2 + number1);
                    break;
                case "-":
                    Console.WriteLine(number2 - number1);
                    break;
                case "*":
                    Console.WriteLine(number2 * number1);
                    break;
                case "/":
                    if (number2 == 0)
                        Console.WriteLine("Nulov sa neda delit");
                    else                                                 
                    Console.WriteLine(number1 / number2);
                        break;
                default:
                    Console.WriteLine("Nespravny znak");
                    break;                       

            }


            

            
                    
                
            
        }
    }
}