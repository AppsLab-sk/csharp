using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_pravdepodobnosť
{
    public class student
    {
        public string Name { get; set; }
        public int Ticketcount { get; set; }


        public student(string name, int ticketcount)
        {
            Name = name;
            Ticketcount = ticketcount;
        }
    }
}
