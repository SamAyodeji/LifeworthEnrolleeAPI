using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Empcountcoy
    {
        public string EmployeeNo { get; set; }
        public string CompanyName { get; set; }
        public int IdEmployee { get; set; }
        public int IdCompany { get; set; }
        public DateTime? Tdate { get; set; }
    }
}
