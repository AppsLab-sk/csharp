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
            gender_box.ItemsSource = Enum.GetValues(typeof(Gender));
        }
        


        private void Add_book_Click_1(object sender, RoutedEventArgs e)
        {

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_User_Click(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;
            var id = library.Users.Count;
            var user_fullname = fullname_text.Text;
            var user_city = city_text.Text;
            var user_birthday = date_text.SelectedDate.Value.Date;
            var user_gender = (Gender)Enum.Parse(typeof(Gender), gender_box.SelectedValue.ToString(), true);

            var newUser = new User(id, user_fullname, user_city, user_birthday, Gender);
           
            library.Users.Add(newUser);
            Close();
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Gender_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Close_Button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}