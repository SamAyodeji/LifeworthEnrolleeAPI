using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Depcountcoy
    {
        public int IdCompany { get; set; }
        public string CompanyName { get; set; }
        public int IdDependant { get; set; }
        public string EmployeeNo { get; set; }
    }
}
