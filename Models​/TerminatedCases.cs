using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class TerminatedCases
    {
        public int IdEndCases { get; set; }
        public string EmployeeNo { get; set; }
        public string PolicyNo { get; set; }
        public int? IdReason { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? WithDependants { get; set; }
        public string CaseType { get; set; }
        public bool? RefundPremium { get; set; }
    }
}
