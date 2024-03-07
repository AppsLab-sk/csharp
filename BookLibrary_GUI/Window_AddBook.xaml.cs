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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookLibrary_GUI
{
    /// <summary>
    /// Interaction logic for Window_AddBook.xaml
    /// </summary>
    public partial class Window_AddBook : Window
    {
        public Window_AddBook()
        {
            InitializeComponent();
            book_genre.ItemsSource = Enum.GetValues(typeof(BookGenre));
        }
        private void Add_book_Click(object sender, RoutedEventArgs e)
        {

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_book_Click_1(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;

            var id = library.Books.Count;
            var name = bookname.Text;
            var author = author_text.Text;
            var releasedate = date.SelectedDate.Value.Date;
            var genre = (BookGenre)Enum.Parse(typeof(BookGenre), book_genre.SelectedValue.ToString(), true);

            var newBook = new Book(id, name, author, releasedate, genre);
            library.Books.Add(newBook);
            Close();
        }
    }
}