using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourDay.MClass;
using YourDay.SubCl;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace YourDay
{
    public partial class App : Application
    {
        
        public static DisplayInfo DisplayInfo { get; set; }
        public App()
        {
            InitializeComponent();
            //DisplayInfo = new DisplayInfo();
            ////MStatic.RouteModel = new AppClass.RouteVM();
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
