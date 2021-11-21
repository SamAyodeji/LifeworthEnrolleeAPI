using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CountAll
    {
        public int IdCompany { get; set; }
        public string CompanyName { get; set; }
        public string EmployeeNo { get; set; }
        public string Type { get; set; }
        public string StatusId { get; set; }
        public DateTime? Tdate { get; set; }
    }
}
