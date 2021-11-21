using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PreEmployDetail
    {
        public int IdPreEmpDetail { get; set; }
        public string IdCompany { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeNo { get; set; }
        public int? IdPreEmpMaster { get; set; }

        public virtual PreEmployMaster IdPreEmpMasterNavigation { get; set; }
    }
}
