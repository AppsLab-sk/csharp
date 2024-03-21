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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace BookLibrary_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public Library LibraryKNM { get; set; } = Library.Instance;
        public MainWindow()
        {
            InitializeComponent();
            Refresh();

        }

        private void Refresh()
        {
            ListView_AllNewBooks.Items.Clear();
            foreach (var book in LibraryKNM.Books.Where(x => !x.IsBorrowed).ToList())
            {
                ListView_AllNewBooks.Items.Add(book.ToString());
            
            }
            ListView_AllUsers.Items.Clear();
            foreach (var user in LibraryKNM.Users)
            {
                ListView_AllUsers.Items.Add(user.FullName);

            }
            ListView_AllBorrowedBooks.Items.Clear();
            foreach (var book in LibraryKNM.Books.Where(x => x.IsBorrowed).ToList())
            {
                ListView_AllBorrowedBooks.Items.Add(book.ToString());

            }
        }
        

        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_AllBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }

    
}
