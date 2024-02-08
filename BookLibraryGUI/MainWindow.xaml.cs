using BookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
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

            //List<Book> book = new List<Book>()
            //{
            //   new Book(0, "Ako naučiť Murína C#", "Michalec", new DateTime(2024, 02, 01), BookGenre.Scifi),
            // new Book(1, "Ako naučiť Murína C# 2", "Michalec", new DateTime(2024, 02, 02), BookGenre.Scifi),
            //new Book(2, "Ako naučiť Murína C# 3", "Michalec", new DateTime(2024, 02, 03), BookGenre.Scifi)
            //};

            //User murin = new User(12, "Murín", "Krasno pod Kysucou", new DateTime(2008, 05, 29), Gender.Male);

            //book[2].IsBorrowed = true;
            //book[2].BorrowedBy = murin;
            //book[2].BorrowedTime = DateTime.Now;

            //            for (int i = 0; i < book.Count; i++)
            //          {
            //            ListView.Items.Add(book[i].Name);
            //          ListView2.Items.Add(book[i].Author);
            //        ListView3.Items.Add(book[i].ReleaseDate);
            //  }
            Refresh();  
           
        }
        private void Refresh()
        {
            ListView.Items.Clear();
            foreach (var book in LibraryKNM.Books.Where(x => !x.IsBorrowed).ToList()) 
            {
                ListView.Items.Add(book.ToString());
            }
        }
    }
}
