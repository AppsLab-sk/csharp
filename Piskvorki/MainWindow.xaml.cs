using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
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

namespace Piskvorki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char Lastplayer { get; set; } = '◯';

        public char PlayerOne { get; set; } = '✕';

        public char PlayerTwo { get; set; } = '◯';


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
            if (Lastplayer == PlayerOne)
            {
                button.Content = PlayerTwo;
                button.Background = new SolidColorBrush(Colors.Blue);
                Lastplayer = PlayerTwo;
            }
            else if (Lastplayer == PlayerTwo)
            {
                button.Content = PlayerOne;
                button.Background = new SolidColorBrush(Colors.Red);
                Lastplayer = PlayerOne;
            }
            var Iswinner = CheckWinner();
            if (Iswinner)
            {
                var result = MessageBox.Show("Vyhral hrac: " + Lastplayer,
                "Vyhral hrac",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);


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

                    Button_0x0.Background = new SolidColorBrush(Colors.Tan);
                    Button_0x1.Background = new SolidColorBrush(Colors.Tan);
                    Button_0x2.Background = new SolidColorBrush(Colors.Tan);
                    Button_1x0.Background = new SolidColorBrush(Colors.Tan);
                    Button_1x1.Background = new SolidColorBrush(Colors.Tan);
                    Button_1x2.Background = new SolidColorBrush(Colors.Tan);
                    Button_2x0.Background = new SolidColorBrush(Colors.Tan);
                    Button_2x1.Background = new SolidColorBrush(Colors.Tan);
                    Button_2x2.Background = new SolidColorBrush(Colors.Tan);

                }
                else
                {
                    this.Close();
                }
            }
            bool isFull = CheckFull();
            if (isFull)
            {
                MessageBox.Show("Remiza");
                this.Close();
            }
        }

        private bool CheckFull()
        {
            var button0 = Button_0x0.Content.ToString();
            var button1 = Button_0x1.Content.ToString();
            var button2 = Button_0x2.Content.ToString();
            var button3 = Button_1x0.Content.ToString();
            var button4 = Button_1x1.Content.ToString();
            var button5 = Button_1x2.Content.ToString();
            var button6 = Button_2x0.Content.ToString();
            var button7 = Button_2x1.Content.ToString();
            var button8 = Button_2x2.Content.ToString();

            if (button0 != "" && button1 != "" && button2 != ""
                && button3 != "" && button4 != "" && button5 != "" &&
                button6 != "" && button7 != "" && button8 != "")
            {
                return true;
            }
            return false;
        }

           
        
       
        private void Button_0x0_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick(sender as Button);
        }
        public bool CheckWinner()
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

            if (b_0x0 == b_0x1 && b_0x0 == b_0x2 && b_0x2 != "")   //kontrola prveho riadku
            {
                return true;
            }
            else if (b_1x0 == b_1x1 && b_1x0 == b_1x2 && b_1x2 != "") // druhy
            {
                return true;
            }
            else if (b_2x0 == b_2x1 && b_2x0 == b_2x2 && b_2x2 != "") // treti
            {
                return true;
            }
            else if (b_0x0 == b_1x1 && b_0x0 == b_2x2 && b_2x2 != "") //diagonal 1
            {
                return true;
            }
            else if (b_2x0 == b_1x1 && b_2x0 == b_0x2 && b_0x2 != "") // diagonal 2
            {
                return true;
            }
            else if (b_0x0 == b_1x0 && b_0x0 == b_2x0 && b_2x0 != "") //stlpec 1 
            {
                return true;
            }
            else if (b_0x1 == b_1x1 && b_0x1 == b_2x1 && b_2x1 != "") //stlpec 2 
            {
                return true;
            }
            else if (b_0x2 == b_1x2 && b_0x2 == b_2x2 && b_2x2 != "") // stlpec 3
            {
                return true;
            }
            return false;



        }
    }
}