using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Bkbanda
    {
        public int Sn { get; set; }
        public string Classification { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Unit { get; set; }
        public string Refer { get; set; }
    }
}
