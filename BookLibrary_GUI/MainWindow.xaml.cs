﻿using BookLibrary;
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

namespace BookLibrary_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var book1 = new Book(1,"Promile Tour","Milan Nevedal",new DateTime(2017, 5 , 5), BookGenre.Religion);
            var book2 = new Book(2, "Identita Muza","Milan Nevedal", new DateTime(2019 , 6 , 9), BookGenre.Educational);
            var book3 = new Book(3, "Katechezy Pre Kazdeho", "Milan Nevedal", new DateTime(2020, 4 , 5), BookGenre.Religion);

            ListView_AllBooks.Items.Add(book1);
            ListView_AllBooks.Items.Add(book2);
            ListView_AllBooks.Items.Add(book3);

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
