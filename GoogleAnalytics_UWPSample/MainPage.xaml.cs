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
            //App.Tracker.ScreenName = "MainPageMahendra";
            //App.Tracker.Title = "CustomPage111"; 
            //var hit = HitBuilder.CreateScreenView().Build();
            //App.Tracker.Send(hit);

            var hit1 = HitBuilder.CreateCustomEvent("AB2","BC2",null,0);
            hit1.SetCustomDimension(2, "Test");
            App.Tracker.Send(hit1.Build());


            //HitBuilder hitBuilder = new HitBuilder();
            //hitBuilder.SetCustomDimension(1, "Dummy");
           // App.Tracker.Send(HitBuilder.CreateCustomEvent("test22", "userclick22",null, 0).Build());
          
        }
    }
}
