using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourDay.MClass;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace YourDay
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();
            MStatic.RouteModel = new AppClass.RouteVM();
            MainPage = new MainPage();
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
