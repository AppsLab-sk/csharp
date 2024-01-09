using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteSimulator.Modules
{
    public interface IGameMode
    {
        public string Name { get; set; }

        public void Execute(ICharacter usedCh, IEnemy enemy) { }
    }
}
