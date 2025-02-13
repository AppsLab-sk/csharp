using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokemon_Fight.Windows
{
    /// <summary>
    /// Interaction logic for UserControl_Map.xaml
    /// </summary>
    public partial class UserControl_Map : UserControl
    {
        public GameEngine GameEngine { get; set; }
        public Dictionary<Button, Pokemon> Enemies { get; set; } = new Dictionary<Button, Pokemon>();

        public UserControl_Map()
        {
            InitializeComponent();
            GenerateMap();
            
        }
        public void GenerateMap() 
        {
            Random rnd = new Random();
            int numberofenemies = 3;

            for (int i = 0; i < numberofenemies; i++) 
            { 
                var positionx = rnd.Next(-280, 280);
                var positiony = rnd.Next(-280, 280);

                Button button = new Button();
                button.Width = 100;
                button.Height = 50;
                button.Margin = new Thickness(positionx, positiony, 0, 0);
                button.Click += Button_Click1;

                Grid_Map.Children.Add(button);


                Pokemon pokemon = new Pokemon("Enemie:" + i, 200  + (100 * i), i);
                button.Content = pokemon.Name + "LVL:" + pokemon.Level;

                Enemies.Add(button, pokemon);
            }        
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var pokemon = Enemies[button];

            GameEngine.LastPokemon = pokemon;

            var Window_PokemonBattle = new Window_PokemonBattle(GameEngine);
            Window_PokemonBattle.Show();
        }

        
    }
}
