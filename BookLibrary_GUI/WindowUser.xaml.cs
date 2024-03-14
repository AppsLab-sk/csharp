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
    /// Interaction logic for WindowUser.xaml
    /// </summary>
    public partial class WindowUser : Window
    {
        public WindowUser()
        {
            InitializeComponent();
        }

        private void fullname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ___Add_User__Click(object sender, RoutedEventArgs e)
        {
            
            var user_fullname = fullname.Text;
            var user_city = city.Text;
            var user_birthday = birthday.Text;
            var user_gender = gender.Text;
            var newUser = new User (user_fullname,user_city,user_birthday,user_gender);
            User.Add(newUser);
            Close();

        }
    }
}
 
