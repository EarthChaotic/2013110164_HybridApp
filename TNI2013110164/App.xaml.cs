using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TNI2013110164
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //FlyoutPage
            var FP = new FlyoutPage();
            FP.Flyout = new MenuPage();
            FP.Detail = new NavigationPage(new MainPage()) ;

            MainPage = FP;
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
