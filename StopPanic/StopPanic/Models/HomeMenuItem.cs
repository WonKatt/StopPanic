using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StopPanic.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Geolocation
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public string Title { get; set; }
    }
}
