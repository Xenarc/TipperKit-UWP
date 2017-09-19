using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TipperKit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) { // Calculate Button
            Tipper TipperCalculator = new Tipper();
            if (txtTrayWeightEmpty.Text == "" || txtDistanceBetweenPivotPoints.Text == "" || txtGrossTrayWeight.Text == "" || txtTrayLength.Text == "" || cmbCylinderStroke.SelectedIndex == -1) {
                return;
            }
            TipperCalculator.Q12DistanceBetweenPivotPoints = (float)Convert.ToDecimal(txtDistanceBetweenPivotPoints.Text);
            TipperCalculator.Q10GrossTrayWeightLoaded = (float)Convert.ToDecimal(txtGrossTrayWeight.Text);
            TipperCalculator.Q14TrayLength = (float)Convert.ToDecimal(txtTrayLength.Text);
            TipperCalculator.Q9TrayWeightEmpty = (float)Convert.ToDecimal(txtTrayWeightEmpty.Text);
            TipperCalculator.Q13CylinderStroke = (float)Convert.ToDecimal((cmbCylinderStroke.SelectedItem as ComboBoxItem).Content);

            for (int i = 0; i < 10; i++) {
                TipperCalculator.Calculate();
            }

            if (TipperCalculator.Calculate()) btnCalcluate.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(50, 50, 255, 50));
            if (!TipperCalculator.Calculate()) btnCalcluate.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(50, 255, 50, 50));
            this.Frame.Navigate(typeof(OutputPage));
        }
    }
}
