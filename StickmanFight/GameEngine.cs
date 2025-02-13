using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickmanFight
{
    public class GameEngine
    {
        public GameEngine gameEngine { get; set; }
        public Fighter FirstFighter { get; set; }
        public Fighter SecondFighter { get; set; }

        public GameEngine()
        {
            FirstFighter = new Fighter(name: "Niggatchu", 200,1);
            SecondFighter = new Fighter(name: "Pikachu", 100, 1);
        }
    }
}
