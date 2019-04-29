using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using YourDay.Interfaces;

namespace YourDay.MClass
{
  public partial class MVModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       

        public MVModel()
        {

            this.FirstCommand = new Command(() => {
                if (MethodForFirstCommand == null) return;
                try
                {
                    MethodForFirstCommand.Invoke();
                }
                catch (Exception ex)
                {
                   
                }
            });

            this.SecondCommand = new Command(() => {
                if (MethodForSecondCommand == null) return;
                try
                {
                    MethodForSecondCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });


            this.ThirdCommand = new Command(() => {
                if (MethodForThirdCommand == null) return;
                try
                {
                    MethodForThirdCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });

            this.FourthCommand = new Command(() => {
                if (MethodForFourthCommand == null) return;
                try
                {
                    MethodForFourthCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });


            this.FifthCommand = new Command(() => {
                if (MethodForFifthCommand == null) return;
                try
                {
                    MethodForFifthCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });


            this.SixthCommand = new Command(() => {
                if (MethodForSixthCommand == null) return;
                try
                {
                    MethodForSixthCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });


            this.SeventhCommand = new Command(() => {
                if (MethodForSeventhCommand == null) return;
                try
                {
                    MethodForSeventhCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });


            this.EightCommand = new Command(() => {
                if (MethodForEightCommand == null) return;
                try
                {
                    MethodForEightCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });

            this.NinethCommand = new Command(() => {
                if (MethodForNinethCommand == null) return;
                try
                {
                    MethodForNinethCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });

            this.TenthCommand = new Command(() => {
                if (MethodForTenthCommand == null) return;
                try
                {
                    MethodForTenthCommand.Invoke();
                }
                catch (Exception ex)
                {

                }
            });


            this.CloseCommand = new Command(() => {

                try
                {
                    Task.Run(() => {
                        var closer = DependencyService.Get<ICloseApplication>();
                        if (closer != null)
                            closer.closeApplication();
                    });
                }
                catch (Exception)
                {

                }
            });
        }


    }
}
