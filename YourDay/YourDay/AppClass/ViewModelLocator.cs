using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace YourDay.AppClass
{
   public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            IocInit.Initialize();
        }

        public RouteVM RouteVMProp
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RouteVM>();
            }
        }
    }
}
