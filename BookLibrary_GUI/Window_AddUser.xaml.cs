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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookLibrary_GUI
{
    /// <summary>
    /// Interaction logic for Window_AddUser.xaml
    /// </summary>
    public partial class Window_AddUser : Window
    {
        public Window_AddUser()
        {
            InitializeComponent();
            user_gender.ItemsSource = Enum.GetValues(typeof(BookGenre));
        }
        private void Add_U_Click_1(object sender, RoutedEventArgs e)
        {
            var BookLibrary = User.Instance;

            var user_ID= User.Count
            var user_fullname = fullname.Text;
            var user_birthday = birthday.Text;
            var user_city = city.Text;
            var user_gender = (gender)Enum.Parse(typeof(BookGenre), user_gender.SelectedValue.ToString(), true);

            var newBook = new User(int iD, user_fullName, user_city, birthDay user_birthDay, Gender gender);
            User.Add(newUser);
            Close();
        }
    }
}
