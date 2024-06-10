using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
using System.Windows.Threading;

namespace DC
{
    /// <summary>
    /// Interaction logic for WindowPlayScreen.xaml
    /// </summary>
    public partial class WindowPlayScreen : Window
    {
        private float score = 0.0f;
        private float counter = 0.0f;
        private float click = 1.0f;
        private float cost1 = 100.0f;
        private float cost2 = 100.0f;
        private float cost3 = 100.0f;
        private float cost4 = 100.0f;
        private DispatcherTimer timer;
        private DispatcherTimer refresh;
        public WindowPlayScreen()
        {
            InitializeComponent();
            InitializeTimer();
            Refresh();
        }
        private void Refresh()
        {
            refresh = new DispatcherTimer();
            refresh.Interval = TimeSpan.FromSeconds(0.05);
            refresh.Tick += Refresh_Tick;
            refresh.Start();
        }
        private void Refresh_Tick(object sender, EventArgs e)
        {
            counter += (int)0;
            score += (int)0;
            click += (int)0;
            CounterLabel.Content = "Ďugcookies: " + FormatNumber(counter);
            ScoreCounter.Content = "Score: " + FormatNumber(score);
            ClickCounter.Content = "Click value: " + FormatNumber(click);
            PriceLabel1.Content = "Price: " + FormatNumber(cost1);
        }

        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); 
            timer.Tick += Timer_Tick; 
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter += (int)250;
            score += (int)250;
            CounterLabel.Content = "Ďugcookies: " + FormatNumber(counter);
            ScoreCounter.Content = "Score: " + FormatNumber(score);
        }
        private void Window_KeyInput(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.I)
            {
                counter += (int)69420;
                click = 1;
                score = 0;

            }
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.O)
            {
                counter = (int)0;
                click = 1;
                score = 0;

            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter += (int)click;
            score += (int)click;

            CounterLabel.Content = "Ďugcookies: " + FormatNumber(counter);

            ClickCounter.Content = "Click value: " + FormatNumber(click);

            ScoreCounter.Content = "Score: " + FormatNumber(score);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (score < cost1 && counter < cost1 )
            { }
            else if (score >= cost1 && counter >= cost1)
            {

                counter -= cost1;
                score -= cost1;
                click *= 1.25f;
                cost1 *= 1.25f;
                ((Button)sender).IsEnabled = true;
                

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (score < 1500 && counter < cost2)
            {

            }
            else if (score >= 1500 && counter >= cost2)
            {
                
                counter -= 1000.0f;
                click += score * 0.005f;
                ((Button)sender).IsEnabled = false;

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (score < cost3 && counter < cost3) 
            { }
            else if (score >= cost3 && counter >= cost3)
            {
                
                timer.Start();
                ((Button)sender).IsEnabled = false;
            }

        }
        private string FormatNumber(float number)
        {
            
            if (number >= 1000000000000000000)
                return (number / 1000000000000000000).ToString("0.##Qi");
            if (number >= 1000000000000000)
                return (number / 1000000000000000).ToString("0.##T");
            if (number >= 1000000000000)
                return (number / 1000000000000).ToString("0.##T");
            if (number >= 1000000000)
                return (number / 1000000000).ToString("0.##B");
            if (number >= 1000000)
                return (number / 1000000).ToString("0.##M");
            else if (number >= 1000)
                return (number / 1000).ToString("0.##k");
            else
                return number.ToString("0");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
