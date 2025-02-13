using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadajte znak pre matematicku operaciu");
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
                Console.WriteLine(number1 * number2);
            }
            else if (operation == "/")
            {
                Console.WriteLine(number1 / number2);

            }






        }




    }

} 









