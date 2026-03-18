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

namespace cvicenie_first_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cislo;
        public Random r;
        public MainWindow()
        {
            InitializeComponent();
            r= new Random();
            cislo = r.Next(1,101);
        }
        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Skus(object sender, RoutedEventArgs e)
        {

        }

      
    }
}