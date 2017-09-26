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
    public class Util {
        public static Tipper TipperCalculator = new Tipper();
    }
    public sealed partial class MainPage : Page{
        public MainPage(){
            this.InitializeComponent();
            txtTrayWeightEmpty.Text = Util.TipperCalculator.Q9TrayWeightEmpty != 0 ? Convert.ToString(Util.TipperCalculator.Q9TrayWeightEmpty) : "";
            txtGrossTrayWeight.Text = Util.TipperCalculator.Q10GrossTrayWeightLoaded != 0 ? Convert.ToString(Util.TipperCalculator.Q10GrossTrayWeightLoaded) : "";
            txtDistanceBetweenPivotPoints.Text = Util.TipperCalculator.Q12DistanceBetweenPivotPoints!= 0 ? Convert.ToString(Util.TipperCalculator.Q12DistanceBetweenPivotPoints) : "";
            switch (Util.TipperCalculator.Q13CylinderStroke) {
                case 0:
                    cmbCylinderStroke.SelectedIndex = -1;
                    break;
                case 800:
                    cmbCylinderStroke.SelectedIndex = 0;
                    break;
                case 1000:
                    cmbCylinderStroke.SelectedIndex = 1;
                    break;
                case 1250:
                    cmbCylinderStroke.SelectedIndex = 2;
                    break;
                case 1500:
                    cmbCylinderStroke.SelectedIndex = 3;
                    break;
            }
            txtTrayLength.Text = Util.TipperCalculator.Q14TrayLength != 0 ? Convert.ToString(Util.TipperCalculator.Q14TrayLength) : "";
        }
        
        private void Button_Click(object sender, RoutedEventArgs e) { // Calculate Button
            
            if (txtTrayWeightEmpty.Text == "" || txtDistanceBetweenPivotPoints.Text == "" || txtGrossTrayWeight.Text == "" || txtTrayLength.Text == "" || cmbCylinderStroke.SelectedIndex == -1) {
                return;
            }
            Util.TipperCalculator.Q12DistanceBetweenPivotPoints = (float)Convert.ToDecimal(txtDistanceBetweenPivotPoints.Text);
            Util.TipperCalculator.Q10GrossTrayWeightLoaded = (float)Convert.ToDecimal(txtGrossTrayWeight.Text);
            Util.TipperCalculator.Q14TrayLength = (float)Convert.ToDecimal(txtTrayLength.Text);
            Util.TipperCalculator.Q9TrayWeightEmpty = (float)Convert.ToDecimal(txtTrayWeightEmpty.Text);
            Util.TipperCalculator.Q13CylinderStroke = (float)Convert.ToDecimal((cmbCylinderStroke.SelectedItem as ComboBoxItem).Content);

            for (int i = 0; i < 10; i++) {
                Util.TipperCalculator.Calculate();
            }
            this.Frame.Navigate(typeof(OutputPage));
        }

        private void DatasheetsButton_Click(object sender, RoutedEventArgs e) {
            try{
                Util.TipperCalculator.Q12DistanceBetweenPivotPoints = (float)Convert.ToDecimal(txtDistanceBetweenPivotPoints.Text);
                Util.TipperCalculator.Q10GrossTrayWeightLoaded = (float)Convert.ToDecimal(txtGrossTrayWeight.Text);
                Util.TipperCalculator.Q14TrayLength = (float)Convert.ToDecimal(txtTrayLength.Text);
                Util.TipperCalculator.Q9TrayWeightEmpty = (float)Convert.ToDecimal(txtTrayWeightEmpty.Text);
                Util.TipperCalculator.Q13CylinderStroke = (float)Convert.ToDecimal((cmbCylinderStroke.SelectedItem as ComboBoxItem).Content);
            }
            catch (Exception){
                
            }
            this.Frame.Navigate(typeof(DatasheetsPage));
        }
    }
}
