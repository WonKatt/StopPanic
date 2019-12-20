namespace StopPanic.Models
{
    public enum MenuItemType
    {
        Browse,
        Geolocation,
        Calendar
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public string Title { get; set; }
    }
}
