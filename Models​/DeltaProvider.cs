using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class DeltaProvider
    {
        public int IdDeltaPrv { get; set; }
        public string EmployeeNo { get; set; }
        public string PolicyNo { get; set; }
        public int? OldProviderId { get; set; }
        public int? NewProviderId { get; set; }
        public int? DeltaId { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? WithDependants { get; set; }
        public decimal? Cap2Pay { get; set; }
    }
}
