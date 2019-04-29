using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace YourDay.MClass
{
    public partial class MVModel
    {

        private static EventHandler _stat_even_Handler;
        protected internal static event EventHandler StatEvenHandler
        {
            add
            {
                _stat_even_Handler -= value;
                _stat_even_Handler += value;
            }
            remove { _stat_even_Handler -= value; }
        }
        protected internal static void OnStatEvenHandler(object obj) { _stat_even_Handler?.Invoke(obj, EventArgs.Empty); }




        private EventHandler _one_even_Handler;
        protected internal event EventHandler OneEvenHandler
        {
            add
            {
                _one_even_Handler -= value;
                _one_even_Handler += value;
            }
            remove { _one_even_Handler -= value; }
        }
        protected internal void OnOneEvenHandler() { _one_even_Handler?.Invoke(this, EventArgs.Empty); }

        private EventHandler _two_even_Handler;
        protected internal event EventHandler TwoEvenHandler
        {
            add
            {
                _two_even_Handler -= value;
                _two_even_Handler += value;
            }
            remove { _two_even_Handler -= value; }
        }
        protected internal void OnTwoEvenHandler() { _two_even_Handler?.Invoke(this, EventArgs.Empty); }

        private EventHandler _three_even_Handler;
        protected internal event EventHandler ThreeEvenHandler
        {
            add
            {
                _three_even_Handler -= value;
                _three_even_Handler += value;
            }
            remove { _three_even_Handler -= value; }
        }
        protected internal void OnThreeEvenHandler() { _three_even_Handler?.Invoke(this, EventArgs.Empty); }

        private EventHandler _four_even_Handler;
        protected internal event EventHandler FourEvenHandler
        {
            add
            {
                _four_even_Handler -= value;
                _four_even_Handler += value;
            }
            remove { _four_even_Handler -= value; }
        }
        protected internal void OnFourEvenHandler() { _four_even_Handler?.Invoke(this, EventArgs.Empty); }

        private EventHandler _five_even_Handler;
        protected internal event EventHandler FiveEvenHandler
        {
            add
            {
                _five_even_Handler -= value;
                _five_even_Handler += value;
            }
            remove { _five_even_Handler -= value; }
        }
        protected internal void OnFiveEvenHandler() { _five_even_Handler?.Invoke(this, EventArgs.Empty); }

        private EventHandler _six_even_Handler;
        protected internal event EventHandler SixEvenHandler
        {
            add
            {
                _six_even_Handler -= value;
                _six_even_Handler += value;
            }
            remove { _six_even_Handler -= value; }
        }
        protected internal void OnSixEvenHandler() { _six_even_Handler?.Invoke(this, EventArgs.Empty); }


        private EventHandler _seven_even_Handler;
        protected internal event EventHandler SevenEvenHandler
        {
            add
            {
                _seven_even_Handler -= value;
                _seven_even_Handler += value;
            }
            remove { _seven_even_Handler -= value; }
        }
        protected internal void OnSevenEvenHandler() { _seven_even_Handler?.Invoke(this, EventArgs.Empty); }


        private EventHandler _eight_even_Handler;
        protected internal event EventHandler EightEvenHandler
        {
            add
            {
                _eight_even_Handler -= value;
                _eight_even_Handler += value;
            }
            remove { _eight_even_Handler -= value; }
        }
        protected internal void OnEightEvenHandler() { _eight_even_Handler?.Invoke(this, EventArgs.Empty); }


        private EventHandler _nine_even_Handler;
        protected internal event EventHandler NineEvenHandler
        {
            add
            {
                _nine_even_Handler -= value;
                _nine_even_Handler += value;
            }
            remove { _nine_even_Handler -= value; }
        }
        protected internal void OnNineEvenHandler() { _nine_even_Handler?.Invoke(this, EventArgs.Empty); }

        private EventHandler _ten_even_Handler;
        protected internal event EventHandler TenEvenHandler
        {
            add
            {
                _ten_even_Handler -= value;
                _ten_even_Handler += value;
            }
            remove { _ten_even_Handler -= value; }
        }
        protected internal void OnTenEvenHandler() { _ten_even_Handler?.Invoke(this, EventArgs.Empty); }




        ////private EventHandler<MyEventArgs> _eleven_even_Handler;
        ////protected internal event EventHandler<MyEventArgs> ElevenEvenHandler
        ////{
        ////    add
        ////    {
        ////        _eleven_even_Handler -= value;
        ////        _eleven_even_Handler += value;
        ////    }
        ////    remove { _eleven_even_Handler -= value; }
        ////}

        //protected internal void OnElevenEvenHandler(object sender, MyEventArgs e)
        //{
        //    _eleven_even_Handler?.Invoke(this, e);
        //}


        protected internal delegate void TimerMethodDelegate();
        protected internal TimerMethodDelegate TimerMethod { get; set; }

        internal void TimerStart(int time)
        {
            if (time < 5000) time = 5000;
            // Tell the timer what to do when it elapses
            StartStopTimer.Elapsed += new ElapsedEventHandler(myEvent);
            // Set it to go off every five seconds
            StartStopTimer.Interval = time;
            // And start it        
            StartStopTimer.Enabled = true;
        }

        private void myEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                if (TimerMethod != null) TimerMethod.Invoke();
            }
            catch (Exception ex)
            {
                ////ErrorLog.LogFileWrite(ErrorLog.CreateErrorMessage(ex), DebugMode);
                ////SenderVM.OnStatEvenHandler(this);
            }
        }
    }
}
