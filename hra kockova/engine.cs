using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace uhadni
{
    internal class Engine
    {
        private int ReadUserInput()
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int value))
                {
                    return value;
                }
                Console.WriteLine("Nevieš čo je číslo???"); 
            }
        }

        public void Do(int randomNumber)
        {
            Console.WriteLine("Zadaj tvoj tip");

            int guess = ReadUserInput();

            while (guess != randomNumber)
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Skús menšie");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Skús väčšie");
                }
                guess = ReadUserInput();
            }
            Console.WriteLine("Gratulujem uhadol si");
        }
    }
}
