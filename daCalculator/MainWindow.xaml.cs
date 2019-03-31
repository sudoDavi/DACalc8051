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

namespace daCalculator8051
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        Wave wave;
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            wave = new Wave()
            {            
                WaveType = WaveformComboBox.Text,
                waveVmax = float.Parse(VmaxTextBox.Text),
                waveVmin = float.Parse(VminTextBox.Text),
                waveResolution = int.Parse(DacResolTextBox.Text),
                waveFrequency = float.Parse(FrequencyTextBox.Text)
            };
            if(wave.WaveType == "Quadrada")
            {
                DacValuesTextBox.Text = wave.Square();
            }
            if (wave.WaveType == "Triangular")
                DacValuesTextBox.Text = wave.Triangle();
            if (wave.WaveType == "Senoidal")
                DacValuesTextBox.Text = wave.Sin();
        }

        private void WaveformComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WaveformComboBox.Text == "Senoidal")
                FrequencyGrid.Visibility = Visibility.Visible;
            else
                FrequencyGrid.Visibility = Visibility.Hidden;
        }
    }
}
