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
            var book1 = new Book(1, "Harry Humenčan", "Tik-Tok", DateTime.Now, Book.BookGenre.Comedy);
            var book2 = new Book(2, "Plomile Toul", "Milan Nevedal", DateTime.Now, Book.BookGenre.education);
            var book3 = new Book(3, "Dano Drevo", "PPPier", DateTime.Now, Book.BookGenre.Comedy);

            ListView_AllBooks.Items.Add(book1);
            ListView_AllBooks.Items.Add(book2);
            ListView_AllBooks.Items.Add(book3);



        }




        
    }
}


    

    
  
