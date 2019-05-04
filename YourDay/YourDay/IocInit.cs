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
            builder.RegisterType<Engine>().As<IEngine>();
            builder.RegisterType<InterAct>().As<IInterAct>();
            builder.RegisterType<GraphEngine>().As<IGraphEngine>();
            builder.RegisterType<Advert>().As<IAdvert>();
            builder.RegisterType<WorkData>().As<IWorkData>();

            IContainer container = builder.Build();
            AutofacServiceLocator asl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => asl);
        }

    }
}
