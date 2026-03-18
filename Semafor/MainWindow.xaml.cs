using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Semafor
{
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _timer = new DispatcherTimer();
        private int _currentIndex = 0; // 0..2

        private readonly Brush _off = Brushes.DimGray;
        private readonly Brush _on = Brushes.Red;

        public MainWindow()
        {
            InitializeComponent();

            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;

            SetAllOff();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;
            StopButton.IsEnabled = true;
            ResetButton.IsEnabled = false;

            _timer.Start();
            ShowOnly(_currentIndex);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();

            StartButton.IsEnabled = true;
            StopButton.IsEnabled = false;
            ResetButton.IsEnabled = true;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _currentIndex = 0;
            SetAllOff();

            StartButton.IsEnabled = true;
            StopButton.IsEnabled = false;
            ResetButton.IsEnabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // posun index
            _currentIndex++;
            if (_currentIndex > 2)
            {
                _currentIndex = 0;
            }
            ShowOnly(_currentIndex);
        }
        private void SetAllOff()
        {
            Light1.Fill = _off;
            Light2.Fill = _off;
            Light3.Fill = _off;
        }

        private void ShowOnly(int index)
        {
            SetAllOff();
            if (index == 0) Light1.Fill = _on;
            if (index == 1) Light2.Fill = _on;
            if (index == 2) Light3.Fill = _on;
        }
    }
}