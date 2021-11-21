using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PolicyUpdDetails
    {
        public int IdPolicyUpdDetails { get; set; }
        public int IdPolicyUpdMaster { get; set; }
        public string EmployeeNo { get; set; }
        public int IdProvider { get; set; }
        public decimal? Prm2Pay { get; set; }
        public decimal? Cap2Pay { get; set; }
        public int? PrmPrdLeft { get; set; }
        public int? CapPrdLeft { get; set; }
    }
}
