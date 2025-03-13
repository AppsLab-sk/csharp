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

namespace WPF_TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //premenne
        public char LastPlayer { get; set; } = '〇';
        public char PlayerOne { get; set; } = '✕';
        public char PlayerTwo { get; set; } = '〇';

        public MainWindow()
        {
            InitializeComponent();
        }

        //Spracovavanie kliknutia hociakeho tlacidla
        public void ProcessClick(Button button)
        {
            
            //Strieda hracov
            var buttonContent = button.Content.ToString();
            if (buttonContent.Contains(PlayerOne) || buttonContent.Contains(PlayerTwo))
            {
                return;
            }

            if (LastPlayer == PlayerOne)
            {
                PlayerMark.Content = "✕";
                button.Content = PlayerTwo;
                LastPlayer = PlayerTwo;
            }
            else if (LastPlayer == PlayerTwo)
            {
                PlayerMark.Content = "〇";
                button.Content = PlayerOne;
                LastPlayer = PlayerOne;
            }

            var isWinner = CHeckWinner();
            var isFull = CheckIsFull();

            //Kontroluje ci je vitaz
            if (isWinner)
            {
                var result = MessageBox.Show(messageBoxText: "Vyhral hrac: " + LastPlayer + ", chcete pokracovat?",
                    caption: "Pokracovat v hre",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    Button_0x0.Content = "";
                    Button_0x1.Content = "";
                    Button_0x2.Content = "";
                    Button_1x0.Content = "";
                    Button_1x1.Content = "";
                    Button_1x2.Content = "";
                    Button_2x0.Content = "";
                    Button_2x1.Content = "";
                    Button_2x2.Content = "";
                }
                else
                {
                    this.Close();
                }      
            }
            else //Kontroluje ci je plne
            {
                if (isFull)
                {
                    var result = MessageBox.Show(messageBoxText: "Remiza, chcete pokracovat?",
                    caption: "Pokracovat v hre",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information);
                    if (result == MessageBoxResult.Yes)
                    {
                        Button_0x0.Content = "";
                        Button_0x1.Content = "";
                        Button_0x2.Content = "";
                        Button_1x0.Content = "";
                        Button_1x1.Content = "";
                        Button_1x2.Content = "";
                        Button_2x0.Content = "";
                        Button_2x1.Content = "";
                        Button_2x2.Content = "";
                    }
                    else
                    {
                        this.Close();
                    }
                }
              
            }
        }

        //Pri kliknuti tlacidla
        private void Button_0x0_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick(sender as Button);
        }

        //Kontroluje vitaza
        public bool CHeckWinner()
        {
            var b_0x0 = Button_0x0.Content.ToString();
            var b_0x1 = Button_0x1.Content.ToString();
            var b_0x2 = Button_0x2.Content.ToString();
            var b_1x0 = Button_1x0.Content.ToString();
            var b_1x1 = Button_1x1.Content.ToString();
            var b_1x2 = Button_1x2.Content.ToString();
            var b_2x0 = Button_2x0.Content.ToString();
            var b_2x1 = Button_2x1.Content.ToString();
            var b_2x2 = Button_2x2.Content.ToString();

            //kontrola prveho stlpca
            if ((b_0x0 == b_0x1 && b_0x1 == b_0x2) && (b_0x0 != "" && b_0x1 != "" && b_0x2 != ""))
            {
                return true;
            }
            //kontrola druheho stlpca
            else if ((b_1x0 == b_1x1 && b_1x1 == b_1x2) && (b_1x0 != "" && b_1x1 != "" && b_1x2 != ""))
            {
                return true;
            }
            //kontrola tretieho stlpca
            else if ((b_2x0 == b_2x1 && b_2x1 == b_2x2) && (b_2x0 != "" && b_2x1 != "" && b_2x2 != ""))
            {
                return true;
            }

            //kontrola prveho riadku
            else if ((b_0x0 == b_1x0 && b_1x0 == b_2x0) && (b_0x0 != "" && b_1x0 != "" && b_2x0 != ""))
            {
                return true;
            }

            //kontrola druheho riadku
            else if ((b_0x1 == b_1x1 && b_1x1 == b_2x1) && (b_0x1 != "" && b_1x1 != "" && b_2x1 != ""))
            {
                return true;
            }

            //kontrola tretieho riadku
            else if ((b_0x2 == b_1x2 && b_1x2 == b_2x2) && (b_0x2 != "" && b_1x2 != "" && b_2x2 != ""))
            {
                return true;
            }

            //kontrola diagonalne 1
            else if ((b_0x0 == b_1x1 && b_1x1 == b_2x2) && (b_0x0 != "" && b_1x1 != "" && b_2x2 != ""))
            {
                return true;
            }

            //kontrola diagonalne 2
            else if ((b_2x0 == b_1x1 && b_1x1 == b_0x2) && (b_2x0 != "" && b_1x1 != "" && b_0x2 != ""))
            {
                return true;
            }
            else
            {
                CheckIsFull();
            }

            return false;
        }

        //Kod pre resetovacie tlacidlo
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Button_0x0.Content = "";
            Button_0x1.Content = "";
            Button_0x2.Content = "";
            Button_1x0.Content = "";
            Button_1x1.Content = "";
            Button_1x2.Content = "";
            Button_2x0.Content = "";
            Button_2x1.Content = "";
            Button_2x2.Content = "";
        }

        //Kontroluje ci je plne
        public bool CheckIsFull()
        {
            var b_0x0 = Button_0x0.Content.ToString();
            var b_0x1 = Button_0x1.Content.ToString();
            var b_0x2 = Button_0x2.Content.ToString();
            var b_1x0 = Button_1x0.Content.ToString();
            var b_1x1 = Button_1x1.Content.ToString();
            var b_1x2 = Button_1x2.Content.ToString();
            var b_2x0 = Button_2x0.Content.ToString();
            var b_2x1 = Button_2x1.Content.ToString();
            var b_2x2 = Button_2x2.Content.ToString();

            if (b_0x0 != "" && b_0x1 != "" && b_0x2 != "" && b_1x0 != "" && b_1x1 != "" && b_1x2 != "" && b_2x0 != "" && b_2x1 != "" && b_2x2 != "")
            {
                return true;
            }
            return false;
        }
    }
}