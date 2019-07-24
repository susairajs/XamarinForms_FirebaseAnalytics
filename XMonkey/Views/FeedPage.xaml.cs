using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XMonkey.Views
{
    public partial class FeedPage : ContentPage
    {
        IEventTracker eventTracker;
        public FeedPage()
        {
            InitializeComponent();
            eventTracker = DependencyService.Get<IEventTracker>();  
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            eventTracker.SendEvent("Click01");
            //throw new NotImplementedException();
        }
    }
}
