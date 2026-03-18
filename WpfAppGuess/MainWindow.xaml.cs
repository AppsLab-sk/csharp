using System;
using System.Windows;

namespace secondwpf
{
    public partial class MainWindow : Window
    {
        private int secret;
        private int attempts;
        private int lastDistance;
        private bool firstGuess;
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            secret = random.Next(0, 101); // 0–100
            attempts = 0;
            firstGuess = true;
            lastDistance = 0;

            TextBox_number.IsEnabled = true;
            TextBox_number.Text = "";
            Info.Text = "";
            Guesses.Text = "0";
        }

        private void Button_Click_Test(object sender, RoutedEventArgs e)
        {
            int guess;

            // kontrola či je číslo
            if (!int.TryParse(TextBox_number.Text, out guess))
            {
                Info.Text = "Enter number!";
                return;
            }

            // kontrola rozsahu
            if (guess < 0 || guess > 100)
            {
                Info.Text = "0 - 100 only!";
                return;
            }

            attempts++;
            Guesses.Text = attempts.ToString();

            // výhra
            if (guess == secret)
            {
                Info.Text = "Correct!";
                TextBox_number.IsEnabled = false;
                return;
            }

            int distance = Math.Abs(secret - guess);

            if (firstGuess)
            {
                if (guess < secret)
                    Info.Text = "Higher!";
                else
                    Info.Text = "Lower!";

                firstGuess = false;
            }
            else
            {
                if (distance < lastDistance)
                    Info.Text = "Warmer!";
                else if (distance > lastDistance)
                    Info.Text = "Colder!";
                else
                    Info.Text = "Same distance!";
            }

            lastDistance = distance;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }
    }
}
