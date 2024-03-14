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
    /// Interaction logic for ViewUserWindow.xaml
    /// </summary>
    public partial class ViewUserWindow : Window
    {
        public MainWindow MainWindowReference { get; set; }
        public Library LibraryKNM { get; set; } = Library.Instance;
        public ViewUserWindow()
        {
            InitializeComponent();
            Refresh();
        }
        public void Refresh()
        {
            IDsList.Items.Clear();
            NameList.Items.Clear();
            CityList.Items.Clear();
            BirthList.Items.Clear();
            foreach (var user in LibraryKNM.Users)
            {
                IDsList.Items.Add(user.ID);
                NameList.Items.Add(user.FullName);
                CityList.Items.Add(user.City);
                BirthList.Items.Add(user.BirthDay);
            }

        }
        private void Button_AddUser(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.ViewUserWindowReference = this;
            addUserWindow.Show();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
