using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class TreatmentList
    {
        public string IdTreatmentList { get; set; }
        public string Narration { get; set; }
        public string Strenght { get; set; }
        public string Specification { get; set; }
        public decimal? Cost { get; set; }
        public decimal? CostA { get; set; }
        public decimal? CostB { get; set; }
        public decimal? CostC { get; set; }
        public bool? CoverByCap { get; set; }
        public string IdTreatmentClass { get; set; }
        public short? TransType { get; set; }
        public bool? TrackIt { get; set; }
    }
}
