using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Hladanie_čísla
{
    internal class Engine
    {
        public void Do(int randomNumber)
        {
            Console.WriteLine("Zadaj tvoj tip:");
            string userIntput = Console.ReadLine();
            int guess = Convert.ToInt32(userIntput);


            while (guess != randomNumber)
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Skús menšie...");
                }
                else
                {
                    Console.WriteLine("Skús väčšie...");
                }

                userIntput = Console.ReadLine();
                guess = Convert.ToInt32(userIntput);
            }
        }
    }
}
