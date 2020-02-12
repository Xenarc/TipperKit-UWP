using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows;
using Windows.ApplicationModel.Email;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.Storage.Pickers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TipperKit {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GenerateAndSendReportPage : Page
    {
        public GenerateAndSendReportPage(){
            this.InitializeComponent();
            Send.IsChecked = true;
            GenerateReport();
            Webview1.NavigateToString(htmlOUT);
        }
        public string htmlOUT;
        private async void GenerateReport(){
            htmlOUT = ("<!DOCTYPE html><html><head><style media=screen>a,abbr,acronym,address,applet,article,aside,audio,b,big,blockquote,body,canvas,caption,center,cite,code,dd,del,details,dfn,div,dl,dt,em,embed,fieldset,figcaption,figure,footer,form,h1,h2,h3,h4,h5,h6,header,hgroup,html,i,iframe,img,ins,kbd,label,legend,li,mark,menu,nav,object,ol,output,p,pre,q,ruby,s,samp,section,small,span,strike,strong,sub,summary,sup,table,tbody,td,tfoot,th,thead,time,tr,tt,u,ul,var,video{margin:0;padding:0;border:0;font-size:100%;font:inherit;vertical-align:baseline}article,aside,details,figcaption,figure,footer,header,hgroup,menu,nav,section{display:block}body{line-height:1}ol,ul{list-style:none}blockquote,q{quotes:none}blockquote:after,blockquote:before,q:after,q:before{content:'';content:none}table{border-collapse:collapse;border-spacing:0}*{background-color:#131313;margin:0;padding:0}.Vals2ManT{background-color:#dbad20;color:#000;padding:2px;display:inline-block;width:75%;text-align:left;float:left;font-size:12px}.Vals4ManV{background-color:#dbad20;color:#000;padding:2px;display:inline-block;width:9%;float:center;margin:0 1px;font-size:12px}.Vals4ManT{background-color:#dbad20;color:#000;padding:2px;display:inline-block;width:63%;text-align:left;float:left;font-size:12px}.Vals3FixV{background-color:#639144;color:#fff;padding:2px;display:inline-block;width:9%;float:center;margin:0 1px;font-size:12px}.Vals3FixT{background-color:#639144;color:#fff;padding:2px;display:inline-block;width:75%;text-align:left;float:left;font-size:12px}.Vals3RefV{background-color:#32cddb;color:#000;padding:2px;display:inline-block;width:9%;float:center;margin:0 1px;font-size:12px}.Vals3RefT{background-color:#32cddb;color:#000;padding:2px;display:inline-block;width:75%;text-align:left;float:left;font-size:12px}.Vals3RLV{background-color:#7f0bc6;color:#fff;padding:2px;display:inline-block;width:9%;float:center;margin:0 1px;font-size:12px}.Vals3RLT{background-color:#7f0bc6;color:#fff;padding:2px;display:inline-block;width:75%;text-align:left;float:left;font-size:12px}</style></head>#<body style=margin:0;padding:0><div style=\"max-width:980px;margin:auto;font-family:'Segoe UI Light',Verdana,Arial,sans-serif;background-color:#222;color:#fff;padding:.5%;background-color:#222\"><div style=font-size:12pt><div style=clear:both><h2 style=padding:1%;clear:both;background-color:#00f;float:left>Cylinder Part Number:</h2><h2 style=background-color:#00f;padding:1%;text-align:right;padding-right:2%>VALUE1</h2></div><div style=margin-top:1%;clear:both><h2 style=padding:1%;clear:both;background-color:#00f;float:left>Tipper Kit Part Number:</h2><h2 style=background-color:#00f;padding:1%;text-align:right;padding-right:2%>VALUE2</h2></div></div><div style=clear:both><h1 style=margin-top:1.5%;padding:1%;clear:both;background-color:COLOUR3;text-align:center;color:#000;float:left;width:98%>VALUE3</h1></div><h4 style=padding:2%;clear:both;text-align:center>VALUE4</h4><div><h3 style=margin:0;margin-bottom:1%;text-align:center;background-color:#333;padading:.5%>Key</h3><div><h3 style=margin:0;display:inline-block;float:left;width:49%;background-color:red;color:#000;text-align:center;padding:.5%>NOT Acceptable</h3><h3 style=margin:0;margin-bottom:1%;display:inline-block;width:49%;background-color:#0f0;color:#000;text-align:center;padding:.5%>Acceptable</h3></div></div><div style=text-align:center><div style=height:auto;clear:both><h3 style=margin-bottom:5px;padding:.5%;height:46pt;background-color:#333;display:inline-block;width:69%>Is Cylinder Force Acceptable For Application?</h3><h3 style=padding:.5%;text-align:center;line-height:46pt;height:46pt;float:right;display:inline-block;width:29%;background-color:COLOUR5;color:#000>VALUE5</h3></div><div style=height:auto;clear:both><h3 style=margin-bottom:5px;padding:.5%;height:46pt;background-color:#333;display:inline-block;width:69%>Is Cylinder Pressure Acceptable For Application?</h3><h3 style=padding:.5%;text-align:center;line-height:46pt;height:46pt;float:right;display:inline-block;width:29%;background-color:COLOUR6;color:#000>VALUE6</h3></div><div style=height:auto;clear:both><h3 style=margin-bottom:5px;padding:.5%;height:46pt;background-color:#333;display:inline-block;width:69%>Is Tipping Angle Acceptable For Application?</h3><h3 style=padding:.5%;text-align:center;line-height:46pt;height:46pt;float:right;display:inline-block;width:29%;background-color:COLOUR7;color:#000>VALUE7</h3></div><div style=height:auto;clear:both><h3 style=margin-bottom:5px;padding:.5%;height:46pt;background-color:#333;display:inline-block;width:69%>Is Cylinder Location Acceptable?</h3><h3 style=padding:.5%;text-align:center;line-height:46pt;height:46pt;float:right;display:inline-block;width:29%;background-color:COLOUR8;color:#000>VALUE8</h3></div></div><div style=margin-bottom:1%><h3 style=margin:0;padding:.5%;margin-right:.5%;background-color:#333;text-align:center;line-height:46pt;float:left;display:inline-block;width:39%>6L SRH (Option)</h3><div style=display:inline-block;width:29%><h4 style=padding:.5%;background-color:#333;display:block;line-height:24pt;text-align:center>Tank Vol. (usable)</h4><h4 style=padding:.5%;background-color:#444;display:block;line-height:24pt;text-align:center>5.2</h4></div><h3 style=padding:.5%;text-align:center;float:right;display:inline-block;line-height:46pt;background-color:COLOUR9;color:#000;width:29%>VALUE9</h3></div><div style=margin-bottom:5px><h3 style=margin:0;padding:.5%;margin-right:.5%;background-color:#333;text-align:center;line-height:46pt;float:left;display:inline-block;width:39%>10L SSH (Standard)</h3><div style=display:inline-block;width:29%><h4 style=padding:.5%;background-color:#333;display:block;line-height:24pt;text-align:center>Tank Vol. (usable)</h4><h4 style=padding:.5%;background-color:#444;display:block;line-height:24pt;text-align:center>8.5</h4></div><h3 style=padding:.5%;text-align:center;float:right;display:inline-block;line-height:46pt;background-color:COLOUR10;color:#000;width:29%>VALUE10</h3></div><h3 style=margin:0;padding:.5%;margin-right:.5%;background-color:#333;text-align:center;line-height:46pt;float:left;display:inline-block;width:39%>15L SSH (Option)</h3><div style=margin-bottom:1%><div style=display:inline-block;width:29%><h4 style=padding:.5%;background-color:#333;display:block;line-height:24pt;text-align:center>Tank Vol. (usable)</h4><h4 style=padding:.5%;background-color:#444;display:block;line-height:24pt;text-align:center>13.5</h4></div><h3 style=padding:.5%;text-align:center;float:right;display:inline-block;line-height:46pt;background-color:COLOUR11;color:#000;width:29%>VALUE11</h3></div><div style=\"clear:both;text-align:center;font-family:'Segoe UI',Verdana,Arial,sans-serif\"><h3 style=\"font-family:'Segoe UI Light';margin-bottom:4px;background-color:#dbad20;color:#000;padding:.2%\">Manually Inputed</h3><div style=margin-bottom:4px><div class=Vals2ManT>Tray Weight (Empty)</div><div class=Vals4ManV>VALUE12</div><div class=Vals4ManV>kg</div></div><div style=margin-bottom:4px><div class=Vals2ManT>Gross Tray Weight (Loaded)</div><div class=Vals4ManV>VALUE13</div><div class=Vals4ManV>kg</div></div><div style=margin-bottom:4px><div class=Vals4ManT>Distance Between Pivot Points</div><div class=Vals4ManV>L1</div><div class=Vals4ManV>VALUE14</div><div class=Vals4ManV>mm</div></div><div style=margin-bottom:4px><div class=Vals4ManT>Center of Gravity</div><div class=Vals4ManV>L2</div><div class=Vals4ManV>VALUE16</div><div class=Vals4ManV>mm</div></div><div style=margin-bottom:4px><div class=Vals4ManT>Cylinder Stroke</div><div class=Vals4ManV>L3</div><div class=Vals4ManV>VALUE17</div><div class=Vals4ManV>mm</div></div><div style=margin-bottom:4px><div class=Vals4ManT>Tray Length</div><div class=Vals4ManV>L4</div><div class=Vals4ManV>VALUE17</div><div class=Vals4ManV>mm</div></div><div><div class=Vals4ManT>Tipping Angle</div><div class=Vals4ManV>Tilt</div><div class=Vals4ManV>VALUE18</div><div class=Vals4ManV>d</div></div></div><div style=\"margin-top:1%;clear:both;text-align:center;font-family:'Segoe UI',Verdana,Arial,sans-serif\"><h3 style=\"font-family:'Segoe UI Light';margin-bottom:4px;background-color:#639144;color:#fff;padding:.2%\">Fixed Values</h3><div><div style=margin-bottom:4px><div class=Vals3FixT>Max Working Pressure of Cylinder (Pmax)</div><div class=Vals3FixV>VALUE19</div><div class=Vals3FixV>Bar</div></div><div><div style=margin-bottom:4px><div class=Vals3FixT>Flow Rate of Power Pack (Raise)</div><div class=Vals3FixV>VALUE20</div><div class=Vals3FixV>I/min</div></div></div><div><div style=margin-bottom:4px><div class=Vals3FixT>Flow Rate of Power Pack (Lower)</div><div class=Vals3FixV>VALUE21</div><div class=Vals3FixV>I/min</div></div></div><div style=\"margin-top:1%;clear:both;text-align:center;font-family:'Segoe UI',Verdana,Arial,sans-serif\"><h3 style=\"font-family:'Segoe UI Light';margin-bottom:4px;background-color:#32cddb;color:#000;padding:.2%\">Referenced Values</h3><div><div style=margin-bottom:4px><div class=Vals3RefT>Stroke Volume of Cylinder</div><div class=Vals3RefV>VALUE22</div><div class=Vals3RefV>I</div></div><div><div style=margin-bottom:4px><div class=Vals3RefT>Overall Cylinder Diamter</div><div class=Vals3RefV>VALUE23</div><div class=Vals3RefV>mm</div></div><div><div class=Vals3RefT>Smallest Rod Diameter</div><div class=Vals3RefV>VALUE24</div><div class=Vals3RefV>mm</div></div></div></div></div><div style=\"margin-top:1%;clear:both;text-align:center;font-family:'Segoe UI',Verdana,Arial,sans-serif\"><h3 style=\"font-family:'Segoe UI Light';margin-bottom:4px;background-color:#7f0bc6;color:#fff;padding:.2%\">Power Pack Raise / Lower Times</h3><div><div><div style=margin-bottom:4px><div class=Vals3RLT>Power Pack Raise Time</div><div class=Vals3RLV>VALUE25</div><div class=Vals3RLV>sec</div></div><div><div class=Vals3RLT>Power Pack Lower Time</div><div class=Vals3RLV>VALUE26</div><div class=Vals3RLV>sec</div></div></div></div></div></div></div></div></body></html>")
                                .Replace("COLOUR11", Convert.ToString(Util.TipperCalculator.T43SSH15l ? "#00FF00" : "#FF0000"))
                                .Replace("COLOUR10", Convert.ToString(Util.TipperCalculator.T42SSH10L ? "#00FF00" : "#FF0000"))
                                .Replace("COLOUR9", Convert.ToString(Util.TipperCalculator.T41Srh6L ? "#00FF00" : "#FF0000"))
                                .Replace("COLOUR8", Convert.ToString(Util.TipperCalculator.T39TactLtTmax ? "#00FF00" : "#FF0000"))
                                .Replace("COLOUR7", Convert.ToString(Util.TipperCalculator.T48dGt39Lt58 ? "#00FF00" : "#FF0000"))
                                .Replace("COLOUR6", Convert.ToString(Util.TipperCalculator.T38PLsPmax ? "#00FF00" : "#FF0000"))
                                .Replace("COLOUR5", Convert.ToString(Util.TipperCalculator.T37FmaxGtY2 ? "#00FF00" : "#FF0000"))
                                .Replace("COLOUR3", Convert.ToString(Util.TipperCalculator.T68OverallApplicationSetup ? "#00FF00" : "#FF0000"))
                                .Replace("VALUE26", Convert.ToString(Math.Round(Util.TipperCalculator.Q84PowerPackRaiseLowerTimeL, 0)))
                                .Replace("VALUE25", Convert.ToString(Math.Round(Util.TipperCalculator.Q83PowerPackRaiseLowerTimeR, 0)))
                                .Replace("VALUE24", Convert.ToString(Util.TipperCalculator.Q25SmallestRodDiameter))
                                .Replace("VALUE23", Convert.ToString(Util.TipperCalculator.Q24OverallCylinderDiameter))
                                .Replace("VALUE22", Convert.ToString(Util.TipperCalculator.Q23StrokeVolumeOfCylinder))
                                .Replace("VALUE21", Convert.ToString(Util.TipperCalculator.Q19FlowRateOfPowerPackLower))
                                .Replace("VALUE20", Convert.ToString(Util.TipperCalculator.Q18FlowRateOfPowerPackRaise))
                                .Replace("VALUE19", Convert.ToString(Util.TipperCalculator.Q17MaxWorkingPressureOfCylinder))
                                .Replace("VALUE18", Convert.ToString(Math.Round(Util.TipperCalculator.Q15TippingAngle, 0)))
                                .Replace("VALUE17", Convert.ToString(Util.TipperCalculator.Q14TrayLength))
                                .Replace("VALUE16", Convert.ToString(Util.TipperCalculator.Q13CylinderStroke))
                                .Replace("VALUE15", Convert.ToString(Util.TipperCalculator.Q11CenterOfGravity))
                                .Replace("VALUE14", Convert.ToString(Util.TipperCalculator.Q12DistanceBetweenPivotPoints))
                                .Replace("VALUE13", Convert.ToString(Util.TipperCalculator.Q10GrossTrayWeightLoaded))
                                .Replace("VALUE12", Convert.ToString(Util.TipperCalculator.Q9TrayWeightEmpty))
                                .Replace("VALUE11", Util.TipperCalculator.T43SSH15l ? "Acceptable" : "Unacceptable")
                                .Replace("VALUE10", Util.TipperCalculator.T42SSH10L ? "Acceptable" : "Unacceptable")
                                .Replace("VALUE9", Util.TipperCalculator.T41Srh6L ? "Acceptable" : "Unacceptable")
                                .Replace("VALUE8", Util.TipperCalculator.T39TactLtTmax ? "Acceptable" : "Unacceptable")
                                .Replace("VALUE7", Util.TipperCalculator.T48dGt39Lt58 ? "Acceptable" : "Unacceptable")
                                .Replace("VALUE6", Util.TipperCalculator.T38PLsPmax ? "Acceptable" : "Unacceptable")
                                .Replace("VALUE5", Util.TipperCalculator.T37FmaxGtY2 ? "Acceptable" : "Unacceptable")
                                .Replace("VALUE4", Convert.ToString("Cylinder is able to produce a force of " + Math.Round(Util.TipperCalculator.E66ForceRequiredY2 / 1000 / 10, 1) + " Tonne at a pressure of " + Math.Round(Util.TipperCalculator.E75PressureRequiredTheoPB, 1) + " Bar. " + "Cylinder can produce a maximum force of " + Math.Round(Util.TipperCalculator.H83ForceProducedMFWUO20KN / 10, 1) + " Tonne, which includes an underload of 20% with a maximum working pressure of 160 Bar."))
                                .Replace("VALUE3", Util.TipperCalculator.T68OverallApplicationSetup ? "Application Acceptable" : "Application Unacceptable")
                                .Replace("VALUE2", Util.TipperCalculator.P3TipperKitPartNumber)
                                .Replace("VALUE1", Util.TipperCalculator.E30CylinderPartNumber);

            StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile ReportFile = await storageFolder.CreateFileAsync("Output.html", CreationCollisionOption.ReplaceExisting);
            await Windows.Storage.FileIO.WriteTextAsync(ReportFile, htmlOUT);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TToEmail.IsEnabled = false;
            SendButton.Content = "Export";
            TBSubject.Text = "File Name: ";
        }

        private void Send_Checked(object sender, RoutedEventArgs e)
        {
            TToEmail.IsEnabled = true;
            SendButton.Content = "Send";
            TBSubject.Text = "Subject: ";
        }

        private void backb_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OutputPage));
        }

        private async void SendButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            if (TSubject.Text == "" || (TToEmail.Text == "" && Send.IsChecked.Value)) return;
            if (Send.IsChecked.Value) { // Send
                try {
                    EmailMessage email = new EmailMessage();
                    email.Subject = TSubject.Text;
                    email.To.Add(new EmailRecipient(TToEmail.Text));
                    StorageFolder tempFolder = await StorageFolder.GetFolderFromPathAsync(Path.GetTempPath());
                    try {
                        await FileIO.WriteTextAsync(await tempFolder.CreateFileAsync("Report.html", CreationCollisionOption.ReplaceExisting), htmlOUT);
                    } catch (Exception exc) {
                        await new MessageDialog(exc.Message).ShowAsync();
                    }
                StorageFile attachmentFile = await tempFolder.GetFileAsync("Report.html");
                    if (attachmentFile != null){
                        var stream = Windows.Storage.Streams.RandomAccessStreamReference.CreateFromFile(attachmentFile);
                        var attachment = new Windows.ApplicationModel.Email.EmailAttachment(attachmentFile.Name, stream);
                        email.Attachments.Add(attachment);
                    }
                    await EmailManager.ShowComposeNewEmailAsync(email);
                    this.Frame.Navigate(typeof(OutputPage));
                } catch (Exception ex){
                    await new MessageDialog(ex.Message).ShowAsync();
                    this.Frame.Navigate(typeof(OutputPage));
                }
            }
            else { //Export
                var picker = new FileSavePicker();
                picker.SuggestedStartLocation = PickerLocationId.ComputerFolder;
                picker.CommitButtonText = "Select";
                picker.SuggestedFileName = "Report.html";
                picker.FileTypeChoices.Add("HTML File", new List<string>() { ".html" });
                try {
                    StorageFile ReportFile = await picker.PickSaveFileAsync();
                    if (ReportFile != null) {
                        try {
                            await Windows.Storage.FileIO.WriteTextAsync(ReportFile, htmlOUT);
                        }
                        catch (Exception exe){
                            await new MessageDialog(exe.Message).ShowAsync();
                        }
                    } else {
                        await new MessageDialog("Operation Canceled").ShowAsync();
                    }
                } catch (Exception ex) {
                    await new MessageDialog("Operation Canceled : " + ex.Message + "\n\n" + " Stack Trace: " + ex.StackTrace ).ShowAsync();
                }
            }
        }
    }
}
