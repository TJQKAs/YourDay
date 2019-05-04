using Autofac;
using Autofac.Core;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;
using YourDay.AppClass;
using YourDay.Classes;

namespace YourDay
{
   public sealed class IocInit
    {
        public static void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<RouteVM>().AsSelf();
            

            IContainer container = builder.Build();
            AutofacServiceLocator asl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => asl);
        }

    }
}
