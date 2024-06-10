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
    /// Interaction logic for Window_BorrowBook.xaml
    /// </summary>
   
    public partial class Window_BorrowBook : Window
    {
        public Library LibraryKNM { get; set; } = Library.Instance;
        public Window_BorrowBook()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            
            ListView_SelectBooks.Items.Clear();
            foreach (var book in LibraryKNM.Books.Where(x => !x.IsBorrowed).ToList())
            {
                ListView_SelectBooks.Items.Add(book.ToString());
            }
            ListView_SelectUsers.Items.Clear();
            foreach (var user in LibraryKNM.Users)
            {
                ListView_SelectUsers.Items.Add(user.ToString());
            }
        }

            private void ListView_SelectBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var title = ListView_SelectBooks.SelectedItem.ToString();
            var name = ListView_SelectUsers.SelectedItem.ToString();
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}