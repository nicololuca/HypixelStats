using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using hypixelstats.Services;
using hypixelstats.View;

namespace hypixelstats
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<IAPICaller, APICaller>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
