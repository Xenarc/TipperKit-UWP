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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TipperKit {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OutputPage : Page {
        public OutputPage() {
            this.InitializeComponent();
            //Texts
            TFmaxGtY2.Text = Util.TipperCalculator.T37FmaxGtY2 ? "Acceptable" : "Unacceptable";
            TPLsPmax.Text = Util.TipperCalculator.T38PLsPmax ? "Acceptable" : "Unacceptable";
            TdGt39Lt58.Text = Util.TipperCalculator.T48dGt39Lt58 ? "Acceptable" : "Unacceptable";
            TTactLtTmax.Text = Util.TipperCalculator.T39TactLtTmax ? "Acceptable" : "Unacceptable";
            TSrh6L.Text = Util.TipperCalculator.T41Srh6L ? "Acceptable" : "Unacceptable";
            TSSH10.Text = Util.TipperCalculator.T42SSH10L ? "Acceptable" : "Unacceptable";
            TSSH15l.Text = Util.TipperCalculator.T43SSH15l ? "Acceptable" : "Unacceptable";

            //Backgrounds
            BGFmaxGtY2.Background = Util.TipperCalculator.T37FmaxGtY2 ? new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 0)) : new SolidColorBrush(Windows.UI.Colors.Red);
            BGPLsPmax.Background = Util.TipperCalculator.T38PLsPmax ? new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 0)) : new SolidColorBrush(Windows.UI.Colors.Red);
            BGdGt39Lt58.Background = Util.TipperCalculator.T48dGt39Lt58 ? new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 0)) : new SolidColorBrush(Windows.UI.Colors.Red);
            BGTactLtTmax.Background = Util.TipperCalculator.T39TactLtTmax ? new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 0)) : new SolidColorBrush(Windows.UI.Colors.Red);
            BGSrh6L.Background = Util.TipperCalculator.T41Srh6L ? new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 0)) : new SolidColorBrush(Windows.UI.Colors.Red);
            BGSSH10.Background = Util.TipperCalculator.T42SSH10L ? new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 0)) : new SolidColorBrush(Windows.UI.Colors.Red);
            BGSSH15l.Background = Util.TipperCalculator.T43SSH15l ? new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 255, 0)) : new SolidColorBrush(Windows.UI.Colors.Red);
        }

        private void btnRealcluate_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btnRealcluate_Copy_Click(object sender, RoutedEventArgs e) {
            //this.Frame.Navigate(typeof(GenerateReportPage));
        }
    }
}
