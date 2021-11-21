using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ViewEnrSbu
    {
        public string EmployeeNo { get; set; }
        public int IdCompany { get; set; }
        public int? IdBranch { get; set; }
        public string Sbu { get; set; }
        public string Description { get; set; }
        public int IdEmployee { get; set; }
    }
}
