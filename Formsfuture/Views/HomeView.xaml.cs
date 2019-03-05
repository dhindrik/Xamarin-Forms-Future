using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Formsfuture.ViewModels;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Formsfuture.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            BindingContext = new HomeViewModel();

        }
    }
}
