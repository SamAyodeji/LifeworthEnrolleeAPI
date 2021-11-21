using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Claims
    {
        public int IdClaims { get; set; }
        public int? IdReturn { get; set; }
        public string IdTreatmentList { get; set; }
        public decimal? Cost { get; set; }
        public int? DosageCnt { get; set; }
        public int? TimesPerDay { get; set; }
        public int? NoOfDays { get; set; }
        public int? TotalCount { get; set; }
        public decimal? ProviderCost { get; set; }
        public int? IdDiffReason { get; set; }
    }
}
