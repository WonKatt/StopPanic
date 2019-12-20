using System.Collections.Generic;
using StopPanic.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StopPanic.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        private MainPage RootPage => Application.Current.MainPage as MainPage;
        private readonly List<HomeMenuItem> menuItems;

        public MenuPage()
        {
            InitializeComponent();
            MainMenuHeaderImage.Source = ImageSource.FromFile("mainmenu.jpg");

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title = "Browse"},
                new HomeMenuItem {Id = MenuItemType.Calendar, Title = "Calendar"},
                new HomeMenuItem {Id = MenuItemType.Geolocation, Title = "Geolocation"},
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int) ((HomeMenuItem) e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}