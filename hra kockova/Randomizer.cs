using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uhadni
{
    internal class Randomizer
    {

        private int MaxNumber;
        private Random Rnd;

        public Randomizer(int maxNumber)
        {
            Rnd = new Random();
            MaxNumber = maxNumber;
        }
        public int Random()

        {
            Random rnd = new Random();
            int nextNumber = rnd.Next(MaxNumber);
            return nextNumber;
        }
    }
}
