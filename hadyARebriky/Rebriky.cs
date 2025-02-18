using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    public class Rebrik
    {
        public int Start { get; set; } // zaciatocna pozicia napr. 10
        public int End { get; set; }  // koncova pozicia napr. 15

        public Rebrik(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Skontroluj (int pozicia)
        {
            if (pozicia == Start)
            {
                Console.WriteLine ($"Super prešiel si z polička {Start} na {End} pomocou rebríku");
                return End;
            }
            return pozicia;

        }
    }
}
