using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class Difficulties
    {
        public double SetDiff() 
        {
            double diff = 0; 
            Console.WriteLine("Choose difficulty: \n1 Easy \n2 Medium \n3 Hard \n4 Imposible \n5 Custom");
            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                diff = 1;
            }
            if (action == 2)
            {
                diff = 1.25;
            }
            if (action == 3)
            {
                diff = 1.5;
            }
            if (action == 4)
            {
                diff = 2;
            }
            if (action == 5)
            {
                Console.WriteLine("Set custom difficulty: ");
                diff = double.Parse(Console.ReadLine());
            }

            return diff; 
        }
    }
}
