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
            ComboBox1.Items.Add("Teacher");
            ComboBox1.Items.Add("Student");

            AllUsers.Add("Teacher Michal");
            AllUsers.Add("Teacher Igor");
            AllUsers.Add("Student Marek");
            AllUsers.Add("Student Alica");
            AllUsers.Add("student Andreas");

            foreach (var user in AllUsers)
            {
                ListBox1.Items.Add(user);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newUsers = (ComboBox1.SelectedItem as string) + " " + TextBox1.Text;
            Label2.Content = newUser;
            AllUsers.Add(newUser);

            foreach (var user in AllUsers)
            {
                ListBox1.Items.Add(user);
            }
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_AcceptRules_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_DeclineRules_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}