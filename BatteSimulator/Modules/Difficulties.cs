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
            
            Console.SetCursorPosition(86, Console.CursorTop);
            Console.WriteLine("║");
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            

            Console.Write("Choose difficulty: ");

            for (int i = 0; i < diffs.Count; i++)
            {
                Console.SetCursorPosition(86, Console.CursorTop);
                Console.WriteLine("║");
                Console.SetCursorPosition(0, Console.CursorTop);

                Console.Write($"{i + 1}. {diffs[i]}");

                Console.SetCursorPosition(86, Console.CursorTop);
                Console.Write("║");
                Console.SetCursorPosition(0, Console.CursorTop);
            }

            Console.SetCursorPosition(0, Console.CursorTop + 2);
            print.EndLine();
            Console.SetCursorPosition(86, Console.CursorTop - 2);
            Console.Write("║");
            Console.SetCursorPosition(0, Console.CursorTop);

            int action = int.Parse(Console.ReadLine());

            if (action == 1) { diff = 1; }
            if (action == 2) { diff = 1.5; }
            if (action == 3) { diff = 2; } 
            if (action == 4){ diff = 4;}
            if (action == 5)
            {
                Console.Clear();
                print.Intro();

                Console.SetCursorPosition(86, Console.CursorTop);
                Console.WriteLine("║");
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Console.WriteLine("Set custom difficulty: ");

                Console.SetCursorPosition(0, Console.CursorTop + 1);
                print.EndLine();
                Console.SetCursorPosition(86, Console.CursorTop - 2);
                Console.Write("║");
                Console.SetCursorPosition(0, Console.CursorTop);

                diff = int.Parse(Console.ReadLine());
            }
            
            Console.Clear();
            print.Intro();

            return diff;
            
        }
    }
}
