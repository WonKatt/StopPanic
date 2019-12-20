using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StopPanic.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetGeolocation : ContentPage
    {
        public GetGeolocation()
        {
            InitializeComponent();
        }

        private async void GeolocButton_OnClicked(object sender, EventArgs e)
        {
            var request = new GeolocationRequest(GeolocationAccuracy.High);
            var location = await Geolocation.GetLocationAsync(request);
            var c = null as string;
        }
    }
}