using BatteSimulator.functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class Levels
    {
        List<string> pList = new List<string>();

        public void SetPlayer()
        {
            if (pList.Count == 0)
            {
                NewPlayer();
            }
            else
            {
                Console.WriteLine("Choose player:"); 
                for (int i = 0; i < pList.Count; i++) 
                {
                    Console.WriteLine($"{i + 1}. {pList[i]}");
                }

                int action = int.Parse(Console.ReadLine());

                int pIndex = action - 1;

                var player = pList[pIndex];
            }
        }
        public string NewPlayer()
        {
            var print = new Print();

            Console.WriteLine("Set your player name:");

            print.Input();
            string action = Console.ReadLine();

            return "";
        }
    }
}
