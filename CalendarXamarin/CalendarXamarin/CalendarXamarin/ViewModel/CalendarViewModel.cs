using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin
{
    public class CalendarViewModel
    {
        public DateTime SelectedDates { get; set; } 
        public CalendarViewModel()
        {
            
            SelectedDates =  new DateTime(2019, 03, 13);
        }
    }
}

