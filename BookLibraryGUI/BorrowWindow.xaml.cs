using BookLibrary;
using System;
using System.Collections;
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

namespace BookLibraryGUI
{
    /// <summary>
    /// Interaction logic for BorrowWindow.xaml
    /// </summary>
    public partial class BorrowWindow : Window
    {
        public Library LibraryKNM { get; set; } = Library.Instance;
        public MainWindow MainWindowReference { get; set; }
        public BorrowWindow()
        {
            InitializeComponent();
            Refresh();
        }

        public void Refresh()
        {
            BookList.Items.Clear();
            UserList.Items.Clear();

            foreach (var book in LibraryKNM.Books.ToList())
            {
                BookList.Items.Add(book);               
            }

            foreach (var user in LibraryKNM.Users)
            {
                UserList.Items.Add(user);
            }
        }
        private void BorrowBook_Click(object sender, RoutedEventArgs e)
        {
            var BBook = (Book)BookList.SelectedItem;
            var BUser = (User)UserList.SelectedItem;
            DateOnly baseDate = DateOnly.FromDateTime(DateTime.Now);
            int bTime = (int)BSlider.Value;
            DateOnly newDate = baseDate.AddDays(bTime);


            if (BBook != null && BUser != null)
            {
                BBook.IsBorrowed = true;
                BBook.BorrowedBy = BUser;
                BBook.BorrowedTime = newDate;
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
