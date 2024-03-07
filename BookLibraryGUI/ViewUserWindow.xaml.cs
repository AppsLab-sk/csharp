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
        public ViewUserWindow()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
