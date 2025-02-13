using Pokemoni.Windows;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokemoni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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