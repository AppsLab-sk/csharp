using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PokemonGame
{
    public class GameEngine
    {
        
        public Pokemon FirstPokemon { get; set; }
        public Pokemon SecondPokemon { get; set; }

        public GameEngine()
        {
            FirstPokemon = new Pokemon("Lickitung");
            SecondPokemon = new Pokemon("Mimikyu");

            
        }
    }
}
