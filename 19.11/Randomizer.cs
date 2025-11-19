using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generator
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

            int nextNumber = Rnd.Next(MaxNumber);
            return nextNumber;
        }
    }
}
