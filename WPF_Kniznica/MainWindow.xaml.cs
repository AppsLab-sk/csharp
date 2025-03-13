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

namespace WPF_Kniznica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Kniha> knihy = new List<Kniha>();
        public List<User> users = new List<User>();
        int nextBookId = 1;


        public MainWindow()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            BooksDataGrid.ItemsSource = null;
            BooksDataGrid.ItemsSource = knihy;
        }

        private void LoadLoanBooks()
        {

        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            if (addBookWindow.ShowDialog() == true) 
            {
                string title = addBookWindow.Nazov;
                string autor = addBookWindow.Autor;
                string isbn = addBookWindow.ISBN;
                int year = addBookWindow.RokVydania;
                int copies = addBookWindow.PocetDostupnychKusov;
                BookCategory category = addBookWindow.Category;

                Kniha newBook = new Kniha(title, autor, isbn, year, copies, category);
                knihy.Add(newBook);
                LoadBooks();
                LoadLoanBooks();

            
            }
        }
        
        private void RemoveBookButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BooksDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}