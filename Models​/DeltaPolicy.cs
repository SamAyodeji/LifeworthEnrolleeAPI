using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class DeltaPolicy
    {
        public int IdDeltaPlc { get; set; }
        public string EmployeeNo { get; set; }
        public string PolicyNo { get; set; }
        public string OldPolicyNo { get; set; }
        public string NewPolicyNo { get; set; }
        public int? DeltaId { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? WithDependants { get; set; }
    }
}
