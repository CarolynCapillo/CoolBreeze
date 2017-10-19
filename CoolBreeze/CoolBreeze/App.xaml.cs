using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CoolBreeze
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel;
        public static string RegistrationCode = "XBWW63199CCA79B09F4382D613C67AA2";
        public App()
        {
            InitializeComponent();
            MobileCenter.Start("android=c4d74eba-ad62-4316-bee2-6fe8a6ce6086;" + "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
            MainPage = new NavigationPage (new StartPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start(typeof(Analytics), typeof(Crashes));
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
