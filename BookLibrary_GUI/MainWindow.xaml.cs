using BookLibrary;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookLibrary_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Book> books = new List<Book>();

            var book1 = new Book(1, "Kniha1", "Autor1", new DateTime(2012, 12, 13), BookGenre.Comix);
            var book2 = new Book(2, "Kniha2", "Autor2", new DateTime(2006, 4, 5), BookGenre.Cartoon);
            var book3 = new Book(3, "Kniha3", "Autor3", new DateTime(2015, 2, 6), BookGenre.Comedy);

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            ListView_AllBooks = new ListView();

        }

        private void ListView_AllBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
