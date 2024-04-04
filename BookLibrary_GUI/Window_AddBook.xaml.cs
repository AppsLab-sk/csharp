using BookLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window_AddBook : Window
    {
        public Window_AddBook()
        {
            InitializeComponent();

            
            ___bookgenre_.ItemsSource = Enum.GetValues(typeof(BookGenre)).Cast<BookGenre>();

            
        }


        private void __Add_Book__Click(object sender, RoutedEventArgs e)
        {
           var library = Library.Instance;
          var id = library.Books.Count;
          var name = ___bookname_.Text;
          var releasedate = ___bookdate_.SelectedDate.Value.Date;
          var author = ___bookauthor_.Text;
          var genre = (BookGenre)Enum.Parse(typeof(BookGenre), ___bookgenre_.SelectedValue.ToString(), true);
          var newbook = new Book (id, name, releasedate, author, genre);
            library.Books.Add(newbook);
            Close();
            
       }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
    