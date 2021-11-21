using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Insured
    {
        public Insured()
        {
            InsuredProvider = new HashSet<InsuredProvider>();
        }

        public int IdInsured { get; set; }
        public int IdCompany { get; set; }
        public string PolicyNo { get; set; }
        public int? IdEmployee { get; set; }
        public string PolicyStatus { get; set; }
        public decimal? PrmAmount { get; set; }
        public decimal? CapAmount { get; set; }
        public string EmployeeNo { get; set; }
        public byte? CapCount { get; set; }
        public byte? PrmCount { get; set; }

        public virtual ICollection<InsuredProvider> InsuredProvider { get; set; }
    }
}
