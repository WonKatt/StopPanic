using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StopPanic.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Geolocation : ContentPage
    {
        public Geolocation()
        {
            InitializeComponent();
        }
    }
}