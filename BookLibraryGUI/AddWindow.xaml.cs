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
using static System.Reflection.Metadata.BlobBuilder;

namespace BookLibraryGUI
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
            PopulateComboBox();
            //GenreComboBox();
        }

        private void PopulateComboBox()
        {
            var genres = Enum.GetValues(typeof(BookGenre))
                              .Cast<BookGenre>()
                              .Select(e => e.ToListItem())
                              .ToList();
            GenreComboBox.ItemsSource = genres;
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;

            int i = library.Books.Count + 1;
            DateTime releaseDate = (DateTime)BRelease.SelectedDate;

            string author = BAuthorTextBox.Text;

            string bookName = BNameTextBox.Text;

            var selectedItem = GenreComboBox.SelectedItem as NameValueBinder;
            var bookGenre = (BookGenre)selectedItem.Value;
            var newBook = new Book(i, bookName, author, releaseDate, bookGenre);

            library.Books.Add(newBook);
        }
    }
}
