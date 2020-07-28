using DemoLibrary;
using System;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for SunInfo.xaml
    /// </summary>
    public partial class SunInfo : Window
    {
        public SunInfo()
        {
            InitializeComponent();
        }

        private async void loadSunInfo_Click(object sender, RoutedEventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInformation();

            sunriseText.Text = $"Sunrise is at { sunInfo.SunRise.ToLocalTime().ToShortTimeString() }";
            sunsetText.Text = $"Sunset is at { sunInfo.SunSet.ToLocalTime().ToShortTimeString() }";
        }
    }
}
