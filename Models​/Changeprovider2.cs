using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Changeprovider2
    {
        public int Sno { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int IdProviderOld { get; set; }
        public string ProviderNameOld { get; set; }
        public int IdProviderNew { get; set; }
        public string ProviderNameNew { get; set; }
        public int? IdCompany { get; set; }
        public string Employeestatus { get; set; }
        public string Changedby { get; set; }
        public bool? Treated { get; set; }
    }
}
