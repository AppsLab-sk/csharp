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

namespace WPF_Kniznica
{
    /// <summary>
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public string Nazov { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int RokVydania { get; set; }
        public int PocetDostupnychKusov { get; set; }
        public BookCategory Category { get; set; }

        public AddBookWindow(string nazov, string autor, string iSBN, int rokVydania, int pocetDostupnychKusov, BookCategory category)
        {
            Nazov = nazov;
            Autor = autor;
            ISBN = iSBN;
            RokVydania = rokVydania;
            PocetDostupnychKusov = pocetDostupnychKusov;
            Category = category;
        }
        public AddBookWindow()
        {
            InitializeComponent();
        }
    }
}
