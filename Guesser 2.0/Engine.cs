using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_2._0
{
    internal class Engine
    {


        public void Do(int randomNumber)
        {
            string userInput;
            int guess = 0;
            Console.WriteLine("The number:");

            try 
            {
                 userInput = Console.ReadLine();
                 guess = Convert.ToInt32(userInput);
            }
           catch
            {
                Console.WriteLine("a number");
            }
           

            while (guess != randomNumber) 
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Try smaller");
                }
                else
                {
                    Console.WriteLine("Try bigger");
                }
                userInput = Console.ReadLine();
                guess = Convert.ToInt32(userInput);
            }
        }
    }
}
