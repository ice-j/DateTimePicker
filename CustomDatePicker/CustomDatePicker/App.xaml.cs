using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CustomDatePicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var dtPicker = new DateTimePicker()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                StringFormat = "HH:mm dd/MM/yyyy"
            };

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        dtPicker._datePicker,
                        dtPicker._timePicker,
                        dtPicker
                    },
                    BackgroundColor = Color.Aqua
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
