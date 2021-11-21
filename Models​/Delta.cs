using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Delta
    {
        public int DeltaId { get; set; }
        public string EmployeeNo { get; set; }
        public string PolicyNo { get; set; }
        public string IdDeltaType { get; set; }
        public int? IdReason { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? EndorsementNo { get; set; }
        public string PostPrd { get; set; }
        public decimal? Charges { get; set; }
    }
}
