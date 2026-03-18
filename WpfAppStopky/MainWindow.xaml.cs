using System;
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

namespace WpfAppStopky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        DateTime startTime;
        DateTime stopTime;
        TimeSpan elapsed;

        public MainWindow()
        {
            InitializeComponent();

            // Po spustení budú tieto prvky vypnuté
            StopButton.IsEnabled = false;
            TipTextBox.IsEnabled = false;
            CheckTipButton.IsEnabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;

            StartButton.IsEnabled = false;
            StopButton.IsEnabled = true;

            ResultLabel.Content = "";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            stopTime = DateTime.Now;

            elapsed = stopTime - startTime;

            ResultLabel.Content = "Nameraný čas: " +
                               elapsed.TotalMilliseconds + " ms";

            TipTextBox.IsEnabled = true;
            CheckTipButton.IsEnabled = true;

            StopButton.IsEnabled = false;
        }

        private void CheckTipButton_Click(object sender, EventArgs e)
        {
            double tip;

            if (double.TryParse(TipTextBox.Text, out tip))
            {
                double realTime = elapsed.TotalMilliseconds;
                double difference = Math.Abs(realTime - tip);

                ResultLabel.Content +=
                    "\nTvoj tip bol o " + difference + " ms vedľa.";
            }
            else
            {
                MessageBox.Show("Zadaj platné číslo!");
            }
        }
    }
}