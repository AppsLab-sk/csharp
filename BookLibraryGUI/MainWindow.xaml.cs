using BookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
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

namespace BookLibraryGUI
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
        public void Refresh()
        {
            IDsList.Items.Clear();
            BookList.Items.Clear();
            AuthorList.Items.Clear();
            ReleaseList.Items.Clear();
            GenreList.Items.Clear();
            foreach (var book in LibraryKNM.Books.Where(x => !x.IsBorrowed).ToList())
            {
                IDsList.Items.Add(book.ID); 
                BookList.Items.Add(book.ToString()); 
                AuthorList.Items.Add(book.Author); 
                ReleaseList.Items.Add(book.ReleaseDate);
                GenreList.Items.Add(book.Genre);
            }
        }
        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MenuItem_AddBook_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of the window you want to open
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.MainWindowReference = this;
            // Show the window
            addBookWindow.Show();
        }
        private void MenuItem_AddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.MainWindowReference = this;
            addUserWindow.Show();
        }
        private void MenuItem_ViewUser_Click(object sender, RoutedEventArgs e)
        {
            ViewUserWindow viewUserWindow = new ViewUserWindow();
            viewUserWindow.MainWindowReference = this;
            viewUserWindow.Show();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
