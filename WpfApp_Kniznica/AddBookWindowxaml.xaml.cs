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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Kniznica
{
    /// <summary>
    /// Interaction logic for AddBookWindowxaml.xaml
    /// </summary>
    public partial class AddBookWindowxaml : Page
    {
        public string Titul {  get; set; }
        public string Author { get; set; }
        public string ibns {  get; set; }
        public int year { get; set; }
        public int cpies {  get; set; }
                                     
        public AddBookWindowxaml()
        {
            InitializeComponent();
        }
    }
}
