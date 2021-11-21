using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class DeltaDesignation
    {
        public int IdDeltaDesignation { get; set; }
        public string EmployeeNo { get; set; }
        public string PolicyNo { get; set; }
        public int OldDesignationId { get; set; }
        public int NewDesignationId { get; set; }
        public int? DeltaId { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public DateTime? TransactionDate { get; set; }
        public bool? WithDependants { get; set; }
    }
}
