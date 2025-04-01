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

            GameEngine.MainWindow = this;

            UserControl_World.GameEngine = GameEngine;
            UserControl_World.GenerateMap();

            GameEngine.TakeXP(0);
        }
    }
}