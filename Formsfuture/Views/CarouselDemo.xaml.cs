using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Formsfuture.ViewModels;

namespace Formsfuture.Views
{
    public partial class CarouselDemo : ContentPage
    {
        public CarouselDemo()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);

            BindingContext = new HomeViewModel();
        }
    }
}
