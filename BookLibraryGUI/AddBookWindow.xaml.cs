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
    public partial class AddBookWindow : Window
    {
        public MainWindow MainWindowReference { get; set; }
        public AddBookWindow()
        {
            InitializeComponent();
            PopulateComboBox();
            BookId.Text = GetBookIdText();
        }
        private void PopulateComboBox()
        {
            var genres = Enum.GetValues(typeof(BookGenre))
                              .Cast<BookGenre>()
                              .Select(e => e.ToListItem())
                              .ToList();
            GenreComboBox.ItemsSource = genres;
        }
        private string GetBookIdText()
        {
            var library = Library.Instance;
            int i = library.Books.Count;

            return $"Book ID {i}";
        }
        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;

            int i = library.Books.Count;
            
            string bookName = BNameTextBox.Text;

            string author = BAuthorTextBox.Text;   
            
            DateOnly releaseDate = DateOnly.FromDateTime((DateTime)BRelease.SelectedDate);

            var selectedItem = GenreComboBox.SelectedItem as NameValueBinder;
            var bookGenre = (BookGenre)selectedItem.Value;

            var newBook = new Book(i, bookName, author, releaseDate, bookGenre);

            library.Books.Add(newBook);

            MainWindowReference.Refresh();

            Close();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
