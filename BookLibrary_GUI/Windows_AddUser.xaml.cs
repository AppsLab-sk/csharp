using BookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookLibrary_GUI
{
    /// <summary>
    /// Interaction logic for Windows_AddUser.xaml
    /// </summary>
    public partial class Windows_AddUser : Window
    {
        public Windows_AddUser()
        {
            InitializeComponent();
            Gender_box.ItemsSource = Enum.GetValues(typeof(Gender));

        }
        private void Add_User_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Add_book_Click_1(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;
            var id = library.Users.Count;
            var FullName = fullname_text.Text;
            var City = city_text.Text;
            var Birthday = date2.SelectedDate.Value.Date;
            var Gender = (Gender)Enum.Parse(typeof(Gender), Gender_box.SelectedValue.ToString(), true);

            var newUser = new User( id , FullName, City, Birthday, Gender);
            library.Users.Add(newUser);
            Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Close_Button2_Click(object sender, RoutedEventArgs e)
        {
                Close();
        }
    }
}    
