using BookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for Windows_AddUser.xaml
    /// </summary>
    public partial class Windows_AddUser : Window
    {
        public Windows_AddUser()
        {
            InitializeComponent();

        }
        private void Add_User_Click(object sender, RoutedEventArgs e)
        {

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_book_Click_1(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;
            var ID = id.User.Count;
             var FullName = fullname.Text;
            var City = city.Text;
            var Birthday = date.SelectedDate.Value.Date;
            var Gender = (Gender)Enum.Parse(typeof(Gender), user_Gender.SelectedValue.ToString(), true);

            var newUser = new User(ID, FullName, City, Birthday, Gender);
            library.Users.Add(newUser);
            Close();
        }
    }
}    
