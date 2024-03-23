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

namespace BookLibraryGUI
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public MainWindow MainWindowReference { get; set; }
        public ViewUserWindow ViewUserWindowReference { get; set; }

        public AddUserWindow()
        {
            InitializeComponent();
            PopulateComboBox();
            UserID.Text = GetUserIdText();
        }
        private void PopulateComboBox()
        {
            var genres = Enum.GetValues(typeof(Gender))
                              .Cast<Gender>()
                              .Select(e => e.ToListItem())
                              .ToList();
            UGenreComboBox.ItemsSource = genres;
        }
        private string GetUserIdText()
        {
            var library = Library.Instance;
            int i = library.Users.Count;

            return $"User ID {i}";
        }
        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var library = Library.Instance;

            int i = library.Users.Count;
            DateTime birth = (DateTime)UBirth.SelectedDate;

            string fullname = UNameTextBox.Text;

            string city = UCityTextBox.Text;

            var selectedItem = UGenreComboBox.SelectedItem as NameValueBinder;
            var gender = (Gender)selectedItem.Value;
            var newUser = new User(i, fullname, city, birth, gender);

            library.Users.Add(newUser);

            ViewUserWindowReference.Refresh();

            Close();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
