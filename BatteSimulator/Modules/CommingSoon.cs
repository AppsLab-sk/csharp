using BatteSimulator.functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public class CommingSoon : IGameMode
    {
        public string Name { get; set; }
        public CommingSoon(string name) { Name = name; }

        public void Execute()
        {
            var print = new Print();

            print.Soon();
        }
    }
}
