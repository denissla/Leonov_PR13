using Leonov_PR13.Services;
using Leonov_PR13.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leonov_PR13
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
