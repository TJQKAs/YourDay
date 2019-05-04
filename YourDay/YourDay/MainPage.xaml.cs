using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using YourDay.AppClass;
using YourDay.MClass;

namespace YourDay
{
    public partial class MainPage : ContentPage
    {
        public RouteVM VMProp { get; set; }

        public MainPage()
        {
            InitializeComponent();
            VMProp = this.BindingContext as RouteVM;
            
            VMProp.OneEvenHandler += Vm_OneEvenHandler;

            Task.Run(() => {
                Task.Delay(1000);
                Device.BeginInvokeOnMainThread(() => {
                    LoadingVision();
                });             
            });

        }

        public void LoadingVision()
        {
            //this.WidthRequest = App.DisplayInfo.WidthScreen;
            //this.HeightRequest = App.DisplayInfo.HeighScreen;



            LBL1.Text = VMProp.WorkDataProp.CurDateTime.ToString() + " " + VMProp.WorkDataProp.Culture;

           
        }



        private void Vm_OneEvenHandler(object sender, EventArgs e)
        {
            //Task.Run(() => {
            //    Task.Delay(1000);
            //    Device.BeginInvokeOnMainThread(() => {
            //        LBL1.Text =  "vcvbdffdjidfiod";
            //        LBL1.HeightRequest = App.DisplayInfo.HeighScreen * 0.05;  
            //        LBL1.WidthRequest = App.DisplayInfo.WidthScreen * 0.08;
            //    });
            //});
        }
    }
}
