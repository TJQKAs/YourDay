using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace YourDay.Classes
{
   public class WorkData : IWorkData
    {
        public DateTime CurDateTime { get; set; }
        public string Culture { get; set; }
        public WorkData()
        {
           
        }
        public void LoadData()
        {
            try
            {
                CurDateTime = DateTime.Now;
                CultureInfo culture = CultureInfo.CurrentCulture;
                Culture = culture.Name;
            }
            catch (Exception ex)
            {

            }         
        }

        
    }
}
