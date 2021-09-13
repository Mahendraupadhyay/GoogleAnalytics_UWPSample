using GoogleAnalytics;
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

namespace GoogleAnalytics_UWPSample
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Tracker.ScreenName = "MainPageUWP";
            App.Tracker.Title = "CustomPageUWP";
            var hit = HitBuilder.CreateScreenView().Build();
            App.Tracker.Send(hit);

            var hit2 = HitBuilder.CreateCustomEvent("xx", "11", null, 0);
            hit2 = hit2.SetCustomDimension(2, "z");
            App.Tracker.Send(hit2.Build());

        }
    }
}
