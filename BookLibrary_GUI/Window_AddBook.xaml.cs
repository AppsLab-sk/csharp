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

            ComboBox_BookGenre.ItemsSource = Enum.GetValues(typeof(BookGenre));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
       
            var library = Library.Instance;

            var id = library.Books.Count;
            var name = TextBoxBookName.Text;
            var author = TextBoxAuthorName.Text;
            var releasedate = DatePickerRelease.SelectedDate.Value.Date;
            var genre = (BookGenre)Enum.Parse(typeof(BookGenre), ComboBox_BookGenre.SelectedValue.ToString(), true);

            var newBook = new Book(id, name, author, releasedate, genre);
            library.Books.Add(newBook);
            Close();
        }
         
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        } 
    }
}
