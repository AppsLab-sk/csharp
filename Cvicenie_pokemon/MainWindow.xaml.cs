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

namespace Cvicenie_pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hero myhero=new Hero(100,100,10,100,200);
            Priserkabojimbojim myenemy = new Priserkabojimbojim(200, 200, 1 );
            

            Window_fight fight_window = new Window_fight( myhero, myenemy);
            fight_window.Show();
        }
        

       

     
    }
}