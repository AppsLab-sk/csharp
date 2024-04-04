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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {

            InitializeComponent();

            Refresh();
        }
        private void Refresh()
        {
            var library = Library.Instance;
            SelectedBook.Items.Clear();
            foreach (var book in library.Books.Where(X => !X.IsBorrowed).ToList())
            {
                SelectedBook.Items.Add(book.ToString());
            }
            SelectedUser.Items.Clear();
            foreach (var user in library.Users)
            {
                SelectedUser.Items.Add(user.ToString());

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)slider.Value;

            textBox.Text = value.ToString();
        }
    }
}
