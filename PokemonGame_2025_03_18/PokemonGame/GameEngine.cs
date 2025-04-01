using System.Windows.Controls;

namespace PokemonGame
{
    public class GameEngine
    {
        public int Xp { get; set; }
        public int XpNextLevel { get; set; } = 500;
        public MainWindow MainWindow { get; set; }
        public Pokemon FirstPokemon { get; set; }
        public Pokemon SecondPokemon { get; set; }

        public Dictionary<Image, Pokemon> Enemies { get; set; } = new Dictionary<Image, Pokemon>();
        public List<string> Pokemons { get; set; } = new List<string>() { "Butterfree", "Chansey", "Charizard",
                                                                          "Lapras", "Minccino", "Moltres",
                                                                          "Pikachu", "ShinyBulbasaur", "Squirtle" };

        public List<string> Maps { get; set; } = new List<string>() { "World_Iceland",
                                                                      "World_Lavaland",
                                                                      "World_Natureland"};


        public GameEngine()
        {
            FirstPokemon = new Pokemon("Pikachu", 200, 1, 200);
            SecondPokemon = new Pokemon("Charizard", 200, 1, 200);
        }


        public void TakeXP(int xp)
        {
            Xp += xp;
            if (Xp >= XpNextLevel) // Zistujeme ci pokemon ma dostatok XP na level up
            {
                // Pripocitanie levelu mojmu pokemonovi
                FirstPokemon.Level++;

                //Pripocitanie HP
                FirstPokemon.MaxHealth *= 2;

                //Zvysenie potrebneho poctu na novy level
                XpNextLevel *= 2;
            }
            MainWindow.ProgressBar_XP.Value = Xp;
            MainWindow.ProgressBar_XP.Maximum = XpNextLevel;

            MainWindow.Label_XP.Content = Xp + " / " + XpNextLevel + "(" + FirstPokemon.Level + ")";


        }

    }
}
