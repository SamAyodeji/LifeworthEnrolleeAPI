using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class InsuredProvider
    {
        public int IdInsuredprovider { get; set; }
        public int IdInsured { get; set; }
        public string PolicyNo { get; set; }
        public int IdProvider { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmployeeNo { get; set; }

        public virtual Insured IdInsuredNavigation { get; set; }
    }
}
