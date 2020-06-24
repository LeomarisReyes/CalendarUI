using System;
using System.Collections.Generic;
using CalendarUI.ViewModels;
using Xamarin.Forms;

namespace CalendarUI.Views
{
    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();
            BindingContext = new ScheduleViewModel();
        }
    }
}
