﻿#pragma checksum "G:\Mark\Documents\TIPPERKIT\Windows\TipperKit\TipperKit\DeviceFamily-Mobile\GenerateAndSendReportPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "95E4B36D306C8BE828CEA209249E9735"
#pragma checksum "G:\Mark\Documents\TIPPERKIT\Windows\TipperKit\TipperKit\GenerateAndSendReportPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "64933EF872993D2EE095961BB39589F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TipperKit
{
    partial class GenerateAndSendReportPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.SendButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 47 "..\..\..\DeviceFamily-Mobile\GenerateAndSendReportPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SendButton).Click += this.SendButton_ClickAsync;
                    #line default
                }
                break;
            case 2:
                {
                    this.backb = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 48 "..\..\..\DeviceFamily-Mobile\GenerateAndSendReportPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backb).Click += this.backb_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Send = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 44 "..\..\..\DeviceFamily-Mobile\GenerateAndSendReportPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.Send).Checked += this.Send_Checked;
                    #line default
                }
                break;
            case 4:
                {
                    this.Export = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 45 "..\..\..\DeviceFamily-Mobile\GenerateAndSendReportPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.Export).Checked += this.RadioButton_Checked;
                    #line default
                }
                break;
            case 5:
                {
                    this.Webview1 = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 6:
                {
                    this.TToEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.TBSubject = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.TSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.SendButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 47 "..\..\..\GenerateAndSendReportPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SendButton).Click += this.SendButton_ClickAsync;
                    #line default
                }
                break;
            case 10:
                {
                    this.backb = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 48 "..\..\..\GenerateAndSendReportPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backb).Click += this.backb_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.Send = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 44 "..\..\..\GenerateAndSendReportPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.Send).Checked += this.Send_Checked;
                    #line default
                }
                break;
            case 12:
                {
                    this.Export = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 45 "..\..\..\GenerateAndSendReportPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.Export).Checked += this.RadioButton_Checked;
                    #line default
                }
                break;
            case 13:
                {
                    this.Webview1 = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 14:
                {
                    this.TToEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.TBSubject = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.TSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

