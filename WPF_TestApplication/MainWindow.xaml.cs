using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_TestApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> AllUsers { get; set; } = new List<string>();
        public MainWindow()
        {

            InitializeComponent();
            Button_FirstName.IsEnabled = false;

            ComboBox_AcaundRoles.Items.Add("Teacher");
            ComboBox_AcaundRoles.Items.Add("Student");

            AllUsers.Add("teacher Micahal");
            AllUsers.Add("Teacher Franta");
            AllUsers.Add("Teacher Johan");
            AllUsers.Add("Student Hanzi");
            AllUsers.Add("Student Chans");
            AllUsers.Add("Student Hans");
            AllUsers.Add("Student Kubo");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newUser = (ComboBox_AcaundRoles.SelectedItem as string) + " " + Text_ZmenaMena.Text;
            var acaunfrolr = ComboBox_AcaundRoles.SelectedItem as string;
            var textik = Text_ZmenaMena.Text;
            Label_FirstName.Content = textik + " " + acaunfrolr;

            AllUsers.Add(newUser);

            Listbox_Allusers.Items.Add(newUser);
            /*
            Listbox_Allusers.Items.Clear();
            foreach (var user in AllUsers) 
            {
                
                Listbox_Allusers.Items.Add(user);       
            }*/

        }
        

        private void Text_ZmenaMena_TextChanged(object sender, TextChangedEventArgs e)
        {
           /* var textik = Text_ZmenaMena.Text;
            Label_FirstName.Content = textik;*/
        }

        private void Checkin_Acceptruleros_Checked(object sender, RoutedEventArgs e)
        {
            Button_FirstName.IsEnabled = Checkin_Acceptruleros.IsChecked.Value;
       
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            Button_FirstName.IsEnabled = !Checkin_NeAcceptruleros.IsChecked.Value;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Listbox_Allusers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Triedic_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in AllUsers) 
            {
                if (user.Contains("Teacher" ))
                {
                    Listbox_Allusers.Items.Add(user);
                }
                else if (user.Contains("teacher")) 
                {
                    Listbox_Allusers.Items.Add(user);
                }
            }
        }
    }
}