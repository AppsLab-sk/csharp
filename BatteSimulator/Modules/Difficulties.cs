using BatteSimulator.functions;
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
            var print = new Print();
            Console.Clear();
            print.Intro();

            List<string> diffs = new List<string>()
            {
                "Easy",
                "Medium",
                "Hard",
                "Impossible",
                "Custom"
            };

            print.DfChoose();

            for (int i = 0; i < diffs.Count; i++)
            {
                print.DfList(i, diffs);
            }

            print.Input();

            int action = int.Parse(Console.ReadLine());

            if (action == 1) { diff = 1; }
            if (action == 2) { diff = 1.5; }
            if (action == 3) { diff = 2; } 
            if (action == 4){ diff = 4;}
            if (action == 5)
            {
                print.DfCustom();

                diff = int.Parse(Console.ReadLine());
            }
            
            Console.Clear();
            print.Intro();

            return diff;
            
        }
    }
}
