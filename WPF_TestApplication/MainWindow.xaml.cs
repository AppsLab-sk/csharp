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

            Button.IsEnabled = false;

            ComboBox_AccountRole.Items.Add("Blitz");
            ComboBox_AccountRole.Items.Add("Tacher");
            ComboBox_AccountRole.Items.Add("Mute");
            ComboBox_AccountRole.Items.Add("Mozzie");
            ComboBox_AccountRole.Items.Add("Azami");


            AllUsers.Add("Teacher Michal");
            AllUsers.Add("Teacher Igor");
            AllUsers.Add("Student Adam");
            AllUsers.Add("Student Andrej");
            AllUsers.Add("Student Seth");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newUser = (ComboBox_AccountRole.SelectedItem as string) + " " + ZadajMeno.Text;
            //var accountrole = ComboBox_AccountRole.SelectedItem as string;
           // var textik = ZadajMeno.Text;
            //Label_Firstname.Content = accountrole + textik;
            AllUsers.Add(newUser);
            List_AllUsers.Items.Clear();
            foreach (var user in AllUsers)
            {
                List_AllUsers.Items.Add(user);            
            }
        }

        private void ZadajMeno_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var textik = ZadajMeno.Text;
            //Label_Firstname.Content = textik;

        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            Button.IsEnabled = !Checkbox_Acceptrules.IsChecked.Value;
            // Button.IsEnabled = true;

        }

        private void Checkbox_Acceptrules_Unchecked(object sender, RoutedEventArgs e)
        {
            //Button.IsEnabled= false;
        }

        private void Checkbox_Acceptrules_Click(object sender, RoutedEventArgs e)
        {
            Button.IsEnabled = Checkbox_Acceptrules.IsChecked.Value;


            /*bool acceptedrules = Checkbox_Acceptrules.IsChecked.Value;
            if (acceptedrules)
            {
                Button.IsEnabled = true;
            }
            else
            {
                Button.IsEnabled = false;
            }*/
        }

        private void ComboBox_Roles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Teacher_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in AllUsers)
            {
                if (user.Contains("Teacher"))  
                {
                    List_AllUsers.Items.Add(user);
                }
            }
        }
    }
}