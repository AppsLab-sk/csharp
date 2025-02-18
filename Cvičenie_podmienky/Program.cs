// See https://aka.ms/new-console-template for more information


using System;
using System.Data.Common;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadaj znak pre matematicku operaciu");
            string operation = Console.ReadLine();
            double number1 = 10;
            double number2 = 5;


            switch (operation)
            { 
                case "+":
                    Console.WriteLine(number1 + number2); //15
                    break;
                case "-":
                    Console.WriteLine(number1 - number2); //5
                    break;
                case "*":
                    Console.WriteLine(number1 * number2); //50
                    break;
                case "/":
                    Console.WriteLine(number1 / number2); //2
                    break;


                default:
                    Console.WriteLine("nespravna operacia");
                    break;


            }
        }




        }

    }
