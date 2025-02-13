using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemoni
{
    public class GameEngine
    {
        public Pokemon FirstPokemon { get; set; }
        public Pokemon SecondPokemon { get; set; }

        public GameEngine() 
        {
            FirstPokemon = new Pokemon(name: "Pikachu",200,1);
            SecondPokemon = new Pokemon(name: "Charizard",200,1);
        }

    }
}
