using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XMonkey.Services;
using XMonkey.Views;

namespace XMonkey
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            Routing.RegisterRoute("aboutPage", typeof(AboutPage));
            Routing.RegisterRoute("itemsPage", typeof(ItemsPage));
            MainPage = new AppShell();
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
