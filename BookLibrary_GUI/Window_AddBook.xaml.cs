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

            Genres_ComboBox.ItemsSource = Enum.GetValues(typeof(BookGenre)).Cast<BookGenre>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;
            var iD = library.Books.Count;
            var title = BookTitle_TextBox.Text;
            var author = AuthorName_TextBook.Text;
            var genre = (BookGenre)Enum.Parse(typeof(BookGenre), Genres_ComboBox.SelectedValue.ToString(), true);
            var releaseDate = Date_DatePicker.SelectedDate.Value.Date;
            var newbook = new Book(iD, title, author, releaseDate, genre);
            library.Books.Add(newbook);
            Close();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
