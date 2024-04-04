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
    /// Interaction logic for Window_AddUser.xaml
    /// </summary>
    public partial class Window_AddUser : Window
    {
        public Window_AddUser()
        {
            InitializeComponent();

            ___usergender_.ItemsSource = Enum.GetValues(typeof(Gender)).Cast<BookGenre>();
        }
        private void __Add_User__Click(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;
            var id = library.Users.Count;
            var FullName = ___userFullname_.Text;
            var City = ___userCity_.Text;
            var BirthDay = ___userBirthDay_.SelectedDate.Value.Date;
            var gender = (Gender)Enum.Parse(typeof(Gender), ___usergender_.SelectedValue.ToString(), true);
            var newUser = new User(id, FullName, City, BirthDay, gender);
            library.Users.Add(newUser);
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
