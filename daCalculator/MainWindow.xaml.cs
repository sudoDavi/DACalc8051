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
                waveFrequency = float.Parse(FrequencyTextBox.Text),
                WaveType = WaveformComboBox.Text,
                waveVmax = float.Parse(VmaxTextBox.Text),
                waveVmin = float.Parse(VminTextBox.Text),
                waveResolution = int.Parse(DacResolTextBox.Text)
            };
            if(wave.WaveType == "Quadrada")
            {
                DacValuesTextBox.Text = wave.Square();
            }
            if (wave.WaveType == "Triangular")
                DacValuesTextBox.Text = wave.Triangle();
            
        }
    }
}
