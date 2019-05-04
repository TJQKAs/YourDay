using System;
using System.Collections.Generic;
using System.Text;

namespace YourDay.Classes
{
    public interface IWorkData
    {
        DateTime CurDateTime { get; set; }
        string Culture { get; set; }

        void LoadData();
    }
}