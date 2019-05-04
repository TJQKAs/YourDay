using System;
using System.Collections.Generic;
using System.Text;

namespace YourDay.SubCl
{
   public class YDData
    {
        public DateTime CurrentDate { get; set; }
        public int Id { get; set; }
        public int IdRuna { get; set; }
        public int IdMoon { get; set; }
        public int IdArkan { get; set; }
        public int MaxScore { get; set; }
    }

    public class SubYDData
    {
        public int Id { get; set; }
        public int Score { get; set; }
    }
}
