using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ClaimDiagnosis
    {
        public int IdClaimDiagnosis { get; set; }
        public int IdReturns { get; set; }
        public int IdDiagnosis { get; set; }
        public string Details { get; set; }
    }
}
