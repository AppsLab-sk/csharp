using BatteSimulator.functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class _1v1
    {
        public void Execute(Warrior usedCh, Enemy enemy)
        {
            var print = new Print();
            Console.Clear();
            print.Intro();
            Console.WriteLine("You succesfully got there!");
        }

        internal void Execute(Wizzard usedCh, Enemy enemy)
        {
            var print = new Print();
            Console.Clear();
            print.Intro();
            Console.WriteLine("You succesfully got there!");
        }
    }
}
