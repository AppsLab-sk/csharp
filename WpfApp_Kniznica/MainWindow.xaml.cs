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
using WpfApp_Kniznica.model;
using static WpfApp_Kniznica.model.Kniha;

namespace WpfApp_Kniznica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public List<User> knihas = new List<User>();
        public List<User> kniznicas = new List<User>();

        private void AddBookButtton_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            if (addBookWindow.ShowDialog() == true )
            {
                string title = addBookWindow.Title;
                string author = addBookWindow.Author;   
                string isbn = addBookWindow.Isbn;
                int year = addBookWindow.Year;  
                int copies = addBookWindow.Copies;
                DruhyKnih druhyKnih = new DruhyKnih();

                Kniha newkniha = new Kniha(title, author, isbn, year, copies, DruhyKnih);
                knihas.Add(newkniha);
                LoadBooks();
                LoadLoanBooks();
            }
        }
       
    }
}