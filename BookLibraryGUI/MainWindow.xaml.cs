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

namespace BookLibraryGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Book> book = new List<Book>()
            {
                 new Book(0, "Ako naučiť Murína C#", "Michalec", new DateTime(2024, 02, 01), BookGenre.Scifi),
                 new Book(1, "Ako naučiť Murína C# 2", "Michalec", new DateTime(2024, 02, 02), BookGenre.Scifi),
                 new Book(2, "Ako naučiť Murína C# 3", "Michalec", new DateTime(2024, 02, 03), BookGenre.Scifi)
            };

            User murin = new User(12, "Murín", "Krasno pod Kysucou", new DateTime(2008, 05, 29), Gender.Male);

            book[2].IsBorrowed = true;
            book[2].BorrowedBy = murin;
            book[2].BorrowedTime = DateTime.Now;

            foreach (Book bookItem in book)
            {
                
                ListView.Items.Add(bookItem);
            }
                      
        }
    }
}
