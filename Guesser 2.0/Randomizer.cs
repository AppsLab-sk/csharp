using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser_2._0
{
    internal class Randomizer
    {
        public Randomizer()
        {
            //idk man
        }
        private int MaxNumber;
        private Random Rnd;

        public Randomizer(int maxNumber)
        {
            MaxNumber = maxNumber;
            Rnd = new Random();
        }


        public int Random()
        { 
            Random rnd = new Random();
            int nextNumber = rnd.Next(MaxNumber);

            return nextNumber;
        }
    }
    
}


//alt + šipka hore, ctrl + alt