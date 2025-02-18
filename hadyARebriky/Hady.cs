using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hadyARebriky
{
    
       public class Had
       {
            public int Start { get; set; } // zaciatocna pozicia napr. 20
            public int End { get; set; } // konecna pozicia napr. 12

            public Had(int start, int end)
            {
                Start = start;
                End = end;
            }

            public int Skontroluj (int pozicia)
            {
                if (pozicia == Start)
                {
                    Console.WriteLine($"Oh nie odišiel si z polička {Start} na {End} kvôli hadovi!");
                    return End;
                }
                return pozicia;
            }
        }
    
}
