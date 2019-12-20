using System;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace StopPanic.ViewModels
{
    public class CalendarViewModel : BaseViewModel
    {
        public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();
        public CalendarViewModel()
        {
            CalendarInlineEvent event1 = new CalendarInlineEvent();
            event1.StartTime = DateTime.Now;
            event1.IsAllDay = true;
            event1.Subject = "Go to Meeting";
            event1.Color = Color.Fuchsia;

            CalendarInlineEvents.Add(event1);
        }
    }
}
