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

namespace WPF_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> allUsers { get; set; } = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            Button.IsEnabled = false;
            ComboBox_AccountRole.Items.Add("Teacher");
            ComboBox_AccountRole.Items.Add("Student");

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var AccountRole = ComboBox_AccountRole.SelectedItem as string;
            var NewUser = $"{TextBox.Text} - {ComboBox_AccountRole.Text} ";
            Label_FirstName.Content = NewUser;
            allUsers.Add(NewUser);
            ListBox_AllUsers.Items.Add(NewUser);
            
        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //Label_FirstName.Content = TextBox.Text;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //Button.IsEnabled = true;
        }
        private void CheckBox_AcceptRules_Unchecked(object sender, RoutedEventArgs e)
        {
            //Button.IsEnabled = false;
        }

        private void CheckBox_AcceptRules_Click(object sender, RoutedEventArgs e)
        {
            Button.IsEnabled = CheckBox_AcceptRules.IsChecked.Value;
        }

        private void ComboBox_AccountRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}