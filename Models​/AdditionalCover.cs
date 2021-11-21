using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AdditionalCover
    {
        public int IdCover { get; set; }
        public string PolicyNo { get; set; }
        public int? CompanyId { get; set; }
        public string IdProduct { get; set; }
        public string IdBenefit { get; set; }
        public int? NoOfTimes { get; set; }
        public decimal? CoverLimit { get; set; }
        public string Narration { get; set; }
    }
}
