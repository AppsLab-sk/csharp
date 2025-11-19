using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generator
{
    internal class Engine
    {
        public void Do(int randomNumber)
        {
            Console.WriteLine("Zadaj tvoj tip");
            string userInput = Console.ReadLine();
            int guess = Convert.ToInt32(userInput);

            while (guess != randomNumber)
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Skus mensie.");
                }
                else
                {
                    Console.WriteLine("Skus vacsie.");
                }
                userInput = Console.ReadLine();
                guess = Convert.ToInt32(userInput);
            }
            Console.WriteLine("Gratulujem Uhadol si");
        }
    }
}
