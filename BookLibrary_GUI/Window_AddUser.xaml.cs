using System;
using BookLibrary;
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

            Gender_ComboBox.ItemsSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            var library = Library.Instance;
            var iD = 0;
            var name = Name_TextBox.Text;
            var city = City_TextBox.Text;
            var dateofbirth = Birthday_DatePicker.SelectedDate.Value.Date;
            var gender = (Gender)Enum.Parse(typeof(Gender), Gender_ComboBox.SelectedValue.ToString(), true);
            var newuser = new User(iD, name, city, dateofbirth, gender);
            library.Users.Add(newuser);
            Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
