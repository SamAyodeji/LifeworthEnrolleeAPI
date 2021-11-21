using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class IndBenefits
    {
        public int Sn { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Essential { get; set; }
        public string Bronze { get; set; }
        public string Silver { get; set; }
        public string Gold { get; set; }
        public string Platinium { get; set; }
        public int? Essentiall { get; set; }
        public int? Bronzel { get; set; }
        public int? Silverl { get; set; }
        public int? Goldl { get; set; }
        public int? Platiniuml { get; set; }
        public int? Amt { get; set; }
        public int? Count { get; set; }
    }
}
