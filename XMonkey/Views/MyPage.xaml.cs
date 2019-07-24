using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XMonkey.Views
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        async void  Handle_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//aboutPage");
            //throw new NotImplementedException();
        }
    }
}
