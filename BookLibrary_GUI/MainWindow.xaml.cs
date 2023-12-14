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
        public MainWindow()
        {
            InitializeComponent();
            var book1 = new Book(1, "King", "Sladkovic", new DateTime(2013, 07, 06), BookGenre.Cartoon);

            var book2 = new Book(2, "Pinokio", "Kolár", new DateTime(2016, 04, 06), BookGenre.Cartoon);

            var book3 = new Book(3, "Hobbit", "Tolkien", new DateTime(1950, 02, 01), BookGenre.SciFi);       
        
        
            ListView_AllBooks.Items.Add(book1);
            ListView_AllBooks.Items.Add(book2);
            ListView_AllBooks.Items.Add(book3);






        }
    }
}
