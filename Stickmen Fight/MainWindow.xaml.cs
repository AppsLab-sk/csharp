using Stickmen_Fight.Windows;
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

namespace Stickmen_Fight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameEngine GameEngine { get; set; } = new GameEngine();
        public Window_FighterBattle Window_PokemonBattle { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            UserControl_World.gameEngine = GameEngine;
  
         
        }
    }
}