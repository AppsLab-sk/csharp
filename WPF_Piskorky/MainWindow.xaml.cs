using System.Diagnostics.Eventing.Reader;
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

namespace WPF_Piskorky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char LastPlayer { get; set; } = '☼';

        public char PlayerOne { get; set; } = '☽';

        public char PlayerTwo { get; set; } = '☼';

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
                button.Background = new SolidColorBrush(Colors.Green);
                LastPlayer = PlayerTwo;

            }

            else if (LastPlayer == PlayerTwo)
            {
                button.Content = PlayerOne;
                button.Background = new SolidColorBrush(Colors.Blue);
                LastPlayer = PlayerOne;


            }
            var isWinner = CheckWinner();
            if (isWinner)
            {

                var result = MessageBox.Show("Vyhral hrac:" + LastPlayer +
                    Environment.NewLine + "Chces novu hru?",
                    "Vyhral hrac",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information);

                if (result == MessageBoxResult.Yes)
                {
                    Button0.Content = "";
                    Button1.Content = "";
                    Button2.Content = "";
                    Button3.Content = "";
                    Button4.Content = "";
                    Button5.Content = "";
                    Button6.Content = "";
                    Button7.Content = "";
                    Button8.Content = "";
                    Button0.Background = new SolidColorBrush(Colors.White);
                    Button1.Background = new SolidColorBrush(Colors.White);
                    Button2.Background = new SolidColorBrush(Colors.White);
                    Button3.Background = new SolidColorBrush(Colors.White);
                    Button4.Background = new SolidColorBrush(Colors.White);
                    Button5.Background = new SolidColorBrush(Colors.White);
                    Button6.Background = new SolidColorBrush(Colors.White);
                    Button7.Background = new SolidColorBrush(Colors.White);
                    Button8.Background = new SolidColorBrush(Colors.White);
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
            var button0 = Button0.Content.ToString();
            var button1 = Button1.Content.ToString();
            var button2 = Button2.Content.ToString();
            var button3 = Button3.Content.ToString();
            var button4 = Button4.Content.ToString();
            var button5 = Button5.Content.ToString();
            var button6 = Button6.Content.ToString();
            var button7 = Button7.Content.ToString();
            var button8 = Button8.Content.ToString();

            if (button0 != "" && button1 != "" && button2 != ""
                && button3 != "" && button4 != "" && button5 != "" &&
                button6 != "" && button7 != "" && button8 != "")
            {
                return true;
            }
            return false;
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick(sender as Button);
        }

        public bool CheckWinner()
        {
            var button0 = Button0.Content.ToString();
            var button1 = Button1.Content.ToString();
            var button2 = Button2.Content.ToString();
            var button3 = Button3.Content.ToString();
            var button4 = Button4.Content.ToString();
            var button5 = Button5.Content.ToString();
            var button6 = Button6.Content.ToString();
            var button7 = Button7.Content.ToString();
            var button8 = Button8.Content.ToString();

            // Kontrola prveho riadku
            if (button0 == button1 && button1 == button2 && button2 != "")
            {
                return true;
            }
            if (button3 == button4 && button4 == button5 && button3 != "")
            {
                return true;
            }
            if (button6 == button7 && button7 == button8 && button6 != "")
            {
                return true;
            }
            if (button0 == button3 && button3 == button6 && button3 != "")
            {
                return true;
            }
            if (button1 == button4 && button4 == button7 && button4 != "")
            {
                return true;
            }
            if (button0 == button4 && button4 == button8 && button4 != "")
            {
                return true;
            }
            if (button2 == button4 && button4 == button6 && button4 != "")
            {
                return true;
            }
            return false;
        }
    }

}