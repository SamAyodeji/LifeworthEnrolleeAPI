using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PolicyUpdMaster
    {
        public int IdPolicyUpdMaster { get; set; }
        public string PolicyNo { get; set; }
        public string ReqAction { get; set; }
        public DateTime? ActionDate { get; set; }
        public decimal? PrmAmt2Deduct { get; set; }
        public decimal? CapAmt2Deduct { get; set; }
        public string CaseType { get; set; }
        public int? IdReason { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? RefundPremium { get; set; }
        public int? EnrolleeCount { get; set; }
        public int? InsureCount { get; set; }
    }
}
