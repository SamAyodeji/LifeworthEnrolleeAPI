using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class TreatmentResult
    {
        public TreatmentResult()
        {
            ProviderReturns = new HashSet<ProviderReturns>();
        }

        public string IdTreatmentResult { get; set; }
        public string TreatmentResult1 { get; set; }

        public virtual ICollection<ProviderReturns> ProviderReturns { get; set; }
    }
}
