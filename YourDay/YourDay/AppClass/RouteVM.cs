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
 
       IWorkData WorkDataProp { get; set; }
       IEngine EngineProp { get; set; }
       IInterAct InteractProp { get; set; }

    public RouteVM()
        {
            //WorkDataProp = ServiceLocator.Current.GetInstance<WorkData>();
            //EngineProp = ServiceLocator.Current.GetInstance<Engine>();
            //InteractProp = ServiceLocator.Current.GetInstance<InterAct>();
        }
    }
}
