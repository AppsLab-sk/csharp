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

namespace TicTacToe_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char LastPlayer {  get; set; } = '⚪';
        public char PlayerOne { get; set; } = '✕';
        public char PlayerTwo { get; set; } = '⚪';
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ProcessClick(Button button)
        {
            var buttonContent = button.Content.ToString();
            if (buttonContent.Contains(PlayerOne) || buttonContent.Contains(PlayerTwo))
            {
                return;
            }
            
           if (LastPlayer == PlayerOne)
           {
               button.Content = PlayerTwo;
               LastPlayer = PlayerTwo;
           }
           else if (LastPlayer == PlayerTwo)
           {
               button.Content = PlayerOne;
               LastPlayer = PlayerOne;
           }
           var isWinner = CheckWinner();
           if (isWinner)
           {
                var result = MessageBox.Show(messageBoxText: "Vyhral hrac: " + LastPlayer + ", chces pokracovat?",
                    caption: "Pokravovat v hre",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    Button_0x0.Content = "";
                    Button_0x1.Content = "";
                    Button_0x2.Content = "";
                    Button_1x1.Content = "";
                    Button_1x2.Content = "";
                    Button_1x3.Content = "";
                    Button_2x1.Content = "";
                    Button_2x2.Content = "";
                    Button_2x3.Content = "";
                }
                else
                {
                    this.Close();
                }
            }
        }


        private void Button_0x0_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick(sender as Button);
        }

        public bool CheckWinner()
        {
            var b_00 = Button_0x0.Content.ToString();
            var b_01 = Button_0x1.Content.ToString();
            var b_02 = Button_0x2.Content.ToString();
            var b_11 = Button_1x1.Content.ToString();
            var b_12 = Button_1x2.Content.ToString();
            var b_13 = Button_1x3.Content.ToString();
            var b_21 = Button_2x1.Content.ToString();
            var b_22 = Button_2x2.Content.ToString();
            var b_23 = Button_2x3.Content.ToString();



            if ((b_00 == b_01 && b_01 == b_02) && (b_00 != "" && b_01 != "" && b_02 != ""))
            {
                return true;
            }

            if ((b_11 == b_12 && b_12 == b_13) && (b_11 != "" && b_12 != "" && b_13 != ""))
            {
                return true;
            }

            if ((b_21 == b_22 && b_22 == b_23) && (b_21 != "" && b_22 != "" && b_23 != ""))
            {
                return true;
            }

            if ((b_00 == b_11 && b_11 == b_21) && (b_00 != "" && b_11 != "" && b_21 != ""))
            {
                return true;
            }

            if ((b_01 == b_12 && b_12 == b_22) && (b_01 != "" && b_12 != "" && b_22 != ""))
            {
                return true;
            }

            if ((b_02 == b_13 && b_13 == b_23) && (b_02 != "" && b_13 != "" && b_23 != ""))
            {
                return true;
            }

            if ((b_21 == b_12 && b_12 == b_02) && (b_21 != "" && b_12 != "" && b_02 != ""))
            {
                return true;
            }

            if ((b_23 == b_12 && b_12 == b_00) && (b_23 != "" && b_12 != "" && b_00!= ""))
            {
                return true;
            }
            return false;
        }
    }
}