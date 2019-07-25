using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XMonkey.Interfaces;

namespace XMonkey.Views
{
    public partial class FeedPage : ContentPage
    {
        IFirebaseAnalytics eventTracker;
        public FeedPage()
        {
            InitializeComponent();
            eventTracker = DependencyService.Get<IFirebaseAnalytics>();  
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            eventTracker.SendEvent("Click1");
        }
    }
}
