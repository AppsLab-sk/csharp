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
            ListView_AllBooks.Items.Clear();
            foreach (var book in LibraryKNM.Books.Where(x => x.IsBorrowed).ToList());
            {
                ListView_AllBooks.Items.Add(ListView_AllBooks.ToString());
            }
        }
        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_AllBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        
    
    }

    
}
