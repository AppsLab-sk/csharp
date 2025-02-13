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

            Button_ShowName.IsEnabled = false;

            ComboBox_AccountRole.Items.Add("Teacher");
            ComboBox_AccountRole.Items.Add("Student");

            AllUsers.Add("Teacher Michal");
            AllUsers.Add("Teacher Igor");
            AllUsers.Add("student Marek");
            AllUsers.Add("student Alica");
            AllUsers.Add("student Andreas");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //var accountrole = ComboBox_AccountRole.SelectedItem as string;
            //var inputName = TextBox_InputFirstName.Text;
            //Label_FirstName.Content = accountrole + inputName;

            var newUser = (ComboBox_AccountRole.SelectedItem as string) + " " + TextBox_InputFirstName.Text;
            Label_FirstName.Content = newUser;
            AllUsers.Add(newUser);

            ListBox_AllUsers.Items.Clear();
            foreach (var item in AllUsers)
            {
                ListBox_AllUsers.Items.Add(item);
            }
        }

        private void TextBox_InputFirstName_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            /*var textBox = sender as TextBox;
            var inputName = TextBox_InputFirstName.Text;
            Label_FirstName.Content = inputName;*/
        }

        private void CheckBox_AcceptRules_Checked(object sender, RoutedEventArgs e)
        {
            //Button_ShowName.IsEnabled = true;
        }

        private void CheckBox_AcceptRules_Unchecked(object sender, RoutedEventArgs e)
        {
            //Button_ShowName.IsEnabled = false;

        }

        private void CheckBox_AcceptRules_Click(object sender, RoutedEventArgs e)
        {
            Button_ShowName.IsEnabled = CheckBox_AcceptRules.IsChecked.Value;

            /* bool acceptedRules = CheckBox_AcceptRules.IsChecked.Value;
             if (acceptedRules)
             {
                 Button_ShowName.IsEnabled = true;
             }
             else
             {
                 Button_ShowName.IsEnabled = false;
             }*/
        }

        private void ChcekBox_DoNotAccpetRules_Checked(object sender, RoutedEventArgs e)
        {
            Button_ShowName.IsEnabled = CheckBox_AcceptRules.IsChecked.Value;
        }

        private void Button_FilterOnlyTeacher_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in AllUsers)
            {
                if (user.Contains("Teacher"))
                {
                    ListBox_AllUsers.Items.Add(user);
                }
            }
        }
    }
}
