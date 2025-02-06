using PokemonGame.Windows;
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

namespace PokemonGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window_PokemonBattle Window_PokemonBattle { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Window_PokemonBattle = new Window_PokemonBattle();
            Window_PokemonBattle.Show();

            this.Hide();
        }
    }
}