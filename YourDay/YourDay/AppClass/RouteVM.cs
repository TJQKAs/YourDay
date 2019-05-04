using Autofac;
using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;
using YourDay.Classes;
using YourDay.MClass;

namespace YourDay.AppClass
{
   public class RouteVM: MVModel
    {

      public IWorkData WorkDataProp { get; set; }
      public IEngine EngineProp { get; set; }
      public IInterAct InteractProp { get; set; }
      public IGraphEngine GraphEngineProp { get; set; }
      public IAdvert AdvertProp { get; set; }
      
        public RouteVM()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<WorkData>().As<IWorkData>();
            builder.RegisterType<Engine>().As<IEngine>();
            builder.RegisterType<InterAct>().As<IInterAct>();
            builder.RegisterType<GraphEngine>().As<IGraphEngine>();
            builder.RegisterType<Advert>().As<IAdvert>();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                WorkDataProp = scope.Resolve<IWorkData>();
                EngineProp = scope.Resolve<IEngine>();
                InteractProp = scope.Resolve<IInterAct>();
                GraphEngineProp = scope.Resolve<IGraphEngine>();
                AdvertProp = scope.Resolve<IAdvert>();
            }          
            WorkDataProp.LoadData();



            //EngineProp = ServiceLocator.Current.GetInstance<Engine>();
            //InteractProp = ServiceLocator.Current.GetInstance<InterAct>(); 


            MethodForFirstCommand = new FirstCommandMeth(OnOneEvenHandler);

        }
    }
}
