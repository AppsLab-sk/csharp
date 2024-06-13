using System;
using System.Windows;
using System.Windows.Threading;

namespace stopwatch1
{
    public partial class stopwatch : Window
    {
        private DispatcherTimer timer;
        private DateTime startTime;
        private TimeSpan elapsedTime;

        public stopwatch()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
            elapsedTime = TimeSpan.Zero;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            startTime = DateTime.Now - elapsedTime;
            timer.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            elapsedTime = DateTime.Now - startTime;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            elapsedTime = TimeSpan.Zero;
            TimerText.Text = "00:00:00.0";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - startTime;
            TimerText.Text = elapsedTime.ToString(@"hh\:mm\:ss\.f");
        }
    }
}