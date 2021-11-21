using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class TblCompanyHead2
    {
        public int HeadId { get; set; }
        public int? IdCompany { get; set; }
        public string HeadName { get; set; }
        public string GsmNo { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public DateTime? DOB { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
    }
}
