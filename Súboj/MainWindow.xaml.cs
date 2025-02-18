using PokemonGame.Windows;
using System.Windows;

namespace PokemonGame
{
    public partial class MainWindow : Window
    {
        public GameEngine GameEngine { get; set; } = new GameEngine();
        public Window_PokemonBattle Window_PokemonBattle { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            UserControl_World.GameEngine = GameEngine;

            //Window_PokemonBattle = new Window_PokemonBattle();
            //Window_PokemonBattle.Show();
            //Close();

        }
    }
}