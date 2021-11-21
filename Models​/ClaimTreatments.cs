using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ClaimTreatments
    {
        public int IdClaimTreatment { get; set; }
        public int? IdReturn { get; set; }
        public string IdTreatmentClass { get; set; }
        public string Descriptions { get; set; }
        public decimal? Cost { get; set; }
    }
}
