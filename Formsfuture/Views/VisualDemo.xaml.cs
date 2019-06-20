using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Formsfuture.Views
{
    public partial class VisualDemo : ContentPage
    {
        public VisualDemo()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            
            Shell.Current.GoToAsync("//home/about");
        }
    }
}
